namespace My_News.User_Controls
{
    partial class ucSetupSource
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
            this.lstSelected = new System.Windows.Forms.ListBox();
            this.lstMenu = new System.Windows.Forms.ListBox();
            this.cmdGet = new System.Windows.Forms.Button();
            this.cmdGetAll = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdAccept = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdGetBackAll = new System.Windows.Forms.Button();
            this.cmdGetBack = new System.Windows.Forms.Button();
            this.cmdSortAsCategory = new System.Windows.Forms.Button();
            this.cmdSoftAsSource = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstSelected
            // 
            this.lstSelected.FormattingEnabled = true;
            this.lstSelected.Location = new System.Drawing.Point(330, 14);
            this.lstSelected.Name = "lstSelected";
            this.lstSelected.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstSelected.Size = new System.Drawing.Size(240, 160);
            this.lstSelected.TabIndex = 26;
            // 
            // lstMenu
            // 
            this.lstMenu.FormattingEnabled = true;
            this.lstMenu.Location = new System.Drawing.Point(3, 14);
            this.lstMenu.Name = "lstMenu";
            this.lstMenu.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstMenu.Size = new System.Drawing.Size(240, 160);
            this.lstMenu.TabIndex = 25;
            // 
            // cmdGet
            // 
            this.cmdGet.Location = new System.Drawing.Point(249, 63);
            this.cmdGet.Name = "cmdGet";
            this.cmdGet.Size = new System.Drawing.Size(75, 30);
            this.cmdGet.TabIndex = 24;
            this.cmdGet.Text = ">>";
            this.cmdGet.UseVisualStyleBackColor = true;
            this.cmdGet.Click += new System.EventHandler(this.cmdGet_Click);
            // 
            // cmdGetAll
            // 
            this.cmdGetAll.Location = new System.Drawing.Point(249, 27);
            this.cmdGetAll.Name = "cmdGetAll";
            this.cmdGetAll.Size = new System.Drawing.Size(75, 30);
            this.cmdGetAll.TabIndex = 23;
            this.cmdGetAll.Text = ">>>>";
            this.cmdGetAll.UseVisualStyleBackColor = true;
            this.cmdGetAll.Click += new System.EventHandler(this.cmdGetAll_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(451, 180);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(119, 29);
            this.cmdCancel.TabIndex = 22;
            this.cmdCancel.Text = "Hủy bỏ";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdAccept
            // 
            this.cmdAccept.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdAccept.Location = new System.Drawing.Point(330, 180);
            this.cmdAccept.Name = "cmdAccept";
            this.cmdAccept.Size = new System.Drawing.Size(115, 29);
            this.cmdAccept.TabIndex = 21;
            this.cmdAccept.Text = "Lưu lại";
            this.cmdAccept.UseVisualStyleBackColor = true;
            this.cmdAccept.Click += new System.EventHandler(this.cmdAccept_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Danh mục";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(327, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Đã Chọn";
            // 
            // cmdGetBackAll
            // 
            this.cmdGetBackAll.Location = new System.Drawing.Point(249, 135);
            this.cmdGetBackAll.Name = "cmdGetBackAll";
            this.cmdGetBackAll.Size = new System.Drawing.Size(75, 30);
            this.cmdGetBackAll.TabIndex = 18;
            this.cmdGetBackAll.Text = "<<<<";
            this.cmdGetBackAll.UseVisualStyleBackColor = true;
            this.cmdGetBackAll.Click += new System.EventHandler(this.cmdGetBackAll_Click);
            // 
            // cmdGetBack
            // 
            this.cmdGetBack.Location = new System.Drawing.Point(249, 99);
            this.cmdGetBack.Name = "cmdGetBack";
            this.cmdGetBack.Size = new System.Drawing.Size(75, 30);
            this.cmdGetBack.TabIndex = 17;
            this.cmdGetBack.Text = "<<";
            this.cmdGetBack.UseVisualStyleBackColor = true;
            this.cmdGetBack.Click += new System.EventHandler(this.cmdGetBack_Click);
            // 
            // cmdSortAsCategory
            // 
            this.cmdSortAsCategory.Location = new System.Drawing.Point(128, 180);
            this.cmdSortAsCategory.Name = "cmdSortAsCategory";
            this.cmdSortAsCategory.Size = new System.Drawing.Size(115, 29);
            this.cmdSortAsCategory.TabIndex = 16;
            this.cmdSortAsCategory.Text = "Sắp xếp theo chủ đề";
            this.cmdSortAsCategory.UseVisualStyleBackColor = true;
            this.cmdSortAsCategory.Click += new System.EventHandler(this.cmdSortAsCategory_Click);
            // 
            // cmdSoftAsSource
            // 
            this.cmdSoftAsSource.Location = new System.Drawing.Point(3, 180);
            this.cmdSoftAsSource.Name = "cmdSoftAsSource";
            this.cmdSoftAsSource.Size = new System.Drawing.Size(115, 29);
            this.cmdSoftAsSource.TabIndex = 15;
            this.cmdSoftAsSource.Text = "Sắp xếp theo nguồn";
            this.cmdSoftAsSource.UseVisualStyleBackColor = true;
            this.cmdSoftAsSource.Click += new System.EventHandler(this.cmdSoftAsSource_Click);
            // 
            // ucSetupSource
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lstSelected);
            this.Controls.Add(this.lstMenu);
            this.Controls.Add(this.cmdGet);
            this.Controls.Add(this.cmdGetAll);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdAccept);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdGetBackAll);
            this.Controls.Add(this.cmdGetBack);
            this.Controls.Add(this.cmdSortAsCategory);
            this.Controls.Add(this.cmdSoftAsSource);
            this.Name = "ucSetupSource";
            this.Size = new System.Drawing.Size(574, 212);
            this.Load += new System.EventHandler(this.ucSetupSource_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstSelected;
        private System.Windows.Forms.ListBox lstMenu;
        private System.Windows.Forms.Button cmdGet;
        private System.Windows.Forms.Button cmdGetAll;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdAccept;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdGetBackAll;
        private System.Windows.Forms.Button cmdGetBack;
        private System.Windows.Forms.Button cmdSortAsCategory;
        private System.Windows.Forms.Button cmdSoftAsSource;
    }
}
