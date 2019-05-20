using System.Windows.Forms;
using MissionPlanner.Utilities.Drawing;

namespace MissionPlanner.Antenna
{
    partial class Tracker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CMB_interface = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CMB_baudrate = new System.Windows.Forms.ComboBox();
            this.CMB_serialport = new System.Windows.Forms.ComboBox();
            this.TRK_pantrim = new System.Windows.Forms.TrackBar();
            this.TXT_panrange = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TXT_tiltrange = new System.Windows.Forms.TextBox();
            this.TRK_tilttrim = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CHK_revpan = new System.Windows.Forms.CheckBox();
            this.CHK_revtilt = new System.Windows.Forms.CheckBox();
            this.TXT_pwmrangepan = new System.Windows.Forms.TextBox();
            this.TXT_pwmrangetilt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.BUT_connect = new Button();
            this.LBL_pantrim = new System.Windows.Forms.Label();
            this.LBL_tilttrim = new System.Windows.Forms.Label();
            this.BUT_find = new Button();
            this.TXT_centerpan = new System.Windows.Forms.TextBox();
            this.TXT_centertilt = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.TXT_panspeed = new System.Windows.Forms.TextBox();
            this.TXT_panaccel = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.TXT_tiltspeed = new System.Windows.Forms.TextBox();
            this.TXT_tiltaccel = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.TRK_pantrim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TRK_tilttrim)).BeginInit();
            this.SuspendLayout();
            // 
            // CMB_interface
            // 
            this.CMB_interface.FormattingEnabled = true;
            this.CMB_interface.Items.AddRange(new object[] {
            "Maestro",
            "ArduTracker"});
            this.CMB_interface.Location = new System.Drawing.Point(83, 10);
            this.CMB_interface.Name = "CMB_interface";
            this.CMB_interface.Size = new System.Drawing.Size(121, 21);
            this.CMB_interface.TabIndex = 0;
            this.CMB_interface.Text = "Maestro";
            this.CMB_interface.SelectedIndexChanged += new System.EventHandler(this.CMB_interface_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 99;
            this.label1.Text = "Interface";
            // 
            // CMB_baudrate
            // 
            this.CMB_baudrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_baudrate.FormattingEnabled = true;
            this.CMB_baudrate.Items.AddRange(new object[] {
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "57600",
            "115200"});
            this.CMB_baudrate.Location = new System.Drawing.Point(337, 9);
            this.CMB_baudrate.Name = "CMB_baudrate";
            this.CMB_baudrate.Size = new System.Drawing.Size(121, 21);
            this.CMB_baudrate.TabIndex = 2;
            // 
            // CMB_serialport
            // 
            this.CMB_serialport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_serialport.FormattingEnabled = true;
            this.CMB_serialport.Location = new System.Drawing.Point(210, 10);
            this.CMB_serialport.Name = "CMB_serialport";
            this.CMB_serialport.Size = new System.Drawing.Size(121, 21);
            this.CMB_serialport.TabIndex = 1;
            // 
            // TRK_pantrim
            // 
            this.TRK_pantrim.Location = new System.Drawing.Point(153, 96);
            this.TRK_pantrim.Maximum = 360;
            this.TRK_pantrim.Minimum = -360;
            this.TRK_pantrim.Name = "TRK_pantrim";
            this.TRK_pantrim.Size = new System.Drawing.Size(375, 45);
            this.TRK_pantrim.TabIndex = 15;
            this.TRK_pantrim.TickFrequency = 5;
            this.TRK_pantrim.Scroll += new System.EventHandler(this.TRK_pantrim_Scroll);
            // 
            // TXT_panrange
            // 
            this.TXT_panrange.Location = new System.Drawing.Point(83, 81);
            this.TXT_panrange.Name = "TXT_panrange";
            this.TXT_panrange.Size = new System.Drawing.Size(64, 20);
            this.TXT_panrange.TabIndex = 10;
            this.TXT_panrange.Text = "360";
            this.TXT_panrange.TextChanged += new System.EventHandler(this.TXT_panrange_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(326, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 99;
            this.label3.Text = "Trim";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 99;
            this.label4.Text = "Range";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 99;
            this.label5.Text = "Range";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(326, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 99;
            this.label6.Text = "Trim";
            // 
            // TXT_tiltrange
            // 
            this.TXT_tiltrange.Location = new System.Drawing.Point(83, 244);
            this.TXT_tiltrange.Name = "TXT_tiltrange";
            this.TXT_tiltrange.Size = new System.Drawing.Size(64, 20);
            this.TXT_tiltrange.TabIndex = 20;
            this.TXT_tiltrange.Text = "90";
            this.TXT_tiltrange.TextChanged += new System.EventHandler(this.TXT_tiltrange_TextChanged);
            // 
            // TRK_tilttrim
            // 
            this.TRK_tilttrim.Location = new System.Drawing.Point(153, 258);
            this.TRK_tilttrim.Maximum = 180;
            this.TRK_tilttrim.Minimum = -180;
            this.TRK_tilttrim.Name = "TRK_tilttrim";
            this.TRK_tilttrim.Size = new System.Drawing.Size(375, 45);
            this.TRK_tilttrim.TabIndex = 25;
            this.TRK_tilttrim.TickFrequency = 5;
            this.TRK_tilttrim.Scroll += new System.EventHandler(this.TRK_tilttrim_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 99;
            this.label2.Text = "Pan";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 99;
            this.label7.Text = "Tilt";
            // 
            // CHK_revpan
            // 
            this.CHK_revpan.AutoSize = true;
            this.CHK_revpan.Location = new System.Drawing.Point(534, 98);
            this.CHK_revpan.Name = "CHK_revpan";
            this.CHK_revpan.Size = new System.Drawing.Size(46, 17);
            this.CHK_revpan.TabIndex = 16;
            this.CHK_revpan.Text = "Rev";
            this.CHK_revpan.UseVisualStyleBackColor = true;
            this.CHK_revpan.CheckedChanged += new System.EventHandler(this.CHK_revpan_CheckedChanged);
            // 
            // CHK_revtilt
            // 
            this.CHK_revtilt.AutoSize = true;
            this.CHK_revtilt.Location = new System.Drawing.Point(534, 260);
            this.CHK_revtilt.Name = "CHK_revtilt";
            this.CHK_revtilt.Size = new System.Drawing.Size(46, 17);
            this.CHK_revtilt.TabIndex = 26;
            this.CHK_revtilt.Text = "Rev";
            this.CHK_revtilt.UseVisualStyleBackColor = true;
            this.CHK_revtilt.CheckedChanged += new System.EventHandler(this.CHK_revtilt_CheckedChanged);
            // 
            // TXT_pwmrangepan
            // 
            this.TXT_pwmrangepan.Location = new System.Drawing.Point(83, 107);
            this.TXT_pwmrangepan.Name = "TXT_pwmrangepan";
            this.TXT_pwmrangepan.Size = new System.Drawing.Size(64, 20);
            this.TXT_pwmrangepan.TabIndex = 11;
            this.TXT_pwmrangepan.Text = "1000";
            // 
            // TXT_pwmrangetilt
            // 
            this.TXT_pwmrangetilt.Location = new System.Drawing.Point(83, 270);
            this.TXT_pwmrangetilt.Name = "TXT_pwmrangetilt";
            this.TXT_pwmrangetilt.Size = new System.Drawing.Size(64, 20);
            this.TXT_pwmrangetilt.TabIndex = 21;
            this.TXT_pwmrangetilt.Text = "1000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 99;
            this.label8.Text = "PWM Range";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 273);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 99;
            this.label9.Text = "PWM Range";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(45, 247);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 99;
            this.label10.Text = "Angle";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(45, 84);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 99;
            this.label11.Text = "Angle";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(94, 40);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(393, 13);
            this.label12.TabIndex = 99;
            this.label12.Text = "Misusing this interface can cause servo damage, use with caution!!!";
            // 
            // BUT_connect
            // 
            this.BUT_connect.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BUT_connect.Location = new System.Drawing.Point(476, 9);
            this.BUT_connect.Name = "BUT_connect";
            this.BUT_connect.Size = new System.Drawing.Size(75, 23);
            this.BUT_connect.TabIndex = 3;
            this.BUT_connect.Text = "Connect";
            this.BUT_connect.UseVisualStyleBackColor = true;
            this.BUT_connect.Click += new System.EventHandler(this.BUT_connect_Click);
            // 
            // LBL_pantrim
            // 
            this.LBL_pantrim.AutoSize = true;
            this.LBL_pantrim.Location = new System.Drawing.Point(326, 128);
            this.LBL_pantrim.Name = "LBL_pantrim";
            this.LBL_pantrim.Size = new System.Drawing.Size(34, 13);
            this.LBL_pantrim.TabIndex = 0;
            this.LBL_pantrim.Text = "Angle";
            // 
            // LBL_tilttrim
            // 
            this.LBL_tilttrim.AutoSize = true;
            this.LBL_tilttrim.Location = new System.Drawing.Point(326, 291);
            this.LBL_tilttrim.Name = "LBL_tilttrim";
            this.LBL_tilttrim.Size = new System.Drawing.Size(34, 13);
            this.LBL_tilttrim.TabIndex = 0;
            this.LBL_tilttrim.Text = "Angle";
            // 
            // BUT_find
            // 
            this.BUT_find.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BUT_find.Location = new System.Drawing.Point(497, 51);
            this.BUT_find.Name = "BUT_find";
            this.BUT_find.Size = new System.Drawing.Size(83, 28);
            this.BUT_find.TabIndex = 40;
            this.BUT_find.Text = "Find Trim Pan (Sik Radio)";
            this.BUT_find.UseVisualStyleBackColor = true;
            this.BUT_find.Visible = false;
            this.BUT_find.Click += new System.EventHandler(this.BUT_find_Click);
            // 
            // TXT_centerpan
            // 
            this.TXT_centerpan.Location = new System.Drawing.Point(83, 133);
            this.TXT_centerpan.Name = "TXT_centerpan";
            this.TXT_centerpan.Size = new System.Drawing.Size(64, 20);
            this.TXT_centerpan.TabIndex = 12;
            this.TXT_centerpan.Text = "1500";
            this.TXT_centerpan.TextChanged += new System.EventHandler(this.TXT_centerpan_TextChanged);
            // 
            // TXT_centertilt
            // 
            this.TXT_centertilt.Location = new System.Drawing.Point(83, 296);
            this.TXT_centertilt.Name = "TXT_centertilt";
            this.TXT_centertilt.Size = new System.Drawing.Size(64, 20);
            this.TXT_centertilt.TabIndex = 22;
            this.TXT_centertilt.Text = "1500";
            this.TXT_centertilt.TextChanged += new System.EventHandler(this.TXT_centertilt_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label13.Location = new System.Drawing.Point(9, 136);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 13);
            this.label13.TabIndex = 99;
            this.label13.Text = "Center PWM";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label14.Location = new System.Drawing.Point(9, 299);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 13);
            this.label14.TabIndex = 99;
            this.label14.Text = "Center PWM";
            // 
            // TXT_panspeed
            // 
            this.TXT_panspeed.Location = new System.Drawing.Point(83, 159);
            this.TXT_panspeed.Name = "TXT_panspeed";
            this.TXT_panspeed.Size = new System.Drawing.Size(64, 20);
            this.TXT_panspeed.TabIndex = 13;
            this.TXT_panspeed.Text = "100";
            this.TXT_panspeed.TextChanged += new System.EventHandler(this.TXT_panspeed_TextChanged);
            // 
            // TXT_panaccel
            // 
            this.TXT_panaccel.Location = new System.Drawing.Point(83, 185);
            this.TXT_panaccel.Name = "TXT_panaccel";
            this.TXT_panaccel.Size = new System.Drawing.Size(64, 20);
            this.TXT_panaccel.TabIndex = 14;
            this.TXT_panaccel.Text = "5";
            this.TXT_panaccel.TextChanged += new System.EventHandler(this.TXT_panaccel_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label15.Location = new System.Drawing.Point(39, 162);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 13);
            this.label15.TabIndex = 99;
            this.label15.Text = "Speed";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label16.Location = new System.Drawing.Point(9, 188);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(66, 13);
            this.label16.TabIndex = 99;
            this.label16.Text = "Acceleration";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label17.Location = new System.Drawing.Point(9, 351);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(66, 13);
            this.label17.TabIndex = 99;
            this.label17.Text = "Acceleration";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label18.Location = new System.Drawing.Point(39, 325);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(38, 13);
            this.label18.TabIndex = 99;
            this.label18.Text = "Speed";
            // 
            // TXT_tiltspeed
            // 
            this.TXT_tiltspeed.Location = new System.Drawing.Point(83, 322);
            this.TXT_tiltspeed.Name = "TXT_tiltspeed";
            this.TXT_tiltspeed.Size = new System.Drawing.Size(64, 20);
            this.TXT_tiltspeed.TabIndex = 23;
            this.TXT_tiltspeed.Text = "100";
            this.TXT_tiltspeed.TextChanged += new System.EventHandler(this.TXT_tiltspeed_TextChanged);
            // 
            // TXT_tiltaccel
            // 
            this.TXT_tiltaccel.Location = new System.Drawing.Point(83, 348);
            this.TXT_tiltaccel.Name = "TXT_tiltaccel";
            this.TXT_tiltaccel.Size = new System.Drawing.Size(64, 20);
            this.TXT_tiltaccel.TabIndex = 24;
            this.TXT_tiltaccel.Text = "5";
            this.TXT_tiltaccel.TextChanged += new System.EventHandler(this.TXT_tiltaccel_TextChanged);
            // 
            // Tracker
            // 
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.TXT_tiltspeed);
            this.Controls.Add(this.TXT_tiltaccel);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.TXT_panspeed);
            this.Controls.Add(this.TXT_panaccel);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.TXT_centertilt);
            this.Controls.Add(this.TXT_centerpan);
            this.Controls.Add(this.BUT_find);
            this.Controls.Add(this.LBL_tilttrim);
            this.Controls.Add(this.LBL_pantrim);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TXT_pwmrangetilt);
            this.Controls.Add(this.TXT_pwmrangepan);
            this.Controls.Add(this.CHK_revtilt);
            this.Controls.Add(this.CHK_revpan);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TXT_tiltrange);
            this.Controls.Add(this.TRK_tilttrim);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TXT_panrange);
            this.Controls.Add(this.TRK_pantrim);
            this.Controls.Add(this.CMB_baudrate);
            this.Controls.Add(this.BUT_connect);
            this.Controls.Add(this.CMB_serialport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CMB_interface);
            this.Name = "Tracker";
            this.Size = new System.Drawing.Size(587, 386);
            ((System.ComponentModel.ISupportInitialize)(this.TRK_pantrim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TRK_tilttrim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CMB_interface;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CMB_baudrate;
        private Button BUT_connect;
        private System.Windows.Forms.ComboBox CMB_serialport;
        private System.Windows.Forms.TrackBar TRK_pantrim;
        private System.Windows.Forms.TextBox TXT_panrange;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TXT_tiltrange;
        private System.Windows.Forms.TrackBar TRK_tilttrim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox CHK_revpan;
        private System.Windows.Forms.CheckBox CHK_revtilt;
        private System.Windows.Forms.TextBox TXT_pwmrangepan;
        private System.Windows.Forms.TextBox TXT_pwmrangetilt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label LBL_pantrim;
        private System.Windows.Forms.Label LBL_tilttrim;
        private Button BUT_find;
        private System.Windows.Forms.TextBox TXT_centerpan;
        private System.Windows.Forms.TextBox TXT_centertilt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TXT_panspeed;
        private System.Windows.Forms.TextBox TXT_panaccel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox TXT_tiltspeed;
        private System.Windows.Forms.TextBox TXT_tiltaccel;
    }
}