namespace Login_Form
{
    partial class form_Customer
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
            this.lbl_customers = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.dgv_customers = new System.Windows.Forms.DataGridView();
            this.CUST_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUST_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUST_PHONE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_cust_back = new System.Windows.Forms.Button();
            this.lbl_cust_name = new System.Windows.Forms.Label();
            this.txt_CUSTOMERNAME = new System.Windows.Forms.TextBox();
            this.txt_PHONENUMBER = new System.Windows.Forms.TextBox();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.txt_cust_id = new System.Windows.Forms.TextBox();
            this.lbl_cust_id = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_customers)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_customers
            // 
            this.lbl_customers.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_customers.Location = new System.Drawing.Point(476, 33);
            this.lbl_customers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_customers.Name = "lbl_customers";
            this.lbl_customers.Size = new System.Drawing.Size(247, 36);
            this.lbl_customers.TabIndex = 15;
            this.lbl_customers.Text = "CUSTOMER";
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Location = new System.Drawing.Point(337, 373);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(100, 28);
            this.btn_delete.TabIndex = 14;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Location = new System.Drawing.Point(196, 373);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(100, 28);
            this.btn_edit.TabIndex = 13;
            this.btn_edit.Text = "EDIT";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Location = new System.Drawing.Point(60, 373);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(100, 28);
            this.btn_save.TabIndex = 12;
            this.btn_save.Text = "SAVE";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // dgv_customers
            // 
            this.dgv_customers.BackgroundColor = System.Drawing.Color.White;
            this.dgv_customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_customers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CUST_ID,
            this.CUST_NAME,
            this.CUST_PHONE});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_customers.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_customers.Location = new System.Drawing.Point(509, 133);
            this.dgv_customers.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_customers.Name = "dgv_customers";
            this.dgv_customers.RowHeadersWidth = 51;
            this.dgv_customers.Size = new System.Drawing.Size(839, 393);
            this.dgv_customers.TabIndex = 11;
            this.dgv_customers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_customers_CellClick);
            // 
            // CUST_ID
            // 
            this.CUST_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CUST_ID.DataPropertyName = "CUST_ID";
            this.CUST_ID.HeaderText = "CUSTOMER_ID";
            this.CUST_ID.MinimumWidth = 6;
            this.CUST_ID.Name = "CUST_ID";
            // 
            // CUST_NAME
            // 
            this.CUST_NAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CUST_NAME.DataPropertyName = "CUST_NAME";
            this.CUST_NAME.HeaderText = "CUSTOMER_NAME";
            this.CUST_NAME.MinimumWidth = 6;
            this.CUST_NAME.Name = "CUST_NAME";
            // 
            // CUST_PHONE
            // 
            this.CUST_PHONE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CUST_PHONE.DataPropertyName = "CUST_PHONE";
            this.CUST_PHONE.HeaderText = "PHONE NUMBER";
            this.CUST_PHONE.MinimumWidth = 6;
            this.CUST_PHONE.Name = "CUST_PHONE";
            // 
            // btn_cust_back
            // 
            this.btn_cust_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_cust_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cust_back.Location = new System.Drawing.Point(16, 15);
            this.btn_cust_back.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cust_back.Name = "btn_cust_back";
            this.btn_cust_back.Size = new System.Drawing.Size(56, 37);
            this.btn_cust_back.TabIndex = 16;
            this.btn_cust_back.Text = "<-";
            this.btn_cust_back.UseVisualStyleBackColor = false;
            this.btn_cust_back.Click += new System.EventHandler(this.btn_cust_back_Click);
            // 
            // lbl_cust_name
            // 
            this.lbl_cust_name.AutoSize = true;
            this.lbl_cust_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cust_name.Location = new System.Drawing.Point(56, 185);
            this.lbl_cust_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cust_name.Name = "lbl_cust_name";
            this.lbl_cust_name.Size = new System.Drawing.Size(150, 20);
            this.lbl_cust_name.TabIndex = 18;
            this.lbl_cust_name.Text = "Customer Name:";
            // 
            // txt_CUSTOMERNAME
            // 
            this.txt_CUSTOMERNAME.Location = new System.Drawing.Point(216, 180);
            this.txt_CUSTOMERNAME.Margin = new System.Windows.Forms.Padding(4);
            this.txt_CUSTOMERNAME.Name = "txt_CUSTOMERNAME";
            this.txt_CUSTOMERNAME.Size = new System.Drawing.Size(220, 22);
            this.txt_CUSTOMERNAME.TabIndex = 19;
            // 
            // txt_PHONENUMBER
            // 
            this.txt_PHONENUMBER.Location = new System.Drawing.Point(216, 238);
            this.txt_PHONENUMBER.Margin = new System.Windows.Forms.Padding(4);
            this.txt_PHONENUMBER.Name = "txt_PHONENUMBER";
            this.txt_PHONENUMBER.Size = new System.Drawing.Size(220, 22);
            this.txt_PHONENUMBER.TabIndex = 21;
            // 
            // lbl_phone
            // 
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_phone.Location = new System.Drawing.Point(56, 242);
            this.lbl_phone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(138, 20);
            this.lbl_phone.TabIndex = 20;
            this.lbl_phone.Text = "Phone Number:";
            // 
            // txt_cust_id
            // 
            this.txt_cust_id.BackColor = System.Drawing.Color.White;
            this.txt_cust_id.Location = new System.Drawing.Point(216, 133);
            this.txt_cust_id.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cust_id.Name = "txt_cust_id";
            this.txt_cust_id.ReadOnly = true;
            this.txt_cust_id.Size = new System.Drawing.Size(220, 22);
            this.txt_cust_id.TabIndex = 23;
            // 
            // lbl_cust_id
            // 
            this.lbl_cust_id.AutoSize = true;
            this.lbl_cust_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cust_id.Location = new System.Drawing.Point(56, 138);
            this.lbl_cust_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cust_id.Name = "lbl_cust_id";
            this.lbl_cust_id.Size = new System.Drawing.Size(121, 20);
            this.lbl_cust_id.TabIndex = 22;
            this.lbl_cust_id.Text = "Customer ID:";
            // 
            // form_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1382, 653);
            this.Controls.Add(this.txt_cust_id);
            this.Controls.Add(this.lbl_cust_id);
            this.Controls.Add(this.txt_PHONENUMBER);
            this.Controls.Add(this.lbl_phone);
            this.Controls.Add(this.txt_CUSTOMERNAME);
            this.Controls.Add(this.lbl_cust_name);
            this.Controls.Add(this.btn_cust_back);
            this.Controls.Add(this.lbl_customers);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.dgv_customers);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "form_Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.form_Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_customers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_customers;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.DataGridView dgv_customers;
        private System.Windows.Forms.Button btn_cust_back;
        private System.Windows.Forms.Label lbl_cust_name;
        private System.Windows.Forms.TextBox txt_CUSTOMERNAME;
        private System.Windows.Forms.TextBox txt_PHONENUMBER;
        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.TextBox txt_cust_id;
        private System.Windows.Forms.Label lbl_cust_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUST_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUST_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUST_PHONE;
    }
}