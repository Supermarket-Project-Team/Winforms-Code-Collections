namespace LuluSupermarket
{
    partial class form_staff
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
            this.lbl_staffname = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_salary = new System.Windows.Forms.Label();
            this.txt_staffname = new System.Windows.Forms.TextBox();
            this.dt_jdate = new System.Windows.Forms.DateTimePicker();
            this.txt_salary = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_heading = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_print = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_staffname
            // 
            this.lbl_staffname.AutoSize = true;
            this.lbl_staffname.Location = new System.Drawing.Point(279, 78);
            this.lbl_staffname.Name = "lbl_staffname";
            this.lbl_staffname.Size = new System.Drawing.Size(78, 17);
            this.lbl_staffname.TabIndex = 0;
            this.lbl_staffname.Text = "Staff Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Joining Date";
            // 
            // lbl_salary
            // 
            this.lbl_salary.AutoSize = true;
            this.lbl_salary.Location = new System.Drawing.Point(285, 195);
            this.lbl_salary.Name = "lbl_salary";
            this.lbl_salary.Size = new System.Drawing.Size(48, 17);
            this.lbl_salary.TabIndex = 2;
            this.lbl_salary.Text = "Salary";
            // 
            // txt_staffname
            // 
            this.txt_staffname.Location = new System.Drawing.Point(435, 78);
            this.txt_staffname.Name = "txt_staffname";
            this.txt_staffname.Size = new System.Drawing.Size(200, 22);
            this.txt_staffname.TabIndex = 3;
            // 
            // dt_jdate
            // 
            this.dt_jdate.Location = new System.Drawing.Point(435, 133);
            this.dt_jdate.Name = "dt_jdate";
            this.dt_jdate.Size = new System.Drawing.Size(200, 22);
            this.dt_jdate.TabIndex = 4;
            // 
            // txt_salary
            // 
            this.txt_salary.Location = new System.Drawing.Point(435, 189);
            this.txt_salary.Name = "txt_salary";
            this.txt_salary.Size = new System.Drawing.Size(200, 22);
            this.txt_salary.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 243);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1258, 390);
            this.dataGridView1.TabIndex = 6;
            // 
            // lbl_heading
            // 
            this.lbl_heading.AutoSize = true;
            this.lbl_heading.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_heading.Location = new System.Drawing.Point(459, 4);
            this.lbl_heading.Name = "lbl_heading";
            this.lbl_heading.Size = new System.Drawing.Size(70, 29);
            this.lbl_heading.TabIndex = 7;
            this.lbl_heading.Text = "Staff";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(691, 13);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 8;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(790, 12);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 9;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(906, 12);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 10;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_print
            // 
            this.btn_print.Location = new System.Drawing.Point(1025, 12);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(75, 23);
            this.btn_print.TabIndex = 11;
            this.btn_print.Text = "Print";
            this.btn_print.UseVisualStyleBackColor = true;
            // 
            // form_staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 645);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.lbl_heading);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_salary);
            this.Controls.Add(this.dt_jdate);
            this.Controls.Add(this.txt_staffname);
            this.Controls.Add(this.lbl_salary);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_staffname);
            this.Name = "form_staff";
            this.Text = "Staff";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_staffname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_salary;
        private System.Windows.Forms.TextBox txt_staffname;
        private System.Windows.Forms.DateTimePicker dt_jdate;
        private System.Windows.Forms.TextBox txt_salary;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_heading;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_print;
    }
}