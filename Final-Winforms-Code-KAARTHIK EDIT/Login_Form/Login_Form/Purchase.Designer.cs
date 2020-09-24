namespace Login_Form
{
    partial class form_Purchase
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_orders = new System.Windows.Forms.Label();
            this.dgv_orders = new System.Windows.Forms.DataGridView();
            this.btn_orders_back = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_totalamount = new System.Windows.Forms.TextBox();
            this.lbl_Totalamount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_order_no = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.txt_ventorid = new System.Windows.Forms.TextBox();
            this.lbl_vendor_id = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_order_date = new System.Windows.Forms.TextBox();
            this.ORDER_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ORDER_N0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ORD_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VENDOR_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL_AMT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_orders)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_orders
            // 
            this.lbl_orders.AutoSize = true;
            this.lbl_orders.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_orders.Location = new System.Drawing.Point(459, 15);
            this.lbl_orders.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_orders.Name = "lbl_orders";
            this.lbl_orders.Size = new System.Drawing.Size(340, 39);
            this.lbl_orders.TabIndex = 0;
            this.lbl_orders.Text = "PURCHASE ORDERS";
            // 
            // dgv_orders
            // 
            this.dgv_orders.BackgroundColor = System.Drawing.Color.White;
            this.dgv_orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_orders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ORDER_ID,
            this.ORDER_N0,
            this.ORD_DATE,
            this.VENDOR_ID,
            this.TOTAL_AMT});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_orders.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_orders.Location = new System.Drawing.Point(581, 155);
            this.dgv_orders.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_orders.Name = "dgv_orders";
            this.dgv_orders.RowHeadersWidth = 51;
            this.dgv_orders.Size = new System.Drawing.Size(788, 379);
            this.dgv_orders.TabIndex = 73;
            // 
            // btn_orders_back
            // 
            this.btn_orders_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_orders_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_orders_back.Location = new System.Drawing.Point(16, 15);
            this.btn_orders_back.Margin = new System.Windows.Forms.Padding(4);
            this.btn_orders_back.Name = "btn_orders_back";
            this.btn_orders_back.Size = new System.Drawing.Size(59, 33);
            this.btn_orders_back.TabIndex = 74;
            this.btn_orders_back.Text = "<-";
            this.btn_orders_back.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_totalamount);
            this.panel1.Controls.Add(this.lbl_Totalamount);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_order_no);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.btn_edit);
            this.panel1.Controls.Add(this.btn_delete);
            this.panel1.Controls.Add(this.txt_ventorid);
            this.panel1.Controls.Add(this.lbl_vendor_id);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_order_date);
            this.panel1.Location = new System.Drawing.Point(45, 155);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(515, 322);
            this.panel1.TabIndex = 77;
            // 
            // txt_totalamount
            // 
            this.txt_totalamount.Location = new System.Drawing.Point(212, 181);
            this.txt_totalamount.Margin = new System.Windows.Forms.Padding(4);
            this.txt_totalamount.Name = "txt_totalamount";
            this.txt_totalamount.Size = new System.Drawing.Size(255, 22);
            this.txt_totalamount.TabIndex = 74;
            // 
            // lbl_Totalamount
            // 
            this.lbl_Totalamount.AutoSize = true;
            this.lbl_Totalamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Totalamount.Location = new System.Drawing.Point(28, 181);
            this.lbl_Totalamount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Totalamount.Name = "lbl_Totalamount";
            this.lbl_Totalamount.Size = new System.Drawing.Size(127, 24);
            this.lbl_Totalamount.TabIndex = 73;
            this.lbl_Totalamount.Text = "Total Amount:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 67;
            this.label1.Text = "Order No:";
            // 
            // txt_order_no
            // 
            this.txt_order_no.Location = new System.Drawing.Point(212, 23);
            this.txt_order_no.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_order_no.Name = "txt_order_no";
            this.txt_order_no.Size = new System.Drawing.Size(255, 22);
            this.txt_order_no.TabIndex = 70;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Location = new System.Drawing.Point(116, 256);
            this.btn_save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 32);
            this.btn_save.TabIndex = 64;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Location = new System.Drawing.Point(261, 255);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 32);
            this.btn_edit.TabIndex = 65;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Location = new System.Drawing.Point(393, 255);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 33);
            this.btn_delete.TabIndex = 66;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // txt_ventorid
            // 
            this.txt_ventorid.Location = new System.Drawing.Point(212, 132);
            this.txt_ventorid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_ventorid.Name = "txt_ventorid";
            this.txt_ventorid.Size = new System.Drawing.Size(255, 22);
            this.txt_ventorid.TabIndex = 71;
            // 
            // lbl_vendor_id
            // 
            this.lbl_vendor_id.AutoSize = true;
            this.lbl_vendor_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vendor_id.Location = new System.Drawing.Point(23, 130);
            this.lbl_vendor_id.Name = "lbl_vendor_id";
            this.lbl_vendor_id.Size = new System.Drawing.Size(100, 24);
            this.lbl_vendor_id.TabIndex = 68;
            this.lbl_vendor_id.Text = "Vendor ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 24);
            this.label2.TabIndex = 69;
            this.label2.Text = "Order Date:";
            // 
            // txt_order_date
            // 
            this.txt_order_date.Location = new System.Drawing.Point(212, 76);
            this.txt_order_date.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_order_date.Name = "txt_order_date";
            this.txt_order_date.Size = new System.Drawing.Size(255, 22);
            this.txt_order_date.TabIndex = 72;
            // 
            // ORDER_ID
            // 
            this.ORDER_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ORDER_ID.DataPropertyName = "ORDER_ID";
            this.ORDER_ID.HeaderText = "ORDER ID";
            this.ORDER_ID.MinimumWidth = 6;
            this.ORDER_ID.Name = "ORDER_ID";
            // 
            // ORDER_N0
            // 
            this.ORDER_N0.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ORDER_N0.DataPropertyName = "ORDER_N0";
            this.ORDER_N0.HeaderText = "ORDER NO";
            this.ORDER_N0.MinimumWidth = 6;
            this.ORDER_N0.Name = "ORDER_N0";
            // 
            // ORD_DATE
            // 
            this.ORD_DATE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ORD_DATE.DataPropertyName = "ORD_DATE";
            this.ORD_DATE.HeaderText = "ORDER DATE";
            this.ORD_DATE.MinimumWidth = 6;
            this.ORD_DATE.Name = "ORD_DATE";
            // 
            // VENDOR_ID
            // 
            this.VENDOR_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.VENDOR_ID.DataPropertyName = "VENDOR_ID";
            this.VENDOR_ID.HeaderText = "VENDOR ID";
            this.VENDOR_ID.MinimumWidth = 6;
            this.VENDOR_ID.Name = "VENDOR_ID";
            // 
            // TOTAL_AMT
            // 
            this.TOTAL_AMT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TOTAL_AMT.DataPropertyName = "TOTAL_AMT";
            this.TOTAL_AMT.HeaderText = "TOTAL AMOUNT";
            this.TOTAL_AMT.MinimumWidth = 6;
            this.TOTAL_AMT.Name = "TOTAL_AMT";
            // 
            // form_Purchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1382, 653);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_orders_back);
            this.Controls.Add(this.dgv_orders);
            this.Controls.Add(this.lbl_orders);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "form_Purchase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase";
            this.Load += new System.EventHandler(this.Purchase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_orders)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_orders;
        private System.Windows.Forms.DataGridView dgv_orders;
        private System.Windows.Forms.Button btn_orders_back;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_totalamount;
        private System.Windows.Forms.Label lbl_Totalamount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_order_no;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.TextBox txt_ventorid;
        private System.Windows.Forms.Label lbl_vendor_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_order_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn ORDER_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ORDER_N0;
        private System.Windows.Forms.DataGridViewTextBoxColumn ORD_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn VENDOR_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL_AMT;
    }
}