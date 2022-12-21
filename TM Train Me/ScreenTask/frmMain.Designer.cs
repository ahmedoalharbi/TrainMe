namespace ScreenTask
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.gbOptions = new System.Windows.Forms.GroupBox();
            this.cbAllowPublicAccess = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboIPs = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numPort = new System.Windows.Forms.NumericUpDown();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.cbCaptureMouse = new System.Windows.Forms.CheckBox();
            this.btnStartServer = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbPrivate = new System.Windows.Forms.CheckBox();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numShotEvery = new System.Windows.Forms.NumericUpDown();
            this.lblMe = new System.Windows.Forms.Label();
            this.comboScreens = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnLaunch = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.appNotify = new System.Windows.Forms.NotifyIcon(this.components);
            this.cbAutoStart = new System.Windows.Forms.CheckBox();
            this.cbMiniStart = new System.Windows.Forms.CheckBox();
            this.qualitySlider = new System.Windows.Forms.TrackBar();
            this.lblQuality = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numShotEvery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qualitySlider)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbOptions
            // 
            this.gbOptions.Controls.Add(this.cbAllowPublicAccess);
            this.gbOptions.Controls.Add(this.label5);
            this.gbOptions.Controls.Add(this.comboIPs);
            this.gbOptions.Controls.Add(this.label2);
            this.gbOptions.Controls.Add(this.numPort);
            this.gbOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOptions.ForeColor = System.Drawing.Color.White;
            this.gbOptions.Location = new System.Drawing.Point(18, 205);
            this.gbOptions.Margin = new System.Windows.Forms.Padding(4);
            this.gbOptions.Name = "gbOptions";
            this.gbOptions.Padding = new System.Windows.Forms.Padding(4);
            this.gbOptions.Size = new System.Drawing.Size(520, 99);
            this.gbOptions.TabIndex = 0;
            this.gbOptions.TabStop = false;
            this.gbOptions.Text = "Network Options";
            // 
            // cbAllowPublicAccess
            // 
            this.cbAllowPublicAccess.AutoSize = true;
            this.cbAllowPublicAccess.BackColor = System.Drawing.Color.Transparent;
            this.cbAllowPublicAccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAllowPublicAccess.ForeColor = System.Drawing.Color.White;
            this.cbAllowPublicAccess.Location = new System.Drawing.Point(52, 61);
            this.cbAllowPublicAccess.Margin = new System.Windows.Forms.Padding(4);
            this.cbAllowPublicAccess.Name = "cbAllowPublicAccess";
            this.cbAllowPublicAccess.Size = new System.Drawing.Size(183, 24);
            this.cbAllowPublicAccess.TabIndex = 44;
            this.cbAllowPublicAccess.Text = "Allow public access";
            this.cbAllowPublicAccess.UseVisualStyleBackColor = false;
            this.cbAllowPublicAccess.CheckedChanged += new System.EventHandler(this.cbAllowPublicAccess_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(9, 26);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "IP :";
            // 
            // comboIPs
            // 
            this.comboIPs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboIPs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboIPs.FormattingEnabled = true;
            this.comboIPs.Location = new System.Drawing.Point(52, 22);
            this.comboIPs.Margin = new System.Windows.Forms.Padding(4);
            this.comboIPs.Name = "comboIPs";
            this.comboIPs.Size = new System.Drawing.Size(290, 28);
            this.comboIPs.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(357, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Port :";
            // 
            // numPort
            // 
            this.numPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPort.Location = new System.Drawing.Point(414, 23);
            this.numPort.Margin = new System.Windows.Forms.Padding(4);
            this.numPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numPort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPort.Name = "numPort";
            this.numPort.Size = new System.Drawing.Size(98, 26);
            this.numPort.TabIndex = 1;
            this.numPort.Value = new decimal(new int[] {
            7070,
            0,
            0,
            0});
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(14, 747);
            this.txtLog.Margin = new System.Windows.Forms.Padding(4);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(523, 68);
            this.txtLog.TabIndex = 3;
            this.txtLog.TextChanged += new System.EventHandler(this.txtLog_TextChanged);
            // 
            // cbCaptureMouse
            // 
            this.cbCaptureMouse.AutoSize = true;
            this.cbCaptureMouse.BackColor = System.Drawing.Color.Transparent;
            this.cbCaptureMouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCaptureMouse.ForeColor = System.Drawing.Color.White;
            this.cbCaptureMouse.Location = new System.Drawing.Point(294, 95);
            this.cbCaptureMouse.Margin = new System.Windows.Forms.Padding(4);
            this.cbCaptureMouse.Name = "cbCaptureMouse";
            this.cbCaptureMouse.Size = new System.Drawing.Size(189, 24);
            this.cbCaptureMouse.TabIndex = 26;
            this.cbCaptureMouse.Text = "Show Mouse Pointer";
            this.cbCaptureMouse.UseVisualStyleBackColor = false;
            this.cbCaptureMouse.CheckedChanged += new System.EventHandler(this.cbCaptureMouse_CheckedChanged);
            // 
            // btnStartServer
            // 
            this.btnStartServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnStartServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartServer.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btnStartServer.ForeColor = System.Drawing.Color.White;
            this.btnStartServer.Location = new System.Drawing.Point(70, 61);
            this.btnStartServer.Margin = new System.Windows.Forms.Padding(4);
            this.btnStartServer.Name = "btnStartServer";
            this.btnStartServer.Size = new System.Drawing.Size(326, 44);
            this.btnStartServer.TabIndex = 23;
            this.btnStartServer.Tag = "start";
            this.btnStartServer.Text = "Start Server";
            this.btnStartServer.UseVisualStyleBackColor = false;
            this.btnStartServer.Click += new System.EventHandler(this.btnStartServer_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Enabled = false;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(346, 53);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(163, 26);
            this.txtPassword.TabIndex = 22;
            this.txtPassword.Text = "task";
            // 
            // txtUser
            // 
            this.txtUser.Enabled = false;
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(78, 53);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(163, 26);
            this.txtUser.TabIndex = 21;
            this.txtUser.Text = "screen";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(252, 57);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Password : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 57);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "User : ";
            // 
            // cbPrivate
            // 
            this.cbPrivate.AutoSize = true;
            this.cbPrivate.BackColor = System.Drawing.Color.Transparent;
            this.cbPrivate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPrivate.ForeColor = System.Drawing.Color.White;
            this.cbPrivate.Location = new System.Drawing.Point(14, 28);
            this.cbPrivate.Margin = new System.Windows.Forms.Padding(4);
            this.cbPrivate.Name = "cbPrivate";
            this.cbPrivate.Size = new System.Drawing.Size(133, 24);
            this.cbPrivate.TabIndex = 18;
            this.cbPrivate.Text = "Private Task ";
            this.cbPrivate.UseVisualStyleBackColor = false;
            this.cbPrivate.CheckedChanged += new System.EventHandler(this.cbPrivate_CheckedChanged);
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(70, 23);
            this.txtURL.Margin = new System.Windows.Forms.Padding(4);
            this.txtURL.Name = "txtURL";
            this.txtURL.ReadOnly = true;
            this.txtURL.Size = new System.Drawing.Size(324, 27);
            this.txtURL.TabIndex = 17;
            this.txtURL.Text = "the URL will displayed here after starting the server";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "URL :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(429, 38);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 20);
            this.label6.TabIndex = 31;
            this.label6.Text = "Millisecond";
            // 
            // numShotEvery
            // 
            this.numShotEvery.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numShotEvery.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numShotEvery.Location = new System.Drawing.Point(357, 35);
            this.numShotEvery.Margin = new System.Windows.Forms.Padding(4);
            this.numShotEvery.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numShotEvery.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numShotEvery.Name = "numShotEvery";
            this.numShotEvery.Size = new System.Drawing.Size(72, 26);
            this.numShotEvery.TabIndex = 30;
            this.numShotEvery.ThousandsSeparator = true;
            this.numShotEvery.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // lblMe
            // 
            this.lblMe.BackColor = System.Drawing.Color.Transparent;
            this.lblMe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblMe.Location = new System.Drawing.Point(14, 829);
            this.lblMe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMe.Name = "lblMe";
            this.lblMe.Size = new System.Drawing.Size(525, 34);
            this.lblMe.TabIndex = 32;
            this.lblMe.Text = "© AHMED ALHARBI 2022 ";
            this.lblMe.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblMe.Click += new System.EventHandler(this.lblMe_Click);
            // 
            // comboScreens
            // 
            this.comboScreens.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboScreens.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboScreens.FormattingEnabled = true;
            this.comboScreens.Location = new System.Drawing.Point(86, 34);
            this.comboScreens.Margin = new System.Windows.Forms.Padding(4);
            this.comboScreens.Name = "comboScreens";
            this.comboScreens.Size = new System.Drawing.Size(193, 28);
            this.comboScreens.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(9, 38);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.TabIndex = 36;
            this.label7.Text = "Screen :";
            // 
            // btnLaunch
            // 
            this.btnLaunch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLaunch.ForeColor = System.Drawing.Color.White;
            this.btnLaunch.Location = new System.Drawing.Point(414, 19);
            this.btnLaunch.Margin = new System.Windows.Forms.Padding(4);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(98, 37);
            this.btnLaunch.TabIndex = 38;
            this.btnLaunch.Text = "Launch";
            this.btnLaunch.UseVisualStyleBackColor = true;
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(290, 38);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 20);
            this.label8.TabIndex = 39;
            this.label8.Text = "Speed :";
            // 
            // appNotify
            // 
            this.appNotify.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.appNotify.Icon = ((System.Drawing.Icon)(resources.GetObject("appNotify.Icon")));
            this.appNotify.Text = "Screen Task";
            this.appNotify.Visible = true;
            this.appNotify.Click += new System.EventHandler(this.appNotify_Click);
            // 
            // cbAutoStart
            // 
            this.cbAutoStart.AutoSize = true;
            this.cbAutoStart.BackColor = System.Drawing.Color.Transparent;
            this.cbAutoStart.ForeColor = System.Drawing.Color.White;
            this.cbAutoStart.Location = new System.Drawing.Point(70, 114);
            this.cbAutoStart.Margin = new System.Windows.Forms.Padding(4);
            this.cbAutoStart.Name = "cbAutoStart";
            this.cbAutoStart.Size = new System.Drawing.Size(157, 23);
            this.cbAutoStart.TabIndex = 40;
            this.cbAutoStart.Text = "Auto Start Server";
            this.cbAutoStart.UseVisualStyleBackColor = false;
            // 
            // cbMiniStart
            // 
            this.cbMiniStart.AutoSize = true;
            this.cbMiniStart.BackColor = System.Drawing.Color.Transparent;
            this.cbMiniStart.ForeColor = System.Drawing.Color.White;
            this.cbMiniStart.Location = new System.Drawing.Point(250, 114);
            this.cbMiniStart.Margin = new System.Windows.Forms.Padding(4);
            this.cbMiniStart.Name = "cbMiniStart";
            this.cbMiniStart.Size = new System.Drawing.Size(144, 23);
            this.cbMiniStart.TabIndex = 41;
            this.cbMiniStart.Text = "Start Minimized";
            this.cbMiniStart.UseVisualStyleBackColor = false;
            // 
            // qualitySlider
            // 
            this.qualitySlider.Location = new System.Drawing.Point(82, 85);
            this.qualitySlider.Margin = new System.Windows.Forms.Padding(4);
            this.qualitySlider.Maximum = 100;
            this.qualitySlider.Minimum = 1;
            this.qualitySlider.Name = "qualitySlider";
            this.qualitySlider.Size = new System.Drawing.Size(195, 69);
            this.qualitySlider.SmallChange = 10;
            this.qualitySlider.TabIndex = 42;
            this.qualitySlider.TickFrequency = 25;
            this.qualitySlider.Value = 100;
            this.qualitySlider.Scroll += new System.EventHandler(this.qualitySlider_Scroll);
            // 
            // lblQuality
            // 
            this.lblQuality.AutoSize = true;
            this.lblQuality.BackColor = System.Drawing.Color.Transparent;
            this.lblQuality.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuality.ForeColor = System.Drawing.Color.White;
            this.lblQuality.Location = new System.Drawing.Point(9, 101);
            this.lblQuality.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuality.Name = "lblQuality";
            this.lblQuality.Size = new System.Drawing.Size(71, 20);
            this.lblQuality.TabIndex = 43;
            this.lblQuality.Text = "Quality :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numShotEvery);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblQuality);
            this.groupBox1.Controls.Add(this.comboScreens);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbCaptureMouse);
            this.groupBox1.Controls.Add(this.qualitySlider);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(18, 313);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(520, 158);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Display Options";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbPrivate);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtUser);
            this.groupBox2.Controls.Add(this.txtPassword);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(18, 479);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(520, 107);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Privacy Options";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtURL);
            this.groupBox3.Controls.Add(this.btnLaunch);
            this.groupBox3.Controls.Add(this.cbMiniStart);
            this.groupBox3.Controls.Add(this.btnStartServer);
            this.groupBox3.Controls.Add(this.cbAutoStart);
            this.groupBox3.Location = new System.Drawing.Point(18, 595);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(520, 143);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(32, 865);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(466, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 38;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(526, 186);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(554, 919);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.gbOptions);
            this.Controls.Add(this.lblMe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lecture display tool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.gbOptions.ResumeLayout(false);
            this.gbOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numShotEvery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qualitySlider)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbOptions;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.ComboBox comboIPs;
        private System.Windows.Forms.CheckBox cbCaptureMouse;
        private System.Windows.Forms.Button btnStartServer;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbPrivate;
        private System.Windows.Forms.NumericUpDown numPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numShotEvery;
        private System.Windows.Forms.Label lblMe;
        private System.Windows.Forms.ComboBox comboScreens;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnLaunch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NotifyIcon appNotify;
        private System.Windows.Forms.CheckBox cbAutoStart;
        private System.Windows.Forms.CheckBox cbMiniStart;
        private System.Windows.Forms.TrackBar qualitySlider;
        private System.Windows.Forms.Label lblQuality;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbAllowPublicAccess;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

