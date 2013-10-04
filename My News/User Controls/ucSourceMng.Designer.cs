namespace My_News.User_Controls
{
    partial class ucSourceMng
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
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtRss = new System.Windows.Forms.TextBox();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.cboSource = new System.Windows.Forms.ComboBox();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.cmdUpdate = new System.Windows.Forms.Button();
            this.cmdInsert = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgdData = new System.Windows.Forms.DataGridView();
            this.colRssId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSource = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUrl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.picLoadingExport = new System.Windows.Forms.PictureBox();
            this.picLoadingImport = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoadingExport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoadingImport)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Quản lý";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtRss);
            this.panel1.Controls.Add(this.cboCategory);
            this.panel1.Controls.Add(this.cboSource);
            this.panel1.Controls.Add(this.cmdDelete);
            this.panel1.Controls.Add(this.cmdUpdate);
            this.panel1.Controls.Add(this.cmdInsert);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(337, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 187);
            this.panel1.TabIndex = 8;
            // 
            // txtRss
            // 
            this.txtRss.Location = new System.Drawing.Point(82, 93);
            this.txtRss.Name = "txtRss";
            this.txtRss.Size = new System.Drawing.Size(135, 20);
            this.txtRss.TabIndex = 0;
            // 
            // cboCategory
            // 
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Items.AddRange(new object[] {
            "[Thêm mới]"});
            this.cboCategory.Location = new System.Drawing.Point(82, 60);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(135, 21);
            this.cboCategory.TabIndex = 2;
            this.cboCategory.SelectedIndexChanged += new System.EventHandler(this.cboCategory_SelectedIndexChanged);
            // 
            // cboSource
            // 
            this.cboSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSource.FormattingEnabled = true;
            this.cboSource.Items.AddRange(new object[] {
            "[Thêm mới]"});
            this.cboSource.Location = new System.Drawing.Point(82, 25);
            this.cboSource.Name = "cboSource";
            this.cboSource.Size = new System.Drawing.Size(135, 21);
            this.cboSource.TabIndex = 3;
            this.cboSource.SelectedIndexChanged += new System.EventHandler(this.cboSource_SelectedIndexChanged);
            // 
            // cmdDelete
            // 
            this.cmdDelete.Location = new System.Drawing.Point(152, 134);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(65, 25);
            this.cmdDelete.TabIndex = 6;
            this.cmdDelete.Text = "Xóa";
            this.cmdDelete.UseVisualStyleBackColor = true;
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // cmdUpdate
            // 
            this.cmdUpdate.Location = new System.Drawing.Point(82, 134);
            this.cmdUpdate.Name = "cmdUpdate";
            this.cmdUpdate.Size = new System.Drawing.Size(65, 25);
            this.cmdUpdate.TabIndex = 5;
            this.cmdUpdate.Text = "Cập nhật";
            this.cmdUpdate.UseVisualStyleBackColor = true;
            this.cmdUpdate.Click += new System.EventHandler(this.cmdUpdate_Click);
            // 
            // cmdInsert
            // 
            this.cmdInsert.Location = new System.Drawing.Point(11, 134);
            this.cmdInsert.Name = "cmdInsert";
            this.cmdInsert.Size = new System.Drawing.Size(65, 25);
            this.cmdInsert.TabIndex = 4;
            this.cmdInsert.Text = "Thêm";
            this.cmdInsert.UseVisualStyleBackColor = true;
            this.cmdInsert.Click += new System.EventHandler(this.cmdInsert_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Rss Link";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Chuyên mục";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nguồn";
            // 
            // dgdData
            // 
            this.dgdData.AllowUserToAddRows = false;
            this.dgdData.AllowUserToDeleteRows = false;
            this.dgdData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgdData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgdData.ColumnHeadersHeight = 25;
            this.dgdData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRssId,
            this.colSource,
            this.colCategory,
            this.colUrl});
            this.dgdData.Location = new System.Drawing.Point(3, 22);
            this.dgdData.MultiSelect = false;
            this.dgdData.Name = "dgdData";
            this.dgdData.ReadOnly = true;
            this.dgdData.RowHeadersWidth = 25;
            this.dgdData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgdData.Size = new System.Drawing.Size(310, 160);
            this.dgdData.TabIndex = 10;
            this.dgdData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgdData_CellContentClick);
            // 
            // colRssId
            // 
            this.colRssId.DataPropertyName = "Id";
            this.colRssId.FillWeight = 40.60914F;
            this.colRssId.HeaderText = "ID";
            this.colRssId.Name = "colRssId";
            this.colRssId.ReadOnly = true;
            // 
            // colSource
            // 
            this.colSource.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSource.DataPropertyName = "SourceName";
            this.colSource.FillWeight = 119.797F;
            this.colSource.HeaderText = "Nguồn";
            this.colSource.Name = "colSource";
            this.colSource.ReadOnly = true;
            // 
            // colCategory
            // 
            this.colCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCategory.DataPropertyName = "CategoryName";
            this.colCategory.FillWeight = 150F;
            this.colCategory.HeaderText = "Chuyên mục";
            this.colCategory.Name = "colCategory";
            this.colCategory.ReadOnly = true;
            // 
            // colUrl
            // 
            this.colUrl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colUrl.DataPropertyName = "Url";
            this.colUrl.FillWeight = 119.797F;
            this.colUrl.HeaderText = "Url";
            this.colUrl.Name = "colUrl";
            this.colUrl.ReadOnly = true;
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(5, 188);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(150, 23);
            this.btnImport.TabIndex = 11;
            this.btnImport.Text = "Nhập từ file Excel (Import)";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(163, 188);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(150, 23);
            this.btnExport.TabIndex = 11;
            this.btnExport.Text = "Xuất file Excel (Export)";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "MYNEWS_DATA_";
            this.openFileDialog1.Filter = "Excel file (*.xls)|*.xls";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Excel file (*.xls)|*.xls";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // picLoadingExport
            // 
            this.picLoadingExport.Image = global::My_News.Properties.Resources.loading;
            this.picLoadingExport.Location = new System.Drawing.Point(204, 189);
            this.picLoadingExport.Name = "picLoadingExport";
            this.picLoadingExport.Size = new System.Drawing.Size(59, 22);
            this.picLoadingExport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLoadingExport.TabIndex = 12;
            this.picLoadingExport.TabStop = false;
            this.picLoadingExport.Visible = false;
            // 
            // picLoadingImport
            // 
            this.picLoadingImport.Image = global::My_News.Properties.Resources.loading;
            this.picLoadingImport.Location = new System.Drawing.Point(50, 189);
            this.picLoadingImport.Name = "picLoadingImport";
            this.picLoadingImport.Size = new System.Drawing.Size(59, 22);
            this.picLoadingImport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLoadingImport.TabIndex = 12;
            this.picLoadingImport.TabStop = false;
            this.picLoadingImport.Visible = false;
            // 
            // ucSourceMng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picLoadingImport);
            this.Controls.Add(this.picLoadingExport);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgdData);
            this.Name = "ucSourceMng";
            this.Size = new System.Drawing.Size(578, 223);
            this.Load += new System.EventHandler(this.ucSourceMng_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoadingExport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoadingImport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtRss;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.ComboBox cboSource;
        private System.Windows.Forms.Button cmdDelete;
        private System.Windows.Forms.Button cmdUpdate;
        private System.Windows.Forms.Button cmdInsert;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgdData;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRssId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUrl;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox picLoadingExport;
        private System.Windows.Forms.PictureBox picLoadingImport;
    }
}
