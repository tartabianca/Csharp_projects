namespace SamplePanelRoboDK
{
    partial class FormRobot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRobot));
            this.btnSelectRobot = new System.Windows.Forms.Button();
            this.btnRun_Program = new System.Windows.Forms.Button();
            this.btnSelectStation = new System.Windows.Forms.Button();
            this.btnTXneg = new System.Windows.Forms.Button();
            this.btnTXpos = new System.Windows.Forms.Button();
            this.btnTYpos = new System.Windows.Forms.Button();
            this.btnTYneg = new System.Windows.Forms.Button();
            this.btnTZpos = new System.Windows.Forms.Button();
            this.btnTZneg = new System.Windows.Forms.Button();
            this.btnRXpos = new System.Windows.Forms.Button();
            this.btnRXneg = new System.Windows.Forms.Button();
            this.btnRYpos = new System.Windows.Forms.Button();
            this.btnRYneg = new System.Windows.Forms.Button();
            this.btnRZpos = new System.Windows.Forms.Button();
            this.btnRZneg = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.notifybar = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupRoboDKwindow = new System.Windows.Forms.GroupBox();
            this.rad_RoboDK_Integrated = new System.Windows.Forms.RadioButton();
            this.rad_RoboDK_hide = new System.Windows.Forms.RadioButton();
            this.rad_RoboDK_show = new System.Windows.Forms.RadioButton();
            this.groupIncrementalMove = new System.Windows.Forms.GroupBox();
            this.numStep = new System.Windows.Forms.NumericUpDown();
            this.lblstepIncrement = new System.Windows.Forms.Label();
            this.rad_Move_Joints = new System.Windows.Forms.RadioButton();
            this.rad_Move_wrt_Tool = new System.Windows.Forms.RadioButton();
            this.rad_Move_wrt_Reference = new System.Windows.Forms.RadioButton();
            this.btnMoveRobotHome = new System.Windows.Forms.Button();
            this.panel_rdk = new System.Windows.Forms.Panel();
            this.statusStrip1.SuspendLayout();
            this.groupRoboDKwindow.SuspendLayout();
            this.groupIncrementalMove.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStep)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelectRobot
            // 
            this.btnSelectRobot.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSelectRobot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectRobot.ForeColor = System.Drawing.Color.White;
            this.btnSelectRobot.Location = new System.Drawing.Point(145, 10);
            this.btnSelectRobot.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnSelectRobot.Name = "btnSelectRobot";
            this.btnSelectRobot.Size = new System.Drawing.Size(119, 26);
            this.btnSelectRobot.TabIndex = 14;
            this.btnSelectRobot.Text = "Select Robot";
            this.btnSelectRobot.UseVisualStyleBackColor = false;
            this.btnSelectRobot.Click += new System.EventHandler(this.btnSelectRobot_Click);
            // 
            // btnRun_Program
            // 
            this.btnRun_Program.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnRun_Program.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRun_Program.ForeColor = System.Drawing.Color.White;
            this.btnRun_Program.Location = new System.Drawing.Point(429, 57);
            this.btnRun_Program.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnRun_Program.Name = "btnRun_Program";
            this.btnRun_Program.Size = new System.Drawing.Size(71, 38);
            this.btnRun_Program.TabIndex = 23;
            this.btnRun_Program.Text = "Run";
            this.btnRun_Program.UseVisualStyleBackColor = false;
            this.btnRun_Program.Click += new System.EventHandler(this.btnRun_Program_Click);
            // 
            // btnSelectStation
            // 
            this.btnSelectStation.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSelectStation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectStation.ForeColor = System.Drawing.Color.White;
            this.btnSelectStation.Location = new System.Drawing.Point(14, 10);
            this.btnSelectStation.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnSelectStation.Name = "btnSelectStation";
            this.btnSelectStation.Size = new System.Drawing.Size(118, 26);
            this.btnSelectStation.TabIndex = 25;
            this.btnSelectStation.Text = "Load File";
            this.btnSelectStation.UseVisualStyleBackColor = false;
            this.btnSelectStation.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // btnTXneg
            // 
            this.btnTXneg.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnTXneg.ForeColor = System.Drawing.Color.White;
            this.btnTXneg.Location = new System.Drawing.Point(231, 36);
            this.btnTXneg.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnTXneg.Name = "btnTXneg";
            this.btnTXneg.Size = new System.Drawing.Size(47, 37);
            this.btnTXneg.TabIndex = 27;
            this.btnTXneg.Text = "X-";
            this.btnTXneg.UseVisualStyleBackColor = false;
            this.btnTXneg.Click += new System.EventHandler(this.btnTXneg_Click);
            // 
            // btnTXpos
            // 
            this.btnTXpos.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnTXpos.ForeColor = System.Drawing.Color.White;
            this.btnTXpos.Location = new System.Drawing.Point(231, 83);
            this.btnTXpos.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnTXpos.Name = "btnTXpos";
            this.btnTXpos.Size = new System.Drawing.Size(47, 37);
            this.btnTXpos.TabIndex = 28;
            this.btnTXpos.Text = "X+";
            this.btnTXpos.UseVisualStyleBackColor = false;
            this.btnTXpos.Click += new System.EventHandler(this.btnTXpos_Click);
            // 
            // btnTYpos
            // 
            this.btnTYpos.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnTYpos.ForeColor = System.Drawing.Color.White;
            this.btnTYpos.Location = new System.Drawing.Point(282, 83);
            this.btnTYpos.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnTYpos.Name = "btnTYpos";
            this.btnTYpos.Size = new System.Drawing.Size(47, 37);
            this.btnTYpos.TabIndex = 30;
            this.btnTYpos.Text = "Y+";
            this.btnTYpos.UseVisualStyleBackColor = false;
            this.btnTYpos.Click += new System.EventHandler(this.btnTYpos_Click);
            // 
            // btnTYneg
            // 
            this.btnTYneg.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnTYneg.ForeColor = System.Drawing.Color.White;
            this.btnTYneg.Location = new System.Drawing.Point(282, 36);
            this.btnTYneg.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnTYneg.Name = "btnTYneg";
            this.btnTYneg.Size = new System.Drawing.Size(47, 37);
            this.btnTYneg.TabIndex = 29;
            this.btnTYneg.Text = "Y-";
            this.btnTYneg.UseVisualStyleBackColor = false;
            this.btnTYneg.Click += new System.EventHandler(this.btnTYneg_Click);
            // 
            // btnTZpos
            // 
            this.btnTZpos.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnTZpos.ForeColor = System.Drawing.Color.White;
            this.btnTZpos.Location = new System.Drawing.Point(333, 83);
            this.btnTZpos.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnTZpos.Name = "btnTZpos";
            this.btnTZpos.Size = new System.Drawing.Size(46, 37);
            this.btnTZpos.TabIndex = 32;
            this.btnTZpos.Text = "Z+";
            this.btnTZpos.UseVisualStyleBackColor = false;
            this.btnTZpos.Click += new System.EventHandler(this.btnTZpos_Click);
            // 
            // btnTZneg
            // 
            this.btnTZneg.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnTZneg.ForeColor = System.Drawing.Color.White;
            this.btnTZneg.Location = new System.Drawing.Point(333, 36);
            this.btnTZneg.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnTZneg.Name = "btnTZneg";
            this.btnTZneg.Size = new System.Drawing.Size(46, 37);
            this.btnTZneg.TabIndex = 31;
            this.btnTZneg.Text = "Z-";
            this.btnTZneg.UseVisualStyleBackColor = false;
            this.btnTZneg.Click += new System.EventHandler(this.btnTZneg_Click);
            // 
            // btnRXpos
            // 
            this.btnRXpos.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnRXpos.ForeColor = System.Drawing.Color.White;
            this.btnRXpos.Location = new System.Drawing.Point(383, 83);
            this.btnRXpos.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnRXpos.Name = "btnRXpos";
            this.btnRXpos.Size = new System.Drawing.Size(42, 37);
            this.btnRXpos.TabIndex = 34;
            this.btnRXpos.Text = "rX+";
            this.btnRXpos.UseVisualStyleBackColor = false;
            this.btnRXpos.Click += new System.EventHandler(this.btnRXpos_Click);
            // 
            // btnRXneg
            // 
            this.btnRXneg.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnRXneg.ForeColor = System.Drawing.Color.White;
            this.btnRXneg.Location = new System.Drawing.Point(383, 36);
            this.btnRXneg.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnRXneg.Name = "btnRXneg";
            this.btnRXneg.Size = new System.Drawing.Size(42, 37);
            this.btnRXneg.TabIndex = 33;
            this.btnRXneg.Text = "rX-";
            this.btnRXneg.UseVisualStyleBackColor = false;
            this.btnRXneg.Click += new System.EventHandler(this.btnRXneg_Click);
            // 
            // btnRYpos
            // 
            this.btnRYpos.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnRYpos.ForeColor = System.Drawing.Color.White;
            this.btnRYpos.Location = new System.Drawing.Point(429, 83);
            this.btnRYpos.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnRYpos.Name = "btnRYpos";
            this.btnRYpos.Size = new System.Drawing.Size(42, 37);
            this.btnRYpos.TabIndex = 36;
            this.btnRYpos.Text = "rY+";
            this.btnRYpos.UseVisualStyleBackColor = false;
            this.btnRYpos.Click += new System.EventHandler(this.btnRYpos_Click);
            // 
            // btnRYneg
            // 
            this.btnRYneg.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnRYneg.ForeColor = System.Drawing.Color.White;
            this.btnRYneg.Location = new System.Drawing.Point(429, 36);
            this.btnRYneg.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnRYneg.Name = "btnRYneg";
            this.btnRYneg.Size = new System.Drawing.Size(42, 37);
            this.btnRYneg.TabIndex = 35;
            this.btnRYneg.Text = "rY-";
            this.btnRYneg.UseVisualStyleBackColor = false;
            this.btnRYneg.Click += new System.EventHandler(this.btnRYneg_Click);
            // 
            // btnRZpos
            // 
            this.btnRZpos.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnRZpos.ForeColor = System.Drawing.Color.White;
            this.btnRZpos.Location = new System.Drawing.Point(475, 83);
            this.btnRZpos.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnRZpos.Name = "btnRZpos";
            this.btnRZpos.Size = new System.Drawing.Size(41, 37);
            this.btnRZpos.TabIndex = 38;
            this.btnRZpos.Text = "rZ+";
            this.btnRZpos.UseVisualStyleBackColor = false;
            this.btnRZpos.Click += new System.EventHandler(this.btnRZpos_Click);
            // 
            // btnRZneg
            // 
            this.btnRZneg.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnRZneg.ForeColor = System.Drawing.Color.White;
            this.btnRZneg.Location = new System.Drawing.Point(475, 36);
            this.btnRZneg.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnRZneg.Name = "btnRZneg";
            this.btnRZneg.Size = new System.Drawing.Size(41, 37);
            this.btnRZneg.TabIndex = 37;
            this.btnRZneg.Text = "rZ-";
            this.btnRZneg.UseVisualStyleBackColor = false;
            this.btnRZneg.Click += new System.EventHandler(this.btnRZneg_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.notifybar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 462);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1305, 22);
            this.statusStrip1.TabIndex = 44;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // notifybar
            // 
            this.notifybar.Name = "notifybar";
            this.notifybar.Size = new System.Drawing.Size(95, 17);
            this.notifybar.Text = "Notification area";
            // 
            // groupRoboDKwindow
            // 
            this.groupRoboDKwindow.Controls.Add(this.rad_RoboDK_Integrated);
            this.groupRoboDKwindow.Controls.Add(this.rad_RoboDK_hide);
            this.groupRoboDKwindow.Controls.Add(this.rad_RoboDK_show);
            this.groupRoboDKwindow.Location = new System.Drawing.Point(15, 41);
            this.groupRoboDKwindow.Margin = new System.Windows.Forms.Padding(4);
            this.groupRoboDKwindow.Name = "groupRoboDKwindow";
            this.groupRoboDKwindow.Padding = new System.Windows.Forms.Padding(4);
            this.groupRoboDKwindow.Size = new System.Drawing.Size(249, 143);
            this.groupRoboDKwindow.TabIndex = 45;
            this.groupRoboDKwindow.TabStop = false;
            this.groupRoboDKwindow.Text = "Display Mode";
            // 
            // rad_RoboDK_Integrated
            // 
            this.rad_RoboDK_Integrated.AutoSize = true;
            this.rad_RoboDK_Integrated.Location = new System.Drawing.Point(15, 107);
            this.rad_RoboDK_Integrated.Margin = new System.Windows.Forms.Padding(4);
            this.rad_RoboDK_Integrated.Name = "rad_RoboDK_Integrated";
            this.rad_RoboDK_Integrated.Size = new System.Drawing.Size(196, 23);
            this.rad_RoboDK_Integrated.TabIndex = 2;
            this.rad_RoboDK_Integrated.TabStop = true;
            this.rad_RoboDK_Integrated.Text = "Integrate RoboDK Window";
            this.rad_RoboDK_Integrated.UseVisualStyleBackColor = true;
            this.rad_RoboDK_Integrated.CheckedChanged += new System.EventHandler(this.rad_RoboDK_Integrated_CheckedChanged);
            // 
            // rad_RoboDK_hide
            // 
            this.rad_RoboDK_hide.AutoSize = true;
            this.rad_RoboDK_hide.Location = new System.Drawing.Point(15, 69);
            this.rad_RoboDK_hide.Margin = new System.Windows.Forms.Padding(4);
            this.rad_RoboDK_hide.Name = "rad_RoboDK_hide";
            this.rad_RoboDK_hide.Size = new System.Drawing.Size(117, 23);
            this.rad_RoboDK_hide.TabIndex = 1;
            this.rad_RoboDK_hide.TabStop = true;
            this.rad_RoboDK_hide.Text = "Hide RoboDK";
            this.rad_RoboDK_hide.UseVisualStyleBackColor = true;
            this.rad_RoboDK_hide.CheckedChanged += new System.EventHandler(this.rad_RoboDK_hide_CheckedChanged);
            // 
            // rad_RoboDK_show
            // 
            this.rad_RoboDK_show.AutoSize = true;
            this.rad_RoboDK_show.Location = new System.Drawing.Point(15, 31);
            this.rad_RoboDK_show.Margin = new System.Windows.Forms.Padding(4);
            this.rad_RoboDK_show.Name = "rad_RoboDK_show";
            this.rad_RoboDK_show.Size = new System.Drawing.Size(123, 23);
            this.rad_RoboDK_show.TabIndex = 0;
            this.rad_RoboDK_show.TabStop = true;
            this.rad_RoboDK_show.Text = "Show RoboDK";
            this.rad_RoboDK_show.UseVisualStyleBackColor = true;
            this.rad_RoboDK_show.CheckedChanged += new System.EventHandler(this.rad_RoboDK_show_CheckedChanged);
            // 
            // groupIncrementalMove
            // 
            this.groupIncrementalMove.Controls.Add(this.numStep);
            this.groupIncrementalMove.Controls.Add(this.lblstepIncrement);
            this.groupIncrementalMove.Controls.Add(this.rad_Move_Joints);
            this.groupIncrementalMove.Controls.Add(this.rad_Move_wrt_Tool);
            this.groupIncrementalMove.Controls.Add(this.rad_Move_wrt_Reference);
            this.groupIncrementalMove.Controls.Add(this.btnTXneg);
            this.groupIncrementalMove.Controls.Add(this.btnTXpos);
            this.groupIncrementalMove.Controls.Add(this.btnTYneg);
            this.groupIncrementalMove.Controls.Add(this.btnTYpos);
            this.groupIncrementalMove.Controls.Add(this.btnRZpos);
            this.groupIncrementalMove.Controls.Add(this.btnTZneg);
            this.groupIncrementalMove.Controls.Add(this.btnRZneg);
            this.groupIncrementalMove.Controls.Add(this.btnTZpos);
            this.groupIncrementalMove.Controls.Add(this.btnRYpos);
            this.groupIncrementalMove.Controls.Add(this.btnRXneg);
            this.groupIncrementalMove.Controls.Add(this.btnRYneg);
            this.groupIncrementalMove.Controls.Add(this.btnRXpos);
            this.groupIncrementalMove.Location = new System.Drawing.Point(755, 12);
            this.groupIncrementalMove.Margin = new System.Windows.Forms.Padding(4);
            this.groupIncrementalMove.Name = "groupIncrementalMove";
            this.groupIncrementalMove.Padding = new System.Windows.Forms.Padding(4);
            this.groupIncrementalMove.Size = new System.Drawing.Size(537, 172);
            this.groupIncrementalMove.TabIndex = 46;
            this.groupIncrementalMove.TabStop = false;
            this.groupIncrementalMove.Text = "Incremental Move";
            // 
            // numStep
            // 
            this.numStep.DecimalPlaces = 1;
            this.numStep.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numStep.Location = new System.Drawing.Point(110, 113);
            this.numStep.Margin = new System.Windows.Forms.Padding(4);
            this.numStep.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numStep.Name = "numStep";
            this.numStep.Size = new System.Drawing.Size(105, 26);
            this.numStep.TabIndex = 48;
            // 
            // lblstepIncrement
            // 
            this.lblstepIncrement.AutoSize = true;
            this.lblstepIncrement.Location = new System.Drawing.Point(9, 118);
            this.lblstepIncrement.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblstepIncrement.Name = "lblstepIncrement";
            this.lblstepIncrement.Size = new System.Drawing.Size(76, 19);
            this.lblstepIncrement.TabIndex = 47;
            this.lblstepIncrement.Text = "Step (mm):";
            // 
            // rad_Move_Joints
            // 
            this.rad_Move_Joints.AutoSize = true;
            this.rad_Move_Joints.Location = new System.Drawing.Point(16, 83);
            this.rad_Move_Joints.Margin = new System.Windows.Forms.Padding(4);
            this.rad_Move_Joints.Name = "rad_Move_Joints";
            this.rad_Move_Joints.Size = new System.Drawing.Size(95, 23);
            this.rad_Move_Joints.TabIndex = 2;
            this.rad_Move_Joints.TabStop = true;
            this.rad_Move_Joints.Text = "Joint Move";
            this.rad_Move_Joints.UseVisualStyleBackColor = true;
            this.rad_Move_Joints.CheckedChanged += new System.EventHandler(this.rad_Move_Joints_CheckedChanged);
            // 
            // rad_Move_wrt_Tool
            // 
            this.rad_Move_wrt_Tool.AutoSize = true;
            this.rad_Move_wrt_Tool.Location = new System.Drawing.Point(16, 54);
            this.rad_Move_wrt_Tool.Margin = new System.Windows.Forms.Padding(4);
            this.rad_Move_wrt_Tool.Name = "rad_Move_wrt_Tool";
            this.rad_Move_wrt_Tool.Size = new System.Drawing.Size(54, 23);
            this.rad_Move_wrt_Tool.TabIndex = 1;
            this.rad_Move_wrt_Tool.TabStop = true;
            this.rad_Move_wrt_Tool.Text = "Tool";
            this.rad_Move_wrt_Tool.UseVisualStyleBackColor = true;
            this.rad_Move_wrt_Tool.CheckedChanged += new System.EventHandler(this.rad_Move_wrt_Tool_CheckedChanged);
            // 
            // rad_Move_wrt_Reference
            // 
            this.rad_Move_wrt_Reference.AutoSize = true;
            this.rad_Move_wrt_Reference.Location = new System.Drawing.Point(16, 25);
            this.rad_Move_wrt_Reference.Margin = new System.Windows.Forms.Padding(4);
            this.rad_Move_wrt_Reference.Name = "rad_Move_wrt_Reference";
            this.rad_Move_wrt_Reference.Size = new System.Drawing.Size(88, 23);
            this.rad_Move_wrt_Reference.TabIndex = 0;
            this.rad_Move_wrt_Reference.TabStop = true;
            this.rad_Move_wrt_Reference.Text = "Reference";
            this.rad_Move_wrt_Reference.UseVisualStyleBackColor = true;
            this.rad_Move_wrt_Reference.CheckedChanged += new System.EventHandler(this.rad_Move_wrt_Reference_CheckedChanged);
            // 
            // btnMoveRobotHome
            // 
            this.btnMoveRobotHome.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnMoveRobotHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoveRobotHome.ForeColor = System.Drawing.Color.White;
            this.btnMoveRobotHome.Location = new System.Drawing.Point(559, 57);
            this.btnMoveRobotHome.Margin = new System.Windows.Forms.Padding(4);
            this.btnMoveRobotHome.Name = "btnMoveRobotHome";
            this.btnMoveRobotHome.Size = new System.Drawing.Size(71, 38);
            this.btnMoveRobotHome.TabIndex = 51;
            this.btnMoveRobotHome.Text = "Home";
            this.btnMoveRobotHome.UseVisualStyleBackColor = false;
            this.btnMoveRobotHome.Click += new System.EventHandler(this.btnMoveRobotHome_Click);
            // 
            // panel_rdk
            // 
            this.panel_rdk.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_rdk.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_rdk.Location = new System.Drawing.Point(0, 201);
            this.panel_rdk.Margin = new System.Windows.Forms.Padding(4);
            this.panel_rdk.Name = "panel_rdk";
            this.panel_rdk.Size = new System.Drawing.Size(1318, 257);
            this.panel_rdk.TabIndex = 52;
            this.panel_rdk.Resize += new System.EventHandler(this.panel_Resized);
            // 
            // FormRobot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1305, 484);
            this.Controls.Add(this.btnMoveRobotHome);
            this.Controls.Add(this.groupIncrementalMove);
            this.Controls.Add(this.groupRoboDKwindow);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnSelectStation);
            this.Controls.Add(this.btnRun_Program);
            this.Controls.Add(this.btnSelectRobot);
            this.Controls.Add(this.panel_rdk);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1064, 523);
            this.Name = "FormRobot";
            this.Text = "Robot Panel HMI";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormRobot_FormClosed);
            this.Load += new System.EventHandler(this.FormRobot_Load);
            this.Shown += new System.EventHandler(this.FormRobot_Shown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupRoboDKwindow.ResumeLayout(false);
            this.groupRoboDKwindow.PerformLayout();
            this.groupIncrementalMove.ResumeLayout(false);
            this.groupIncrementalMove.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSelectRobot;
        private System.Windows.Forms.Button btnRun_Program;
        private System.Windows.Forms.Button btnSelectStation;
        private System.Windows.Forms.Button btnTXneg;
        private System.Windows.Forms.Button btnTXpos;
        private System.Windows.Forms.Button btnTYpos;
        private System.Windows.Forms.Button btnTYneg;
        private System.Windows.Forms.Button btnTZpos;
        private System.Windows.Forms.Button btnTZneg;
        private System.Windows.Forms.Button btnRXpos;
        private System.Windows.Forms.Button btnRXneg;
        private System.Windows.Forms.Button btnRYpos;
        private System.Windows.Forms.Button btnRYneg;
        private System.Windows.Forms.Button btnRZpos;
        private System.Windows.Forms.Button btnRZneg;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel notifybar;
        private System.Windows.Forms.GroupBox groupRoboDKwindow;
        private System.Windows.Forms.RadioButton rad_RoboDK_hide;
        private System.Windows.Forms.RadioButton rad_RoboDK_show;
        private System.Windows.Forms.GroupBox groupIncrementalMove;
        private System.Windows.Forms.RadioButton rad_Move_Joints;
        private System.Windows.Forms.RadioButton rad_Move_wrt_Tool;
        private System.Windows.Forms.RadioButton rad_Move_wrt_Reference;
        private System.Windows.Forms.Label lblstepIncrement;
        private System.Windows.Forms.NumericUpDown numStep;
        private System.Windows.Forms.Button btnMoveRobotHome;
        private System.Windows.Forms.RadioButton rad_RoboDK_Integrated;
        private System.Windows.Forms.Panel panel_rdk;
    }
}

