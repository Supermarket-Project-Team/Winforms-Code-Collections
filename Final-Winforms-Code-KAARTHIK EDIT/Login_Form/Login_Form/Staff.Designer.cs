namespace Login_Form
{
    partial class form_Staff
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_staff_back = new System.Windows.Forms.Button();
            this.lbl_staff = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.lbl_salary = new System.Windows.Forms.Label();
            this.lbl_jdate = new System.Windows.Forms.Label();
            this.lbl_staffname = new System.Windows.Forms.Label();
            this.txt_staff_name = new System.Windows.Forms.TextBox();
            this.dt_jdate = new System.Windows.Forms.DateTimePicker();
            this.txt_salary = new System.Windows.Forms.TextBox();
            this.dgv_staff = new System.Windows.Forms.DataGridView();
            this.STAFF_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JDATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SALARY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESIGNATION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_designation = new System.Windows.Forms.Label();
            this.cmb_designation = new System.Windows.Forms.ComboBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_staff_id = new System.Windows.Forms.TextBox();
            this.lbl_staff_id = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_staff)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_staff_back
            // 
            this.btn_staff_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_staff_back.FlatAppearance.BorderSize = 0;
            this.btn_staff_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_staff_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_staff_back.Location = new System.Drawing.Point(15, 15);
            this.btn_staff_back.Margin = new System.Windows.Forms.Padding(4);
            this.btn_staff_back.Name = "btn_staff_back";
            this.btn_staff_back.Size = new System.Drawing.Size(49, 34);
            this.btn_staff_back.TabIndex = 58;
            this.btn_staff_back.Text = "<-";
            this.btn_staff_back.UseVisualStyleBackColor = false;
            this.btn_staff_back.Click += new System.EventHandler(this.btn_staff_back_Click);
            // 
            // lbl_staff
            // 
            this.lbl_staff.AutoSize = true;
            this.lbl_staff.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_staff.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_staff.Location = new System.Drawing.Point(184, 90);
            this.lbl_staff.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_staff.Name = "lbl_staff";
            this.lbl_staff.Size = new System.Drawing.Size(122, 38);
            this.lbl_staff.TabIndex = 57;
            this.lbl_staff.Text = "STAFF";
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Location = new System.Drawing.Point(280, 480);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(91, 33);
            this.btn_delete.TabIndex = 56;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Location = new System.Drawing.Point(121, 480);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(87, 32);
            this.btn_edit.TabIndex = 55;
            this.btn_edit.Text = "EDIT";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Location = new System.Drawing.Point(280, 396);
            this.btn_save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(91, 32);
            this.btn_save.TabIndex = 54;
            this.btn_save.Text = "SAVE";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // lbl_salary
            // 
            this.lbl_salary.AutoSize = true;
            this.lbl_salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_salary.Location = new System.Drawing.Point(71, 272);
            this.lbl_salary.Name = "lbl_salary";
            this.lbl_salary.Size = new System.Drawing.Size(66, 24);
            this.lbl_salary.TabIndex = 62;
            this.lbl_salary.Text = "Salary:";
            // 
            // lbl_jdate
            // 
            this.lbl_jdate.AutoSize = true;
            this.lbl_jdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_jdate.Location = new System.Drawing.Point(71, 229);
            this.lbl_jdate.Name = "lbl_jdate";
            this.lbl_jdate.Size = new System.Drawing.Size(119, 24);
            this.lbl_jdate.TabIndex = 61;
            this.lbl_jdate.Text = "Joining Date:";
            // 
            // lbl_staffname
            // 
            this.lbl_staffname.AutoSize = true;
            this.lbl_staffname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_staffname.Location = new System.Drawing.Point(71, 188);
            this.lbl_staffname.Name = "lbl_staffname";
            this.lbl_staffname.Size = new System.Drawing.Size(105, 24);
            this.lbl_staffname.TabIndex = 60;
            this.lbl_staffname.Text = "Staff Name:";
            // 
            // txt_staff_name
            // 
            this.txt_staff_name.Location = new System.Drawing.Point(227, 188);
            this.txt_staff_name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_staff_name.Name = "txt_staff_name";
            this.txt_staff_name.Size = new System.Drawing.Size(169, 22);
            this.txt_staff_name.TabIndex = 63;
            // 
            // dt_jdate
            // 
            this.dt_jdate.Location = new System.Drawing.Point(227, 229);
            this.dt_jdate.Margin = new System.Windows.Forms.Padding(4);
            this.dt_jdate.Name = "dt_jdate";
            this.dt_jdate.Size = new System.Drawing.Size(169, 22);
            this.dt_jdate.TabIndex = 64;
            // 
            // txt_salary
            // 
            this.txt_salary.Location = new System.Drawing.Point(227, 272);
            this.txt_salary.Margin = new System.Windows.Forms.Padding(4);
            this.txt_salary.Name = "txt_salary";
            this.txt_salary.Size = new System.Drawing.Size(169, 22);
            this.txt_salary.TabIndex = 65;
            // 
            // dgv_staff
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.NullValue = "NULL";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_staff.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_staff.BackgroundColor = System.Drawing.Color.White;
            this.dgv_staff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_staff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STAFF_ID,
            this.NAME,
            this.JDATE,
            this.SALARY,
            this.DESIGNATION});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_staff.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_staff.GridColor = System.Drawing.Color.White;
            this.dgv_staff.Location = new System.Drawing.Point(495, 90);
            this.dgv_staff.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_staff.Name = "dgv_staff";
            this.dgv_staff.RowHeadersWidth = 51;
            this.dgv_staff.RowTemplate.Height = 25;
            this.dgv_staff.Size = new System.Drawing.Size(819, 462);
            this.dgv_staff.TabIndex = 66;
            this.dgv_staff.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_staff_CellClick);
            // 
            // STAFF_ID
            // 
            this.STAFF_ID.DataPropertyName = "STAFF_ID";
            this.STAFF_ID.HeaderText = "STAFF_ID";
            this.STAFF_ID.MinimumWidth = 6;
            this.STAFF_ID.Name = "STAFF_ID";
            this.STAFF_ID.Visible = false;
            this.STAFF_ID.Width = 125;
            // 
            // NAME
            // 
            this.NAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NAME.DataPropertyName = "NAME";
            this.NAME.HeaderText = "NAME";
            this.NAME.MinimumWidth = 6;
            this.NAME.Name = "NAME";
            // 
            // JDATE
            // 
            this.JDATE.DataPropertyName = "JDATE";
            this.JDATE.HeaderText = "JOINING DATE";
            this.JDATE.MinimumWidth = 6;
            this.JDATE.Name = "JDATE";
            this.JDATE.Width = 125;
            // 
            // SALARY
            // 
            this.SALARY.DataPropertyName = "SALARY";
            this.SALARY.HeaderText = "SALARY";
            this.SALARY.MinimumWidth = 6;
            this.SALARY.Name = "SALARY";
            this.SALARY.Width = 125;
            // 
            // DESIGNATION
            // 
            this.DESIGNATION.DataPropertyName = "DESIGNATION";
            this.DESIGNATION.HeaderText = "DESIGNATION";
            this.DESIGNATION.MinimumWidth = 6;
            this.DESIGNATION.Name = "DESIGNATION";
            this.DESIGNATION.Width = 125;
            // 
            // lbl_designation
            // 
            this.lbl_designation.AutoSize = true;
            this.lbl_designation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_designation.Location = new System.Drawing.Point(71, 321);
            this.lbl_designation.Name = "lbl_designation";
            this.lbl_designation.Size = new System.Drawing.Size(114, 24);
            this.lbl_designation.TabIndex = 67;
            this.lbl_designation.Text = "Designation:";
            // 
            // cmb_designation
            // 
            this.cmb_designation.FormattingEnabled = true;
            this.cmb_designation.Items.AddRange(new object[] {
            "ADMIN",
            "MANAGER",
            "SALESMAN",
            "HELPER"});
            this.cmb_designation.Location = new System.Drawing.Point(227, 321);
            this.cmb_designation.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_designation.Name = "cmb_designation";
            this.cmb_designation.Size = new System.Drawing.Size(169, 24);
            this.cmb_designation.TabIndex = 68;
            this.cmb_designation.Text = "--Select--";
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Location = new System.Drawing.Point(121, 396);
            this.btn_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(87, 32);
            this.btn_add.TabIndex = 69;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_staff_id
            // 
            this.txt_staff_id.Location = new System.Drawing.Point(227, 143);
            this.txt_staff_id.Margin = new System.Windows.Forms.Padding(4);
            this.txt_staff_id.Name = "txt_staff_id";
            this.txt_staff_id.ReadOnly = true;
            this.txt_staff_id.Size = new System.Drawing.Size(169, 22);
            this.txt_staff_id.TabIndex = 71;
            // 
            // lbl_staff_id
            // 
            this.lbl_staff_id.AutoSize = true;
            this.lbl_staff_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_staff_id.Location = new System.Drawing.Point(71, 143);
            this.lbl_staff_id.Name = "lbl_staff_id";
            this.lbl_staff_id.Size = new System.Drawing.Size(71, 24);
            this.lbl_staff_id.TabIndex = 70;
            this.lbl_staff_id.Text = "Staff ID:";
            // 
            // form_Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1382, 653);
            this.Controls.Add(this.txt_staff_id);
            this.Controls.Add(this.lbl_staff_id);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.cmb_designation);
            this.Controls.Add(this.lbl_designation);
            this.Controls.Add(this.dgv_staff);
            this.Controls.Add(this.txt_salary);
            this.Controls.Add(this.dt_jdate);
            this.Controls.Add(this.txt_staff_name);
            this.Controls.Add(this.lbl_salary);
            this.Controls.Add(this.lbl_jdate);
            this.Controls.Add(this.lbl_staffname);
            this.Controls.Add(this.btn_staff_back);
            this.Controls.Add(this.lbl_staff);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_save);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "form_Staff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff";
            this.Load += new System.EventHandler(this.Staff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_staff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_staff_back;
        private System.Windows.Forms.Label lbl_staff;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label lbl_salary;
        private System.Windows.Forms.Label lbl_jdate;
        private System.Windows.Forms.Label lbl_staffname;
        private System.Windows.Forms.TextBox txt_staff_name;
        private System.Windows.Forms.DateTimePicker dt_jdate;
        private System.Windows.Forms.TextBox txt_salary;
        private System.Windows.Forms.DataGridView dgv_staff;
        private System.Windows.Forms.Label lbl_designation;
        private System.Windows.Forms.ComboBox cmb_designation;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn STAFF_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn JDATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn SALARY;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESIGNATION;
        private System.Windows.Forms.TextBox txt_staff_id;
        private System.Windows.Forms.Label lbl_staff_id;
    }
}