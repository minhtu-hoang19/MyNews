namespace My_News
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tctMain = new System.Windows.Forms.TabControl();
            this.tbGeneral = new System.Windows.Forms.TabPage();
            this.ucGeneral1 = new My_News.Window_Forms.ucGeneral();
            this.tbSetupSource = new System.Windows.Forms.TabPage();
            this.ucSetupSource1 = new My_News.User_Controls.ucSetupSource();
            this.tbSourceMng = new System.Windows.Forms.TabPage();
            this.ucSourceMng1 = new My_News.User_Controls.ucSourceMng();
            this.tbSettings = new System.Windows.Forms.TabPage();
            this.ucSetting1 = new My_News.User_Controls.ucSetting();
            this.tbAbout = new System.Windows.Forms.TabPage();
            this.ucAbout1 = new My_News.User_Controls.ucAbout();
            this.tctMain.SuspendLayout();
            this.tbGeneral.SuspendLayout();
            this.tbSetupSource.SuspendLayout();
            this.tbSourceMng.SuspendLayout();
            this.tbSettings.SuspendLayout();
            this.tbAbout.SuspendLayout();
            this.SuspendLayout();
            // 
            // tctMain
            // 
            this.tctMain.Controls.Add(this.tbGeneral);
            this.tctMain.Controls.Add(this.tbSetupSource);
            this.tctMain.Controls.Add(this.tbSourceMng);
            this.tctMain.Controls.Add(this.tbSettings);
            this.tctMain.Controls.Add(this.tbAbout);
            this.tctMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tctMain.Location = new System.Drawing.Point(0, 0);
            this.tctMain.Name = "tctMain";
            this.tctMain.SelectedIndex = 0;
            this.tctMain.Size = new System.Drawing.Size(613, 266);
            this.tctMain.TabIndex = 0;
            this.tctMain.SelectedIndexChanged += new System.EventHandler(this.tctMain_SelectedIndexChanged);
            // 
            // tbGeneral
            // 
            this.tbGeneral.Controls.Add(this.ucGeneral1);
            this.tbGeneral.Location = new System.Drawing.Point(4, 22);
            this.tbGeneral.Name = "tbGeneral";
            this.tbGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tbGeneral.Size = new System.Drawing.Size(605, 240);
            this.tbGeneral.TabIndex = 2;
            this.tbGeneral.Text = "Thông tin chung";
            this.tbGeneral.UseVisualStyleBackColor = true;
            // 
            // ucGeneral1
            // 
            this.ucGeneral1.Location = new System.Drawing.Point(65, 0);
            this.ucGeneral1.Name = "ucGeneral1";
            this.ucGeneral1.Size = new System.Drawing.Size(537, 234);
            this.ucGeneral1.TabIndex = 0;
            this.ucGeneral1.Load += new System.EventHandler(this.ucGeneral1_Load);
            // 
            // tbSetupSource
            // 
            this.tbSetupSource.Controls.Add(this.ucSetupSource1);
            this.tbSetupSource.Location = new System.Drawing.Point(4, 22);
            this.tbSetupSource.Name = "tbSetupSource";
            this.tbSetupSource.Padding = new System.Windows.Forms.Padding(3);
            this.tbSetupSource.Size = new System.Drawing.Size(605, 240);
            this.tbSetupSource.TabIndex = 0;
            this.tbSetupSource.Text = "Chọn nguồn tin";
            this.tbSetupSource.UseVisualStyleBackColor = true;
            // 
            // ucSetupSource1
            // 
            this.ucSetupSource1.Location = new System.Drawing.Point(17, 14);
            this.ucSetupSource1.Name = "ucSetupSource1";
            this.ucSetupSource1.Size = new System.Drawing.Size(574, 212);
            this.ucSetupSource1.TabIndex = 0;
            // 
            // tbSourceMng
            // 
            this.tbSourceMng.Controls.Add(this.ucSourceMng1);
            this.tbSourceMng.Location = new System.Drawing.Point(4, 22);
            this.tbSourceMng.Name = "tbSourceMng";
            this.tbSourceMng.Padding = new System.Windows.Forms.Padding(3);
            this.tbSourceMng.Size = new System.Drawing.Size(605, 240);
            this.tbSourceMng.TabIndex = 1;
            this.tbSourceMng.Text = "Quản lý nguồn tin";
            this.tbSourceMng.UseVisualStyleBackColor = true;
            // 
            // ucSourceMng1
            // 
            this.ucSourceMng1.Location = new System.Drawing.Point(16, 8);
            this.ucSourceMng1.Name = "ucSourceMng1";
            this.ucSourceMng1.Size = new System.Drawing.Size(570, 226);
            this.ucSourceMng1.TabIndex = 0;
            // 
            // tbSettings
            // 
            this.tbSettings.Controls.Add(this.ucSetting1);
            this.tbSettings.Location = new System.Drawing.Point(4, 22);
            this.tbSettings.Name = "tbSettings";
            this.tbSettings.Size = new System.Drawing.Size(605, 240);
            this.tbSettings.TabIndex = 3;
            this.tbSettings.Text = "Cài đặt";
            this.tbSettings.UseVisualStyleBackColor = true;
            // 
            // ucSetting1
            // 
            this.ucSetting1.Location = new System.Drawing.Point(14, 9);
            this.ucSetting1.Name = "ucSetting1";
            this.ucSetting1.Size = new System.Drawing.Size(584, 228);
            this.ucSetting1.TabIndex = 0;
            // 
            // tbAbout
            // 
            this.tbAbout.Controls.Add(this.ucAbout1);
            this.tbAbout.Location = new System.Drawing.Point(4, 22);
            this.tbAbout.Name = "tbAbout";
            this.tbAbout.Size = new System.Drawing.Size(605, 240);
            this.tbAbout.TabIndex = 4;
            this.tbAbout.Text = "Giới thiệu";
            this.tbAbout.UseVisualStyleBackColor = true;
            // 
            // ucAbout1
            // 
            this.ucAbout1.Location = new System.Drawing.Point(10, 3);
            this.ucAbout1.Name = "ucAbout1";
            this.ucAbout1.Size = new System.Drawing.Size(589, 234);
            this.ucAbout1.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 266);
            this.Controls.Add(this.tctMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My News - Thế giới trong tầm mắt!";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.tctMain.ResumeLayout(false);
            this.tbGeneral.ResumeLayout(false);
            this.tbSetupSource.ResumeLayout(false);
            this.tbSourceMng.ResumeLayout(false);
            this.tbSettings.ResumeLayout(false);
            this.tbAbout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tctMain;
        private System.Windows.Forms.TabPage tbSetupSource;
        private System.Windows.Forms.TabPage tbSourceMng;
        private System.Windows.Forms.TabPage tbGeneral;
        private System.Windows.Forms.TabPage tbSettings;
        private System.Windows.Forms.TabPage tbAbout;
        private Window_Forms.ucGeneral ucGeneral1;
        private User_Controls.ucSetupSource ucSetupSource1;
        private User_Controls.ucSourceMng ucSourceMng1;
        private User_Controls.ucSetting ucSetting1;
        private User_Controls.ucAbout ucAbout1;

    }
}