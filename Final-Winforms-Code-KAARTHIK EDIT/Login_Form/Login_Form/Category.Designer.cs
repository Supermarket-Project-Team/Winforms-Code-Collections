namespace Login_Form
{
    partial class Category
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_category_back = new System.Windows.Forms.Button();
            this.lbl_category = new System.Windows.Forms.Label();
            this.dgv_category = new System.Windows.Forms.DataGridView();
            this.link_SubCategory = new System.Windows.Forms.LinkLabel();
            this.CATEGORY_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CATEGORY_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_category)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_category_back
            // 
            this.btn_category_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_category_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_category_back.Location = new System.Drawing.Point(13, 15);
            this.btn_category_back.Margin = new System.Windows.Forms.Padding(4);
            this.btn_category_back.Name = "btn_category_back";
            this.btn_category_back.Size = new System.Drawing.Size(47, 36);
            this.btn_category_back.TabIndex = 58;
            this.btn_category_back.Text = "<-";
            this.btn_category_back.UseVisualStyleBackColor = false;
            this.btn_category_back.Click += new System.EventHandler(this.btn_category_back_Click);
            // 
            // lbl_category
            // 
            this.lbl_category.AutoSize = true;
            this.lbl_category.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_category.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_category.Location = new System.Drawing.Point(543, 34);
            this.lbl_category.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(210, 38);
            this.lbl_category.TabIndex = 57;
            this.lbl_category.Text = "CATEGORY";
            // 
            // dgv_category
            // 
            this.dgv_category.BackgroundColor = System.Drawing.Color.White;
            this.dgv_category.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_category.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CATEGORY_ID,
            this.CATEGORY_NAME});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_category.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_category.Location = new System.Drawing.Point(218, 148);
            this.dgv_category.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_category.Name = "dgv_category";
            this.dgv_category.RowHeadersWidth = 51;
            this.dgv_category.Size = new System.Drawing.Size(951, 364);
            this.dgv_category.TabIndex = 62;
            // 
            // link_SubCategory
            // 
            this.link_SubCategory.AutoSize = true;
            this.link_SubCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_SubCategory.ForeColor = System.Drawing.Color.White;
            this.link_SubCategory.Location = new System.Drawing.Point(1196, 48);
            this.link_SubCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.link_SubCategory.Name = "link_SubCategory";
            this.link_SubCategory.Size = new System.Drawing.Size(122, 20);
            this.link_SubCategory.TabIndex = 63;
            this.link_SubCategory.TabStop = true;
            this.link_SubCategory.Text = "Sub Category";
            this.link_SubCategory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_SubCategory_LinkClicked);
            // 
            // CATEGORY_ID
            // 
            this.CATEGORY_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CATEGORY_ID.DataPropertyName = "CATEGORY_ID";
            this.CATEGORY_ID.HeaderText = "CATEGORY_ID";
            this.CATEGORY_ID.MinimumWidth = 6;
            this.CATEGORY_ID.Name = "CATEGORY_ID";
            // 
            // CATEGORY_NAME
            // 
            this.CATEGORY_NAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CATEGORY_NAME.DataPropertyName = "CATEGORY_NAME";
            this.CATEGORY_NAME.FillWeight = 66.31017F;
            this.CATEGORY_NAME.HeaderText = "CATEGORY_NAME";
            this.CATEGORY_NAME.MinimumWidth = 6;
            this.CATEGORY_NAME.Name = "CATEGORY_NAME";
            // 
            // Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1382, 653);
            this.Controls.Add(this.link_SubCategory);
            this.Controls.Add(this.dgv_category);
            this.Controls.Add(this.btn_category_back);
            this.Controls.Add(this.lbl_category);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Category";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Category";
            this.Load += new System.EventHandler(this.Category_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_category)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_category_back;
        private System.Windows.Forms.Label lbl_category;
        private System.Windows.Forms.DataGridView dgv_category;
        private System.Windows.Forms.LinkLabel link_SubCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn CATEGORY_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CATEGORY_NAME;
    }
}