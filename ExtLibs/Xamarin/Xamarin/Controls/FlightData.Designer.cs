using MissionPlanner.Utilities.Drawing;
using System.Drawing;

namespace MissionPlanner.GCSViews
{
    partial class FlightData
    {
        private System.ComponentModel.IContainer components = null;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MainH = new System.Windows.Forms.SplitContainer();
            this.SubMainLeft = new System.Windows.Forms.SplitContainer();
            this.hud1 = new MissionPlanner.Controls.HUD();
            this.contextMenuStripHud = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.videoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordHudToAVIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setMJPEGSourceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startCameraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setGStreamerSourceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setAspectRatioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.russianHudToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.swapWithMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingSourceHud = new System.Windows.Forms.BindingSource(this.components);
            this.tabControlactions = new System.Windows.Forms.TabControl();
            this.contextMenuStripactionstab = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabQuick = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelQuick = new System.Windows.Forms.TableLayoutPanel();
            this.quickView6 = new MissionPlanner.Controls.QuickView();
            this.contextMenuStripQuickView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.setViewCountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingSourceQuickTab = new System.Windows.Forms.BindingSource(this.components);
            this.quickView5 = new MissionPlanner.Controls.QuickView();
            this.quickView4 = new MissionPlanner.Controls.QuickView();
            this.quickView3 = new MissionPlanner.Controls.QuickView();
            this.quickView2 = new MissionPlanner.Controls.QuickView();
            this.quickView1 = new MissionPlanner.Controls.QuickView();
            this.tabActions = new System.Windows.Forms.TabPage();
            this.modifyandSetLoiterRad = new MissionPlanner.Controls.ModifyandSet();
            this.BUT_abortland = new MissionPlanner.Controls.MyButton();
            this.BUT_resumemis = new MissionPlanner.Controls.MyButton();
            this.CMB_mountmode = new System.Windows.Forms.ComboBox();
            this.BUT_mountmode = new MissionPlanner.Controls.MyButton();
            this.BUT_ARM = new MissionPlanner.Controls.MyButton();
            this.BUT_joystick = new MissionPlanner.Controls.MyButton();
            this.BUT_quickmanual = new MissionPlanner.Controls.MyButton();
            this.BUT_quickrtl = new MissionPlanner.Controls.MyButton();
            this.BUT_quickauto = new MissionPlanner.Controls.MyButton();
            this.CMB_setwp = new System.Windows.Forms.ComboBox();
            this.BUT_setwp = new MissionPlanner.Controls.MyButton();
            this.CMB_modes = new System.Windows.Forms.ComboBox();
            this.BUT_setmode = new MissionPlanner.Controls.MyButton();
            this.BUT_clear_track = new MissionPlanner.Controls.MyButton();
            this.CMB_action = new System.Windows.Forms.ComboBox();
            this.BUT_Homealt = new MissionPlanner.Controls.MyButton();
            this.BUT_RAWSensor = new MissionPlanner.Controls.MyButton();
            this.BUTrestartmission = new MissionPlanner.Controls.MyButton();
            this.BUTactiondo = new MissionPlanner.Controls.MyButton();
            this.modifyandSetSpeed = new MissionPlanner.Controls.ModifyandSet();
            this.modifyandSetAlt = new MissionPlanner.Controls.ModifyandSet();
            this.tabActionsSimple = new System.Windows.Forms.TabPage();
            this.myButton1 = new MissionPlanner.Controls.MyButton();
            this.myButton2 = new MissionPlanner.Controls.MyButton();
            this.myButton3 = new MissionPlanner.Controls.MyButton();
            this.tabPagePreFlight = new System.Windows.Forms.TabPage();
            this.checkListControl1 = new MissionPlanner.Controls.PreFlight.CheckListControl();
            this.tabGauges = new System.Windows.Forms.TabPage();
            this.Gvspeed = new AGaugeApp.AGauge();
            this.bindingSourceGaugesTab = new System.Windows.Forms.BindingSource(this.components);
            this.Gheading = new MissionPlanner.Controls.HSI();
            this.Galt = new AGaugeApp.AGauge();
            this.Gspeed = new AGaugeApp.AGauge();
            this.tabStatus = new System.Windows.Forms.TabPage();
            this.tabServo = new System.Windows.Forms.TabPage();
            this.flowLayoutPanelServos = new System.Windows.Forms.FlowLayoutPanel();
            this.servoOptions1 = new MissionPlanner.Controls.ServoOptions();
            this.servoOptions2 = new MissionPlanner.Controls.ServoOptions();
            this.servoOptions3 = new MissionPlanner.Controls.ServoOptions();
            this.servoOptions4 = new MissionPlanner.Controls.ServoOptions();
            this.servoOptions5 = new MissionPlanner.Controls.ServoOptions();
            this.servoOptions6 = new MissionPlanner.Controls.ServoOptions();
            this.servoOptions7 = new MissionPlanner.Controls.ServoOptions();
            this.servoOptions8 = new MissionPlanner.Controls.ServoOptions();
            this.servoOptions9 = new MissionPlanner.Controls.ServoOptions();
            this.servoOptions10 = new MissionPlanner.Controls.ServoOptions();
            this.tabTLogs = new System.Windows.Forms.TabPage();
            this.tableLayoutPaneltlogs = new System.Windows.Forms.TableLayoutPanel();
            this.BUT_loadtelem = new MissionPlanner.Controls.MyButton();
            this.lbl_playbackspeed = new MissionPlanner.Controls.MyLabel();
            this.lbl_logpercent = new MissionPlanner.Controls.MyLabel();
            this.tracklog = new System.Windows.Forms.TrackBar();
            this.LBL_logfn = new MissionPlanner.Controls.MyLabel();
            this.BUT_log2kml = new MissionPlanner.Controls.MyButton();
            this.BUT_playlog = new MissionPlanner.Controls.MyButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.BUT_speed10 = new MissionPlanner.Controls.MyButton();
            this.BUT_speed5 = new MissionPlanner.Controls.MyButton();
            this.BUT_speed2 = new MissionPlanner.Controls.MyButton();
            this.BUT_speed1 = new MissionPlanner.Controls.MyButton();
            this.BUT_speed1_2 = new MissionPlanner.Controls.MyButton();
            this.BUT_speed1_4 = new MissionPlanner.Controls.MyButton();
            this.BUT_speed1_10 = new MissionPlanner.Controls.MyButton();
            this.tablogbrowse = new System.Windows.Forms.TabPage();
            this.BUT_loganalysis = new MissionPlanner.Controls.MyButton();
            this.BUT_DFMavlink = new MissionPlanner.Controls.MyButton();
            this.but_dflogtokml = new MissionPlanner.Controls.MyButton();
            this.but_bintolog = new MissionPlanner.Controls.MyButton();
            this.BUT_matlab = new MissionPlanner.Controls.MyButton();
            this.BUT_logbrowse = new MissionPlanner.Controls.MyButton();
            this.tabScripts = new System.Windows.Forms.TabPage();
            this.checkBoxRedirectOutput = new System.Windows.Forms.CheckBox();
            this.BUT_edit_selected = new MissionPlanner.Controls.MyButton();
            this.labelSelectedScript = new System.Windows.Forms.Label();
            this.BUT_run_script = new MissionPlanner.Controls.MyButton();
            this.BUT_abort_script = new MissionPlanner.Controls.MyButton();
            this.labelScriptStatus = new System.Windows.Forms.Label();
            this.BUT_select_script = new MissionPlanner.Controls.MyButton();
            this.tabPagemessages = new System.Windows.Forms.TabPage();
            this.txt_messagebox = new System.Windows.Forms.TextBox();
            this.tabPayload = new System.Windows.Forms.TabPage();
            this.BUT_PayloadFolder = new MissionPlanner.Controls.MyButton();
            this.groupBoxRoll = new System.Windows.Forms.GroupBox();
            this.TXT_gimbalRollPos = new System.Windows.Forms.TextBox();
            this.bindingSourcePayloadTab = new System.Windows.Forms.BindingSource(this.components);
            this.trackBarRoll = new System.Windows.Forms.TrackBar();
            this.groupBoxYaw = new System.Windows.Forms.GroupBox();
            this.TXT_gimbalYawPos = new System.Windows.Forms.TextBox();
            this.trackBarYaw = new System.Windows.Forms.TrackBar();
            this.BUT_resetGimbalPos = new MissionPlanner.Controls.MyButton();
            this.groupBoxPitch = new System.Windows.Forms.GroupBox();
            this.trackBarPitch = new System.Windows.Forms.TrackBar();
            this.TXT_gimbalPitchPos = new System.Windows.Forms.TextBox();
            this.tableMap = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            //this.zg1 = new ZedGraph.ZedGraphControl();
            this.contextMenuStripMap = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.goHereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flyToHereAltToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPoiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pointCameraHereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PointCameraCoordsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.triggerCameraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flightPlannerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setHomeHereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setEKFHomeHereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setHomeHereToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.takeOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onOffCameraOverlapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altitudeAngelSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.but_disablejoystick = new MissionPlanner.Controls.MyButton();
            this.distanceBar1 = new MissionPlanner.Controls.DistanceBar();
            this.windDir1 = new MissionPlanner.Controls.WindDir();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_hdop = new MissionPlanner.Controls.MyLabel();
            this.lbl_sats = new MissionPlanner.Controls.MyLabel();
            this.gMapControl1 = new MissionPlanner.Controls.myGMAP();
            this.TRK_zoom = new MissionPlanner.Controls.MyTrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.coords1 = new MissionPlanner.Controls.Coords();
            this.Zoomlevel = new System.Windows.Forms.NumericUpDown();
            this.label1 = new MissionPlanner.Controls.MyLabel();
            this.CHK_autopan = new System.Windows.Forms.CheckBox();
            this.CB_tuning = new System.Windows.Forms.CheckBox();
            this.ZedGraphTimer = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.openScriptDialog = new System.Windows.Forms.OpenFileDialog();
            this.scriptChecker = new System.Windows.Forms.Timer(this.components);
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Messagetabtimer = new System.Windows.Forms.Timer(this.components);
            this.bindingSourceStatusTab = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MainH)).BeginInit();
            this.MainH.Panel1.SuspendLayout();
            this.MainH.Panel2.SuspendLayout();
            this.MainH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SubMainLeft)).BeginInit();
            this.SubMainLeft.Panel1.SuspendLayout();
            this.SubMainLeft.Panel2.SuspendLayout();
            this.SubMainLeft.SuspendLayout();
            this.contextMenuStripHud.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHud)).BeginInit();
            this.tabControlactions.SuspendLayout();
            this.contextMenuStripactionstab.SuspendLayout();
            this.tabQuick.SuspendLayout();
            this.tableLayoutPanelQuick.SuspendLayout();
            this.contextMenuStripQuickView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceQuickTab)).BeginInit();
            this.tabActions.SuspendLayout();
            this.tabActionsSimple.SuspendLayout();
            this.tabPagePreFlight.SuspendLayout();
            this.tabGauges.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceGaugesTab)).BeginInit();
            this.tabServo.SuspendLayout();
            this.flowLayoutPanelServos.SuspendLayout();
            this.tabTLogs.SuspendLayout();
            this.tableLayoutPaneltlogs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tracklog)).BeginInit();
            this.panel2.SuspendLayout();
            this.tablogbrowse.SuspendLayout();
            this.tabScripts.SuspendLayout();
            this.tabPagemessages.SuspendLayout();
            this.tabPayload.SuspendLayout();
            this.groupBoxRoll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePayloadTab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRoll)).BeginInit();
            this.groupBoxYaw.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarYaw)).BeginInit();
            this.groupBoxPitch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPitch)).BeginInit();
            this.tableMap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.contextMenuStripMap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TRK_zoom)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Zoomlevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceStatusTab)).BeginInit();
            this.SuspendLayout();
            // 
            // MainH
            // 
            this.MainH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainH.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.MainH.Location = new Point(0, 0);
            this.MainH.Margin = new System.Windows.Forms.Padding(0);
            this.MainH.Name = "MainH";
            // 
            // MainH.Panel1
            // 
            this.MainH.Panel1.Controls.Add(this.SubMainLeft);
            this.MainH.Panel1MinSize = 360;
            // 
            // MainH.Panel2
            // 
            this.MainH.Panel2.Controls.Add(this.tableMap);
            this.MainH.Size = new Size(1008, 462);
            this.MainH.SplitterDistance = 360;
            this.MainH.TabIndex = 68;
            // 
            // SubMainLeft
            // 
            this.SubMainLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SubMainLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SubMainLeft.Location = new Point(0, 0);
            this.SubMainLeft.Margin = new System.Windows.Forms.Padding(0);
            this.SubMainLeft.Name = "SubMainLeft";
            this.SubMainLeft.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SubMainLeft.Panel1
            // 
            this.SubMainLeft.Panel1.Controls.Add(this.hud1);
            // 
            // SubMainLeft.Panel2
            // 
            this.SubMainLeft.Panel2.Controls.Add(this.tabControlactions);
            this.SubMainLeft.Size = new Size(360, 462);
            this.SubMainLeft.SplitterDistance = 266;
            this.SubMainLeft.TabIndex = 0;
            // 
            // hud1
            // 
            this.hud1.airspeed = 0F;
            this.hud1.alt = 0F;
            this.hud1.altunit = null;
            this.hud1.AOA = 0F;
            this.hud1.BackColor = Color.Black;
            this.hud1.batterylevel = 0F;
            this.hud1.batteryremaining = 0F;
            this.hud1.bgimage = null;
            this.hud1.connected = false;
            this.hud1.ContextMenuStrip = this.contextMenuStripHud;
            this.hud1.critAOA = 25F;
            this.hud1.critSSA = 30F;
            this.hud1.current = 0F;
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("airspeed", this.bindingSourceHud, "airspeed", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("alt", this.bindingSourceHud, "alt", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("batterylevel", this.bindingSourceHud, "battery_voltage", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("batteryremaining", this.bindingSourceHud, "battery_remaining", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("connected", this.bindingSourceHud, "connected", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("current", this.bindingSourceHud, "current", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("datetime", this.bindingSourceHud, "datetime", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("disttowp", this.bindingSourceHud, "wp_dist", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("ekfstatus", this.bindingSourceHud, "ekfstatus", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("failsafe", this.bindingSourceHud, "failsafe", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("gpsfix", this.bindingSourceHud, "gpsstatus", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("gpsfix2", this.bindingSourceHud, "gpsstatus2", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("gpshdop", this.bindingSourceHud, "gpshdop", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("gpshdop2", this.bindingSourceHud, "gpshdop2", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("groundalt", this.bindingSourceHud, "HomeAlt", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("groundcourse", this.bindingSourceHud, "groundcourse", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("groundspeed", this.bindingSourceHud, "groundspeed", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("heading", this.bindingSourceHud, "yaw", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("linkqualitygcs", this.bindingSourceHud, "linkqualitygcs", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("message", this.bindingSourceHud, "messageHigh", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("messagetime", this.bindingSourceHud, "messageHighTime", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("mode", this.bindingSourceHud, "mode", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("navpitch", this.bindingSourceHud, "nav_pitch", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("navroll", this.bindingSourceHud, "nav_roll", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("pitch", this.bindingSourceHud, "pitch", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("roll", this.bindingSourceHud, "roll", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("status", this.bindingSourceHud, "armed", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("targetalt", this.bindingSourceHud, "targetalt", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("targetheading", this.bindingSourceHud, "nav_bearing", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("targetspeed", this.bindingSourceHud, "targetairspeed", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("turnrate", this.bindingSourceHud, "turnrate", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("verticalspeed", this.bindingSourceHud, "verticalspeed", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("vibex", this.bindingSourceHud, "vibex", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("vibey", this.bindingSourceHud, "vibey", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("vibez", this.bindingSourceHud, "vibez", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("wpno", this.bindingSourceHud, "wpno", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("xtrack_error", this.bindingSourceHud, "xtrack_error", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("AOA", this.bindingSourceHud, "AOA", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("SSA", this.bindingSourceHud, "SSA", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("critAOA", this.bindingSourceHud, "crit_AOA", true));
            this.hud1.datetime = new System.DateTime(((long)(0)));
            this.hud1.displayAOASSA = false;
            this.hud1.disttowp = 0F;
            this.hud1.distunit = null;
            this.hud1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hud1.ekfstatus = 0F;
            this.hud1.failsafe = false;
            this.hud1.gpsfix = 0F;
            this.hud1.gpsfix2 = 0F;
            this.hud1.gpshdop = 0F;
            this.hud1.gpshdop2 = 0F;
            this.hud1.groundalt = 0F;
            this.hud1.groundcourse = 0F;
            this.hud1.groundspeed = 0F;
            this.hud1.heading = 0F;
            this.hud1.hudcolor = Color.LightGray;
            this.hud1.linkqualitygcs = 0F;
            this.hud1.Location = new Point(0, 0);
            this.hud1.lowairspeed = false;
            this.hud1.lowgroundspeed = false;
            this.hud1.lowvoltagealert = false;
            this.hud1.message = "";
            this.hud1.messagetime = new System.DateTime(((long)(0)));
            this.hud1.mode = "Unknown";
            this.hud1.Name = "hud1";
            this.hud1.navpitch = 0F;
            this.hud1.navroll = 0F;
            this.hud1.pitch = 0F;
            this.hud1.roll = 0F;
            this.hud1.Russian = false;
            this.hud1.Size = new Size(358, 264);
            this.hud1.skyColor1 = Color.Blue;
            this.hud1.skyColor2 = Color.LightBlue;
            this.hud1.speedunit = null;
            this.hud1.SSA = 0F;
            this.hud1.status = false;
            this.hud1.streamjpg = null;
            this.hud1.TabIndex = 1;
            this.hud1.targetalt = 0F;
            this.hud1.targetheading = 0F;
            this.hud1.targetspeed = 0F;
            this.hud1.turnrate = 0F;
            this.hud1.verticalspeed = 0F;
            this.hud1.vibex = 0F;
            this.hud1.vibey = 0F;
            this.hud1.vibez = 0F;
         
            this.hud1.wpno = 0;
            this.hud1.xtrack_error = 0F;
            this.hud1.ekfclick += new System.EventHandler(this.hud1_ekfclick);
            this.hud1.vibeclick += new System.EventHandler(this.hud1_vibeclick);
            this.hud1.DoubleClick += new System.EventHandler(this.hud1_DoubleClick);
            this.hud1.Resize += new System.EventHandler(this.hud1_Resize);
            // 
            // contextMenuStripHud
            // 
            this.contextMenuStripHud.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.videoToolStripMenuItem,
            this.setAspectRatioToolStripMenuItem,
            this.userItemsToolStripMenuItem,
            this.russianHudToolStripMenuItem,
            this.swapWithMapToolStripMenuItem,
            this.groundColorToolStripMenuItem});
            this.contextMenuStripHud.Name = "contextMenuStrip2";
            this.contextMenuStripHud.Size = new Size(160, 136);
            // 
            // videoToolStripMenuItem
            // 
            this.videoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recordHudToAVIToolStripMenuItem,
            this.stopRecordToolStripMenuItem,
            this.setMJPEGSourceToolStripMenuItem,
            this.startCameraToolStripMenuItem,
            this.setGStreamerSourceToolStripMenuItem});
            this.videoToolStripMenuItem.Name = "videoToolStripMenuItem";
            this.videoToolStripMenuItem.Size = new Size(159, 22);
            this.videoToolStripMenuItem.Text = "Video";
            // 
            // recordHudToAVIToolStripMenuItem
            // 
            this.recordHudToAVIToolStripMenuItem.Name = "recordHudToAVIToolStripMenuItem";
            this.recordHudToAVIToolStripMenuItem.Size = new Size(187, 22);
            this.recordHudToAVIToolStripMenuItem.Text = "Record Hud to AVI";
            this.recordHudToAVIToolStripMenuItem.Click += new System.EventHandler(this.recordHudToAVIToolStripMenuItem_Click);
            // 
            // stopRecordToolStripMenuItem
            // 
            this.stopRecordToolStripMenuItem.Name = "stopRecordToolStripMenuItem";
            this.stopRecordToolStripMenuItem.Size = new Size(187, 22);
            this.stopRecordToolStripMenuItem.Text = "Stop Record";
            this.stopRecordToolStripMenuItem.Click += new System.EventHandler(this.stopRecordToolStripMenuItem_Click);
            // 
            // setMJPEGSourceToolStripMenuItem
            // 
            this.setMJPEGSourceToolStripMenuItem.Name = "setMJPEGSourceToolStripMenuItem";
            this.setMJPEGSourceToolStripMenuItem.Size = new Size(187, 22);
            this.setMJPEGSourceToolStripMenuItem.Text = "Set MJPEG source";
            this.setMJPEGSourceToolStripMenuItem.Click += new System.EventHandler(this.setMJPEGSourceToolStripMenuItem_Click);
            // 
            // startCameraToolStripMenuItem
            // 
            this.startCameraToolStripMenuItem.Name = "startCameraToolStripMenuItem";
            this.startCameraToolStripMenuItem.Size = new Size(187, 22);
            this.startCameraToolStripMenuItem.Text = "Start Camera";
            this.startCameraToolStripMenuItem.Click += new System.EventHandler(this.startCameraToolStripMenuItem_Click);
            // 
            // setGStreamerSourceToolStripMenuItem
            // 
            this.setGStreamerSourceToolStripMenuItem.Name = "setGStreamerSourceToolStripMenuItem";
            this.setGStreamerSourceToolStripMenuItem.Size = new Size(187, 22);
            this.setGStreamerSourceToolStripMenuItem.Text = "Set GStreamer Source";
            this.setGStreamerSourceToolStripMenuItem.Click += new System.EventHandler(this.setGStreamerSourceToolStripMenuItem_Click);
            // 
            // setAspectRatioToolStripMenuItem
            // 
            this.setAspectRatioToolStripMenuItem.Name = "setAspectRatioToolStripMenuItem";
            this.setAspectRatioToolStripMenuItem.Size = new Size(159, 22);
            this.setAspectRatioToolStripMenuItem.Text = "Set Aspect Ratio";
            this.setAspectRatioToolStripMenuItem.Click += new System.EventHandler(this.setAspectRatioToolStripMenuItem_Click);
            // 
            // userItemsToolStripMenuItem
            // 
            this.userItemsToolStripMenuItem.Name = "userItemsToolStripMenuItem";
            this.userItemsToolStripMenuItem.Size = new Size(159, 22);
            this.userItemsToolStripMenuItem.Text = "User Items";
            this.userItemsToolStripMenuItem.Click += new System.EventHandler(this.hud_UserItem);
            // 
            // russianHudToolStripMenuItem
            // 
            this.russianHudToolStripMenuItem.Name = "russianHudToolStripMenuItem";
            this.russianHudToolStripMenuItem.Size = new Size(159, 22);
            this.russianHudToolStripMenuItem.Text = "Russian Hud";
            this.russianHudToolStripMenuItem.Click += new System.EventHandler(this.russianHudToolStripMenuItem_Click);
            // 
            // swapWithMapToolStripMenuItem
            // 
            this.swapWithMapToolStripMenuItem.Name = "swapWithMapToolStripMenuItem";
            this.swapWithMapToolStripMenuItem.Size = new Size(159, 22);
            this.swapWithMapToolStripMenuItem.Text = "Swap With Map";
            this.swapWithMapToolStripMenuItem.Click += new System.EventHandler(this.swapWithMapToolStripMenuItem_Click);
            // 
            // groundColorToolStripMenuItem
            // 
            this.groundColorToolStripMenuItem.CheckOnClick = true;
            this.groundColorToolStripMenuItem.Name = "groundColorToolStripMenuItem";
            this.groundColorToolStripMenuItem.Size = new Size(159, 22);
            this.groundColorToolStripMenuItem.Text = "Ground Color";
            this.groundColorToolStripMenuItem.Click += new System.EventHandler(this.groundColorToolStripMenuItem_Click);
            // 
            // bindingSourceHud
            // 
            this.bindingSourceHud.DataSource = typeof(MissionPlanner.CurrentState);
            // 
            // tabControlactions
            // 
            this.tabControlactions.ContextMenuStrip = this.contextMenuStripactionstab;
            this.tabControlactions.Controls.Add(this.tabQuick);
            this.tabControlactions.Controls.Add(this.tabActions);
            this.tabControlactions.Controls.Add(this.tabActionsSimple);
            this.tabControlactions.Controls.Add(this.tabPagePreFlight);
            this.tabControlactions.Controls.Add(this.tabGauges);
            this.tabControlactions.Controls.Add(this.tabStatus);
            this.tabControlactions.Controls.Add(this.tabServo);
            this.tabControlactions.Controls.Add(this.tabTLogs);
            this.tabControlactions.Controls.Add(this.tablogbrowse);
            this.tabControlactions.Controls.Add(this.tabScripts);
            this.tabControlactions.Controls.Add(this.tabPagemessages);
            this.tabControlactions.Controls.Add(this.tabPayload);
            this.tabControlactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlactions.ItemSize = new Size(55, 18);
            this.tabControlactions.Location = new Point(0, 0);
            this.tabControlactions.Margin = new System.Windows.Forms.Padding(0);
            this.tabControlactions.Multiline = true;
            this.tabControlactions.Name = "tabControlactions";
            this.tabControlactions.Padding = new Point(0, 0);
            this.tabControlactions.SelectedIndex = 0;
            this.tabControlactions.Size = new Size(358, 190);
            this.tabControlactions.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControlactions.TabIndex = 84;
            this.tabControlactions.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl1_DrawItem);
            this.tabControlactions.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // contextMenuStripactionstab
            // 
            this.contextMenuStripactionstab.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customizeToolStripMenuItem});
            this.contextMenuStripactionstab.Name = "contextMenuStripactionstab";
            this.contextMenuStripactionstab.Size = new Size(131, 26);
            // 
            // customizeToolStripMenuItem
            // 
            this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            this.customizeToolStripMenuItem.Size = new Size(130, 22);
            this.customizeToolStripMenuItem.Text = "Customize";
            this.customizeToolStripMenuItem.Click += new System.EventHandler(this.customizeToolStripMenuItem_Click);
            // 
            // tabQuick
            // 
            this.tabQuick.AutoScroll = true;
            this.tabQuick.Controls.Add(this.tableLayoutPanelQuick);
            this.tabQuick.Location = new Point(4, 58);
            this.tabQuick.Name = "tabQuick";
            this.tabQuick.Padding = new System.Windows.Forms.Padding(3);
            this.tabQuick.Size = new Size(350, 128);
            this.tabQuick.TabIndex = 4;
            this.tabQuick.Text = "Quick";
            this.tabQuick.UseVisualStyleBackColor = true;
            this.tabQuick.Resize += new System.EventHandler(this.tabQuick_Resize);
            // 
            // tableLayoutPanelQuick
            // 
            this.tableLayoutPanelQuick.AutoScroll = true;
            this.tableLayoutPanelQuick.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanelQuick.ColumnCount = 2;
            this.tableLayoutPanelQuick.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelQuick.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelQuick.Controls.Add(this.quickView6, 1, 2);
            this.tableLayoutPanelQuick.Controls.Add(this.quickView5, 0, 2);
            this.tableLayoutPanelQuick.Controls.Add(this.quickView4, 1, 1);
            this.tableLayoutPanelQuick.Controls.Add(this.quickView3, 0, 1);
            this.tableLayoutPanelQuick.Controls.Add(this.quickView2, 1, 0);
            this.tableLayoutPanelQuick.Controls.Add(this.quickView1, 0, 0);
            this.tableLayoutPanelQuick.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelQuick.Location = new Point(3, 3);
            this.tableLayoutPanelQuick.Name = "tableLayoutPanelQuick";
            this.tableLayoutPanelQuick.RowCount = 3;
            this.tableLayoutPanelQuick.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelQuick.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelQuick.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelQuick.Size = new Size(344, 122);
            this.tableLayoutPanelQuick.TabIndex = 73;
            // 
            // quickView6
            // 
            this.quickView6.ContextMenuStrip = this.contextMenuStripQuickView;
            this.quickView6.DataBindings.Add(new System.Windows.Forms.Binding("number", this.bindingSourceQuickTab, "DistToHome", true));
            this.quickView6.desc = "DistToMAV";
            this.quickView6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quickView6.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.quickView6.Location = new Point(175, 83);
            this.quickView6.MinimumSize = new Size(100, 27);
            this.quickView6.Name = "quickView6";
            this.quickView6.number = 0D;
            this.quickView6.numberColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.quickView6.numberformat = "0.00";
            this.quickView6.Size = new Size(166, 36);
            this.quickView6.TabIndex = 10;
            this.quickView6.DoubleClick += new System.EventHandler(this.quickView_DoubleClick);
            // 
            // contextMenuStripQuickView
            // 
            this.contextMenuStripQuickView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setViewCountToolStripMenuItem});
            this.contextMenuStripQuickView.Name = "contextMenuStripQuickView";
            this.contextMenuStripQuickView.Size = new Size(155, 26);
            // 
            // setViewCountToolStripMenuItem
            // 
            this.setViewCountToolStripMenuItem.Name = "setViewCountToolStripMenuItem";
            this.setViewCountToolStripMenuItem.Size = new Size(154, 22);
            this.setViewCountToolStripMenuItem.Text = "Set View Count";
            this.setViewCountToolStripMenuItem.Click += new System.EventHandler(this.setViewCountToolStripMenuItem_Click);
            // 
            // bindingSourceQuickTab
            // 
            this.bindingSourceQuickTab.DataSource = typeof(MissionPlanner.CurrentState);
            // 
            // quickView5
            // 
            this.quickView5.ContextMenuStrip = this.contextMenuStripQuickView;
            this.quickView5.DataBindings.Add(new System.Windows.Forms.Binding("number", this.bindingSourceQuickTab, "verticalspeed", true));
            this.quickView5.desc = "verticalspeed";
            this.quickView5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quickView5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.quickView5.Location = new Point(3, 83);
            this.quickView5.MinimumSize = new Size(100, 27);
            this.quickView5.Name = "quickView5";
            this.quickView5.number = 0D;
            this.quickView5.numberColor = Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(86)))));
            this.quickView5.numberformat = "0.00";
            this.quickView5.Size = new Size(166, 36);
            this.quickView5.TabIndex = 9;
            this.quickView5.DoubleClick += new System.EventHandler(this.quickView_DoubleClick);
            // 
            // quickView4
            // 
            this.quickView4.ContextMenuStrip = this.contextMenuStripQuickView;
            this.quickView4.DataBindings.Add(new System.Windows.Forms.Binding("number", this.bindingSourceQuickTab, "yaw", true));
            this.quickView4.desc = "yaw";
            this.quickView4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quickView4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.quickView4.Location = new Point(175, 43);
            this.quickView4.MinimumSize = new Size(100, 27);
            this.quickView4.Name = "quickView4";
            this.quickView4.number = 0D;
            this.quickView4.numberColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(83)))));
            this.quickView4.numberformat = "0.00";
            this.quickView4.Size = new Size(166, 34);
            this.quickView4.TabIndex = 8;
            this.quickView4.DoubleClick += new System.EventHandler(this.quickView_DoubleClick);
            // 
            // quickView3
            // 
            this.quickView3.ContextMenuStrip = this.contextMenuStripQuickView;
            this.quickView3.DataBindings.Add(new System.Windows.Forms.Binding("number", this.bindingSourceQuickTab, "wp_dist", true));
            this.quickView3.desc = "wp_dist";
            this.quickView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quickView3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.quickView3.Location = new Point(3, 43);
            this.quickView3.MinimumSize = new Size(100, 27);
            this.quickView3.Name = "quickView3";
            this.quickView3.number = 0D;
            this.quickView3.numberColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(91)))));
            this.quickView3.numberformat = "0.00";
            this.quickView3.Size = new Size(166, 34);
            this.quickView3.TabIndex = 3;
            this.quickView3.DoubleClick += new System.EventHandler(this.quickView_DoubleClick);
            // 
            // quickView2
            // 
            this.quickView2.ContextMenuStrip = this.contextMenuStripQuickView;
            this.quickView2.DataBindings.Add(new System.Windows.Forms.Binding("number", this.bindingSourceQuickTab, "groundspeed", true));
            this.quickView2.desc = "groundspeed";
            this.quickView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quickView2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.quickView2.Location = new Point(175, 3);
            this.quickView2.MinimumSize = new Size(100, 27);
            this.quickView2.Name = "quickView2";
            this.quickView2.number = 0D;
            this.quickView2.numberColor = Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(132)))), ((int)(((byte)(46)))));
            this.quickView2.numberformat = "0.00";
            this.quickView2.Size = new Size(166, 34);
            this.quickView2.TabIndex = 1;
            this.quickView2.DoubleClick += new System.EventHandler(this.quickView_DoubleClick);
            // 
            // quickView1
            // 
            this.quickView1.ContextMenuStrip = this.contextMenuStripQuickView;
            this.quickView1.DataBindings.Add(new System.Windows.Forms.Binding("number", this.bindingSourceQuickTab, "alt", true));
            this.quickView1.desc = "alt";
            this.quickView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quickView1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.quickView1.Location = new Point(3, 3);
            this.quickView1.MinimumSize = new Size(100, 27);
            this.quickView1.Name = "quickView1";
            this.quickView1.number = 0D;
            this.quickView1.numberColor = Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(151)))), ((int)(((byte)(248)))));
            this.quickView1.numberformat = "0.00";
            this.quickView1.Size = new Size(166, 34);
            this.quickView1.TabIndex = 1;
            this.toolTip1.SetToolTip(this.quickView1, "Double Click me to change");
            this.quickView1.DoubleClick += new System.EventHandler(this.quickView_DoubleClick);
            // 
            // tabActions
            // 
            this.tabActions.Controls.Add(this.modifyandSetLoiterRad);
            this.tabActions.Controls.Add(this.BUT_abortland);
            this.tabActions.Controls.Add(this.BUT_resumemis);
            this.tabActions.Controls.Add(this.CMB_mountmode);
            this.tabActions.Controls.Add(this.BUT_mountmode);
            this.tabActions.Controls.Add(this.BUT_ARM);
            this.tabActions.Controls.Add(this.BUT_joystick);
            this.tabActions.Controls.Add(this.BUT_quickmanual);
            this.tabActions.Controls.Add(this.BUT_quickrtl);
            this.tabActions.Controls.Add(this.BUT_quickauto);
            this.tabActions.Controls.Add(this.CMB_setwp);
            this.tabActions.Controls.Add(this.BUT_setwp);
            this.tabActions.Controls.Add(this.CMB_modes);
            this.tabActions.Controls.Add(this.BUT_setmode);
            this.tabActions.Controls.Add(this.BUT_clear_track);
            this.tabActions.Controls.Add(this.CMB_action);
            this.tabActions.Controls.Add(this.BUT_Homealt);
            this.tabActions.Controls.Add(this.BUT_RAWSensor);
            this.tabActions.Controls.Add(this.BUTrestartmission);
            this.tabActions.Controls.Add(this.BUTactiondo);
            this.tabActions.Controls.Add(this.modifyandSetSpeed);
            this.tabActions.Controls.Add(this.modifyandSetAlt);
            this.tabActions.Location = new Point(4, 58);
            this.tabActions.Name = "tabActions";
            this.tabActions.Size = new Size(350, 128);
            this.tabActions.TabIndex = 2;
            this.tabActions.Text = "Actions";
            this.tabActions.UseVisualStyleBackColor = true;
            // 
            // modifyandSetLoiterRad
            // 
            this.modifyandSetLoiterRad.ButtonText = "Set Loiter Rad";
            this.modifyandSetLoiterRad.Location = new Point(276, 64);
            this.modifyandSetLoiterRad.Margin = new System.Windows.Forms.Padding(0);
            this.modifyandSetLoiterRad.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.modifyandSetLoiterRad.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.modifyandSetLoiterRad.Name = "modifyandSetLoiterRad";
            this.modifyandSetLoiterRad.Size = new Size(130, 29);
            this.modifyandSetLoiterRad.TabIndex = 87;
            this.modifyandSetLoiterRad.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.modifyandSetLoiterRad.Click += new System.EventHandler(this.modifyandSetLoiterRad_Click);
            // 
            // BUT_abortland
            // 
            this.BUT_abortland.ColorMouseDown = Color.Empty;
            this.BUT_abortland.ColorMouseOver = Color.Empty;
            this.BUT_abortland.ColorNotEnabled = Color.Empty;
            this.BUT_abortland.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BUT_abortland.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BUT_abortland.Location = new Point(275, 122);
            this.BUT_abortland.Name = "BUT_abortland";
            this.BUT_abortland.Size = new Size(69, 23);
            this.BUT_abortland.TabIndex = 86;
            this.BUT_abortland.Text = "Abort Landing";
            this.toolTip1.SetToolTip(this.BUT_abortland, "Plane only");
            this.BUT_abortland.UseVisualStyleBackColor = true;
            this.BUT_abortland.Click += new System.EventHandler(this.BUT_abortland_Click);
            // 
            // BUT_resumemis
            // 
            this.BUT_resumemis.ColorMouseDown = Color.Empty;
            this.BUT_resumemis.ColorMouseOver = Color.Empty;
            this.BUT_resumemis.ColorNotEnabled = Color.Empty;
            this.BUT_resumemis.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BUT_resumemis.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BUT_resumemis.Location = new Point(200, 122);
            this.BUT_resumemis.Name = "BUT_resumemis";
            this.BUT_resumemis.Size = new Size(69, 23);
            this.BUT_resumemis.TabIndex = 85;
            this.BUT_resumemis.Text = "Resume Mission";
            this.BUT_resumemis.UseVisualStyleBackColor = true;
            this.BUT_resumemis.Click += new System.EventHandler(this.BUT_resumemis_Click);
            // 
            // CMB_mountmode
            // 
            this.CMB_mountmode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_mountmode.FormattingEnabled = true;
            this.CMB_mountmode.Location = new Point(4, 93);
            this.CMB_mountmode.Name = "CMB_mountmode";
            this.CMB_mountmode.Size = new Size(76, 21);
            this.CMB_mountmode.TabIndex = 82;
            // 
            // BUT_mountmode
            // 
            this.BUT_mountmode.ColorMouseDown = Color.Empty;
            this.BUT_mountmode.ColorMouseOver = Color.Empty;
            this.BUT_mountmode.ColorNotEnabled = Color.Empty;
            this.BUT_mountmode.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BUT_mountmode.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BUT_mountmode.Location = new Point(86, 93);
            this.BUT_mountmode.Name = "BUT_mountmode";
            this.BUT_mountmode.Size = new Size(55, 23);
            this.BUT_mountmode.TabIndex = 83;
            this.BUT_mountmode.Text = "Set Mount";
            this.toolTip1.SetToolTip(this.BUT_mountmode, "Changes to the Mode on the left");
            this.BUT_mountmode.UseVisualStyleBackColor = true;
            this.BUT_mountmode.Click += new System.EventHandler(this.BUT_mountmode_Click);
            // 
            // BUT_ARM
            // 
            this.BUT_ARM.ColorMouseDown = Color.Empty;
            this.BUT_ARM.ColorMouseOver = Color.Empty;
            this.BUT_ARM.ColorNotEnabled = Color.Empty;
            this.BUT_ARM.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BUT_ARM.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BUT_ARM.Location = new Point(200, 93);
            this.BUT_ARM.Name = "BUT_ARM";
            this.BUT_ARM.Size = new Size(69, 23);
            this.BUT_ARM.TabIndex = 79;
            this.BUT_ARM.Text = "Arm/ Disarm";
            this.toolTip1.SetToolTip(this.BUT_ARM, "Arm the Mav");
            this.BUT_ARM.UseVisualStyleBackColor = true;
            this.BUT_ARM.Click += new System.EventHandler(this.BUT_ARM_Click);
            // 
            // BUT_joystick
            // 
            this.BUT_joystick.ColorMouseDown = Color.Empty;
            this.BUT_joystick.ColorMouseOver = Color.Empty;
            this.BUT_joystick.ColorNotEnabled = Color.Empty;
            this.BUT_joystick.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BUT_joystick.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BUT_joystick.Location = new Point(147, 93);
            this.BUT_joystick.Name = "BUT_joystick";
            this.BUT_joystick.Size = new Size(49, 23);
            this.BUT_joystick.TabIndex = 77;
            this.BUT_joystick.Text = "Joystick";
            this.toolTip1.SetToolTip(this.BUT_joystick, "Setup and enable your joystick");
            this.BUT_joystick.UseVisualStyleBackColor = true;
            this.BUT_joystick.Click += new System.EventHandler(this.BUT_joystick_Click);
            // 
            // BUT_quickmanual
            // 
            this.BUT_quickmanual.ColorMouseDown = Color.Empty;
            this.BUT_quickmanual.ColorMouseOver = Color.Empty;
            this.BUT_quickmanual.ColorNotEnabled = Color.Empty;
            this.BUT_quickmanual.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BUT_quickmanual.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BUT_quickmanual.Location = new Point(147, 35);
            this.BUT_quickmanual.Name = "BUT_quickmanual";
            this.BUT_quickmanual.Size = new Size(47, 23);
            this.BUT_quickmanual.TabIndex = 76;
            this.BUT_quickmanual.Text = "Loiter";
            this.toolTip1.SetToolTip(this.BUT_quickmanual, "Change Mode to Manual/Stabalize");
            this.BUT_quickmanual.UseVisualStyleBackColor = true;
            this.BUT_quickmanual.Click += new System.EventHandler(this.BUT_quickmanual_Click);
            // 
            // BUT_quickrtl
            // 
            this.BUT_quickrtl.ColorMouseDown = Color.Empty;
            this.BUT_quickrtl.ColorMouseOver = Color.Empty;
            this.BUT_quickrtl.ColorNotEnabled = Color.Empty;
            this.BUT_quickrtl.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BUT_quickrtl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BUT_quickrtl.Location = new Point(147, 64);
            this.BUT_quickrtl.Name = "BUT_quickrtl";
            this.BUT_quickrtl.Size = new Size(47, 23);
            this.BUT_quickrtl.TabIndex = 75;
            this.BUT_quickrtl.Text = "RTL";
            this.toolTip1.SetToolTip(this.BUT_quickrtl, "Change Mode to RTL");
            this.BUT_quickrtl.UseVisualStyleBackColor = true;
            this.BUT_quickrtl.Click += new System.EventHandler(this.BUT_quickrtl_Click);
            // 
            // BUT_quickauto
            // 
            this.BUT_quickauto.ColorMouseDown = Color.Empty;
            this.BUT_quickauto.ColorMouseOver = Color.Empty;
            this.BUT_quickauto.ColorNotEnabled = Color.Empty;
            this.BUT_quickauto.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BUT_quickauto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BUT_quickauto.Location = new Point(147, 7);
            this.BUT_quickauto.Name = "BUT_quickauto";
            this.BUT_quickauto.Size = new Size(47, 23);
            this.BUT_quickauto.TabIndex = 74;
            this.BUT_quickauto.Text = "Auto";
            this.toolTip1.SetToolTip(this.BUT_quickauto, "Change mode to Auto");
            this.BUT_quickauto.UseVisualStyleBackColor = true;
            this.BUT_quickauto.Click += new System.EventHandler(this.BUT_quickauto_Click);
            // 
            // CMB_setwp
            // 
            this.CMB_setwp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_setwp.FormattingEnabled = true;
            this.CMB_setwp.Items.AddRange(new object[] {
            "0 (Home)"});
            this.CMB_setwp.Location = new Point(4, 35);
            this.CMB_setwp.Name = "CMB_setwp";
            this.CMB_setwp.Size = new Size(76, 21);
            this.CMB_setwp.TabIndex = 72;
            this.CMB_setwp.Click += new System.EventHandler(this.CMB_setwp_Click);
            // 
            // BUT_setwp
            // 
            this.BUT_setwp.ColorMouseDown = Color.Empty;
            this.BUT_setwp.ColorMouseOver = Color.Empty;
            this.BUT_setwp.ColorNotEnabled = Color.Empty;
            this.BUT_setwp.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BUT_setwp.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BUT_setwp.Location = new Point(86, 35);
            this.BUT_setwp.Name = "BUT_setwp";
            this.BUT_setwp.Size = new Size(55, 23);
            this.BUT_setwp.TabIndex = 73;
            this.BUT_setwp.Text = "Set WP";
            this.toolTip1.SetToolTip(this.BUT_setwp, "Changes the current target waypoint");
            this.BUT_setwp.UseVisualStyleBackColor = true;
            this.BUT_setwp.Click += new System.EventHandler(this.BUT_setwp_Click);
            // 
            // CMB_modes
            // 
            this.CMB_modes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_modes.FormattingEnabled = true;
            this.CMB_modes.Location = new Point(4, 64);
            this.CMB_modes.Name = "CMB_modes";
            this.CMB_modes.Size = new Size(76, 21);
            this.CMB_modes.TabIndex = 70;
            this.CMB_modes.Click += new System.EventHandler(this.CMB_modes_Click);
            // 
            // BUT_setmode
            // 
            this.BUT_setmode.ColorMouseDown = Color.Empty;
            this.BUT_setmode.ColorMouseOver = Color.Empty;
            this.BUT_setmode.ColorNotEnabled = Color.Empty;
            this.BUT_setmode.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BUT_setmode.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BUT_setmode.Location = new Point(86, 64);
            this.BUT_setmode.Name = "BUT_setmode";
            this.BUT_setmode.Size = new Size(55, 23);
            this.BUT_setmode.TabIndex = 71;
            this.BUT_setmode.Text = "Set Mode";
            this.toolTip1.SetToolTip(this.BUT_setmode, "Changes to the Mode on the left");
            this.BUT_setmode.UseVisualStyleBackColor = true;
            this.BUT_setmode.Click += new System.EventHandler(this.BUT_setmode_Click);
            // 
            // BUT_clear_track
            // 
            this.BUT_clear_track.ColorMouseDown = Color.Empty;
            this.BUT_clear_track.ColorMouseOver = Color.Empty;
            this.BUT_clear_track.ColorNotEnabled = Color.Empty;
            this.BUT_clear_track.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BUT_clear_track.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BUT_clear_track.Location = new Point(275, 93);
            this.BUT_clear_track.Name = "BUT_clear_track";
            this.BUT_clear_track.Size = new Size(72, 23);
            this.BUT_clear_track.TabIndex = 52;
            this.BUT_clear_track.Text = "Clear Track";
            this.toolTip1.SetToolTip(this.BUT_clear_track, "Clear the recorded path on the map");
            this.BUT_clear_track.UseVisualStyleBackColor = true;
            this.BUT_clear_track.Click += new System.EventHandler(this.BUT_clear_track_Click);
            // 
            // CMB_action
            // 
            this.CMB_action.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_action.DropDownWidth = 150;
            this.CMB_action.FormattingEnabled = true;
            this.CMB_action.Location = new Point(4, 7);
            this.CMB_action.Name = "CMB_action";
            this.CMB_action.Size = new Size(76, 21);
            this.CMB_action.TabIndex = 59;
            // 
            // BUT_Homealt
            // 
            this.BUT_Homealt.ColorMouseDown = Color.Empty;
            this.BUT_Homealt.ColorMouseOver = Color.Empty;
            this.BUT_Homealt.ColorNotEnabled = Color.Empty;
            this.BUT_Homealt.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BUT_Homealt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BUT_Homealt.Location = new Point(200, 7);
            this.BUT_Homealt.Name = "BUT_Homealt";
            this.BUT_Homealt.Size = new Size(69, 23);
            this.BUT_Homealt.TabIndex = 69;
            this.BUT_Homealt.Text = "Set Home Alt";
            this.toolTip1.SetToolTip(this.BUT_Homealt, "Set the current display alt as 0, ie home alt is shown as 0");
            this.BUT_Homealt.UseVisualStyleBackColor = true;
            this.BUT_Homealt.Click += new System.EventHandler(this.BUT_Homealt_Click);
            // 
            // BUT_RAWSensor
            // 
            this.BUT_RAWSensor.ColorMouseDown = Color.Empty;
            this.BUT_RAWSensor.ColorMouseOver = Color.Empty;
            this.BUT_RAWSensor.ColorNotEnabled = Color.Empty;
            this.BUT_RAWSensor.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BUT_RAWSensor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BUT_RAWSensor.Location = new Point(200, 64);
            this.BUT_RAWSensor.Name = "BUT_RAWSensor";
            this.BUT_RAWSensor.Size = new Size(69, 23);
            this.BUT_RAWSensor.TabIndex = 68;
            this.BUT_RAWSensor.Text = "Raw Sensor View";
            this.toolTip1.SetToolTip(this.BUT_RAWSensor, "View raw Gyro and Accel values, and Raw Radio ins/outs");
            this.BUT_RAWSensor.UseVisualStyleBackColor = true;
            this.BUT_RAWSensor.Click += new System.EventHandler(this.BUT_RAWSensor_Click);
            // 
            // BUTrestartmission
            // 
            this.BUTrestartmission.ColorMouseDown = Color.Empty;
            this.BUTrestartmission.ColorMouseOver = Color.Empty;
            this.BUTrestartmission.ColorNotEnabled = Color.Empty;
            this.BUTrestartmission.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BUTrestartmission.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BUTrestartmission.Location = new Point(200, 35);
            this.BUTrestartmission.Name = "BUTrestartmission";
            this.BUTrestartmission.Size = new Size(69, 23);
            this.BUTrestartmission.TabIndex = 63;
            this.BUTrestartmission.Text = "Restart Mission";
            this.toolTip1.SetToolTip(this.BUTrestartmission, "Restarts the mission from the beginning");
            this.BUTrestartmission.UseVisualStyleBackColor = true;
            this.BUTrestartmission.Click += new System.EventHandler(this.BUTrestartmission_Click);
            // 
            // BUTactiondo
            // 
            this.BUTactiondo.ColorMouseDown = Color.Empty;
            this.BUTactiondo.ColorMouseOver = Color.Empty;
            this.BUTactiondo.ColorNotEnabled = Color.Empty;
            this.BUTactiondo.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BUTactiondo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BUTactiondo.Location = new Point(86, 7);
            this.BUTactiondo.Name = "BUTactiondo";
            this.BUTactiondo.Size = new Size(55, 23);
            this.BUTactiondo.TabIndex = 60;
            this.BUTactiondo.Text = "Do Action";
            this.toolTip1.SetToolTip(this.BUTactiondo, "Preform the action ot the left");
            this.BUTactiondo.UseVisualStyleBackColor = true;
            this.BUTactiondo.Click += new System.EventHandler(this.BUTactiondo_Click);
            // 
            // modifyandSetSpeed
            // 
            this.modifyandSetSpeed.ButtonText = "Change Speed";
            this.modifyandSetSpeed.Location = new Point(275, 7);
            this.modifyandSetSpeed.Margin = new System.Windows.Forms.Padding(0);
            this.modifyandSetSpeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.modifyandSetSpeed.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.modifyandSetSpeed.Name = "modifyandSetSpeed";
            this.modifyandSetSpeed.Size = new Size(130, 29);
            this.modifyandSetSpeed.TabIndex = 81;
            this.modifyandSetSpeed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.modifyandSetSpeed.Click += new System.EventHandler(this.modifyandSetSpeed_Click);
            this.modifyandSetSpeed.ParentChanged += new System.EventHandler(this.modifyandSetSpeed_ParentChanged);
            // 
            // modifyandSetAlt
            // 
            this.modifyandSetAlt.ButtonText = "Change Alt";
            this.modifyandSetAlt.Location = new Point(275, 35);
            this.modifyandSetAlt.Margin = new System.Windows.Forms.Padding(0);
            this.modifyandSetAlt.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.modifyandSetAlt.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.modifyandSetAlt.Name = "modifyandSetAlt";
            this.modifyandSetAlt.Size = new Size(130, 29);
            this.modifyandSetAlt.TabIndex = 80;
            this.modifyandSetAlt.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.modifyandSetAlt.Click += new System.EventHandler(this.modifyandSetAlt_Click);
            // 
            // tabActionsSimple
            // 
            this.tabActionsSimple.Controls.Add(this.myButton1);
            this.tabActionsSimple.Controls.Add(this.myButton2);
            this.tabActionsSimple.Controls.Add(this.myButton3);
            this.tabActionsSimple.Location = new Point(4, 58);
            this.tabActionsSimple.Name = "tabActionsSimple";
            this.tabActionsSimple.Size = new Size(350, 128);
            this.tabActionsSimple.TabIndex = 9;
            this.tabActionsSimple.Text = "Actions";
            this.tabActionsSimple.UseVisualStyleBackColor = true;
            // 
            // myButton1
            // 
            this.myButton1.ColorMouseDown = Color.Empty;
            this.myButton1.ColorMouseOver = Color.Empty;
            this.myButton1.ColorNotEnabled = Color.Empty;
            this.myButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.myButton1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.myButton1.Location = new Point(150, 49);
            this.myButton1.Name = "myButton1";
            this.myButton1.Size = new Size(47, 23);
            this.myButton1.TabIndex = 79;
            this.myButton1.Text = "Loiter";
            this.toolTip1.SetToolTip(this.myButton1, "Change Mode to Manual/Stabalize");
            this.myButton1.UseVisualStyleBackColor = true;
            this.myButton1.Click += new System.EventHandler(this.BUT_quickmanual_Click);
            // 
            // myButton2
            // 
            this.myButton2.ColorMouseDown = Color.Empty;
            this.myButton2.ColorMouseOver = Color.Empty;
            this.myButton2.ColorNotEnabled = Color.Empty;
            this.myButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.myButton2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.myButton2.Location = new Point(150, 78);
            this.myButton2.Name = "myButton2";
            this.myButton2.Size = new Size(47, 23);
            this.myButton2.TabIndex = 78;
            this.myButton2.Text = "RTL";
            this.toolTip1.SetToolTip(this.myButton2, "Change Mode to RTL");
            this.myButton2.UseVisualStyleBackColor = true;
            this.myButton2.Click += new System.EventHandler(this.BUT_quickrtl_Click);
            // 
            // myButton3
            // 
            this.myButton3.ColorMouseDown = Color.Empty;
            this.myButton3.ColorMouseOver = Color.Empty;
            this.myButton3.ColorNotEnabled = Color.Empty;
            this.myButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.myButton3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.myButton3.Location = new Point(150, 20);
            this.myButton3.Name = "myButton3";
            this.myButton3.Size = new Size(47, 23);
            this.myButton3.TabIndex = 77;
            this.myButton3.Text = "Auto";
            this.toolTip1.SetToolTip(this.myButton3, "Change mode to Auto");
            this.myButton3.UseVisualStyleBackColor = true;
            this.myButton3.Click += new System.EventHandler(this.BUT_quickauto_Click);
            // 
            // tabPagePreFlight
            // 
            this.tabPagePreFlight.Controls.Add(this.checkListControl1);
            this.tabPagePreFlight.Location = new Point(4, 58);
            this.tabPagePreFlight.Name = "tabPagePreFlight";
            this.tabPagePreFlight.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePreFlight.Size = new Size(350, 128);
            this.tabPagePreFlight.TabIndex = 10;
            this.tabPagePreFlight.Text = "PreFlight";
            this.tabPagePreFlight.UseVisualStyleBackColor = true;
            // 
            // checkListControl1
            // 
            this.checkListControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkListControl1.Location = new Point(3, 3);
            this.checkListControl1.Name = "checkListControl1";
            this.checkListControl1.Size = new Size(344, 122);
            this.checkListControl1.TabIndex = 0;
            // 
            // tabGauges
            // 
            this.tabGauges.Controls.Add(this.Gvspeed);
            this.tabGauges.Controls.Add(this.Gheading);
            this.tabGauges.Controls.Add(this.Galt);
            this.tabGauges.Controls.Add(this.Gspeed);
            this.tabGauges.Location = new Point(4, 58);
            this.tabGauges.Name = "tabGauges";
            this.tabGauges.Padding = new System.Windows.Forms.Padding(3);
            this.tabGauges.Size = new Size(350, 128);
            this.tabGauges.TabIndex = 0;
            this.tabGauges.Text = "Gauges";
            this.tabGauges.UseVisualStyleBackColor = true;
            this.tabGauges.Resize += new System.EventHandler(this.tabPage1_Resize);
            // 
            // Gvspeed
            // 
            this.Gvspeed.BackColor = Color.Transparent;
      
            this.Gvspeed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Gvspeed.BaseArcColor = Color.Transparent;
            this.Gvspeed.BaseArcRadius = 60;
            this.Gvspeed.BaseArcStart = 20;
            this.Gvspeed.BaseArcSweep = 320;
            this.Gvspeed.BaseArcWidth = 2;
            this.Gvspeed.Cap_Idx = ((byte)(0));
            this.Gvspeed.CapColor = Color.White;
            this.Gvspeed.CapColors = new Color[] {
        Color.White,
        Color.Black,
        Color.Black,
        Color.Black,
        Color.Black};
            this.Gvspeed.CapPosition = new Point(65, 85);
            this.Gvspeed.CapsPosition = new Point[] {
        new Point(65, 85),
        new Point(30, 55),
        new Point(10, 10),
        new Point(10, 10),
        new Point(10, 10)};
            this.Gvspeed.CapsText = new string[] {
        "VSI",
        "",
        "",
        "",
        ""};
            this.Gvspeed.CapText = "VSI";
            this.Gvspeed.Center = new Point(75, 75);
            this.Gvspeed.DataBindings.Add(new System.Windows.Forms.Binding("Value0", this.bindingSourceGaugesTab, "verticalspeed", true));
            this.Gvspeed.Location = new Point(3, 7);
            this.Gvspeed.Margin = new System.Windows.Forms.Padding(0);
            this.Gvspeed.MaxValue = 10F;
            this.Gvspeed.MinValue = -10F;
            this.Gvspeed.Name = "Gvspeed";
            this.Gvspeed.Need_Idx = ((byte)(3));
            this.Gvspeed.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Gray;
            this.Gvspeed.NeedleColor2 = Color.White;
            this.Gvspeed.NeedleEnabled = false;
            this.Gvspeed.NeedleRadius = 80;
            this.Gvspeed.NeedlesColor1 = new AGaugeApp.AGauge.NeedleColorEnum[] {
        AGaugeApp.AGauge.NeedleColorEnum.Gray,
        AGaugeApp.AGauge.NeedleColorEnum.Gray,
        AGaugeApp.AGauge.NeedleColorEnum.Gray,
        AGaugeApp.AGauge.NeedleColorEnum.Gray};
            this.Gvspeed.NeedlesColor2 = new Color[] {
        Color.White,
        Color.White,
        Color.White,
        Color.White};
            this.Gvspeed.NeedlesEnabled = new bool[] {
        true,
        false,
        false,
        false};
            this.Gvspeed.NeedlesRadius = new int[] {
        50,
        30,
        50,
        80};
            this.Gvspeed.NeedlesType = new int[] {
        0,
        0,
        0,
        0};
            this.Gvspeed.NeedlesWidth = new int[] {
        2,
        2,
        2,
        2};
            this.Gvspeed.NeedleType = 0;
            this.Gvspeed.NeedleWidth = 2;
            this.Gvspeed.Range_Idx = ((byte)(0));
            this.Gvspeed.RangeColor = Color.LightGreen;
            this.Gvspeed.RangeEnabled = false;
            this.Gvspeed.RangeEndValue = 360F;
            this.Gvspeed.RangeInnerRadius = 1;
            this.Gvspeed.RangeOuterRadius = 60;
            this.Gvspeed.RangesColor = new Color[] {
        Color.LightGreen,
        Color.Red,
        Color.Orange,
        SystemColors.Control,
        SystemColors.Control};
            this.Gvspeed.RangesEnabled = new bool[] {
        false,
        false,
        false,
        false,
        false};
            this.Gvspeed.RangesEndValue = new float[] {
        360F,
        200F,
        150F,
        0F,
        0F};
            this.Gvspeed.RangesInnerRadius = new int[] {
        1,
        1,
        1,
        70,
        70};
            this.Gvspeed.RangesOuterRadius = new int[] {
        60,
        60,
        60,
        80,
        80};
            this.Gvspeed.RangesStartValue = new float[] {
        0F,
        150F,
        75F,
        0F,
        0F};
            this.Gvspeed.RangeStartValue = 0F;
            this.Gvspeed.ScaleLinesInterColor = Color.White;
            this.Gvspeed.ScaleLinesInterInnerRadius = 52;
            this.Gvspeed.ScaleLinesInterOuterRadius = 60;
            this.Gvspeed.ScaleLinesInterWidth = 1;
            this.Gvspeed.ScaleLinesMajorColor = Color.White;
            this.Gvspeed.ScaleLinesMajorInnerRadius = 50;
            this.Gvspeed.ScaleLinesMajorOuterRadius = 60;
            this.Gvspeed.ScaleLinesMajorStepValue = 2F;
            this.Gvspeed.ScaleLinesMajorWidth = 2;
            this.Gvspeed.ScaleLinesMinorColor = Color.White;
            this.Gvspeed.ScaleLinesMinorInnerRadius = 55;
            this.Gvspeed.ScaleLinesMinorNumOf = 9;
            this.Gvspeed.ScaleLinesMinorOuterRadius = 60;
            this.Gvspeed.ScaleLinesMinorWidth = 1;
            this.Gvspeed.ScaleNumbersColor = Color.White;
            this.Gvspeed.ScaleNumbersFormat = "";
            this.Gvspeed.ScaleNumbersRadius = 42;
            this.Gvspeed.ScaleNumbersRotation = 0;
            this.Gvspeed.ScaleNumbersStartScaleLine = 1;
            this.Gvspeed.ScaleNumbersStepScaleLines = 1;
            this.Gvspeed.Size = new Size(100, 100);
            this.Gvspeed.TabIndex = 82;
            this.Gvspeed.Value = 0F;
            this.Gvspeed.Value0 = 0F;
            this.Gvspeed.Value1 = 0F;
            this.Gvspeed.Value2 = 0F;
            this.Gvspeed.Value3 = 0F;
            // 
            // bindingSourceGaugesTab
            // 
            this.bindingSourceGaugesTab.DataSource = typeof(MissionPlanner.CurrentState);
            // 
            // Gheading
            // 
            this.Gheading.BackColor = Color.Transparent;
        
            this.Gheading.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Gheading.DataBindings.Add(new System.Windows.Forms.Binding("Heading", this.bindingSourceGaugesTab, "yaw", true));
            this.Gheading.DataBindings.Add(new System.Windows.Forms.Binding("NavHeading", this.bindingSourceGaugesTab, "nav_bearing", true));
            this.Gheading.Heading = 0;
            this.Gheading.Location = new Point(303, 7);
            this.Gheading.Margin = new System.Windows.Forms.Padding(0);
            this.Gheading.Name = "Gheading";
            this.Gheading.NavHeading = 0;
            this.Gheading.Size = new Size(100, 100);
            this.Gheading.TabIndex = 80;
            // 
            // Galt
            // 
            this.Galt.BackColor = Color.Transparent;
       
            this.Galt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Galt.BaseArcColor = Color.Transparent;
            this.Galt.BaseArcRadius = 60;
            this.Galt.BaseArcStart = 270;
            this.Galt.BaseArcSweep = 360;
            this.Galt.BaseArcWidth = 2;
            this.Galt.Cap_Idx = ((byte)(0));
            this.Galt.CapColor = Color.White;
            this.Galt.CapColors = new Color[] {
        Color.White,
        Color.Black,
        Color.Black,
        Color.Black,
        Color.Black};
            this.Galt.CapPosition = new Point(68, 85);
            this.Galt.CapsPosition = new Point[] {
        new Point(68, 85),
        new Point(30, 55),
        new Point(10, 10),
        new Point(10, 10),
        new Point(10, 10)};
            this.Galt.CapsText = new string[] {
        "Alt",
        "",
        "",
        "",
        ""};
            this.Galt.CapText = "Alt";
            this.Galt.Center = new Point(75, 75);
            this.Galt.DataBindings.Add(new System.Windows.Forms.Binding("Value0", this.bindingSourceGaugesTab, "altd100", true));
            this.Galt.DataBindings.Add(new System.Windows.Forms.Binding("Value1", this.bindingSourceGaugesTab, "altd1000", true));
            this.Galt.DataBindings.Add(new System.Windows.Forms.Binding("Value2", this.bindingSourceGaugesTab, "targetaltd100", true));
            this.Galt.Location = new Point(203, 7);
            this.Galt.Margin = new System.Windows.Forms.Padding(0);
            this.Galt.MaxValue = 9.99F;
            this.Galt.MinValue = 0F;
            this.Galt.Name = "Galt";
            this.Galt.Need_Idx = ((byte)(3));
            this.Galt.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Gray;
            this.Galt.NeedleColor2 = Color.White;
            this.Galt.NeedleEnabled = false;
            this.Galt.NeedleRadius = 80;
            this.Galt.NeedlesColor1 = new AGaugeApp.AGauge.NeedleColorEnum[] {
        AGaugeApp.AGauge.NeedleColorEnum.Gray,
        AGaugeApp.AGauge.NeedleColorEnum.Gray,
        AGaugeApp.AGauge.NeedleColorEnum.Red,
        AGaugeApp.AGauge.NeedleColorEnum.Gray};
            this.Galt.NeedlesColor2 = new Color[] {
        Color.White,
        Color.White,
        Color.White,
        Color.White};
            this.Galt.NeedlesEnabled = new bool[] {
        true,
        true,
        true,
        false};
            this.Galt.NeedlesRadius = new int[] {
        50,
        30,
        50,
        80};
            this.Galt.NeedlesType = new int[] {
        0,
        0,
        0,
        0};
            this.Galt.NeedlesWidth = new int[] {
        2,
        2,
        2,
        2};
            this.Galt.NeedleType = 0;
            this.Galt.NeedleWidth = 2;
            this.Galt.Range_Idx = ((byte)(0));
            this.Galt.RangeColor = Color.LightGreen;
            this.Galt.RangeEnabled = false;
            this.Galt.RangeEndValue = 360F;
            this.Galt.RangeInnerRadius = 1;
            this.Galt.RangeOuterRadius = 60;
            this.Galt.RangesColor = new Color[] {
        Color.LightGreen,
        Color.Red,
        Color.Orange,
        SystemColors.Control,
        SystemColors.Control};
            this.Galt.RangesEnabled = new bool[] {
        false,
        false,
        false,
        false,
        false};
            this.Galt.RangesEndValue = new float[] {
        360F,
        200F,
        150F,
        0F,
        0F};
            this.Galt.RangesInnerRadius = new int[] {
        1,
        1,
        1,
        70,
        70};
            this.Galt.RangesOuterRadius = new int[] {
        60,
        60,
        60,
        80,
        80};
            this.Galt.RangesStartValue = new float[] {
        0F,
        150F,
        75F,
        0F,
        0F};
            this.Galt.RangeStartValue = 0F;
            this.Galt.ScaleLinesInterColor = Color.White;
            this.Galt.ScaleLinesInterInnerRadius = 52;
            this.Galt.ScaleLinesInterOuterRadius = 60;
            this.Galt.ScaleLinesInterWidth = 1;
            this.Galt.ScaleLinesMajorColor = Color.White;
            this.Galt.ScaleLinesMajorInnerRadius = 50;
            this.Galt.ScaleLinesMajorOuterRadius = 60;
            this.Galt.ScaleLinesMajorStepValue = 1F;
            this.Galt.ScaleLinesMajorWidth = 2;
            this.Galt.ScaleLinesMinorColor = Color.White;
            this.Galt.ScaleLinesMinorInnerRadius = 55;
            this.Galt.ScaleLinesMinorNumOf = 9;
            this.Galt.ScaleLinesMinorOuterRadius = 60;
            this.Galt.ScaleLinesMinorWidth = 1;
            this.Galt.ScaleNumbersColor = Color.White;
            this.Galt.ScaleNumbersFormat = "";
            this.Galt.ScaleNumbersRadius = 42;
            this.Galt.ScaleNumbersRotation = 0;
            this.Galt.ScaleNumbersStartScaleLine = 1;
            this.Galt.ScaleNumbersStepScaleLines = 1;
            this.Galt.Size = new Size(100, 100);
            this.Galt.TabIndex = 81;
            this.Galt.Value = 0F;
            this.Galt.Value0 = 0F;
            this.Galt.Value1 = 0F;
            this.Galt.Value2 = 0F;
            this.Galt.Value3 = 0F;
            // 
            // Gspeed
            // 
            this.Gspeed.BackColor = Color.Transparent;
         
            this.Gspeed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Gspeed.BaseArcColor = Color.Transparent;
            this.Gspeed.BaseArcRadius = 70;
            this.Gspeed.BaseArcStart = 135;
            this.Gspeed.BaseArcSweep = 270;
            this.Gspeed.BaseArcWidth = 2;
            this.Gspeed.Cap_Idx = ((byte)(0));
            this.Gspeed.CapColor = Color.White;
            this.Gspeed.CapColors = new Color[] {
        Color.White,
        Color.White,
        Color.Black,
        Color.Black,
        Color.Black};
            this.Gspeed.CapPosition = new Point(58, 85);
            this.Gspeed.CapsPosition = new Point[] {
        new Point(58, 85),
        new Point(50, 110),
        new Point(10, 10),
        new Point(10, 10),
        new Point(10, 10)};
            this.Gspeed.CapsText = new string[] {
        "Speed",
        "",
        "",
        "",
        ""};
            this.Gspeed.CapText = "Speed";
            this.Gspeed.Center = new Point(75, 75);
            this.Gspeed.DataBindings.Add(new System.Windows.Forms.Binding("Value0", this.bindingSourceGaugesTab, "airspeed", true));
            this.Gspeed.DataBindings.Add(new System.Windows.Forms.Binding("Value1", this.bindingSourceGaugesTab, "groundspeed", true));
            this.Gspeed.Location = new Point(103, 7);
            this.Gspeed.Margin = new System.Windows.Forms.Padding(0);
            this.Gspeed.MaxValue = 60F;
            this.Gspeed.MinValue = 0F;
            this.Gspeed.Name = "Gspeed";
            this.Gspeed.Need_Idx = ((byte)(3));
            this.Gspeed.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Gray;
            this.Gspeed.NeedleColor2 = Color.Brown;
            this.Gspeed.NeedleEnabled = false;
            this.Gspeed.NeedleRadius = 70;
            this.Gspeed.NeedlesColor1 = new AGaugeApp.AGauge.NeedleColorEnum[] {
        AGaugeApp.AGauge.NeedleColorEnum.Gray,
        AGaugeApp.AGauge.NeedleColorEnum.Red,
        AGaugeApp.AGauge.NeedleColorEnum.Blue,
        AGaugeApp.AGauge.NeedleColorEnum.Gray};
            this.Gspeed.NeedlesColor2 = new Color[] {
        Color.White,
        Color.White,
        Color.White,
        Color.Brown};
            this.Gspeed.NeedlesEnabled = new bool[] {
        true,
        true,
        false,
        false};
            this.Gspeed.NeedlesRadius = new int[] {
        50,
        50,
        70,
        70};
            this.Gspeed.NeedlesType = new int[] {
        0,
        0,
        0,
        0};
            this.Gspeed.NeedlesWidth = new int[] {
        2,
        1,
        2,
        2};
            this.Gspeed.NeedleType = 0;
            this.Gspeed.NeedleWidth = 2;
            this.Gspeed.Range_Idx = ((byte)(2));
            this.Gspeed.RangeColor = Color.Orange;
            this.Gspeed.RangeEnabled = false;
            this.Gspeed.RangeEndValue = 50F;
            this.Gspeed.RangeInnerRadius = 1;
            this.Gspeed.RangeOuterRadius = 70;
            this.Gspeed.RangesColor = new Color[] {
        Color.LightGreen,
        Color.Red,
        Color.Orange,
        SystemColors.Control,
        SystemColors.Control};
            this.Gspeed.RangesEnabled = new bool[] {
        false,
        false,
        false,
        false,
        false};
            this.Gspeed.RangesEndValue = new float[] {
        35F,
        60F,
        50F,
        0F,
        0F};
            this.Gspeed.RangesInnerRadius = new int[] {
        1,
        1,
        1,
        70,
        70};
            this.Gspeed.RangesOuterRadius = new int[] {
        70,
        70,
        70,
        80,
        80};
            this.Gspeed.RangesStartValue = new float[] {
        0F,
        50F,
        35F,
        0F,
        0F};
            this.Gspeed.RangeStartValue = 35F;
            this.Gspeed.ScaleLinesInterColor = Color.White;
            this.Gspeed.ScaleLinesInterInnerRadius = 52;
            this.Gspeed.ScaleLinesInterOuterRadius = 60;
            this.Gspeed.ScaleLinesInterWidth = 1;
            this.Gspeed.ScaleLinesMajorColor = Color.White;
            this.Gspeed.ScaleLinesMajorInnerRadius = 50;
            this.Gspeed.ScaleLinesMajorOuterRadius = 60;
            this.Gspeed.ScaleLinesMajorStepValue = 10F;
            this.Gspeed.ScaleLinesMajorWidth = 2;
            this.Gspeed.ScaleLinesMinorColor = Color.White;
            this.Gspeed.ScaleLinesMinorInnerRadius = 55;
            this.Gspeed.ScaleLinesMinorNumOf = 9;
            this.Gspeed.ScaleLinesMinorOuterRadius = 60;
            this.Gspeed.ScaleLinesMinorWidth = 1;
            this.Gspeed.ScaleNumbersColor = Color.White;
            this.Gspeed.ScaleNumbersFormat = null;
            this.Gspeed.ScaleNumbersRadius = 42;
            this.Gspeed.ScaleNumbersRotation = 0;
            this.Gspeed.ScaleNumbersStartScaleLine = 1;
            this.Gspeed.ScaleNumbersStepScaleLines = 1;
            this.Gspeed.Size = new Size(100, 100);
            this.Gspeed.TabIndex = 79;
            this.toolTip1.SetToolTip(this.Gspeed, "Double click me to change Max");
            this.Gspeed.Value = 0F;
            this.Gspeed.Value0 = 0F;
            this.Gspeed.Value1 = 0F;
            this.Gspeed.Value2 = 0F;
            this.Gspeed.Value3 = 0F;
            this.Gspeed.DoubleClick += new System.EventHandler(this.Gspeed_DoubleClick);
            // 
            // tabStatus
            // 
            this.tabStatus.AutoScroll = true;
            this.tabStatus.Location = new Point(4, 58);
            this.tabStatus.Name = "tabStatus";
            this.tabStatus.Padding = new System.Windows.Forms.Padding(3);
            this.tabStatus.Size = new Size(350, 128);
            this.tabStatus.TabIndex = 1;
            this.tabStatus.Text = "Status";
            // 
            // tabServo
            // 
            this.tabServo.Controls.Add(this.flowLayoutPanelServos);
            this.tabServo.Location = new Point(4, 58);
            this.tabServo.Name = "tabServo";
            this.tabServo.Padding = new System.Windows.Forms.Padding(3);
            this.tabServo.Size = new Size(350, 128);
            this.tabServo.TabIndex = 5;
            this.tabServo.Text = "Servo";
            this.tabServo.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanelServos
            // 
            this.flowLayoutPanelServos.AutoScroll = true;
            this.flowLayoutPanelServos.Controls.Add(this.servoOptions1);
            this.flowLayoutPanelServos.Controls.Add(this.servoOptions2);
            this.flowLayoutPanelServos.Controls.Add(this.servoOptions3);
            this.flowLayoutPanelServos.Controls.Add(this.servoOptions4);
            this.flowLayoutPanelServos.Controls.Add(this.servoOptions5);
            this.flowLayoutPanelServos.Controls.Add(this.servoOptions6);
            this.flowLayoutPanelServos.Controls.Add(this.servoOptions7);
            this.flowLayoutPanelServos.Controls.Add(this.servoOptions8);
            this.flowLayoutPanelServos.Controls.Add(this.servoOptions9);
            this.flowLayoutPanelServos.Controls.Add(this.servoOptions10);
            this.flowLayoutPanelServos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelServos.Location = new Point(3, 3);
            this.flowLayoutPanelServos.Name = "flowLayoutPanelServos";
            this.flowLayoutPanelServos.Size = new Size(344, 122);
            this.flowLayoutPanelServos.TabIndex = 0;
            // 
            // servoOptions1
            // 
            this.servoOptions1.Location = new Point(3, 3);
            this.servoOptions1.Name = "servoOptions1";
            this.servoOptions1.Size = new Size(315, 27);
            this.servoOptions1.TabIndex = 0;
            this.servoOptions1.thisservo = 5;
            // 
            // servoOptions2
            // 
            this.servoOptions2.Location = new Point(3, 36);
            this.servoOptions2.Name = "servoOptions2";
            this.servoOptions2.Size = new Size(315, 27);
            this.servoOptions2.TabIndex = 1;
            this.servoOptions2.thisservo = 6;
            // 
            // servoOptions3
            // 
            this.servoOptions3.Location = new Point(3, 69);
            this.servoOptions3.Name = "servoOptions3";
            this.servoOptions3.Size = new Size(315, 27);
            this.servoOptions3.TabIndex = 2;
            this.servoOptions3.thisservo = 7;
            // 
            // servoOptions4
            // 
            this.servoOptions4.Location = new Point(3, 102);
            this.servoOptions4.Name = "servoOptions4";
            this.servoOptions4.Size = new Size(315, 27);
            this.servoOptions4.TabIndex = 3;
            this.servoOptions4.thisservo = 8;
            // 
            // servoOptions5
            // 
            this.servoOptions5.Location = new Point(3, 135);
            this.servoOptions5.Name = "servoOptions5";
            this.servoOptions5.Size = new Size(315, 27);
            this.servoOptions5.TabIndex = 4;
            this.servoOptions5.thisservo = 9;
            // 
            // servoOptions6
            // 
            this.servoOptions6.Location = new Point(3, 168);
            this.servoOptions6.Name = "servoOptions6";
            this.servoOptions6.Size = new Size(315, 27);
            this.servoOptions6.TabIndex = 5;
            this.servoOptions6.thisservo = 10;
            // 
            // servoOptions7
            // 
            this.servoOptions7.Location = new Point(3, 201);
            this.servoOptions7.Name = "servoOptions7";
            this.servoOptions7.Size = new Size(315, 27);
            this.servoOptions7.TabIndex = 6;
            this.servoOptions7.thisservo = 11;
            // 
            // servoOptions8
            // 
            this.servoOptions8.Location = new Point(3, 234);
            this.servoOptions8.Name = "servoOptions8";
            this.servoOptions8.Size = new Size(295, 24);
            this.servoOptions8.TabIndex = 7;
            this.servoOptions8.thisservo = 12;
            // 
            // servoOptions9
            // 
            this.servoOptions9.Location = new Point(3, 264);
            this.servoOptions9.Name = "servoOptions9";
            this.servoOptions9.Size = new Size(295, 24);
            this.servoOptions9.TabIndex = 8;
            this.servoOptions9.thisservo = 13;
            // 
            // servoOptions10
            // 
            this.servoOptions10.Location = new Point(3, 294);
            this.servoOptions10.Name = "servoOptions10";
            this.servoOptions10.Size = new Size(295, 24);
            this.servoOptions10.TabIndex = 9;
            this.servoOptions10.thisservo = 14;
            // 
            // tabTLogs
            // 
            this.tabTLogs.Controls.Add(this.tableLayoutPaneltlogs);
            this.tabTLogs.Location = new Point(4, 58);
            this.tabTLogs.Name = "tabTLogs";
            this.tabTLogs.Size = new Size(350, 128);
            this.tabTLogs.TabIndex = 3;
            this.tabTLogs.Text = "Telemetry Logs";
            this.tabTLogs.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPaneltlogs
            // 
            this.tableLayoutPaneltlogs.ColumnCount = 3;
            this.tableLayoutPaneltlogs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPaneltlogs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPaneltlogs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPaneltlogs.Controls.Add(this.BUT_loadtelem, 0, 0);
            this.tableLayoutPaneltlogs.Controls.Add(this.lbl_playbackspeed, 2, 2);
            this.tableLayoutPaneltlogs.Controls.Add(this.lbl_logpercent, 2, 1);
            this.tableLayoutPaneltlogs.Controls.Add(this.tracklog, 1, 1);
            this.tableLayoutPaneltlogs.Controls.Add(this.LBL_logfn, 1, 0);
            this.tableLayoutPaneltlogs.Controls.Add(this.BUT_log2kml, 0, 2);
            this.tableLayoutPaneltlogs.Controls.Add(this.BUT_playlog, 0, 1);
            this.tableLayoutPaneltlogs.Controls.Add(this.panel2, 1, 2);
            this.tableLayoutPaneltlogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPaneltlogs.Location = new Point(0, 0);
            this.tableLayoutPaneltlogs.Name = "tableLayoutPaneltlogs";
            this.tableLayoutPaneltlogs.RowCount = 3;
            this.tableLayoutPaneltlogs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPaneltlogs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPaneltlogs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPaneltlogs.Size = new Size(350, 128);
            this.tableLayoutPaneltlogs.TabIndex = 81;
            // 
            // BUT_loadtelem
            // 
            this.BUT_loadtelem.ColorMouseDown = Color.Empty;
            this.BUT_loadtelem.ColorMouseOver = Color.Empty;
            this.BUT_loadtelem.ColorNotEnabled = Color.Empty;
            this.BUT_loadtelem.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BUT_loadtelem.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BUT_loadtelem.Location = new Point(3, 3);
            this.BUT_loadtelem.Name = "BUT_loadtelem";
            this.BUT_loadtelem.Size = new Size(80, 23);
            this.BUT_loadtelem.TabIndex = 71;
            this.BUT_loadtelem.Text = "Load Log";
            this.BUT_loadtelem.UseVisualStyleBackColor = true;
            this.BUT_loadtelem.Click += new System.EventHandler(this.BUT_loadtelem_Click);
            // 
            // lbl_playbackspeed
            // 
            this.lbl_playbackspeed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_playbackspeed.Location = new Point(312, 69);
            this.lbl_playbackspeed.Name = "lbl_playbackspeed";
            this.lbl_playbackspeed.resize = false;
            this.lbl_playbackspeed.Size = new Size(35, 56);
            this.lbl_playbackspeed.TabIndex = 79;
            this.lbl_playbackspeed.Text = "x 1.0";
            // 
            // lbl_logpercent
            // 
            this.lbl_logpercent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_logpercent.Location = new Point(312, 36);
            this.lbl_logpercent.Name = "lbl_logpercent";
            this.lbl_logpercent.resize = false;
            this.lbl_logpercent.Size = new Size(35, 27);
            this.lbl_logpercent.TabIndex = 78;
            this.lbl_logpercent.Text = "0.00 %";
            // 
            // tracklog
            // 
            this.tracklog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tracklog.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tracklog.Location = new Point(89, 36);
            this.tracklog.Maximum = 100;
            this.tracklog.Name = "tracklog";
            this.tracklog.Size = new Size(217, 27);
            this.tracklog.TabIndex = 75;
            this.tracklog.TickFrequency = 5;
            this.tracklog.Scroll += new System.EventHandler(this.tracklog_Scroll);
            // 
            // LBL_logfn
            // 
            this.tableLayoutPaneltlogs.SetColumnSpan(this.LBL_logfn, 2);
            this.LBL_logfn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_logfn.Location = new Point(89, 3);
            this.LBL_logfn.Name = "LBL_logfn";
            this.LBL_logfn.resize = false;
            this.LBL_logfn.Size = new Size(258, 27);
            this.LBL_logfn.TabIndex = 80;
            // 
            // BUT_log2kml
            // 
            this.BUT_log2kml.ColorMouseDown = Color.Empty;
            this.BUT_log2kml.ColorMouseOver = Color.Empty;
            this.BUT_log2kml.ColorNotEnabled = Color.Empty;
            this.BUT_log2kml.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BUT_log2kml.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BUT_log2kml.Location = new Point(3, 69);
            this.BUT_log2kml.Name = "BUT_log2kml";
            this.BUT_log2kml.Padding = new System.Windows.Forms.Padding(0, 0, 0, 50);
            this.BUT_log2kml.Size = new Size(80, 46);
            this.BUT_log2kml.TabIndex = 76;
            this.BUT_log2kml.Text = "Tlog > Kml or Graph";
            this.BUT_log2kml.UseVisualStyleBackColor = true;
            this.BUT_log2kml.Click += new System.EventHandler(this.BUT_log2kml_Click);
            // 
            // BUT_playlog
            // 
            this.BUT_playlog.ColorMouseDown = Color.Empty;
            this.BUT_playlog.ColorMouseOver = Color.Empty;
            this.BUT_playlog.ColorNotEnabled = Color.Empty;
            this.BUT_playlog.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BUT_playlog.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BUT_playlog.Location = new Point(3, 36);
            this.BUT_playlog.Name = "BUT_playlog";
            this.BUT_playlog.Size = new Size(80, 23);
            this.BUT_playlog.TabIndex = 73;
            this.BUT_playlog.Text = "Play/Pause";
            this.BUT_playlog.UseVisualStyleBackColor = true;
            this.BUT_playlog.Click += new System.EventHandler(this.BUT_playlog_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.BUT_speed10);
            this.panel2.Controls.Add(this.BUT_speed5);
            this.panel2.Controls.Add(this.BUT_speed2);
            this.panel2.Controls.Add(this.BUT_speed1);
            this.panel2.Controls.Add(this.BUT_speed1_2);
            this.panel2.Controls.Add(this.BUT_speed1_4);
            this.panel2.Controls.Add(this.BUT_speed1_10);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new Point(89, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new Size(217, 56);
            this.panel2.TabIndex = 81;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new Point(90, 3);
            this.label2.Name = "label2";
            this.label2.Size = new Size(38, 13);
            this.label2.TabIndex = 84;
            this.label2.Text = "Speed";
            // 
            // BUT_speed10
            // 
            this.BUT_speed10.ColorMouseDown = Color.Empty;
            this.BUT_speed10.ColorMouseOver = Color.Empty;
            this.BUT_speed10.ColorNotEnabled = Color.Empty;
            this.BUT_speed10.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BUT_speed10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BUT_speed10.Location = new Point(184, 23);
            this.BUT_speed10.Name = "BUT_speed10";
            this.BUT_speed10.Size = new Size(23, 20);
            this.BUT_speed10.TabIndex = 83;
            this.BUT_speed10.Tag = "10";
            this.BUT_speed10.Text = "10x";
            this.BUT_speed10.UseVisualStyleBackColor = true;
            this.BUT_speed10.Click += new System.EventHandler(this.BUT_speed1_Click);
            // 
            // BUT_speed5
            // 
            this.BUT_speed5.ColorMouseDown = Color.Empty;
            this.BUT_speed5.ColorMouseOver = Color.Empty;
            this.BUT_speed5.ColorNotEnabled = Color.Empty;
            this.BUT_speed5.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BUT_speed5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BUT_speed5.Location = new Point(155, 23);
            this.BUT_speed5.Name = "BUT_speed5";
            this.BUT_speed5.Size = new Size(23, 20);
            this.BUT_speed5.TabIndex = 82;
            this.BUT_speed5.Tag = "5";
            this.BUT_speed5.Text = "5x";
            this.BUT_speed5.UseVisualStyleBackColor = true;
            this.BUT_speed5.Click += new System.EventHandler(this.BUT_speed1_Click);
            // 
            // BUT_speed2
            // 
            this.BUT_speed2.ColorMouseDown = Color.Empty;
            this.BUT_speed2.ColorMouseOver = Color.Empty;
            this.BUT_speed2.ColorNotEnabled = Color.Empty;
            this.BUT_speed2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BUT_speed2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BUT_speed2.Location = new Point(126, 23);
            this.BUT_speed2.Name = "BUT_speed2";
            this.BUT_speed2.Size = new Size(23, 20);
            this.BUT_speed2.TabIndex = 81;
            this.BUT_speed2.Tag = "2";
            this.BUT_speed2.Text = "2x";
            this.BUT_speed2.UseVisualStyleBackColor = true;
            this.BUT_speed2.Click += new System.EventHandler(this.BUT_speed1_Click);
            // 
            // BUT_speed1
            // 
            this.BUT_speed1.ColorMouseDown = Color.Empty;
            this.BUT_speed1.ColorMouseOver = Color.Empty;
            this.BUT_speed1.ColorNotEnabled = Color.Empty;
            this.BUT_speed1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BUT_speed1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BUT_speed1.Location = new Point(97, 23);
            this.BUT_speed1.Name = "BUT_speed1";
            this.BUT_speed1.Size = new Size(23, 20);
            this.BUT_speed1.TabIndex = 80;
            this.BUT_speed1.Tag = "1";
            this.BUT_speed1.Text = "1x";
            this.BUT_speed1.UseVisualStyleBackColor = true;
            this.BUT_speed1.Click += new System.EventHandler(this.BUT_speed1_Click);
            // 
            // BUT_speed1_2
            // 
            this.BUT_speed1_2.ColorMouseDown = Color.Empty;
            this.BUT_speed1_2.ColorMouseOver = Color.Empty;
            this.BUT_speed1_2.ColorNotEnabled = Color.Empty;
            this.BUT_speed1_2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BUT_speed1_2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BUT_speed1_2.Location = new Point(68, 23);
            this.BUT_speed1_2.Name = "BUT_speed1_2";
            this.BUT_speed1_2.Size = new Size(23, 20);
            this.BUT_speed1_2.TabIndex = 79;
            this.BUT_speed1_2.Tag = "0.5";
            this.BUT_speed1_2.Text = "0.5";
            this.BUT_speed1_2.UseVisualStyleBackColor = true;
            this.BUT_speed1_2.Click += new System.EventHandler(this.BUT_speed1_Click);
            // 
            // BUT_speed1_4
            // 
            this.BUT_speed1_4.ColorMouseDown = Color.Empty;
            this.BUT_speed1_4.ColorMouseOver = Color.Empty;
            this.BUT_speed1_4.ColorNotEnabled = Color.Empty;
            this.BUT_speed1_4.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BUT_speed1_4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BUT_speed1_4.Location = new Point(35, 23);
            this.BUT_speed1_4.Name = "BUT_speed1_4";
            this.BUT_speed1_4.Size = new Size(27, 20);
            this.BUT_speed1_4.TabIndex = 78;
            this.BUT_speed1_4.Tag = "0.25";
            this.BUT_speed1_4.Text = "0.25";
            this.BUT_speed1_4.UseVisualStyleBackColor = true;
            this.BUT_speed1_4.Click += new System.EventHandler(this.BUT_speed1_Click);
            // 
            // BUT_speed1_10
            // 
            this.BUT_speed1_10.ColorMouseDown = Color.Empty;
            this.BUT_speed1_10.ColorMouseOver = Color.Empty;
            this.BUT_speed1_10.ColorNotEnabled = Color.Empty;
            this.BUT_speed1_10.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BUT_speed1_10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BUT_speed1_10.Location = new Point(6, 23);
            this.BUT_speed1_10.Name = "BUT_speed1_10";
            this.BUT_speed1_10.Size = new Size(23, 20);
            this.BUT_speed1_10.TabIndex = 77;
            this.BUT_speed1_10.Tag = "0.1";
            this.BUT_speed1_10.Text = "0.1";
            this.BUT_speed1_10.UseVisualStyleBackColor = true;
            this.BUT_speed1_10.Click += new System.EventHandler(this.BUT_speed1_Click);
            // 
            // tablogbrowse
            // 
            this.tablogbrowse.Controls.Add(this.BUT_loganalysis);
            this.tablogbrowse.Controls.Add(this.BUT_DFMavlink);
            this.tablogbrowse.Controls.Add(this.but_dflogtokml);
            this.tablogbrowse.Controls.Add(this.but_bintolog);
            this.tablogbrowse.Controls.Add(this.BUT_matlab);
            this.tablogbrowse.Controls.Add(this.BUT_logbrowse);
            this.tablogbrowse.Location = new Point(4, 58);
            this.tablogbrowse.Name = "tablogbrowse";
            this.tablogbrowse.Padding = new System.Windows.Forms.Padding(3);
            this.tablogbrowse.Size = new Size(350, 128);
            this.tablogbrowse.TabIndex = 6;
            this.tablogbrowse.Text = "DataFlash Logs";
            this.tablogbrowse.UseVisualStyleBackColor = true;
            // 
            // BUT_loganalysis
            // 
            this.BUT_loganalysis.ColorMouseDown = Color.Empty;
            this.BUT_loganalysis.ColorMouseOver = Color.Empty;
            this.BUT_loganalysis.ColorNotEnabled = Color.Empty;
            this.BUT_loganalysis.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BUT_loganalysis.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BUT_loganalysis.Location = new Point(229, 7);
            this.BUT_loganalysis.Name = "BUT_loganalysis";
            this.BUT_loganalysis.Size = new Size(87, 35);
            this.BUT_loganalysis.TabIndex = 12;
            this.BUT_loganalysis.Text = "Auto Analysis";
            this.BUT_loganalysis.UseVisualStyleBackColor = true;
            this.BUT_loganalysis.Click += new System.EventHandler(this.BUT_loganalysis_Click);
            // 
            // BUT_DFMavlink
            // 
            this.BUT_DFMavlink.ColorMouseDown = Color.Empty;
            this.BUT_DFMavlink.ColorMouseOver = Color.Empty;
            this.BUT_DFMavlink.ColorNotEnabled = Color.Empty;
            this.BUT_DFMavlink.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BUT_DFMavlink.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BUT_DFMavlink.Location = new Point(6, 7);
            this.BUT_DFMavlink.Name = "BUT_DFMavlink";
            this.BUT_DFMavlink.Size = new Size(124, 35);
            this.BUT_DFMavlink.TabIndex = 11;
            this.BUT_DFMavlink.Text = "Download DataFlash Log Via Mavlink";
            this.BUT_DFMavlink.UseVisualStyleBackColor = true;
            this.BUT_DFMavlink.Click += new System.EventHandler(this.BUT_DFMavlink_Click);
            // 
            // but_dflogtokml
            // 
            this.but_dflogtokml.ColorMouseDown = Color.Empty;
            this.but_dflogtokml.ColorMouseOver = Color.Empty;
            this.but_dflogtokml.ColorNotEnabled = Color.Empty;
            this.but_dflogtokml.DialogResult = System.Windows.Forms.DialogResult.None;
            this.but_dflogtokml.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.but_dflogtokml.Location = new Point(6, 47);
            this.but_dflogtokml.Name = "but_dflogtokml";
            this.but_dflogtokml.Size = new Size(124, 35);
            this.but_dflogtokml.TabIndex = 10;
            this.but_dflogtokml.Text = "Create KML + gpx";
            this.but_dflogtokml.UseVisualStyleBackColor = true;
            this.but_dflogtokml.Click += new System.EventHandler(this.but_dflogtokml_Click);
            // 
            // but_bintolog
            // 
            this.but_bintolog.ColorMouseDown = Color.Empty;
            this.but_bintolog.ColorMouseOver = Color.Empty;
            this.but_bintolog.ColorNotEnabled = Color.Empty;
            this.but_bintolog.DialogResult = System.Windows.Forms.DialogResult.None;
            this.but_bintolog.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.but_bintolog.Location = new Point(136, 47);
            this.but_bintolog.Name = "but_bintolog";
            this.but_bintolog.Size = new Size(87, 35);
            this.but_bintolog.TabIndex = 9;
            this.but_bintolog.Text = "Convert .Bin to .Log";
            this.but_bintolog.UseVisualStyleBackColor = true;
            this.but_bintolog.Click += new System.EventHandler(this.but_bintolog_Click);
            // 
            // BUT_matlab
            // 
            this.BUT_matlab.ColorMouseDown = Color.Empty;
            this.BUT_matlab.ColorMouseOver = Color.Empty;
            this.BUT_matlab.ColorNotEnabled = Color.Empty;
            this.BUT_matlab.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BUT_matlab.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BUT_matlab.Location = new Point(228, 47);
            this.BUT_matlab.Name = "BUT_matlab";
            this.BUT_matlab.Size = new Size(88, 35);
            this.BUT_matlab.TabIndex = 8;
            this.BUT_matlab.Text = "Create Matlab File";
            this.BUT_matlab.UseVisualStyleBackColor = true;
            this.BUT_matlab.Click += new System.EventHandler(this.BUT_matlab_Click);
            // 
            // BUT_logbrowse
            // 
            this.BUT_logbrowse.ColorMouseDown = Color.Empty;
            this.BUT_logbrowse.ColorMouseOver = Color.Empty;
            this.BUT_logbrowse.ColorNotEnabled = Color.Empty;
            this.BUT_logbrowse.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BUT_logbrowse.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BUT_logbrowse.Location = new Point(136, 7);
            this.BUT_logbrowse.Name = "BUT_logbrowse";
            this.BUT_logbrowse.Size = new Size(87, 35);
            this.BUT_logbrowse.TabIndex = 7;
            this.BUT_logbrowse.Text = "Review a Log";
            this.BUT_logbrowse.UseVisualStyleBackColor = true;
            this.BUT_logbrowse.Click += new System.EventHandler(this.BUT_logbrowse_Click);
            // 
            // tabScripts
            // 
            this.tabScripts.Controls.Add(this.checkBoxRedirectOutput);
            this.tabScripts.Controls.Add(this.BUT_edit_selected);
            this.tabScripts.Controls.Add(this.labelSelectedScript);
            this.tabScripts.Controls.Add(this.BUT_run_script);
            this.tabScripts.Controls.Add(this.BUT_abort_script);
            this.tabScripts.Controls.Add(this.labelScriptStatus);
            this.tabScripts.Controls.Add(this.BUT_select_script);
            this.tabScripts.Location = new Point(4, 58);
            this.tabScripts.Name = "tabScripts";
            this.tabScripts.Padding = new System.Windows.Forms.Padding(3);
            this.tabScripts.Size = new Size(350, 128);
            this.tabScripts.TabIndex = 7;
            this.tabScripts.Text = "Scripts";
            this.tabScripts.UseVisualStyleBackColor = true;
            // 
            // checkBoxRedirectOutput
            // 
            this.checkBoxRedirectOutput.AutoSize = true;
            this.checkBoxRedirectOutput.Checked = true;
            this.checkBoxRedirectOutput.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRedirectOutput.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkBoxRedirectOutput.Location = new Point(19, 48);
            this.checkBoxRedirectOutput.Name = "checkBoxRedirectOutput";
            this.checkBoxRedirectOutput.Size = new Size(143, 17);
            this.checkBoxRedirectOutput.TabIndex = 91;
            this.checkBoxRedirectOutput.Text = "Redirect Program Output";
            this.checkBoxRedirectOutput.UseVisualStyleBackColor = true;
            // 
            // BUT_edit_selected
            // 
            this.BUT_edit_selected.ColorMouseDown = Color.Empty;
            this.BUT_edit_selected.ColorMouseOver = Color.Empty;
            this.BUT_edit_selected.ColorNotEnabled = Color.Empty;
            this.BUT_edit_selected.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BUT_edit_selected.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BUT_edit_selected.Location = new Point(255, 79);
            this.BUT_edit_selected.Name = "BUT_edit_selected";
            this.BUT_edit_selected.Size = new Size(80, 23);
            this.BUT_edit_selected.TabIndex = 90;
            this.BUT_edit_selected.Text = "Edit Selected Script";
            this.BUT_edit_selected.UseVisualStyleBackColor = true;
            this.BUT_edit_selected.Visible = false;
            this.BUT_edit_selected.Click += new System.EventHandler(this.BUT_edit_selected_Click);
            // 
            // labelSelectedScript
            // 
            this.labelSelectedScript.AutoSize = true;
            this.labelSelectedScript.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelSelectedScript.Location = new Point(19, 29);
            this.labelSelectedScript.Name = "labelSelectedScript";
            this.labelSelectedScript.Size = new Size(111, 13);
            this.labelSelectedScript.TabIndex = 89;
            this.labelSelectedScript.Text = "Selected Script: None";
            // 
            // BUT_run_script
            // 
            this.BUT_run_script.ColorMouseDown = Color.Empty;
            this.BUT_run_script.ColorMouseOver = Color.Empty;
            this.BUT_run_script.ColorNotEnabled = Color.Empty;
            this.BUT_run_script.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BUT_run_script.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BUT_run_script.Location = new Point(92, 80);
            this.BUT_run_script.Name = "BUT_run_script";
            this.BUT_run_script.Size = new Size(71, 23);
            this.BUT_run_script.TabIndex = 88;
            this.BUT_run_script.Text = "Run Script";
            this.BUT_run_script.UseVisualStyleBackColor = true;
            this.BUT_run_script.Visible = false;
            this.BUT_run_script.Click += new System.EventHandler(this.BUT_run_script_Click);
            // 
            // BUT_abort_script
            // 
            this.BUT_abort_script.ColorMouseDown = Color.Empty;
            this.BUT_abort_script.ColorMouseOver = Color.Empty;
            this.BUT_abort_script.ColorNotEnabled = Color.Empty;
            this.BUT_abort_script.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BUT_abort_script.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BUT_abort_script.Location = new Point(169, 80);
            this.BUT_abort_script.Name = "BUT_abort_script";
            this.BUT_abort_script.Size = new Size(80, 23);
            this.BUT_abort_script.TabIndex = 87;
            this.BUT_abort_script.Text = "Abort Running Script";
            this.BUT_abort_script.UseVisualStyleBackColor = true;
            this.BUT_abort_script.Visible = false;
            this.BUT_abort_script.Click += new System.EventHandler(this.BUT_abort_script_Click);
            // 
            // labelScriptStatus
            // 
            this.labelScriptStatus.AutoSize = true;
            this.labelScriptStatus.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelScriptStatus.Location = new Point(19, 10);
            this.labelScriptStatus.Name = "labelScriptStatus";
            this.labelScriptStatus.Size = new Size(160, 13);
            this.labelScriptStatus.TabIndex = 86;
            this.labelScriptStatus.Text = "Script Status: No Script Running";
            // 
            // BUT_select_script
            // 
            this.BUT_select_script.ColorMouseDown = Color.Empty;
            this.BUT_select_script.ColorMouseOver = Color.Empty;
            this.BUT_select_script.ColorNotEnabled = Color.Empty;
            this.BUT_select_script.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BUT_select_script.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BUT_select_script.Location = new Point(16, 80);
            this.BUT_select_script.Name = "BUT_select_script";
            this.BUT_select_script.Size = new Size(71, 23);
            this.BUT_select_script.TabIndex = 85;
            this.BUT_select_script.Text = "Select Script";
            this.BUT_select_script.UseVisualStyleBackColor = true;
            this.BUT_select_script.Click += new System.EventHandler(this.BUT_select_script_Click);
            // 
            // tabPagemessages
            // 
            this.tabPagemessages.Controls.Add(this.txt_messagebox);
            this.tabPagemessages.Location = new Point(4, 58);
            this.tabPagemessages.Name = "tabPagemessages";
            this.tabPagemessages.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagemessages.Size = new Size(350, 128);
            this.tabPagemessages.TabIndex = 8;
            this.tabPagemessages.Text = "Messages";
            this.tabPagemessages.UseVisualStyleBackColor = true;
            // 
            // txt_messagebox
            // 
            this.txt_messagebox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_messagebox.Location = new Point(3, 3);
            this.txt_messagebox.Multiline = true;
            this.txt_messagebox.Name = "txt_messagebox";
            this.txt_messagebox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_messagebox.Size = new Size(344, 122);
            this.txt_messagebox.TabIndex = 0;
            // 
            // tabPayload
            // 
            this.tabPayload.Controls.Add(this.BUT_PayloadFolder);
            this.tabPayload.Controls.Add(this.groupBoxRoll);
            this.tabPayload.Controls.Add(this.groupBoxYaw);
            this.tabPayload.Controls.Add(this.BUT_resetGimbalPos);
            this.tabPayload.Controls.Add(this.groupBoxPitch);
            this.tabPayload.Location = new Point(4, 58);
            this.tabPayload.Name = "tabPayload";
            this.tabPayload.Padding = new System.Windows.Forms.Padding(3);
            this.tabPayload.Size = new Size(350, 128);
            this.tabPayload.TabIndex = 11;
            this.tabPayload.Text = "Payload Control";
            this.tabPayload.UseVisualStyleBackColor = true;
            // 
            // BUT_PayloadFolder
            // 
            this.BUT_PayloadFolder.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BUT_PayloadFolder.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BUT_PayloadFolder.Location = new Point(73, 134);
            this.BUT_PayloadFolder.Name = "BUT_PayloadFolder";
            this.BUT_PayloadFolder.Size = new Size(56, 23);
            this.BUT_PayloadFolder.TabIndex = 7;
            this.BUT_PayloadFolder.Text = "Payload Files";
            this.BUT_PayloadFolder.UseVisualStyleBackColor = true;
            this.BUT_PayloadFolder.Visible = false;
            // 
            // groupBoxRoll
            // 
            this.groupBoxRoll.Controls.Add(this.TXT_gimbalRollPos);
            this.groupBoxRoll.Controls.Add(this.trackBarRoll);
            this.groupBoxRoll.Location = new Point(144, 82);
            this.groupBoxRoll.Name = "groupBoxRoll";
            this.groupBoxRoll.Size = new Size(178, 76);
            this.groupBoxRoll.TabIndex = 6;
            this.groupBoxRoll.TabStop = false;
            this.groupBoxRoll.Text = "Roll";
            // 
            // TXT_gimbalRollPos
            // 
            this.TXT_gimbalRollPos.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourcePayloadTab, "campointb", true));
            this.TXT_gimbalRollPos.Location = new Point(6, 19);
            this.TXT_gimbalRollPos.Name = "TXT_gimbalRollPos";
            this.TXT_gimbalRollPos.Size = new Size(51, 20);
            this.TXT_gimbalRollPos.TabIndex = 3;
            // 
            // bindingSourcePayloadTab
            // 
            this.bindingSourcePayloadTab.DataSource = typeof(MissionPlanner.CurrentState);
            // 
            // trackBarRoll
            // 
            this.trackBarRoll.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.trackBarRoll.LargeChange = 10;
            this.trackBarRoll.Location = new Point(63, 19);
            this.trackBarRoll.Maximum = 45;
            this.trackBarRoll.Minimum = -45;
            this.trackBarRoll.Name = "trackBarRoll";
            this.trackBarRoll.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.trackBarRoll.RightToLeftLayout = true;
            this.trackBarRoll.Size = new Size(104, 45);
            this.trackBarRoll.TabIndex = 1;
            this.trackBarRoll.TickFrequency = 10;
            this.trackBarRoll.Scroll += new System.EventHandler(this.gimbalTrackbar_Scroll);
            // 
            // groupBoxYaw
            // 
            this.groupBoxYaw.Controls.Add(this.TXT_gimbalYawPos);
            this.groupBoxYaw.Controls.Add(this.trackBarYaw);
            this.groupBoxYaw.Location = new Point(144, 6);
            this.groupBoxYaw.Name = "groupBoxYaw";
            this.groupBoxYaw.Size = new Size(178, 76);
            this.groupBoxYaw.TabIndex = 5;
            this.groupBoxYaw.TabStop = false;
            this.groupBoxYaw.Text = "Pan";
            // 
            // TXT_gimbalYawPos
            // 
            this.TXT_gimbalYawPos.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourcePayloadTab, "campointc", true));
            this.TXT_gimbalYawPos.Location = new Point(6, 18);
            this.TXT_gimbalYawPos.Name = "TXT_gimbalYawPos";
            this.TXT_gimbalYawPos.Size = new Size(51, 20);
            this.TXT_gimbalYawPos.TabIndex = 3;
            // 
            // trackBarYaw
            // 
            this.trackBarYaw.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.trackBarYaw.LargeChange = 10;
            this.trackBarYaw.Location = new Point(63, 18);
            this.trackBarYaw.Maximum = 45;
            this.trackBarYaw.Minimum = -45;
            this.trackBarYaw.Name = "trackBarYaw";
            this.trackBarYaw.Size = new Size(104, 45);
            this.trackBarYaw.TabIndex = 1;
            this.trackBarYaw.TickFrequency = 10;
            this.trackBarYaw.Scroll += new System.EventHandler(this.gimbalTrackbar_Scroll);
            // 
            // BUT_resetGimbalPos
            // 
            this.BUT_resetGimbalPos.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BUT_resetGimbalPos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BUT_resetGimbalPos.Location = new Point(10, 134);
            this.BUT_resetGimbalPos.Name = "BUT_resetGimbalPos";
            this.BUT_resetGimbalPos.Size = new Size(56, 23);
            this.BUT_resetGimbalPos.TabIndex = 2;
            this.BUT_resetGimbalPos.Text = "Reset Position";
            this.BUT_resetGimbalPos.UseVisualStyleBackColor = true;
            this.BUT_resetGimbalPos.Click += new System.EventHandler(this.BUT_resetGimbalPos_Click);
            // 
            // groupBoxPitch
            // 
            this.groupBoxPitch.Controls.Add(this.trackBarPitch);
            this.groupBoxPitch.Controls.Add(this.TXT_gimbalPitchPos);
            this.groupBoxPitch.Location = new Point(10, 6);
            this.groupBoxPitch.Name = "groupBoxPitch";
            this.groupBoxPitch.Size = new Size(119, 124);
            this.groupBoxPitch.TabIndex = 4;
            this.groupBoxPitch.TabStop = false;
            this.groupBoxPitch.Text = "Tilt";
            // 
            // trackBarPitch
            // 
            this.trackBarPitch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.trackBarPitch.LargeChange = 10;
            this.trackBarPitch.Location = new Point(62, 11);
            this.trackBarPitch.Maximum = 45;
            this.trackBarPitch.Minimum = -45;
            this.trackBarPitch.Name = "trackBarPitch";
            this.trackBarPitch.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarPitch.Size = new Size(45, 104);
            this.trackBarPitch.SmallChange = 5;
            this.trackBarPitch.TabIndex = 1;
            this.trackBarPitch.TickFrequency = 10;
            this.trackBarPitch.Scroll += new System.EventHandler(this.gimbalTrackbar_Scroll);
            // 
            // TXT_gimbalPitchPos
            // 
            this.TXT_gimbalPitchPos.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourcePayloadTab, "campointa", true));
            this.TXT_gimbalPitchPos.Location = new Point(6, 18);
            this.TXT_gimbalPitchPos.Name = "TXT_gimbalPitchPos";
            this.TXT_gimbalPitchPos.Size = new Size(50, 20);
            this.TXT_gimbalPitchPos.TabIndex = 3;
            // 
            // tableMap
            // 
            this.tableMap.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableMap.ColumnCount = 1;
            this.tableMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableMap.Controls.Add(this.splitContainer1, 0, 0);
            this.tableMap.Controls.Add(this.panel1, 0, 1);
            this.tableMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableMap.Location = new Point(0, 0);
            this.tableMap.Name = "tableMap";
            this.tableMap.RowCount = 2;
            this.tableMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableMap.Size = new Size(642, 460);
            this.tableMap.TabIndex = 75;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new Point(4, 4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
         
            this.splitContainer1.Panel1Collapsed = true;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.ContextMenuStrip = this.contextMenuStripMap;
            this.splitContainer1.Panel2.Controls.Add(this.but_disablejoystick);
            this.splitContainer1.Panel2.Controls.Add(this.distanceBar1);
            this.splitContainer1.Panel2.Controls.Add(this.windDir1);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_hdop);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_sats);
            this.splitContainer1.Panel2.Controls.Add(this.gMapControl1);
            this.splitContainer1.Panel2.Controls.Add(this.TRK_zoom);
            this.splitContainer1.Size = new Size(634, 418);
            this.splitContainer1.SplitterDistance = 210;
            this.splitContainer1.TabIndex = 76;
            // 
            // zg1
            // 
      
            // 
            // contextMenuStripMap
            // 
            this.contextMenuStripMap.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goHereToolStripMenuItem,
            this.flyToHereAltToolStripMenuItem,
            this.addPoiToolStripMenuItem,
            this.pointCameraHereToolStripMenuItem,
            this.PointCameraCoordsToolStripMenuItem1,
            this.triggerCameraToolStripMenuItem,
            this.flightPlannerToolStripMenuItem,
            this.setHomeHereToolStripMenuItem,
            this.takeOffToolStripMenuItem,
            this.onOffCameraOverlapToolStripMenuItem,
            this.altitudeAngelSettingsToolStripMenuItem});
            this.contextMenuStripMap.Name = "contextMenuStrip1";
            this.contextMenuStripMap.Size = new Size(196, 246);
            // 
            // goHereToolStripMenuItem
            // 
            this.goHereToolStripMenuItem.Name = "goHereToolStripMenuItem";
            this.goHereToolStripMenuItem.Size = new Size(195, 22);
            this.goHereToolStripMenuItem.Text = "Fly To Here";
            this.goHereToolStripMenuItem.Click += new System.EventHandler(this.goHereToolStripMenuItem_Click);
            // 
            // flyToHereAltToolStripMenuItem
            // 
            this.flyToHereAltToolStripMenuItem.Name = "flyToHereAltToolStripMenuItem";
            this.flyToHereAltToolStripMenuItem.Size = new Size(195, 22);
            this.flyToHereAltToolStripMenuItem.Text = "Fly To Here Alt";
            this.flyToHereAltToolStripMenuItem.Click += new System.EventHandler(this.flyToHereAltToolStripMenuItem_Click);
            // 
            // addPoiToolStripMenuItem
            // 
            this.addPoiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem,
            this.saveFileToolStripMenuItem,
            this.loadFileToolStripMenuItem});
            this.addPoiToolStripMenuItem.Name = "addPoiToolStripMenuItem";
            this.addPoiToolStripMenuItem.Size = new Size(195, 22);
            this.addPoiToolStripMenuItem.Text = "Add Poi";
            this.addPoiToolStripMenuItem.Click += new System.EventHandler(this.addPoiToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new Size(121, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.Size = new Size(121, 22);
            this.saveFileToolStripMenuItem.Text = "Save File";
            this.saveFileToolStripMenuItem.Click += new System.EventHandler(this.saveFileToolStripMenuItem_Click);
            // 
            // loadFileToolStripMenuItem
            // 
            this.loadFileToolStripMenuItem.Name = "loadFileToolStripMenuItem";
            this.loadFileToolStripMenuItem.Size = new Size(121, 22);
            this.loadFileToolStripMenuItem.Text = "Load File";
            this.loadFileToolStripMenuItem.Click += new System.EventHandler(this.loadFileToolStripMenuItem_Click);
            // 
            // pointCameraHereToolStripMenuItem
            // 
            this.pointCameraHereToolStripMenuItem.Name = "pointCameraHereToolStripMenuItem";
            this.pointCameraHereToolStripMenuItem.Size = new Size(195, 22);
            this.pointCameraHereToolStripMenuItem.Text = "Point Camera Here";
            this.pointCameraHereToolStripMenuItem.Click += new System.EventHandler(this.pointCameraHereToolStripMenuItem_Click);
            // 
            // PointCameraCoordsToolStripMenuItem1
            // 
            this.PointCameraCoordsToolStripMenuItem1.Name = "PointCameraCoordsToolStripMenuItem1";
            this.PointCameraCoordsToolStripMenuItem1.Size = new Size(195, 22);
            this.PointCameraCoordsToolStripMenuItem1.Text = "Point Camera Coords";
            this.PointCameraCoordsToolStripMenuItem1.Click += new System.EventHandler(this.PointCameraCoordsToolStripMenuItem1_Click);
            // 
            // triggerCameraToolStripMenuItem
            // 
            this.triggerCameraToolStripMenuItem.Name = "triggerCameraToolStripMenuItem";
            this.triggerCameraToolStripMenuItem.Size = new Size(195, 22);
            this.triggerCameraToolStripMenuItem.Text = "Trigger Camera NOW";
            this.triggerCameraToolStripMenuItem.Click += new System.EventHandler(this.triggerCameraToolStripMenuItem_Click);
            // 
            // flightPlannerToolStripMenuItem
            // 
            this.flightPlannerToolStripMenuItem.Name = "flightPlannerToolStripMenuItem";
            this.flightPlannerToolStripMenuItem.Size = new Size(195, 22);
            this.flightPlannerToolStripMenuItem.Text = "Flight Planner";
            this.flightPlannerToolStripMenuItem.Click += new System.EventHandler(this.flightPlannerToolStripMenuItem_Click);
            // 
            // setHomeHereToolStripMenuItem
            // 
            this.setHomeHereToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setEKFHomeHereToolStripMenuItem,
            this.setHomeHereToolStripMenuItem1});
            this.setHomeHereToolStripMenuItem.Name = "setHomeHereToolStripMenuItem";
            this.setHomeHereToolStripMenuItem.Size = new Size(195, 22);
            this.setHomeHereToolStripMenuItem.Text = "Set Home Here";
            this.setHomeHereToolStripMenuItem.Click += new System.EventHandler(this.setHomeHereToolStripMenuItem_Click);
            // 
            // setEKFHomeHereToolStripMenuItem
            // 
            this.setEKFHomeHereToolStripMenuItem.Name = "setEKFHomeHereToolStripMenuItem";
            this.setEKFHomeHereToolStripMenuItem.Size = new Size(176, 22);
            this.setEKFHomeHereToolStripMenuItem.Text = "Set EKF Origin Here";
            this.setEKFHomeHereToolStripMenuItem.Click += new System.EventHandler(this.setEKFHomeHereToolStripMenuItem_Click);
            // 
            // setHomeHereToolStripMenuItem1
            // 
            this.setHomeHereToolStripMenuItem1.Name = "setHomeHereToolStripMenuItem1";
            this.setHomeHereToolStripMenuItem1.Size = new Size(176, 22);
            this.setHomeHereToolStripMenuItem1.Text = "Set Home Here";
            this.setHomeHereToolStripMenuItem1.Click += new System.EventHandler(this.setHomeHereToolStripMenuItem_Click);
            // 
            // takeOffToolStripMenuItem
            // 
            this.takeOffToolStripMenuItem.Name = "takeOffToolStripMenuItem";
            this.takeOffToolStripMenuItem.Size = new Size(195, 22);
            this.takeOffToolStripMenuItem.Text = "TakeOff";
            this.takeOffToolStripMenuItem.Click += new System.EventHandler(this.takeOffToolStripMenuItem_Click);
            // 
            // onOffCameraOverlapToolStripMenuItem
            // 
            this.onOffCameraOverlapToolStripMenuItem.CheckOnClick = true;
            this.onOffCameraOverlapToolStripMenuItem.Name = "onOffCameraOverlapToolStripMenuItem";
            this.onOffCameraOverlapToolStripMenuItem.Size = new Size(195, 22);
            this.onOffCameraOverlapToolStripMenuItem.Text = "Camera Overlap";
            this.onOffCameraOverlapToolStripMenuItem.Click += new System.EventHandler(this.onOffCameraOverlapToolStripMenuItem_Click);
            // 
            // altitudeAngelSettingsToolStripMenuItem
            // 
            this.altitudeAngelSettingsToolStripMenuItem.Name = "altitudeAngelSettingsToolStripMenuItem";
            this.altitudeAngelSettingsToolStripMenuItem.Size = new Size(195, 22);
            this.altitudeAngelSettingsToolStripMenuItem.Text = "Altitude Angel Settings";
            this.altitudeAngelSettingsToolStripMenuItem.Click += new System.EventHandler(this.altitudeAngelSettingsToolStripMenuItem_Click);
            // 
            // but_disablejoystick
            // 
            this.but_disablejoystick.ColorMouseDown = Color.Empty;
            this.but_disablejoystick.ColorMouseOver = Color.Empty;
            this.but_disablejoystick.ColorNotEnabled = Color.Empty;
            this.but_disablejoystick.DialogResult = System.Windows.Forms.DialogResult.None;
            this.but_disablejoystick.Location = new Point(4, 67);
            this.but_disablejoystick.Name = "but_disablejoystick";
            this.but_disablejoystick.Size = new Size(56, 23);
            this.but_disablejoystick.TabIndex = 77;
            this.but_disablejoystick.Text = "Disable Joystick";
            this.but_disablejoystick.UseVisualStyleBackColor = true;
            this.but_disablejoystick.Visible = false;
            this.but_disablejoystick.Click += new System.EventHandler(this.but_disablejoystick_Click);
            // 
            // distanceBar1
            // 
            this.distanceBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.distanceBar1.BackColor = Color.Transparent;
            this.distanceBar1.Location = new Point(66, 0);
            this.distanceBar1.Name = "distanceBar1";
            this.distanceBar1.Size = new Size(517, 22);
            this.distanceBar1.TabIndex = 76;
            this.distanceBar1.totaldist = 100F;
            this.distanceBar1.traveleddist = 0F;
            // 
            // windDir1
            // 
            this.windDir1.BackColor = Color.Transparent;
            this.windDir1.DataBindings.Add(new System.Windows.Forms.Binding("Direction", this.bindingSource1, "wind_dir", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.windDir1.DataBindings.Add(new System.Windows.Forms.Binding("Speed", this.bindingSource1, "wind_vel", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.windDir1.Direction = 360D;
            this.windDir1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            this.windDir1.Location = new Point(0, 0);
            this.windDir1.Name = "windDir1";
            this.windDir1.Size = new Size(60, 60);
            this.windDir1.Speed = 0D;
            this.windDir1.TabIndex = 75;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(MissionPlanner.CurrentState);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.BackColor = Color.Black;
            this.label6.ForeColor = Color.White;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new Point(332, 388);
            this.label6.Name = "label6";
            this.label6.Size = new Size(96, 13);
            this.label6.TabIndex = 74;
            this.label6.Tag = "custom";
            this.label6.Text = "GPS Track (Black)";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.ForeColor = Color.Green;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new Point(245, 388);
            this.label5.Name = "label5";
            this.label5.Size = new Size(81, 13);
            this.label5.TabIndex = 73;
            this.label5.Tag = "custom";
            this.label5.Text = "Target Heading";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new Point(135, 388);
            this.label3.Name = "label3";
            this.label3.Size = new Size(104, 13);
            this.label3.TabIndex = 71;
            this.label3.Tag = "custom";
            this.label3.Text = "Direct to current WP";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.ForeColor = Color.Red;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new Point(45, 388);
            this.label4.Name = "label4";
            this.label4.Size = new Size(84, 13);
            this.label4.TabIndex = 72;
            this.label4.Tag = "custom";
            this.label4.Text = "Current Heading";
            // 
            // lbl_hdop
            // 
            this.lbl_hdop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_hdop.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "gpshdop", true, System.Windows.Forms.DataSourceUpdateMode.Never, null, "hdop: 0.0"));
            this.lbl_hdop.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_hdop.Location = new Point(-1, 370);
            this.lbl_hdop.Name = "lbl_hdop";
            this.lbl_hdop.resize = true;
            this.lbl_hdop.Size = new Size(43, 12);
            this.lbl_hdop.TabIndex = 70;
            this.lbl_hdop.Text = "hdop: 0";
            this.toolTip1.SetToolTip(this.lbl_hdop, "gps hdop");
            // 
            // lbl_sats
            // 
            this.lbl_sats.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_sats.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "satcount", true, System.Windows.Forms.DataSourceUpdateMode.Never, null, "Sats: 0"));
            this.lbl_sats.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_sats.Location = new Point(-1, 389);
            this.lbl_sats.Name = "lbl_sats";
            this.lbl_sats.resize = true;
            this.lbl_sats.Size = new Size(40, 12);
            this.lbl_sats.TabIndex = 71;
            this.lbl_sats.Text = "Sats: 0";
            this.toolTip1.SetToolTip(this.lbl_sats, "Satallite Count");
            // 
            // gMapControl1
            // 
            this.gMapControl1.BackColor = Color.Black;
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.ContextMenuStrip = this.contextMenuStripMap;
            this.gMapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gMapControl1.EmptyTileColor = Color.Gray;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.HoldInvalidation = false;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new Point(0, 0);
            this.gMapControl1.Margin = new System.Windows.Forms.Padding(0);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 24;
            this.gMapControl1.MinZoom = 0;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionWithoutCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Fractional;
            this.gMapControl1.SelectedAreaFillColor = Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new Size(589, 418);
            this.gMapControl1.TabIndex = 0;
            this.gMapControl1.Zoom = 3D;
            this.gMapControl1.OnPositionChanged += new GMap.NET.PositionChanged(this.gMapControl1_OnPositionChanged);
            this.gMapControl1.Click += new System.EventHandler(this.gMapControl1_Click);
            this.gMapControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gMapControl1_MouseDown);
            this.gMapControl1.MouseLeave += new System.EventHandler(this.gMapControl1_MouseLeave);
            this.gMapControl1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gMapControl1_MouseMove);
            // 
            // TRK_zoom
            // 
            this.TRK_zoom.Dock = System.Windows.Forms.DockStyle.Right;
            this.TRK_zoom.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TRK_zoom.LargeChange = 1F;
            this.TRK_zoom.Location = new Point(589, 0);
            this.TRK_zoom.Maximum = 24F;
            this.TRK_zoom.Minimum = 1F;
            this.TRK_zoom.Name = "TRK_zoom";
            this.TRK_zoom.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.TRK_zoom.Size = new Size(45, 418);
            this.TRK_zoom.SmallChange = 1F;
            this.TRK_zoom.TabIndex = 72;
            this.TRK_zoom.TickFrequency = 1F;
            this.TRK_zoom.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.TRK_zoom.Value = 1F;
            this.TRK_zoom.Scroll += new System.EventHandler(this.TRK_zoom_Scroll);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.coords1);
            this.panel1.Controls.Add(this.Zoomlevel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CHK_autopan);
            this.panel1.Controls.Add(this.CB_tuning);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new Point(1, 426);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(640, 33);
            this.panel1.TabIndex = 0;
            // 
            // coords1
            // 
            this.coords1.Alt = 0D;
            this.coords1.AltSource = "";
            this.coords1.AltUnit = "m";
            this.coords1.DataBindings.Add(new System.Windows.Forms.Binding("Alt", this.bindingSource1, "alt", true));
            this.coords1.DataBindings.Add(new System.Windows.Forms.Binding("Lat", this.bindingSource1, "lat", true));
            this.coords1.DataBindings.Add(new System.Windows.Forms.Binding("Lng", this.bindingSource1, "lng", true));
            this.coords1.Lat = 0D;
            this.coords1.Lng = 0D;
            this.coords1.Location = new Point(7, 4);
            this.coords1.Name = "coords1";
            this.coords1.Size = new Size(247, 21);
            this.coords1.TabIndex = 71;
            this.coords1.Vertical = false;
            // 
            // Zoomlevel
            // 
            this.Zoomlevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Zoomlevel.DecimalPlaces = 1;
            this.Zoomlevel.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.Zoomlevel.Location = new Point(438, 11);
            this.Zoomlevel.Maximum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.Zoomlevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Zoomlevel.Name = "Zoomlevel";
            this.Zoomlevel.Size = new Size(76, 20);
            this.Zoomlevel.TabIndex = 69;
            this.toolTip1.SetToolTip(this.Zoomlevel, "Change Zoom Level");
            this.Zoomlevel.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Zoomlevel.ValueChanged += new System.EventHandler(this.Zoomlevel_ValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new Point(401, 14);
            this.label1.Name = "label1";
            this.label1.resize = false;
            this.label1.Size = new Size(34, 13);
            this.label1.TabIndex = 70;
            this.label1.Text = "Zoom";
            // 
            // CHK_autopan
            // 
            this.CHK_autopan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CHK_autopan.AutoSize = true;
            this.CHK_autopan.Checked = true;
            this.CHK_autopan.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CHK_autopan.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CHK_autopan.Location = new Point(325, 14);
            this.CHK_autopan.Name = "CHK_autopan";
            this.CHK_autopan.Size = new Size(70, 17);
            this.CHK_autopan.TabIndex = 68;
            this.CHK_autopan.Text = "Auto Pan";
            this.toolTip1.SetToolTip(this.CHK_autopan, "Makes the map autopan based on current location");
            this.CHK_autopan.UseVisualStyleBackColor = true;
            this.CHK_autopan.CheckedChanged += new System.EventHandler(this.CHK_autopan_CheckedChanged);
            // 
            // CB_tuning
            // 
            this.CB_tuning.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CB_tuning.AutoSize = true;
            this.CB_tuning.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CB_tuning.Location = new Point(260, 13);
            this.CB_tuning.Name = "CB_tuning";
            this.CB_tuning.Size = new Size(59, 17);
            this.CB_tuning.TabIndex = 62;
            this.CB_tuning.Text = "Tuning";
            this.toolTip1.SetToolTip(this.CB_tuning, "Show the tunning graph, chowing target attitudes vs actual");
            this.CB_tuning.UseVisualStyleBackColor = true;
            this.CB_tuning.CheckedChanged += new System.EventHandler(this.CB_tuning_CheckedChanged);
  
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(226)))), ((int)(((byte)(150)))));
            this.toolTip1.ForeColor = Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(148)))), ((int)(((byte)(41)))));
            // 
            // openScriptDialog
            // 
            this.openScriptDialog.Filter = "Python Files|*.py|All files|*.*";
            // 
            // scriptChecker
            // 
            this.scriptChecker.Tick += new System.EventHandler(this.scriptChecker_Tick);
            // 
            // dataGridViewImageColumn1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewImageColumn1.HeaderText = "Up";
    
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 20;
            // 
            // dataGridViewImageColumn2
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewImageColumn2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewImageColumn2.HeaderText = "Down";
       
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 20;
            // 
            // Messagetabtimer
            // 
            this.Messagetabtimer.Interval = 200;
            this.Messagetabtimer.Tick += new System.EventHandler(this.Messagetabtimer_Tick);
            // 
            // bindingSourceStatusTab
            // 
            this.bindingSourceStatusTab.DataSource = typeof(MissionPlanner.CurrentState);
            // 
            // FlightData
            // 
            this.Controls.Add(this.MainH);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MinimumSize = new Size(1008, 462);
            this.Name = "FlightData";
            this.Size = new Size(1008, 462);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FlightData_FormClosing);
            this.Load += new System.EventHandler(this.FlightData_Load);
            this.Resize += new System.EventHandler(this.FlightData_Resize);
            this.ParentChanged += new System.EventHandler(this.FlightData_ParentChanged);
            this.MainH.Panel1.ResumeLayout(false);
            this.MainH.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainH)).EndInit();
            this.MainH.ResumeLayout(false);
            this.SubMainLeft.Panel1.ResumeLayout(false);
            this.SubMainLeft.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SubMainLeft)).EndInit();
            this.SubMainLeft.ResumeLayout(false);
            this.contextMenuStripHud.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHud)).EndInit();
            this.tabControlactions.ResumeLayout(false);
            this.contextMenuStripactionstab.ResumeLayout(false);
            this.tabQuick.ResumeLayout(false);
            this.tableLayoutPanelQuick.ResumeLayout(false);
            this.contextMenuStripQuickView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceQuickTab)).EndInit();
            this.tabActions.ResumeLayout(false);
            this.tabActionsSimple.ResumeLayout(false);
            this.tabPagePreFlight.ResumeLayout(false);
            this.tabGauges.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceGaugesTab)).EndInit();
            this.tabServo.ResumeLayout(false);
            this.flowLayoutPanelServos.ResumeLayout(false);
            this.tabTLogs.ResumeLayout(false);
            this.tableLayoutPaneltlogs.ResumeLayout(false);
            this.tableLayoutPaneltlogs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tracklog)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tablogbrowse.ResumeLayout(false);
            this.tabScripts.ResumeLayout(false);
            this.tabScripts.PerformLayout();
            this.tabPagemessages.ResumeLayout(false);
            this.tabPagemessages.PerformLayout();
            this.tabPayload.ResumeLayout(false);
            this.groupBoxRoll.ResumeLayout(false);
            this.groupBoxRoll.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePayloadTab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRoll)).EndInit();
            this.groupBoxYaw.ResumeLayout(false);
            this.groupBoxYaw.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarYaw)).EndInit();
            this.groupBoxPitch.ResumeLayout(false);
            this.groupBoxPitch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPitch)).EndInit();
            this.tableMap.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.contextMenuStripMap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TRK_zoom)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Zoomlevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceStatusTab)).EndInit();
            this.ResumeLayout(false);

        }



        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Timer ZedGraphTimer;
        private System.Windows.Forms.SplitContainer MainH;
        private System.Windows.Forms.SplitContainer SubMainLeft;
        private System.Windows.Forms.ToolStripMenuItem goHereToolStripMenuItem;
        private Controls.HUD hud1;
        private Controls.MyButton BUT_clear_track;
        private System.Windows.Forms.CheckBox CB_tuning;
        private Controls.MyButton BUT_RAWSensor;
        private Controls.MyButton BUTactiondo;
        private Controls.MyButton BUTrestartmission;
        private System.Windows.Forms.ComboBox CMB_action;
        private Controls.MyButton BUT_Homealt;
        private System.Windows.Forms.TrackBar tracklog;
        private Controls.MyButton BUT_playlog;
        private Controls.MyButton BUT_loadtelem;
        private AGaugeApp.AGauge Galt;
        private AGaugeApp.AGauge Gspeed;
        private AGaugeApp.AGauge Gvspeed;
        private System.Windows.Forms.TableLayoutPanel tableMap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown Zoomlevel;
        private Controls.MyLabel label1;
        private System.Windows.Forms.CheckBox CHK_autopan;
        public Controls.myGMAP gMapControl1;
        //private ZedGraph.ZedGraphControl zg1;
        public System.Windows.Forms.TabControl tabControlactions;
        public System.Windows.Forms.TabPage tabGauges;
        public System.Windows.Forms.TabPage tabStatus;
        public System.Windows.Forms.TabPage tabActions;
        public System.Windows.Forms.TabPage tabTLogs;
        private System.Windows.Forms.ComboBox CMB_modes;
        private Controls.MyButton BUT_setmode;
        private System.Windows.Forms.ComboBox CMB_setwp;
        private Controls.MyButton BUT_setwp;
        private Controls.MyButton BUT_quickmanual;
        private Controls.MyButton BUT_quickrtl;
        private Controls.MyButton BUT_quickauto;
        private Controls.MyButton BUT_log2kml;
        private Controls.MyButton BUT_joystick;
        private System.Windows.Forms.ToolTip toolTip1;
        private Controls.MyLabel lbl_logpercent;
        private System.Windows.Forms.ToolStripMenuItem pointCameraHereToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private Controls.MyLabel lbl_hdop;
        private Controls.MyLabel lbl_sats;
        private Controls.HSI Gheading;
        private Controls.MyLabel lbl_playbackspeed;
        private System.Windows.Forms.ToolStripMenuItem setAspectRatioToolStripMenuItem;
        public System.Windows.Forms.TabPage tabQuick;
        private Controls.QuickView quickView3;
        private Controls.QuickView quickView2;
        private Controls.QuickView quickView1;
        private Controls.QuickView quickView4;
        private Controls.QuickView quickView6;
        private Controls.QuickView quickView5;
        private System.Windows.Forms.ToolStripMenuItem flyToHereAltToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flightPlannerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userItemsToolStripMenuItem;
        //private Crom.Controls.Docking.DockContainer dockContainer1;
        private Controls.MyButton BUT_ARM;
        private Controls.ModifyandSet modifyandSetAlt;
        private Controls.ModifyandSet modifyandSetSpeed;
        private System.Windows.Forms.ToolStripMenuItem triggerCameraToolStripMenuItem;
        private Controls.MyTrackBar TRK_zoom;
        private Controls.MyLabel LBL_logfn;
        public System.Windows.Forms.TabPage tabServo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelServos;
        private Controls.ServoOptions servoOptions1;
        private Controls.ServoOptions servoOptions2;
        private Controls.ServoOptions servoOptions3;
        private Controls.ServoOptions servoOptions4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPaneltlogs;
        private Controls.ServoOptions servoOptions5;
        private Controls.ServoOptions servoOptions6;
        private Controls.ServoOptions servoOptions7;
        private Controls.ServoOptions servoOptions8;
        private Controls.ServoOptions servoOptions9;
        private Controls.ServoOptions servoOptions10;
        private System.Windows.Forms.BindingSource bindingSourceHud;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelQuick;
        private System.Windows.Forms.Panel panel2;
        private Controls.MyButton BUT_speed10;
        private Controls.MyButton BUT_speed5;
        private Controls.MyButton BUT_speed2;
        private Controls.MyButton BUT_speed1;
        private Controls.MyButton BUT_speed1_2;
        private Controls.MyButton BUT_speed1_4;
        private Controls.MyButton BUT_speed1_10;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TabPage tablogbrowse;
        private Controls.MyButton BUT_logbrowse;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TabPage tabScripts;
        private Controls.MyButton BUT_edit_selected;
        private System.Windows.Forms.Label labelSelectedScript;
        private Controls.MyButton BUT_run_script;
        private Controls.MyButton BUT_abort_script;
        private System.Windows.Forms.Label labelScriptStatus;
        private Controls.MyButton BUT_select_script;
        private System.Windows.Forms.OpenFileDialog openScriptDialog;
        private System.Windows.Forms.Timer scriptChecker;
        private System.Windows.Forms.CheckBox checkBoxRedirectOutput;
        private System.Windows.Forms.ToolStripMenuItem russianHudToolStripMenuItem;
        public System.Windows.Forms.ContextMenuStrip contextMenuStripMap;
        public System.Windows.Forms.ContextMenuStrip contextMenuStripHud;
        private System.Windows.Forms.BindingSource bindingSourceQuickTab;
        private System.Windows.Forms.BindingSource bindingSourceStatusTab;
        private System.Windows.Forms.BindingSource bindingSourceGaugesTab;
        private System.Windows.Forms.ToolStripMenuItem setHomeHereToolStripMenuItem;
        private MissionPlanner.Controls.Coords coords1;
        private Controls.MyButton BUT_matlab;
        private System.Windows.Forms.ComboBox CMB_mountmode;
        private Controls.MyButton BUT_mountmode;
        public Controls.WindDir windDir1;
        private Controls.MyButton but_bintolog;
        private Controls.MyButton but_dflogtokml;
        private Controls.MyButton BUT_DFMavlink;
        public System.Windows.Forms.TabPage tabPagemessages;
        private System.Windows.Forms.TextBox txt_messagebox;
        private System.Windows.Forms.Timer Messagetabtimer;
        public System.Windows.Forms.TabPage tabActionsSimple;
        private Controls.MyButton myButton1;
        private Controls.MyButton myButton2;
        private Controls.MyButton myButton3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripactionstab;
        private Controls.MyButton BUT_loganalysis;
        private System.Windows.Forms.ToolStripMenuItem addPoiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
        private Controls.DistanceBar distanceBar1;
        private System.Windows.Forms.ToolStripMenuItem takeOffToolStripMenuItem;
        private Controls.MyButton BUT_resumemis;
        public System.Windows.Forms.TabPage tabPagePreFlight;
        private Controls.PreFlight.CheckListControl checkListControl1;
        private System.Windows.Forms.ToolStripMenuItem swapWithMapToolStripMenuItem;
        private Controls.MyButton BUT_abortland;
        private Controls.MyButton but_disablejoystick;
        private System.Windows.Forms.ToolStripMenuItem videoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recordHudToAVIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setMJPEGSourceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startCameraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PointCameraCoordsToolStripMenuItem1;
        private Controls.ModifyandSet modifyandSetLoiterRad;
        private System.Windows.Forms.ToolStripMenuItem onOffCameraOverlapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altitudeAngelSettingsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripQuickView;
        private System.Windows.Forms.ToolStripMenuItem setViewCountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setGStreamerSourceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setEKFHomeHereToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPayload;
        private System.Windows.Forms.BindingSource bindingSourcePayloadTab;
        private System.Windows.Forms.TrackBar trackBarYaw;
        private System.Windows.Forms.TrackBar trackBarRoll;
        private System.Windows.Forms.TrackBar trackBarPitch;
        private Controls.MyButton BUT_resetGimbalPos;
        private System.Windows.Forms.TextBox TXT_gimbalPitchPos;
        private System.Windows.Forms.TextBox TXT_gimbalYawPos;
        private System.Windows.Forms.TextBox TXT_gimbalRollPos;
        private System.Windows.Forms.GroupBox groupBoxRoll;
        private System.Windows.Forms.GroupBox groupBoxYaw;
        private System.Windows.Forms.GroupBox groupBoxPitch;
        private Controls.MyButton BUT_PayloadFolder;
        private System.Windows.Forms.ToolStripMenuItem setHomeHereToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem groundColorToolStripMenuItem;
    }
}