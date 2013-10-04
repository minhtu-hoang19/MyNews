namespace My_News.User_Controls
{
    partial class ucSetting
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
            this.cmdSave = new System.Windows.Forms.Button();
            this.cmdDefault = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbSql = new System.Windows.Forms.RadioButton();
            this.rdbWindow = new System.Windows.Forms.RadioButton();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtAddressServer = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nudNewsDays = new System.Windows.Forms.NumericUpDown();
            this.txtFont = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.nudSpeed = new System.Windows.Forms.NumericUpDown();
            this.nudTime = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.tkbOpacity = new System.Windows.Forms.TrackBar();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTest = new System.Windows.Forms.Label();
            this.chkJustShowTitle = new System.Windows.Forms.CheckBox();
            this.chkStartWithWindow = new System.Windows.Forms.CheckBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNewsDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbOpacity)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdSave
            // 
            this.cmdSave.Location = new System.Drawing.Point(409, 196);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(75, 23);
            this.cmdSave.TabIndex = 8;
            this.cmdSave.Text = "Lưu";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // cmdDefault
            // 
            this.cmdDefault.Location = new System.Drawing.Point(497, 196);
            this.cmdDefault.Name = "cmdDefault";
            this.cmdDefault.Size = new System.Drawing.Size(75, 23);
            this.cmdDefault.TabIndex = 9;
            this.cmdDefault.Text = "Mặc Định";
            this.cmdDefault.UseVisualStyleBackColor = true;
            this.cmdDefault.Click += new System.EventHandler(this.cmdDefault_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbSql);
            this.groupBox1.Controls.Add(this.rdbWindow);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtAddressServer);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Location = new System.Drawing.Point(289, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 185);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tùy chọn server";
            // 
            // rdbSql
            // 
            this.rdbSql.AutoSize = true;
            this.rdbSql.Location = new System.Drawing.Point(15, 86);
            this.rdbSql.Name = "rdbSql";
            this.rdbSql.Size = new System.Drawing.Size(154, 17);
            this.rdbSql.TabIndex = 8;
            this.rdbSql.Text = "Dùng tài khoản SQL server";
            this.rdbSql.UseVisualStyleBackColor = true;
            this.rdbSql.CheckedChanged += new System.EventHandler(this.rdbSql_CheckedChanged);
            // 
            // rdbWindow
            // 
            this.rdbWindow.AutoSize = true;
            this.rdbWindow.Checked = true;
            this.rdbWindow.Location = new System.Drawing.Point(15, 67);
            this.rdbWindow.Name = "rdbWindow";
            this.rdbWindow.Size = new System.Drawing.Size(145, 17);
            this.rdbWindow.TabIndex = 7;
            this.rdbWindow.TabStop = true;
            this.rdbWindow.Text = "Dùng tài khoản Windows";
            this.rdbWindow.UseVisualStyleBackColor = true;
            this.rdbWindow.CheckedChanged += new System.EventHandler(this.rdbWindow_CheckedChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword.Enabled = false;
            this.txtPassword.Location = new System.Drawing.Point(89, 152);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(185, 20);
            this.txtPassword.TabIndex = 6;
            // 
            // txtAddressServer
            // 
            this.txtAddressServer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAddressServer.Location = new System.Drawing.Point(92, 30);
            this.txtAddressServer.Name = "txtAddressServer";
            this.txtAddressServer.Size = new System.Drawing.Size(182, 20);
            this.txtAddressServer.TabIndex = 4;
            // 
            // txtId
            // 
            this.txtId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(89, 121);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(185, 20);
            this.txtId.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Địa chỉ Server :";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 121);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Tài khoản :";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 159);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Mật khẩu :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nudNewsDays);
            this.groupBox2.Controls.Add(this.txtFont);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.nudSpeed);
            this.groupBox2.Controls.Add(this.nudTime);
            this.groupBox2.Controls.Add(this.numericUpDown1);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.tkbOpacity);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.lblTest);
            this.groupBox2.Controls.Add(this.chkJustShowTitle);
            this.groupBox2.Controls.Add(this.chkStartWithWindow);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(264, 216);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tùy chọn chung";
            // 
            // nudNewsDays
            // 
            this.nudNewsDays.Location = new System.Drawing.Point(128, 134);
            this.nudNewsDays.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudNewsDays.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNewsDays.Name = "nudNewsDays";
            this.nudNewsDays.Size = new System.Drawing.Size(37, 20);
            this.nudNewsDays.TabIndex = 19;
            this.nudNewsDays.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // txtFont
            // 
            this.txtFont.Location = new System.Drawing.Point(107, 190);
            this.txtFont.Multiline = true;
            this.txtFont.Name = "txtFont";
            this.txtFont.Size = new System.Drawing.Size(148, 20);
            this.txtFont.TabIndex = 18;
            this.txtFont.Text = "My News";
            this.txtFont.Click += new System.EventHandler(this.txtFont_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(19, 193);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(82, 13);
            this.label17.TabIndex = 17;
            this.label17.Text = "Chọn kiểu chữ :";
            // 
            // nudSpeed
            // 
            this.nudSpeed.Location = new System.Drawing.Point(180, 104);
            this.nudSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSpeed.Name = "nudSpeed";
            this.nudSpeed.Size = new System.Drawing.Size(75, 20);
            this.nudSpeed.TabIndex = 16;
            this.nudSpeed.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // nudTime
            // 
            this.nudTime.Location = new System.Drawing.Point(180, 80);
            this.nudTime.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.nudTime.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudTime.Name = "nudTime";
            this.nudTime.Size = new System.Drawing.Size(75, 20);
            this.nudTime.TabIndex = 15;
            this.nudTime.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(316, 226);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 14;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(19, 167);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "Độ mờ:";
            // 
            // tkbOpacity
            // 
            this.tkbOpacity.BackColor = System.Drawing.Color.White;
            this.tkbOpacity.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tkbOpacity.Location = new System.Drawing.Point(66, 165);
            this.tkbOpacity.Maximum = 100;
            this.tkbOpacity.Minimum = 10;
            this.tkbOpacity.Name = "tkbOpacity";
            this.tkbOpacity.Size = new System.Drawing.Size(172, 45);
            this.tkbOpacity.TabIndex = 2;
            this.tkbOpacity.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tkbOpacity.Value = 50;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(171, 136);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(72, 13);
            this.label23.TabIndex = 12;
            this.label23.Text = "ngày gần đây";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(19, 136);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(103, 13);
            this.label22.TabIndex = 12;
            this.label22.Text = "Chỉ hiện tin đã đăng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Tốc độ chạy chữ:";
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Location = new System.Drawing.Point(19, 82);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(127, 13);
            this.lblTest.TabIndex = 11;
            this.lblTest.Text = "Thời gian đồng bộ (phút):";
            // 
            // chkJustShowTitle
            // 
            this.chkJustShowTitle.AutoSize = true;
            this.chkJustShowTitle.Checked = true;
            this.chkJustShowTitle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkJustShowTitle.Location = new System.Drawing.Point(22, 56);
            this.chkJustShowTitle.Name = "chkJustShowTitle";
            this.chkJustShowTitle.Size = new System.Drawing.Size(114, 17);
            this.chkJustShowTitle.TabIndex = 9;
            this.chkJustShowTitle.Text = "Chỉ hiển thị tiêu đề";
            this.chkJustShowTitle.UseVisualStyleBackColor = true;
            // 
            // chkStartWithWindow
            // 
            this.chkStartWithWindow.AutoSize = true;
            this.chkStartWithWindow.Checked = true;
            this.chkStartWithWindow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkStartWithWindow.Location = new System.Drawing.Point(22, 33);
            this.chkStartWithWindow.Name = "chkStartWithWindow";
            this.chkStartWithWindow.Size = new System.Drawing.Size(141, 17);
            this.chkStartWithWindow.TabIndex = 8;
            this.chkStartWithWindow.Text = "Khởi động cùng window";
            this.chkStartWithWindow.UseVisualStyleBackColor = true;
            // 
            // fontDialog1
            // 
            this.fontDialog1.Color = System.Drawing.SystemColors.ControlText;
            // 
            // ucSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.cmdDefault);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "ucSetting";
            this.Size = new System.Drawing.Size(584, 228);
            this.Load += new System.EventHandler(this.ucSetting_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNewsDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbOpacity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Button cmdDefault;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbSql;
        private System.Windows.Forms.RadioButton rdbWindow;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtAddressServer;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nudNewsDays;
        private System.Windows.Forms.TextBox txtFont;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown nudSpeed;
        private System.Windows.Forms.NumericUpDown nudTime;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TrackBar tkbOpacity;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.CheckBox chkJustShowTitle;
        private System.Windows.Forms.CheckBox chkStartWithWindow;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}
