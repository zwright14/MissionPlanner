using System;
using System.Windows.Forms;
using MissionPlanner.Controls;
using MissionPlanner.Comms;
using MissionPlanner.Utilities;

namespace MissionPlanner.Antenna
{
    public partial class Tracker : UserControl
    {
        System.Threading.Thread t12;
        static bool threadrun = false;
       

        enum interfaces
        {
            Maestro,
            ArduTracker,
            DegreeTracker
        }

        public Tracker()
        {
            InitializeComponent();


            CMB_serialport.DataSource = SerialPort.GetPortNames();

            if (threadrun)
            {
                BUT_connect.Text = "Disconnect";
            }

            foreach (string key in Settings.Instance.Keys)
            {
                if (key.StartsWith("Tracker_"))
                {
                    var ctls = Controls.Find(key.Replace("Tracker_", ""), true);

                    foreach (Control ctl in ctls)
                    {
                        if (typeof (TextBox) == ctl.GetType() ||
                            typeof (ComboBox) == ctl.GetType())
                        {
                            if (Settings.Instance[key] != null)
                                ctl.Text = Settings.Instance[key];
                        }
                        else if (typeof (TrackBar) == ctl.GetType())
                        {
                            ((TrackBar)ctl).Value = Settings.Instance.GetInt32(key);
                        }
                        else if (typeof (CheckBox) == ctl.GetType())
                        {
                            ((CheckBox) ctl).Checked = Settings.Instance.GetBoolean(key);
                        }
                    }
                }
            }

            // update other fields from load params
            TXT_panrange_TextChanged(null, null);
            TXT_tiltrange_TextChanged(null, null);
            TRK_pantrim_Scroll(null, null);
            TRK_tilttrim_Scroll(null, null);
        }

        void saveconfig()
        {
            foreach (Control ctl in Controls)
            {
                if (typeof (TextBox) == ctl.GetType() ||
                    typeof (ComboBox) == ctl.GetType())
                {
                    Settings.Instance["Tracker_" + ctl.Name] = ctl.Text;
                }
                if (typeof (TrackBar) == ctl.GetType())
                {
                    Settings.Instance["Tracker_" + ctl.Name] = ((TrackBar) ctl).Value.ToString();
                }
                if (typeof (CheckBox) == ctl.GetType())
                {
                    Settings.Instance["Tracker_" + ctl.Name] = ((CheckBox) ctl).Checked.ToString();
                }
            }
        }

        private void BUT_connect_Click(object sender, EventArgs e)
        {
            saveconfig();

            if (threadrun)
            {
                threadrun = false;
                BUT_connect.Text = Strings.Connect;
           
                foreach (Control ctl in Controls)
                {
                    if (ctl.Name.StartsWith("TXT_"))
                        ctl.Enabled = true;

                    if (ctl.Name.StartsWith("CMB_"))
                        ctl.Enabled = true;
                }
                BUT_find.Enabled = true;
                //CustomMessageBox.Show("Disconnected!");
                return;
            }
            

            BUT_connect.Text = "Disconnect";
        }

        void mainloop()
        {
            threadrun = true;
            while (threadrun)
            {
                try
                {
                    // 10 hz - position updates default to 3 hz on the stream rate
                  //  tracker.PanAndTilt(MainV2.comPort.MAV.cs.AZToMAV, MainV2.comPort.MAV.cs.ELToMAV);
                    System.Threading.Thread.Sleep(100);
                }
                catch
                {
                }
            }
        }

        private void TRK_pantrim_Scroll(object sender, EventArgs e)
        {
          
            LBL_pantrim.Text = TRK_pantrim.Value.ToString();
        }

        private void TRK_tilttrim_Scroll(object sender, EventArgs e)
        {
        
            LBL_tilttrim.Text = TRK_tilttrim.Value.ToString();
        }

        private void TXT_panrange_TextChanged(object sender, EventArgs e)
        {
            int range;

            int.TryParse(TXT_panrange.Text, out range);

            range = 360;

            TRK_pantrim.Minimum = range/2*-1;
            TRK_pantrim.Maximum = range/2;
        }

        private void TXT_tiltrange_TextChanged(object sender, EventArgs e)
        {
            int range;

            int.TryParse(TXT_tiltrange.Text, out range);

            TRK_tilttrim.Minimum = range/2*-1;
            TRK_tilttrim.Maximum = range/2;
        }

        private void CHK_revpan_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void CHK_revtilt_CheckedChanged(object sender, EventArgs e)
        {
        }

        public void Deactivate()
        {
            saveconfig();
        }

        private void BUT_find_Click(object sender, EventArgs e)
        {
            System.Threading.ThreadPool.QueueUserWorkItem(tm1_Tick);
        }

        void tm1_Tick(object item)
        {
            float snr = MainV2.comPort.MAV.cs.localsnrdb;
            float best = snr;

            float tilt = 0;
            float pan = 0;

            if (snr == 0)
            {
                CustomMessageBox.Show("No valid sik radio", Strings.ERROR);
                return;
            }

            this.Invoke((MethodInvoker) delegate
            {
                tilt = TRK_tilttrim.Value;
                pan = TRK_pantrim.Value;
            });


            // scan half range within 30 degrees
            float ans = checkpos((pan - float.Parse(TXT_panrange.Text)/4), (pan + float.Parse(TXT_panrange.Text)/4) - 1,
                30);

            // scan new range within 30 - little overlap
            ans = checkpos((-30 + ans), (30 + ans), 5);

            // scan new range
            ans = checkpos((-5 + ans), (5 + ans), 1);

            setpan(ans);
        }

        void setpan(float no)
        {
            this.Invoke((MethodInvoker) delegate
            {
                try
                {
                    TRK_pantrim.Value = (int) no;
                    TRK_pantrim_Scroll(null, null);
                }
                catch
                {
                    return;
                }
            });
        }

        float checkpos(float start, float end, float scale)
        {
            float lastsnr = 0;
            float best = 0;

            setpan(start);

            System.Threading.Thread.Sleep(4000);

            for (float n = start; n < end; n += scale)
            {
                setpan(n);

                System.Threading.Thread.Sleep(2000);

                Console.WriteLine("Angle " + n + " snr " + MainV2.comPort.MAV.cs.localsnrdb);

                if (MainV2.comPort.MAV.cs.localsnrdb > lastsnr)
                {
                    best = n;
                    lastsnr = MainV2.comPort.MAV.cs.localsnrdb;
                }
            }

            return best;
        }

        private void CMB_interface_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CMB_interface.Text == interfaces.Maestro.ToString())
            {
                TXT_panspeed.Enabled = true;
                TXT_panaccel.Enabled = true;
                TXT_tiltspeed.Enabled = true;
                TXT_tiltaccel.Enabled = true;
            }
            else
            {
                TXT_panspeed.Enabled = false;
                TXT_panaccel.Enabled = false;
                TXT_tiltspeed.Enabled = false;
                TXT_tiltaccel.Enabled = false;
            }
        }

        private void TXT_centerpan_TextChanged(object sender, EventArgs e)
        {
        }

        private void TXT_centertilt_TextChanged(object sender, EventArgs e)
        {
        }

        private void TXT_panspeed_TextChanged(object sender, EventArgs e)
        {
            int speed;

            int.TryParse(TXT_panspeed.Text, out speed);
   
        }

        private void TXT_tiltspeed_TextChanged(object sender, EventArgs e)
        {
            int speed;

            int.TryParse(TXT_tiltspeed.Text, out speed);
      
        }

        private void TXT_panaccel_TextChanged(object sender, EventArgs e)
        {
            int accel;

            int.TryParse(TXT_panaccel.Text, out accel);

        }

        private void TXT_tiltaccel_TextChanged(object sender, EventArgs e)
        {
            int accel;

            int.TryParse(TXT_tiltaccel.Text, out accel);
     
        }
    }
}