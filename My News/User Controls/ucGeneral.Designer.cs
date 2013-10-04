namespace My_News.Window_Forms
{
    partial class ucGeneral
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
            this.btnShowGuide = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.cmdExit = new System.Windows.Forms.Button();
            this.cmdMinimize = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblLinkRss = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblSource = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblSelected = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblLastUpdate = new System.Windows.Forms.Label();
            this.tmrLoadDelay = new System.Windows.Forms.Timer(this.components);
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnShowGuide
            // 
            this.btnShowGuide.Location = new System.Drawing.Point(506, 3);
            this.btnShowGuide.Name = "btnShowGuide";
            this.btnShowGuide.Size = new System.Drawing.Size(28, 23);
            this.btnShowGuide.TabIndex = 19;
            this.btnShowGuide.Text = "?";
            this.btnShowGuide.UseVisualStyleBackColor = true;
            this.btnShowGuide.Click += new System.EventHandler(this.btnShowGuide_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(177, 204);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(131, 23);
            this.btnRefresh.TabIndex = 18;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(167, 39);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(144, 16);
            this.label19.TabIndex = 17;
            this.label19.Text = "Thế giới trong tầm mắt!";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(178, 10);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(119, 29);
            this.label18.TabIndex = 16;
            this.label18.Text = "My News";
            this.label18.DoubleClick += new System.EventHandler(this.label18_DoubleClick);
            // 
            // cmdExit
            // 
            this.cmdExit.Location = new System.Drawing.Point(314, 204);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(75, 23);
            this.cmdExit.TabIndex = 15;
            this.cmdExit.Text = "Thoát";
            this.cmdExit.UseVisualStyleBackColor = true;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // cmdMinimize
            // 
            this.cmdMinimize.Location = new System.Drawing.Point(96, 204);
            this.cmdMinimize.Name = "cmdMinimize";
            this.cmdMinimize.Size = new System.Drawing.Size(75, 23);
            this.cmdMinimize.TabIndex = 14;
            this.cmdMinimize.Text = "Thu nhỏ";
            this.cmdMinimize.UseVisualStyleBackColor = true;
            this.cmdMinimize.Click += new System.EventHandler(this.cmdMinimize_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblLinkRss);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.lblSource);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.lblSelected);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.lblLastUpdate);
            this.groupBox3.Location = new System.Drawing.Point(96, 58);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(293, 135);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            // 
            // lblLinkRss
            // 
            this.lblLinkRss.AutoSize = true;
            this.lblLinkRss.Location = new System.Drawing.Point(157, 106);
            this.lblLinkRss.Name = "lblLinkRss";
            this.lblLinkRss.Size = new System.Drawing.Size(10, 13);
            this.lblLinkRss.TabIndex = 7;
            this.lblLinkRss.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Số link rss:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Số nguồn hiện có :";
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Location = new System.Drawing.Point(157, 50);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(10, 13);
            this.lblSource.TabIndex = 5;
            this.lblSource.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Lần cập nhật cuối cùng :";
            // 
            // lblSelected
            // 
            this.lblSelected.AutoSize = true;
            this.lblSelected.Location = new System.Drawing.Point(157, 78);
            this.lblSelected.Name = "lblSelected";
            this.lblSelected.Size = new System.Drawing.Size(10, 13);
            this.lblSelected.TabIndex = 4;
            this.lblSelected.Text = "-";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(25, 78);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(87, 13);
            this.label16.TabIndex = 2;
            this.label16.Text = "Số chuyên mục :";
            // 
            // lblLastUpdate
            // 
            this.lblLastUpdate.AutoSize = true;
            this.lblLastUpdate.Location = new System.Drawing.Point(157, 23);
            this.lblLastUpdate.Name = "lblLastUpdate";
            this.lblLastUpdate.Size = new System.Drawing.Size(10, 13);
            this.lblLastUpdate.TabIndex = 3;
            this.lblLastUpdate.Text = "-";
            // 
            // tmrLoadDelay
            // 
            this.tmrLoadDelay.Enabled = true;
            this.tmrLoadDelay.Interval = 500;
            this.tmrLoadDelay.Tick += new System.EventHandler(this.tmrLoadDelay_Tick);
            // 
            // ucGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnShowGuide);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.cmdMinimize);
            this.Controls.Add(this.groupBox3);
            this.Name = "ucGeneral";
            this.Size = new System.Drawing.Size(537, 234);
            this.Load += new System.EventHandler(this.ucGeneral_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowGuide;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.Button cmdMinimize;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblLinkRss;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblSelected;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblLastUpdate;
        private System.Windows.Forms.Timer tmrLoadDelay;
    }
}
