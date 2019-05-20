using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MissionPlanner.Controls
{
    public class MyButton:Button
    {
        public Color ColorMouseDown { get; set; }
        public Color ColorMouseOver { get; set; }
        public Color ColorNotEnabled { get; set; }
    }
}
