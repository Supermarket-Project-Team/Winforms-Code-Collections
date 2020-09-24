namespace Login_Form
{
    partial class form_Shelf
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_shelf = new System.Windows.Forms.DataGridView();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_shelf_back = new System.Windows.Forms.Button();
            this.SHELF_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SHELF_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ROW_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRODUCT_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_shelf)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_shelf
            // 
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dgv_shelf.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_shelf.BackgroundColor = System.Drawing.Color.White;
            this.dgv_shelf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_shelf.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SHELF_ID,
            this.SHELF_NO,
            this.ROW_NO,
            this.PRODUCT_ID});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_shelf.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgv_shelf.GridColor = System.Drawing.Color.White;
            this.dgv_shelf.Location = new System.Drawing.Point(169, 199);
            this.dgv_shelf.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_shelf.Name = "dgv_shelf";
            this.dgv_shelf.RowHeadersWidth = 51;
            this.dgv_shelf.Size = new System.Drawing.Size(991, 336);
            this.dgv_shelf.TabIndex = 9;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Location = new System.Drawing.Point(1133, 133);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(96, 28);
            this.btn_delete.TabIndex = 8;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.UseVisualStyleBackColor = false;
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Location = new System.Drawing.Point(956, 133);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(96, 28);
            this.btn_edit.TabIndex = 7;
            this.btn_edit.Text = "EDIT";
            this.btn_edit.UseVisualStyleBackColor = false;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Location = new System.Drawing.Point(795, 133);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(96, 28);
            this.btn_save.TabIndex = 6;
            this.btn_save.Text = "SAVE";
            this.btn_save.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(549, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "Shelf Allocation";
            // 
            // btn_shelf_back
            // 
            this.btn_shelf_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_shelf_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_shelf_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_shelf_back.Location = new System.Drawing.Point(16, 15);
            this.btn_shelf_back.Margin = new System.Windows.Forms.Padding(4);
            this.btn_shelf_back.Name = "btn_shelf_back";
            this.btn_shelf_back.Size = new System.Drawing.Size(39, 28);
            this.btn_shelf_back.TabIndex = 10;
            this.btn_shelf_back.Text = "<-";
            this.btn_shelf_back.UseVisualStyleBackColor = false;
            this.btn_shelf_back.Click += new System.EventHandler(this.btn_shelf_back_Click);
            // 
            // SHELF_ID
            // 
            this.SHELF_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SHELF_ID.DataPropertyName = "SHELF_ID";
            this.SHELF_ID.HeaderText = "SHELF_ID";
            this.SHELF_ID.MinimumWidth = 6;
            this.SHELF_ID.Name = "SHELF_ID";
            // 
            // SHELF_NO
            // 
            this.SHELF_NO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SHELF_NO.DataPropertyName = "SHELF_N0";
            this.SHELF_NO.HeaderText = "SHELF_NO";
            this.SHELF_NO.MinimumWidth = 6;
            this.SHELF_NO.Name = "SHELF_NO";
            // 
            // ROW_NO
            // 
            this.ROW_NO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ROW_NO.DataPropertyName = "ROW_NO";
            this.ROW_NO.HeaderText = "ROW_NO";
            this.ROW_NO.MinimumWidth = 6;
            this.ROW_NO.Name = "ROW_NO";
            // 
            // PRODUCT_ID
            // 
            this.PRODUCT_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PRODUCT_ID.DataPropertyName = "PRODUCT_ID";
            this.PRODUCT_ID.HeaderText = "PRODUCT_ID";
            this.PRODUCT_ID.MinimumWidth = 6;
            this.PRODUCT_ID.Name = "PRODUCT_ID";
            // 
            // form_Shelf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1382, 653);
            this.Controls.Add(this.btn_shelf_back);
            this.Controls.Add(this.dgv_shelf);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "form_Shelf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shelf";
            this.Load += new System.EventHandler(this.Shelf_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_shelf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_shelf;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_shelf_back;
        private System.Windows.Forms.DataGridViewTextBoxColumn SHELF_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SHELF_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ROW_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUCT_ID;
    }
}