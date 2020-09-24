namespace Login_Form
{
    partial class form_vendor
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
            this.btn_vendor_back = new System.Windows.Forms.Button();
            this.dgv_vendor_details = new System.Windows.Forms.DataGridView();
            this.VENDOR_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VENDOR_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VENDOR_PHONE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LOCATION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_location = new System.Windows.Forms.TextBox();
            this.txt_phonenumber = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_location = new System.Windows.Forms.Label();
            this.lbl_phone_vendor = new System.Windows.Forms.Label();
            this.lbl_name_vendor = new System.Windows.Forms.Label();
            this.lbl_vendordetails = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_vendor_id = new System.Windows.Forms.TextBox();
            this.lbl_vendor_id = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vendor_details)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_vendor_back
            // 
            this.btn_vendor_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_vendor_back.Location = new System.Drawing.Point(41, 23);
            this.btn_vendor_back.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_vendor_back.Name = "btn_vendor_back";
            this.btn_vendor_back.Size = new System.Drawing.Size(59, 34);
            this.btn_vendor_back.TabIndex = 78;
            this.btn_vendor_back.Text = "<-";
            this.btn_vendor_back.UseVisualStyleBackColor = false;
            this.btn_vendor_back.Click += new System.EventHandler(this.btn_vendor_back_Click);
            // 
            // dgv_vendor_details
            // 
            this.dgv_vendor_details.BackgroundColor = System.Drawing.Color.White;
            this.dgv_vendor_details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_vendor_details.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VENDOR_ID,
            this.VENDOR_NAME,
            this.VENDOR_PHONE,
            this.LOCATION});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_vendor_details.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_vendor_details.Location = new System.Drawing.Point(556, 172);
            this.dgv_vendor_details.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_vendor_details.Name = "dgv_vendor_details";
            this.dgv_vendor_details.RowHeadersWidth = 51;
            this.dgv_vendor_details.Size = new System.Drawing.Size(749, 401);
            this.dgv_vendor_details.TabIndex = 77;
            this.dgv_vendor_details.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_vendor_details_CellClick);
            // 
            // VENDOR_ID
            // 
            this.VENDOR_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.VENDOR_ID.DataPropertyName = "VENDOR_ID";
            this.VENDOR_ID.HeaderText = "VENDOR ID";
            this.VENDOR_ID.MinimumWidth = 6;
            this.VENDOR_ID.Name = "VENDOR_ID";
            // 
            // VENDOR_NAME
            // 
            this.VENDOR_NAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.VENDOR_NAME.DataPropertyName = "VENDOR_NAME";
            this.VENDOR_NAME.HeaderText = "VENDOR NAME";
            this.VENDOR_NAME.MinimumWidth = 6;
            this.VENDOR_NAME.Name = "VENDOR_NAME";
            // 
            // VENDOR_PHONE
            // 
            this.VENDOR_PHONE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.VENDOR_PHONE.DataPropertyName = "VENDOR_PHONE";
            this.VENDOR_PHONE.HeaderText = "VENDOR PHONE";
            this.VENDOR_PHONE.MinimumWidth = 6;
            this.VENDOR_PHONE.Name = "VENDOR_PHONE";
            // 
            // LOCATION
            // 
            this.LOCATION.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LOCATION.DataPropertyName = "LOCATION";
            this.LOCATION.HeaderText = "LOCATION";
            this.LOCATION.MinimumWidth = 6;
            this.LOCATION.Name = "LOCATION";
            // 
            // txt_location
            // 
            this.txt_location.Location = new System.Drawing.Point(268, 347);
            this.txt_location.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_location.Name = "txt_location";
            this.txt_location.Size = new System.Drawing.Size(163, 22);
            this.txt_location.TabIndex = 76;
            // 
            // txt_phonenumber
            // 
            this.txt_phonenumber.Location = new System.Drawing.Point(268, 302);
            this.txt_phonenumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_phonenumber.Name = "txt_phonenumber";
            this.txt_phonenumber.Size = new System.Drawing.Size(163, 22);
            this.txt_phonenumber.TabIndex = 75;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(268, 261);
            this.txt_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(163, 22);
            this.txt_name.TabIndex = 74;
            // 
            // lbl_location
            // 
            this.lbl_location.AutoSize = true;
            this.lbl_location.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_location.Location = new System.Drawing.Point(119, 351);
            this.lbl_location.Name = "lbl_location";
            this.lbl_location.Size = new System.Drawing.Size(86, 24);
            this.lbl_location.TabIndex = 73;
            this.lbl_location.Text = "Location:";
            // 
            // lbl_phone_vendor
            // 
            this.lbl_phone_vendor.AutoSize = true;
            this.lbl_phone_vendor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_phone_vendor.Location = new System.Drawing.Point(119, 305);
            this.lbl_phone_vendor.Name = "lbl_phone_vendor";
            this.lbl_phone_vendor.Size = new System.Drawing.Size(145, 24);
            this.lbl_phone_vendor.TabIndex = 72;
            this.lbl_phone_vendor.Text = "Phone Number:";
            // 
            // lbl_name_vendor
            // 
            this.lbl_name_vendor.AutoSize = true;
            this.lbl_name_vendor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name_vendor.Location = new System.Drawing.Point(119, 261);
            this.lbl_name_vendor.Name = "lbl_name_vendor";
            this.lbl_name_vendor.Size = new System.Drawing.Size(66, 24);
            this.lbl_name_vendor.TabIndex = 71;
            this.lbl_name_vendor.Text = "Name:";
            // 
            // lbl_vendordetails
            // 
            this.lbl_vendordetails.AutoSize = true;
            this.lbl_vendordetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vendordetails.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_vendordetails.Location = new System.Drawing.Point(496, 37);
            this.lbl_vendordetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_vendordetails.Name = "lbl_vendordetails";
            this.lbl_vendordetails.Size = new System.Drawing.Size(185, 29);
            this.lbl_vendordetails.TabIndex = 70;
            this.lbl_vendordetails.Text = "Vendor Details";
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_delete.Location = new System.Drawing.Point(357, 431);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 33);
            this.btn_delete.TabIndex = 69;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_edit.Location = new System.Drawing.Point(239, 432);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 32);
            this.btn_edit.TabIndex = 68;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_save.Location = new System.Drawing.Point(113, 432);
            this.btn_save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 32);
            this.btn_save.TabIndex = 67;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_vendor_id
            // 
            this.txt_vendor_id.Location = new System.Drawing.Point(268, 214);
            this.txt_vendor_id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_vendor_id.Name = "txt_vendor_id";
            this.txt_vendor_id.Size = new System.Drawing.Size(163, 22);
            this.txt_vendor_id.TabIndex = 80;
            // 
            // lbl_vendor_id
            // 
            this.lbl_vendor_id.AutoSize = true;
            this.lbl_vendor_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vendor_id.Location = new System.Drawing.Point(119, 214);
            this.lbl_vendor_id.Name = "lbl_vendor_id";
            this.lbl_vendor_id.Size = new System.Drawing.Size(105, 24);
            this.lbl_vendor_id.TabIndex = 79;
            this.lbl_vendor_id.Text = " Vendor ID:";
            // 
            // form_vendor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1371, 654);
            this.Controls.Add(this.txt_vendor_id);
            this.Controls.Add(this.lbl_vendor_id);
            this.Controls.Add(this.btn_vendor_back);
            this.Controls.Add(this.dgv_vendor_details);
            this.Controls.Add(this.txt_location);
            this.Controls.Add(this.txt_phonenumber);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lbl_location);
            this.Controls.Add(this.lbl_phone_vendor);
            this.Controls.Add(this.lbl_name_vendor);
            this.Controls.Add(this.lbl_vendordetails);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_save);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "form_vendor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "vendor";
            this.Load += new System.EventHandler(this.form_vendor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vendor_details)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_vendor_back;
        private System.Windows.Forms.DataGridView dgv_vendor_details;
        private System.Windows.Forms.TextBox txt_location;
        private System.Windows.Forms.TextBox txt_phonenumber;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_location;
        private System.Windows.Forms.Label lbl_phone_vendor;
        private System.Windows.Forms.Label lbl_name_vendor;
        private System.Windows.Forms.Label lbl_vendordetails;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.DataGridViewTextBoxColumn VENDOR_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn VENDOR_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn VENDOR_PHONE;
        private System.Windows.Forms.DataGridViewTextBoxColumn LOCATION;
        private System.Windows.Forms.TextBox txt_vendor_id;
        private System.Windows.Forms.Label lbl_vendor_id;
    }
}