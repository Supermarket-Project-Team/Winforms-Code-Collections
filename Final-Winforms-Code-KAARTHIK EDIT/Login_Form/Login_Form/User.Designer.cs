namespace Login_Form
{
    partial class form_User
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
            this.lbl_usercreation = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_name_user = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_name_user = new System.Windows.Forms.Label();
            this.lbl_designation = new System.Windows.Forms.Label();
            this.dgv_user_create = new System.Windows.Forms.DataGridView();
            this.STAFF_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USER_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PASSWORD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESIGNATION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cb_designation = new System.Windows.Forms.ComboBox();
            this.btn_user_back = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_staffid = new System.Windows.Forms.TextBox();
            this.lbl_staff_id = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_user_create)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_usercreation
            // 
            this.lbl_usercreation.AutoSize = true;
            this.lbl_usercreation.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usercreation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_usercreation.Location = new System.Drawing.Point(83, 91);
            this.lbl_usercreation.Name = "lbl_usercreation";
            this.lbl_usercreation.Size = new System.Drawing.Size(238, 31);
            this.lbl_usercreation.TabIndex = 53;
            this.lbl_usercreation.Text = "USER CREATION";
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_delete.Location = new System.Drawing.Point(217, 427);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(69, 27);
            this.btn_delete.TabIndex = 52;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_edit.Location = new System.Drawing.Point(89, 428);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(69, 26);
            this.btn_edit.TabIndex = 51;
            this.btn_edit.Text = "EDIT";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_save.Location = new System.Drawing.Point(217, 355);
            this.btn_save.Margin = new System.Windows.Forms.Padding(2);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(69, 26);
            this.btn_save.TabIndex = 50;
            this.btn_save.Text = "SAVE";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(184, 291);
            this.txt_password.Margin = new System.Windows.Forms.Padding(2);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(154, 20);
            this.txt_password.TabIndex = 61;
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(184, 254);
            this.txt_username.Margin = new System.Windows.Forms.Padding(2);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(154, 20);
            this.txt_username.TabIndex = 60;
            // 
            // txt_name_user
            // 
            this.txt_name_user.Location = new System.Drawing.Point(184, 185);
            this.txt_name_user.Margin = new System.Windows.Forms.Padding(2);
            this.txt_name_user.Name = "txt_name_user";
            this.txt_name_user.Size = new System.Drawing.Size(154, 20);
            this.txt_name_user.TabIndex = 59;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.Location = new System.Drawing.Point(57, 293);
            this.lbl_password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(75, 18);
            this.lbl_password.TabIndex = 57;
            this.lbl_password.Text = "Password";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(57, 256);
            this.lbl_username.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(81, 18);
            this.lbl_username.TabIndex = 56;
            this.lbl_username.Text = "Username:";
            // 
            // lbl_name_user
            // 
            this.lbl_name_user.AutoSize = true;
            this.lbl_name_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name_user.Location = new System.Drawing.Point(57, 187);
            this.lbl_name_user.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_name_user.Name = "lbl_name_user";
            this.lbl_name_user.Size = new System.Drawing.Size(52, 18);
            this.lbl_name_user.TabIndex = 55;
            this.lbl_name_user.Text = "Name:";
            // 
            // lbl_designation
            // 
            this.lbl_designation.AutoSize = true;
            this.lbl_designation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_designation.Location = new System.Drawing.Point(57, 221);
            this.lbl_designation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_designation.Name = "lbl_designation";
            this.lbl_designation.Size = new System.Drawing.Size(90, 18);
            this.lbl_designation.TabIndex = 54;
            this.lbl_designation.Text = "Designation:";
            // 
            // dgv_user_create
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_user_create.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_user_create.BackgroundColor = System.Drawing.Color.White;
            this.dgv_user_create.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_user_create.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STAFF_ID,
            this.NAME,
            this.USER_NAME,
            this.PASSWORD,
            this.DESIGNATION});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_user_create.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_user_create.Location = new System.Drawing.Point(371, 80);
            this.dgv_user_create.Name = "dgv_user_create";
            this.dgv_user_create.RowHeadersWidth = 51;
            this.dgv_user_create.Size = new System.Drawing.Size(640, 390);
            this.dgv_user_create.TabIndex = 63;
            this.dgv_user_create.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_user_create_CellClick);
            // 
            // STAFF_ID
            // 
            this.STAFF_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.STAFF_ID.DataPropertyName = "STAFF_ID";
            this.STAFF_ID.HeaderText = "STAFF ID";
            this.STAFF_ID.MinimumWidth = 6;
            this.STAFF_ID.Name = "STAFF_ID";
            // 
            // NAME
            // 
            this.NAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NAME.DataPropertyName = "NAME";
            this.NAME.HeaderText = "STAFF NAME";
            this.NAME.MinimumWidth = 6;
            this.NAME.Name = "NAME";
            // 
            // USER_NAME
            // 
            this.USER_NAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.USER_NAME.DataPropertyName = "USER_NAME";
            this.USER_NAME.HeaderText = "USER NAME";
            this.USER_NAME.MinimumWidth = 6;
            this.USER_NAME.Name = "USER_NAME";
            // 
            // PASSWORD
            // 
            this.PASSWORD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PASSWORD.DataPropertyName = "PASSWORD";
            this.PASSWORD.HeaderText = "PASSWORD";
            this.PASSWORD.MinimumWidth = 6;
            this.PASSWORD.Name = "PASSWORD";
            // 
            // DESIGNATION
            // 
            this.DESIGNATION.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DESIGNATION.DataPropertyName = "DESIGNATION";
            this.DESIGNATION.HeaderText = "DESIGNATION";
            this.DESIGNATION.MinimumWidth = 6;
            this.DESIGNATION.Name = "DESIGNATION";
            // 
            // cb_designation
            // 
            this.cb_designation.FormattingEnabled = true;
            this.cb_designation.Items.AddRange(new object[] {
            "ADMIN",
            "MANAGER",
            "SALESMAN",
            "HELPER"});
            this.cb_designation.Location = new System.Drawing.Point(184, 218);
            this.cb_designation.Name = "cb_designation";
            this.cb_designation.Size = new System.Drawing.Size(154, 21);
            this.cb_designation.TabIndex = 64;
            this.cb_designation.Text = "--Select--";
            // 
            // btn_user_back
            // 
            this.btn_user_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_user_back.Location = new System.Drawing.Point(12, 12);
            this.btn_user_back.Name = "btn_user_back";
            this.btn_user_back.Size = new System.Drawing.Size(31, 23);
            this.btn_user_back.TabIndex = 65;
            this.btn_user_back.Text = "<-";
            this.btn_user_back.UseVisualStyleBackColor = false;
            this.btn_user_back.Click += new System.EventHandler(this.btn_user_back_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_add.Location = new System.Drawing.Point(89, 355);
            this.btn_add.Margin = new System.Windows.Forms.Padding(2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(69, 26);
            this.btn_add.TabIndex = 66;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_staffid
            // 
            this.txt_staffid.Location = new System.Drawing.Point(184, 149);
            this.txt_staffid.Margin = new System.Windows.Forms.Padding(2);
            this.txt_staffid.Name = "txt_staffid";
            this.txt_staffid.ReadOnly = true;
            this.txt_staffid.Size = new System.Drawing.Size(154, 20);
            this.txt_staffid.TabIndex = 68;
            // 
            // lbl_staff_id
            // 
            this.lbl_staff_id.AutoSize = true;
            this.lbl_staff_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_staff_id.Location = new System.Drawing.Point(57, 151);
            this.lbl_staff_id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_staff_id.Name = "lbl_staff_id";
            this.lbl_staff_id.Size = new System.Drawing.Size(60, 18);
            this.lbl_staff_id.TabIndex = 67;
            this.lbl_staff_id.Text = "Staff ID:";
            // 
            // form_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 531);
            this.Controls.Add(this.txt_staffid);
            this.Controls.Add(this.lbl_staff_id);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_user_back);
            this.Controls.Add(this.cb_designation);
            this.Controls.Add(this.dgv_user_create);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.txt_name_user);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.lbl_name_user);
            this.Controls.Add(this.lbl_designation);
            this.Controls.Add(this.lbl_usercreation);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_save);
            this.Name = "form_User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User";
            this.Load += new System.EventHandler(this.form_User_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_user_create)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_usercreation;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_name_user;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_name_user;
        private System.Windows.Forms.Label lbl_designation;
        private System.Windows.Forms.DataGridView dgv_user_create;
        private System.Windows.Forms.ComboBox cb_designation;
        private System.Windows.Forms.Button btn_user_back;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txt_staffid;
        private System.Windows.Forms.Label lbl_staff_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn STAFF_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn USER_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn PASSWORD;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESIGNATION;
    }
}