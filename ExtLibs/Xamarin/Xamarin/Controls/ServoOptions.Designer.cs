using MissionPlanner.Utilities.Drawing;

namespace MissionPlanner.Controls
{
    partial class ServoOptions
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.BUT_Low = new MissionPlanner.Controls.MyButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BUT_High = new MissionPlanner.Controls.MyButton();
            this.TXT_pwm_low = new System.Windows.Forms.TextBox();
            this.TXT_pwm_high = new System.Windows.Forms.TextBox();
            this.BUT_Repeat = new MissionPlanner.Controls.MyButton();
            this.TXT_rcchannel = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BUT_Low
            // 
            this.BUT_Low.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_Low.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_Low.ColorNotEnabled = System.Drawing.Color.Empty;
            this.BUT_Low.ContextMenuStrip = this.contextMenuStrip1;
            this.BUT_Low.Location = new System.Drawing.Point(0, 1);
            this.BUT_Low.Name = "BUT_Low";
            this.BUT_Low.Size = new System.Drawing.Size(38, 21);
            this.BUT_Low.TabIndex = 0;
            this.BUT_Low.Text = "Low";
            this.BUT_Low.UseVisualStyleBackColor = true;
            this.BUT_Low.Click += new System.EventHandler(this.BUT_Low_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.renameToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(118, 26);
            // 
            // renameToolStripMenuItem
            // 
            this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            this.renameToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.renameToolStripMenuItem.Text = "Rename";
            this.renameToolStripMenuItem.Click += new System.EventHandler(this.renameToolStripMenuItem_Click);
            // 
            // BUT_High
            // 
            this.BUT_High.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_High.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_High.ColorNotEnabled = System.Drawing.Color.Empty;
            this.BUT_High.ContextMenuStrip = this.contextMenuStrip1;
            this.BUT_High.Location = new System.Drawing.Point(44, 1);
            this.BUT_High.Name = "BUT_High";
            this.BUT_High.Size = new System.Drawing.Size(38, 21);
            this.BUT_High.TabIndex = 1;
            this.BUT_High.Text = "High";
            this.BUT_High.UseVisualStyleBackColor = true;
            this.BUT_High.Click += new System.EventHandler(this.BUT_High_Click);
            // 
            // TXT_pwm_low
            // 
            this.TXT_pwm_low.Location = new System.Drawing.Point(197, 3);
            this.TXT_pwm_low.Name = "TXT_pwm_low";
            this.TXT_pwm_low.Size = new System.Drawing.Size(35, 20);
            this.TXT_pwm_low.TabIndex = 3;
            this.TXT_pwm_low.Text = "1100";
            this.TXT_pwm_low.TextChanged += new System.EventHandler(this.TXT_pwm_low_TextChanged);
            // 
            // TXT_pwm_high
            // 
            this.TXT_pwm_high.Location = new System.Drawing.Point(238, 3);
            this.TXT_pwm_high.Name = "TXT_pwm_high";
            this.TXT_pwm_high.Size = new System.Drawing.Size(35, 20);
            this.TXT_pwm_high.TabIndex = 4;
            this.TXT_pwm_high.Text = "1900";
            this.TXT_pwm_high.TextChanged += new System.EventHandler(this.TXT_pwm_high_TextChanged);
            // 
            // BUT_Repeat
            // 
            this.BUT_Repeat.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_Repeat.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_Repeat.ColorNotEnabled = System.Drawing.Color.Empty;
            this.BUT_Repeat.Location = new System.Drawing.Point(88, 1);
            this.BUT_Repeat.Name = "BUT_Repeat";
            this.BUT_Repeat.Size = new System.Drawing.Size(46, 21);
            this.BUT_Repeat.TabIndex = 2;
            this.BUT_Repeat.Text = "Toggle";
            this.BUT_Repeat.UseVisualStyleBackColor = true;
            this.BUT_Repeat.Click += new System.EventHandler(this.BUT_Repeat_Click);
            // 
            // TXT_rcchannel
            // 
            this.TXT_rcchannel.BackColor = System.Drawing.Color.Red;
            this.TXT_rcchannel.ContextMenuStrip = this.contextMenuStrip1;
            this.TXT_rcchannel.Location = new System.Drawing.Point(140, 0);
            this.TXT_rcchannel.Name = "TXT_rcchannel";
            this.TXT_rcchannel.Size = new System.Drawing.Size(51, 21);
            this.TXT_rcchannel.TabIndex = 12;
            this.TXT_rcchannel.Text = "5";
            this.TXT_rcchannel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ServoOptions
            // 
            this.Controls.Add(this.TXT_rcchannel);
            this.Controls.Add(this.BUT_Repeat);
            this.Controls.Add(this.TXT_pwm_high);
            this.Controls.Add(this.TXT_pwm_low);
            this.Controls.Add(this.BUT_High);
            this.Controls.Add(this.BUT_Low);
            this.Name = "ServoOptions";
            this.Size = new System.Drawing.Size(295, 22);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyButton BUT_Low;
        private MyButton BUT_High;
        private System.Windows.Forms.TextBox TXT_pwm_low;
        private System.Windows.Forms.TextBox TXT_pwm_high;
        private MyButton BUT_Repeat;
        private System.Windows.Forms.Label TXT_rcchannel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
    }
}
