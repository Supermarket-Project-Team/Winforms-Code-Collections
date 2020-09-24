namespace Login_Form
{
    partial class SubCategory
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
            this.lbl_subcategory = new System.Windows.Forms.Label();
            this.link_Category = new System.Windows.Forms.LinkLabel();
            this.dgv_sub_category = new System.Windows.Forms.DataGridView();
            this.btn_subcate_back = new System.Windows.Forms.Button();
            this.SUBCATEGORY_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CATEGORY_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUBCATEGORY_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sub_category)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_subcategory
            // 
            this.lbl_subcategory.AutoSize = true;
            this.lbl_subcategory.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_subcategory.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_subcategory.Location = new System.Drawing.Point(487, 25);
            this.lbl_subcategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_subcategory.Name = "lbl_subcategory";
            this.lbl_subcategory.Size = new System.Drawing.Size(286, 38);
            this.lbl_subcategory.TabIndex = 58;
            this.lbl_subcategory.Text = "SUB CATEGORY";
            // 
            // link_Category
            // 
            this.link_Category.AutoSize = true;
            this.link_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_Category.Location = new System.Drawing.Point(1189, 43);
            this.link_Category.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.link_Category.Name = "link_Category";
            this.link_Category.Size = new System.Drawing.Size(84, 20);
            this.link_Category.TabIndex = 73;
            this.link_Category.TabStop = true;
            this.link_Category.Text = "Category";
            this.link_Category.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_Category_LinkClicked);
            // 
            // dgv_sub_category
            // 
            this.dgv_sub_category.BackgroundColor = System.Drawing.Color.White;
            this.dgv_sub_category.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sub_category.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SUBCATEGORY_ID,
            this.CATEGORY_ID,
            this.SUBCATEGORY_NAME});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_sub_category.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_sub_category.Location = new System.Drawing.Point(207, 128);
            this.dgv_sub_category.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_sub_category.Name = "dgv_sub_category";
            this.dgv_sub_category.RowHeadersWidth = 51;
            this.dgv_sub_category.Size = new System.Drawing.Size(951, 364);
            this.dgv_sub_category.TabIndex = 72;
            // 
            // btn_subcate_back
            // 
            this.btn_subcate_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_subcate_back.Location = new System.Drawing.Point(16, 15);
            this.btn_subcate_back.Margin = new System.Windows.Forms.Padding(4);
            this.btn_subcate_back.Name = "btn_subcate_back";
            this.btn_subcate_back.Size = new System.Drawing.Size(52, 32);
            this.btn_subcate_back.TabIndex = 68;
            this.btn_subcate_back.Text = "<-";
            this.btn_subcate_back.UseVisualStyleBackColor = false;
            this.btn_subcate_back.Click += new System.EventHandler(this.btn_subcate_back_Click);
            // 
            // SUBCATEGORY_ID
            // 
            this.SUBCATEGORY_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SUBCATEGORY_ID.DataPropertyName = "SUBCATEGORY_ID";
            this.SUBCATEGORY_ID.HeaderText = "SUBCATEGORY ID";
            this.SUBCATEGORY_ID.MinimumWidth = 6;
            this.SUBCATEGORY_ID.Name = "SUBCATEGORY_ID";
            // 
            // CATEGORY_ID
            // 
            this.CATEGORY_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CATEGORY_ID.DataPropertyName = "CATEGORY_ID";
            this.CATEGORY_ID.HeaderText = "CATEGORY ID";
            this.CATEGORY_ID.MinimumWidth = 6;
            this.CATEGORY_ID.Name = "CATEGORY_ID";
            // 
            // SUBCATEGORY_NAME
            // 
            this.SUBCATEGORY_NAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SUBCATEGORY_NAME.DataPropertyName = "SUBCATEGORY_NAME";
            this.SUBCATEGORY_NAME.HeaderText = "SUBCATEGORY NAME";
            this.SUBCATEGORY_NAME.MinimumWidth = 6;
            this.SUBCATEGORY_NAME.Name = "SUBCATEGORY_NAME";
            // 
            // SubCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1382, 653);
            this.Controls.Add(this.link_Category);
            this.Controls.Add(this.dgv_sub_category);
            this.Controls.Add(this.btn_subcate_back);
            this.Controls.Add(this.lbl_subcategory);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SubCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SubCategory";
            this.Load += new System.EventHandler(this.SubCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sub_category)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_subcategory;
        private System.Windows.Forms.LinkLabel link_Category;
        private System.Windows.Forms.DataGridView dgv_sub_category;
        private System.Windows.Forms.Button btn_subcate_back;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUBCATEGORY_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CATEGORY_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUBCATEGORY_NAME;
    }
}