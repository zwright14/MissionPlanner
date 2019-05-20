using System;
using System.Drawing;
using System.Windows.Forms;
using log4net;
using MissionPlanner.Controls;
using System.IO;
using System.Linq;
using System.Reflection;
using MissionPlanner.Utilities.Drawing;

namespace MissionPlanner.Utilities
{
    /// <summary>
    /// Helper class for the stylng 'theming' of forms and controls, and provides MessageBox
    /// replacements which are also styled
    /// </summary>
    public class ThemeManager
    {
        private static readonly ILog log =
            LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private static Themes _currentTheme = Themes.BurntKermit;

        public static Themes CurrentTheme
        {
            get { return _currentTheme; }
        }

        public enum Themes
        {
            /// <summary>
            /// no theme - standard Winforms appearance
            /// </summary>
            None,

            /// <summary>
            /// Standard Planner Charcoal & Green colours
            /// </summary>
            BurntKermit,
            HighContrast,
            Test,
            Custom,
        }

        // Initialize to the default theme (BurntKermit)
        public static Color BGColor = Color.FromArgb(0x26, 0x27, 0x28);
        public static Color ControlBGColor = Color.FromArgb(0x43, 0x44, 0x45);
        public static Color TextColor = Color.White;
        public static Color BGColorTextBox;
        public static Color ButBG;
        public static Color ButBGBot;
        public static Color ButBorder;
        public static Color ProgressBarColorTop;
        public static Color ProgressBarColorBot;
        public static Color ProgressBarOutlineColor;
        public static Color ColorNotEnabled;
        public static Color ColorMouseOver;
        public static Color ColorMouseDown;
        public static Color BannerColor1;
        public static Color BannerColor2;
        public static Color ButtonTextColor;
        public static Color CurrentPPMBackground;
        public static Color ZedGraphChartFill;
        public static Color ZedGraphPaneFill;
        public static Color ZedGraphLegendFill;
        public static Color RTBForeColor;
        public static Color BSVButtonAreaBGColor;
        public static Color UnselectedTextColour;
        public static Color HorizontalPBValueColor;


        /// <summary>
        /// Change the current theme. Existing controls are not affected
        /// </summary>
        /// <param name="theme"></param>
        public static void SetTheme(Themes theme)
        {
            log.Debug("Theme set to " + Enum.GetName(typeof (Themes), theme));
            _currentTheme = theme;
        }

        public static void CustomColor()
        {
          
        }

        public static void ApplyThemeTo(object control)
        {
            if (control is Control)
                ApplyThemeTo(control as Control);
        }

        /// <summary>
        /// Will recursively apply the current theme to 'control'
        /// </summary>
        /// <param name="control"></param>
        public static void ApplyThemeTo(Control control)
        {
            if(control is ContainerControl)
                ((ContainerControl)control).AutoScaleMode = AutoScaleMode.None;

            switch (_currentTheme)
            {
                case Themes.BurntKermit:
                    SetBurntKermitColors();
                    ApplyTheme(control, 0);
                    break;

                case Themes.HighContrast:
                    SetHighContrastColours();
                    ApplyTheme(control, 0);
                    break;

                case Themes.Test:
                    ApplyTestTheme(control, 0);
                    break;

                case Themes.Custom:
                    ApplyCustomTheme(control, 0);
                    break;

                default:
                    break;
            }
        }


        public static void doxamlgen()
        {
            var asm = Assembly.GetExecutingAssembly();

            var temp = asm.GetTypes().Select(a =>
            {
                if (a.IsSubclassOf(typeof(Control)))
                {
                    try
                    {
                        return (Control) Activator.CreateInstance(a);
                    }
                    catch { }
                }

                return null;
            }).ToList();

            foreach (var ctl in temp)
            {
                if(ctl == null)
                    continue;

                xaml(ctl);

                html(ctl);
            }
        }

        public static void html(Control control)
        {
            Type ty = control.GetType();

            StreamWriter st = new StreamWriter(File.Open(ty.FullName + ".html", FileMode.Create));


            st.Close();
        }


        static object locker = new object();

        public static void xaml(Control control)
        {
            try
            {
                lock (locker)
                {
                    Type ty = control.GetType();

                    StreamWriter st = new StreamWriter(File.Open(ty.FullName + ".xaml", FileMode.Create));

                    string header = @"<UserControl x:Class=""" + ty.FullName + @""" d:DesignHeight=""" + control.Height +
                                    @""" d:DesignWidth=""" + control.Width + @"""
xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation""
xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml""
xmlns:mc=""http://schemas.openxmlformats.org/markup-compatibility/2006""
xmlns:d=""http://schemas.microsoft.com/expression/blend/2008""
xmlns:xctk=""http://schemas.xceed.com/wpf/xaml/toolkit""
xmlns:Custom=""http://schemas.microsoft.com/wpf/2008/toolkit""
xmlns:BackstageView=""clr-namespace:MissionPlanner.Controls.BackstageView""
xmlns:Controls=""clr-namespace:MissionPlanner.Controls""
xmlns:GCSViews=""clr-namespace:MissionPlanner.GCSViews""
xmlns:Wizard=""clr-namespace:MissionPlanner.Wizard""
xmlns:ConfigurationView=""clr-namespace:MissionPlanner.GCSViews.ConfigurationView""
mc:Ignorable=""d""
> <Grid>";

                    st.Write(header);

               

                    string footer = "</Grid></UserControl>";

                    st.Write(footer);

                    st.Close();
                }
            }
            catch
            {
            }
        }
        

        private static void ApplyCustomTheme(Control temp, int level)
        {
            if (level == 0)
            {
                temp.BackColor = BGColor;
                temp.ForeColor = TextColor;
            }

            foreach (Control ctl in temp.Controls)
            {
                if (ctl.GetType() == typeof (Panel))
                {
                    ctl.BackColor = BGColor;
                    ctl.ForeColor = TextColor;
                }
                else if (ctl.GetType() == typeof (GroupBox))
                {
                    ctl.BackColor = BGColor;
                    ctl.ForeColor = TextColor;
                }
                else if (ctl.GetType() == typeof (TreeView))
                {
                    ctl.BackColor = BGColor;
                    ctl.ForeColor = TextColor;
                    TreeView txtr = (TreeView) ctl;
                    txtr.LineColor = TextColor;
                }
                else if (ctl.GetType() == typeof (MyLabel))
                {
                    ctl.BackColor = BGColor;
                    ctl.ForeColor = TextColor;
                }
                else if (ctl.GetType() == typeof (Button))
                {
                    ctl.ForeColor = TextColor;
                    ctl.BackColor = ButBG;
                }
          
                else if (ctl.GetType() == typeof (TextBox))
                {
                    ctl.BackColor = ControlBGColor;
                    ctl.ForeColor = TextColor;
                    TextBox txt = (TextBox) ctl;
                    txt.BorderStyle = BorderStyle.None;
                }
                else if (ctl.GetType() == typeof (DomainUpDown))
                {
                    ctl.BackColor = ControlBGColor;
                    ctl.ForeColor = TextColor;
                    DomainUpDown txt = (DomainUpDown) ctl;
                    txt.BorderStyle = BorderStyle.None;
                }
                else if (ctl.GetType() == typeof (GroupBox) || ctl.GetType() == typeof (UserControl))
                {
                    ctl.BackColor = BGColor;
                    ctl.ForeColor = TextColor;
                }
              
                
                else if (ctl.GetType() == typeof (SplitterPanel))
                {
                    ctl.BackColor = BGColor;
                    ctl.ForeColor = TextColor; // Color.FromArgb(0xe6, 0xe8, 0xea);
                }
               
                else if (ctl.GetType() == typeof (RichTextBox))
                {

                    if ((ctl.Name == "TXT_terminal") )
                    {
                        RichTextBox txtr = (RichTextBox)ctl;
                        txtr.BorderStyle = BorderStyle.None;
                        txtr.ForeColor = Color.White;
                        txtr.BackColor = Color.Black;
                    }
                    else
                    {

                        ctl.BackColor = ControlBGColor;
                        ctl.ForeColor = TextColor;
                        RichTextBox txtr = (RichTextBox)ctl;
                    txtr.BorderStyle = BorderStyle.None;
                }
            }
                else if (ctl.GetType() == typeof (CheckedListBox))
                {
                    ctl.BackColor = ControlBGColor;
                    ctl.ForeColor = TextColor;
                    CheckedListBox txtr = (CheckedListBox) ctl;
                    txtr.BorderStyle = BorderStyle.None;
                }
                else if (ctl.GetType() == typeof (TabPage))
                {
                    ctl.BackColor = BGColor; //ControlBGColor
                    ctl.ForeColor = TextColor;
                    TabPage txtr = (TabPage) ctl;
                    txtr.BorderStyle = BorderStyle.None;
                }
                else if (ctl.GetType() == typeof (TabControl))
                {
                    ctl.BackColor = BGColor; //ControlBGColor
                    ctl.ForeColor = TextColor;
                    TabControl txtr = (TabControl) ctl;
                }
                else if (ctl.GetType() == typeof (DataGridView) )
                {
                    ctl.ForeColor = TextColor;
                    DataGridView dgv = (DataGridView) ctl;
                    dgv.EnableHeadersVisualStyles = false;
                    dgv.BorderStyle = BorderStyle.None;
                    dgv.BackgroundColor = BGColor;
                    DataGridViewCellStyle rs = new DataGridViewCellStyle();
                    rs.BackColor = ControlBGColor;
                    rs.ForeColor = TextColor;
                    dgv.RowsDefaultCellStyle = rs;

                    DataGridViewCellStyle hs = new DataGridViewCellStyle(dgv.ColumnHeadersDefaultCellStyle);
                    hs.BackColor = BGColor;
                    hs.ForeColor = TextColor;

                    dgv.ColumnHeadersDefaultCellStyle = hs;
                    dgv.RowHeadersDefaultCellStyle = hs;

                    dgv.AlternatingRowsDefaultCellStyle.BackColor = BGColor;
                }
        
                else if (ctl.GetType() == typeof (TrackBar))
                {
                    ctl.BackColor = BGColor;
                    ctl.ForeColor = TextColor;
                }
                else if (ctl.GetType() == typeof (LinkLabel))
                {
                    ctl.BackColor = BGColor;
                    ctl.ForeColor = TextColor;
                    LinkLabel LNK = (LinkLabel) ctl;
                    LNK.ActiveLinkColor = TextColor;
                    LNK.LinkColor = TextColor;
                    LNK.VisitedLinkColor = TextColor;
                }
          
                else if (ctl.GetType() == typeof(MyProgressBar))
                {
                    ((MyProgressBar)ctl).BGGradBot = ControlBGColor;
                    ((MyProgressBar)ctl).BGGradTop = BGColor;
                }

                if (ctl.Controls.Count > 0)
                    ApplyCustomTheme(ctl, 1);
            }
        }

        private static void ApplyTestTheme(Control temp, int level)
        {
            foreach (Control ctl in temp.Controls)
            {
         

                if (ctl.Controls.Count > 0)
                    ApplyTestTheme(ctl, 1);
            }
        }

        private static void SetBurntKermitColors()
        {
            BGColor = Color.FromArgb(0x26, 0x27, 0x28);                     // This changes the colour of the main menu background
            ControlBGColor = Color.FromArgb(0x43, 0x44, 0x45);              // This changes the colour of the sub menu backgrounds
            TextColor = Color.White;                                        // This changes the colour of text
            BGColorTextBox = Color.FromArgb(0x43, 0x44, 0x45);              // This changes the colour of the background of textboxes
            ButtonTextColor = Color.FromArgb(64, 87, 4);                    // This changes the colour of button text
            ButBG = Color.FromArgb(148, 193, 31);                           // This changes the colour of button backgrounds (Top)
            ButBGBot = Color.FromArgb(205, 226, 150);                       // This changes the colour of button backgrounds (Bot)
            ProgressBarColorTop = Color.FromArgb(102, 139, 26);             // These three variables change the colours of progress bars
            ProgressBarColorBot = Color.FromArgb(124, 164, 40);
            ProgressBarOutlineColor = Color.FromArgb(150, 174, 112);
            BannerColor1 = Color.FromArgb(0x40, 0x57, 0x04);                // These two variables change the colours of banners such as "planner" umder configuration
            BannerColor2 = Color.FromArgb(0x94, 0xC1, 0x1F);
            ColorNotEnabled = Color.FromArgb(150, 43, 58, 3);               // This changes the background color of buttons when not enabled
            ColorMouseOver = Color.FromArgb(73, 43, 58, 3);                 // This changes the background color of buttons when the mouse is hovering over a button
            ColorMouseDown = Color.FromArgb(73, 43, 58, 3);                 // This changes the background color of buttons when the mouse is clicked down on a button
            CurrentPPMBackground = Color.Green;                             // This changes the background colour of the current PPM setting in the flight modes tab
            ZedGraphChartFill = Color.FromArgb(0x1F, 0x1F, 0x20);           // These three variables change the fill colours of Zed Graphs
            ZedGraphPaneFill = Color.FromArgb(0x37, 0x37, 0x38);
            ZedGraphLegendFill = Color.FromArgb(0x85, 0x84, 0x83);
            RTBForeColor = Color.WhiteSmoke;                                // This changes the colour of text in rich text boxes
            BSVButtonAreaBGColor = Color.Black;                             // This changes the colour of a backstageview button area
            UnselectedTextColour = Color.WhiteSmoke;                        // This changes the colour of unselected text in a BSV button
            HorizontalPBValueColor = Color.FromArgb(148, 193, 31);          // This changes the colour of the horizontal progressbar

  

            Settings.Instance["terminaltheming"] = true.ToString();
        }

        private static void SetHighContrastColours()
        {

            BGColor = Color.FromArgb(0xEE, 0xEE, 0xEE);                     // This changes the colour of the main menu background
            ControlBGColor = Color.FromArgb(0xE2, 0xE2, 0xE2);              // This changes the colour of the sub menu backgrounds
            TextColor = Color.Black;                                        // This changes the colour of text
            BGColorTextBox = ControlBGColor;                                // This changes the colour of the background of textboxes
            ButtonTextColor = Color.Black;                                  // This changes the colour of button text
            ButBG = Color.FromArgb(0xFF, 0xFF, 0x99);                       // This changes the colour of button backgrounds (Top)
            ButBGBot = Color.FromArgb(0xCC, 0xCC, 0x66);                    // This changes the colour of button backgrounds (Bot)
            ProgressBarColorTop = Color.FromArgb(227, 227, 227);            // These three variables change the colours of progress bars
            ProgressBarColorBot = Color.FromArgb(227, 227, 227);
            ProgressBarOutlineColor = Color.FromArgb(150, 174, 112);
            BannerColor1 = Color.FromArgb(0x40, 0x57, 0x04);                // These two variables change the colours of banners such as "planner" umder configuration
            BannerColor2 = Color.FromArgb(0x94, 0xC1, 0x1F);
            ColorNotEnabled = Color.FromArgb(150, 43, 58, 3);               // This changes the background color of buttons when not enabled
            ColorMouseOver = Color.FromArgb(73, 43, 58, 3);                 // This changes the background color of buttons when the mouse is hovering over a button
            ColorMouseDown = Color.FromArgb(73, 43, 58, 3);                 // This changes the background color of buttons when the mouse is clicked down on a button
            CurrentPPMBackground = Color.Green;                             // This changes the background colour of the current PPM setting in the flight modes tab
            ZedGraphChartFill = ControlBGColor;                             // These three variables change the fill colours of Zed Graphs
            ZedGraphPaneFill = BGColor;
            ZedGraphLegendFill = ControlBGColor;
            RTBForeColor = TextColor;                                       // This changes the colour of text in rich text boxes
            BSVButtonAreaBGColor = Color.White;                             // This changes the colour of a backstageview button area
            UnselectedTextColour = Color.Gray;                              // This changes the colour of unselected text in a BSV button
            HorizontalPBValueColor = Color.FromArgb(148, 193, 31);          // This changes the colour of the horizontal progressbar

            if (MainV2.instance != null )
            {
     
            }

            if (MainV2.instance != null)
            {
   
            }

   
            Settings.Instance["terminaltheming"] = true.ToString();
        }

        private static void ApplyTheme(Control temp, int level)
        {
            if (level == 0)
            {
                temp.BackColor = BGColor;
                temp.ForeColor = TextColor;
            }

            foreach (Control ctl in temp.Controls)
            {
                if (ctl.GetType() == typeof(Label))
                {
                    if (!(ctl.Tag is string && (string)ctl.Tag == "custom"))
                    {
                        ctl.ForeColor = TextColor;
                    }
                }
               
                else if (ctl.GetType() == typeof(TreeView))
                {
                    ctl.BackColor = BGColor;
                    ctl.ForeColor = TextColor;
                    TreeView txtr = (TreeView)ctl;
                    txtr.LineColor = TextColor;
                }
                else if (ctl.GetType() == typeof(Panel))
                {
                    ctl.BackColor = BGColor;
                    ctl.ForeColor = TextColor;
                }
                else if (ctl.GetType() == typeof(GroupBox))
                {
                    ctl.BackColor = BGColor;
                    ctl.ForeColor = TextColor;
                }
                else if (ctl.GetType() == typeof(MyLabel))
                {
                    ctl.BackColor = BGColor;
                    ctl.ForeColor = TextColor;
                }
                else if (ctl.GetType() == typeof(Button))
                {
                    ctl.ForeColor = Color.Black;
                    ctl.BackColor = ButBG;
                }
   
                else if (ctl.GetType() == typeof(TextBox))
                {
                    ctl.BackColor = BGColorTextBox;             //sets the BG colour of text boxes to specified colour
                    ctl.ForeColor = TextColor;
                    TextBox txt = (TextBox)ctl;
                    txt.BorderStyle = BorderStyle.None;
                }
                else if (ctl.GetType() == typeof(DomainUpDown))
                {
                    ctl.BackColor = ControlBGColor;
                    ctl.ForeColor = TextColor;
                    DomainUpDown txt = (DomainUpDown)ctl;
                    txt.BorderStyle = BorderStyle.None;
                }
                else if (ctl.GetType() == typeof(GroupBox) || ctl.GetType() == typeof(UserControl) )
                {
                    ctl.BackColor = BGColor;
                    ctl.ForeColor = TextColor;
                }
     
                else if ( ctl.GetType() == typeof(SplitterPanel))
                {
                    ctl.BackColor = BGColor;
                    ctl.ForeColor = TextColor;
                }
               
                else if (ctl.GetType() == typeof(Form))
                {
                    ctl.BackColor = BGColor;
                    ctl.ForeColor = TextColor;

                }
                else if (ctl.GetType() == typeof(RichTextBox))
                {
                    if ((ctl.Name == "TXT_terminal"))
                    {
                        RichTextBox txtr = (RichTextBox)ctl;
                        txtr.BorderStyle = BorderStyle.None;
                        txtr.ForeColor = Color.White;
                        txtr.BackColor = Color.Black;
                    }
                    else
                    {
                        RichTextBox txtr = (RichTextBox)ctl;
                        txtr.BorderStyle = BorderStyle.None;
                        txtr.ForeColor = RTBForeColor;
                        txtr.BackColor = ControlBGColor;
                    }
                }
                else if (ctl.GetType() == typeof(CheckedListBox))
                {
                    ctl.BackColor = ControlBGColor;
                    ctl.ForeColor = TextColor;
                    CheckedListBox txtr = (CheckedListBox)ctl;
                    txtr.BorderStyle = BorderStyle.None;
                }
                else if (ctl.GetType() == typeof(TabPage))
                {
                    ctl.BackColor = BGColor;
                    ctl.ForeColor = TextColor;
                    TabPage txtr = (TabPage)ctl;
                    txtr.BorderStyle = BorderStyle.None;
                }
                else if (ctl.GetType() == typeof(TabControl))
                {
                    ctl.BackColor = BGColor;
                    ctl.ForeColor = TextColor;
                    TabControl txtr = (TabControl)ctl;
                }
                else if (ctl.GetType() == typeof(DataGridView) )
                {
                    ctl.ForeColor = TextColor;
                    DataGridView dgv = (DataGridView)ctl;
                    dgv.EnableHeadersVisualStyles = false;
                    dgv.BorderStyle = BorderStyle.None;
                    dgv.BackgroundColor = BGColor;
                    DataGridViewCellStyle rs = new DataGridViewCellStyle();
                    rs.BackColor = ControlBGColor;
                    rs.ForeColor = TextColor;
                    dgv.RowsDefaultCellStyle = rs;

                    dgv.AlternatingRowsDefaultCellStyle.BackColor = BGColor;

                    DataGridViewCellStyle hs = new DataGridViewCellStyle(dgv.ColumnHeadersDefaultCellStyle);
                    hs.BackColor = BGColor;
                    hs.ForeColor = TextColor;

                    dgv.ColumnHeadersDefaultCellStyle = hs;
                    dgv.RowHeadersDefaultCellStyle = hs;
                }
             
                else if (ctl.GetType() == typeof (TrackBar))
                {
                    ctl.BackColor = BGColor;
                    ctl.ForeColor = TextColor;
                }
                else if (ctl.GetType() == typeof (LinkLabel))
                {
                    ctl.BackColor = BGColor;
                    ctl.ForeColor = TextColor;
                    LinkLabel LNK = (LinkLabel) ctl;
                    LNK.ActiveLinkColor = TextColor;
                    LNK.LinkColor = TextColor;
                    LNK.VisitedLinkColor = TextColor;
                }
      
                else if (ctl.GetType() == typeof(MyProgressBar))
                {
                    ((MyProgressBar)ctl).BGGradTop = ProgressBarColorTop;
                    ((MyProgressBar)ctl).BGGradBot = ProgressBarColorBot;
                    ((MyProgressBar)ctl).Outline = ProgressBarOutlineColor;        //sets the colour of the progress bar box
                } 
                if ( (ctl.Controls.Count > 0))      //Do not iterate into quickView type leave labels as they are
                    ApplyTheme(ctl, 1);

            }
        }
    }
}