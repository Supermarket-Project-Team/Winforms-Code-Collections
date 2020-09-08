namespace sales_winform
{
    partial class Form1
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
            this.lbl_billno = new System.Windows.Forms.Label();
            this.lbl_billdate = new System.Windows.Forms.Label();
            this.lbl_cname = new System.Windows.Forms.Label();
            this.lbl_cphone = new System.Windows.Forms.Label();
            this.lbl_remark = new System.Windows.Forms.Label();
            this.lbl_loyalty = new System.Windows.Forms.Label();
            this.lbl_salesman = new System.Windows.Forms.Label();
            this.txt_billno = new System.Windows.Forms.TextBox();
            this.txt_billdate = new System.Windows.Forms.TextBox();
            this.txt_cname = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txt_remark = new System.Windows.Forms.TextBox();
            this.txt_loyalty = new System.Windows.Forms.TextBox();
            this.cb_salesman = new System.Windows.Forms.ComboBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.dgv_productdetails = new System.Windows.Forms.DataGridView();
            this.lbl_totalamt = new System.Windows.Forms.Label();
            this.lbl_paymode = new System.Windows.Forms.Label();
            this.txt_totalamt = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbl_salesheading = new System.Windows.Forms.Label();
            this.lbl_customerdetails = new System.Windows.Forms.Label();
            this.lbl_productdetails = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productdetails)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_billno
            // 
            this.lbl_billno.AutoSize = true;
            this.lbl_billno.Location = new System.Drawing.Point(44, 75);
            this.lbl_billno.Name = "lbl_billno";
            this.lbl_billno.Size = new System.Drawing.Size(52, 17);
            this.lbl_billno.TabIndex = 0;
            this.lbl_billno.Text = "Bill No:";
            // 
            // lbl_billdate
            // 
            this.lbl_billdate.AutoSize = true;
            this.lbl_billdate.Location = new System.Drawing.Point(220, 75);
            this.lbl_billdate.Name = "lbl_billdate";
            this.lbl_billdate.Size = new System.Drawing.Size(64, 17);
            this.lbl_billdate.TabIndex = 1;
            this.lbl_billdate.Text = "Bill Date:";
            // 
            // lbl_cname
            // 
            this.lbl_cname.AutoSize = true;
            this.lbl_cname.Location = new System.Drawing.Point(44, 203);
            this.lbl_cname.Name = "lbl_cname";
            this.lbl_cname.Size = new System.Drawing.Size(113, 17);
            this.lbl_cname.TabIndex = 2;
            this.lbl_cname.Text = "Customer Name:";
            // 
            // lbl_cphone
            // 
            this.lbl_cphone.AutoSize = true;
            this.lbl_cphone.Location = new System.Drawing.Point(44, 242);
            this.lbl_cphone.Name = "lbl_cphone";
            this.lbl_cphone.Size = new System.Drawing.Size(107, 17);
            this.lbl_cphone.TabIndex = 3;
            this.lbl_cphone.Text = "Phone Number:";
            // 
            // lbl_remark
            // 
            this.lbl_remark.AutoSize = true;
            this.lbl_remark.Location = new System.Drawing.Point(44, 281);
            this.lbl_remark.Name = "lbl_remark";
            this.lbl_remark.Size = new System.Drawing.Size(61, 17);
            this.lbl_remark.TabIndex = 4;
            this.lbl_remark.Text = "Remark:";
            // 
            // lbl_loyalty
            // 
            this.lbl_loyalty.AutoSize = true;
            this.lbl_loyalty.Location = new System.Drawing.Point(44, 315);
            this.lbl_loyalty.Name = "lbl_loyalty";
            this.lbl_loyalty.Size = new System.Drawing.Size(100, 17);
            this.lbl_loyalty.TabIndex = 5;
            this.lbl_loyalty.Text = "Loyalty Points:";
            // 
            // lbl_salesman
            // 
            this.lbl_salesman.AutoSize = true;
            this.lbl_salesman.Location = new System.Drawing.Point(44, 355);
            this.lbl_salesman.Name = "lbl_salesman";
            this.lbl_salesman.Size = new System.Drawing.Size(74, 17);
            this.lbl_salesman.TabIndex = 6;
            this.lbl_salesman.Text = "Salesman:";
            // 
            // txt_billno
            // 
            this.txt_billno.Location = new System.Drawing.Point(102, 75);
            this.txt_billno.Name = "txt_billno";
            this.txt_billno.Size = new System.Drawing.Size(100, 22);
            this.txt_billno.TabIndex = 7;
            // 
            // txt_billdate
            // 
            this.txt_billdate.Location = new System.Drawing.Point(290, 75);
            this.txt_billdate.Name = "txt_billdate";
            this.txt_billdate.Size = new System.Drawing.Size(100, 22);
            this.txt_billdate.TabIndex = 8;
            // 
            // txt_cname
            // 
            this.txt_cname.Location = new System.Drawing.Point(163, 198);
            this.txt_cname.Name = "txt_cname";
            this.txt_cname.Size = new System.Drawing.Size(121, 22);
            this.txt_cname.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(163, 237);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(121, 22);
            this.textBox4.TabIndex = 10;
            // 
            // txt_remark
            // 
            this.txt_remark.Location = new System.Drawing.Point(163, 276);
            this.txt_remark.Name = "txt_remark";
            this.txt_remark.Size = new System.Drawing.Size(121, 22);
            this.txt_remark.TabIndex = 11;
            // 
            // txt_loyalty
            // 
            this.txt_loyalty.Location = new System.Drawing.Point(163, 310);
            this.txt_loyalty.Name = "txt_loyalty";
            this.txt_loyalty.Size = new System.Drawing.Size(121, 22);
            this.txt_loyalty.TabIndex = 12;
            // 
            // cb_salesman
            // 
            this.cb_salesman.FormattingEnabled = true;
            this.cb_salesman.Location = new System.Drawing.Point(163, 348);
            this.cb_salesman.Name = "cb_salesman";
            this.cb_salesman.Size = new System.Drawing.Size(121, 24);
            this.cb_salesman.TabIndex = 13;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(678, 75);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 32);
            this.btn_save.TabIndex = 14;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(759, 75);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 32);
            this.btn_edit.TabIndex = 15;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(840, 74);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 33);
            this.btn_delete.TabIndex = 16;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // dgv_productdetails
            // 
            this.dgv_productdetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_productdetails.Location = new System.Drawing.Point(320, 183);
            this.dgv_productdetails.Name = "dgv_productdetails";
            this.dgv_productdetails.RowHeadersWidth = 51;
            this.dgv_productdetails.RowTemplate.Height = 24;
            this.dgv_productdetails.Size = new System.Drawing.Size(595, 220);
            this.dgv_productdetails.TabIndex = 17;
            // 
            // lbl_totalamt
            // 
            this.lbl_totalamt.AutoSize = true;
            this.lbl_totalamt.Location = new System.Drawing.Point(665, 419);
            this.lbl_totalamt.Name = "lbl_totalamt";
            this.lbl_totalamt.Size = new System.Drawing.Size(96, 17);
            this.lbl_totalamt.TabIndex = 18;
            this.lbl_totalamt.Text = "Total Amount:";
            // 
            // lbl_paymode
            // 
            this.lbl_paymode.AutoSize = true;
            this.lbl_paymode.Location = new System.Drawing.Point(665, 452);
            this.lbl_paymode.Name = "lbl_paymode";
            this.lbl_paymode.Size = new System.Drawing.Size(106, 17);
            this.lbl_paymode.TabIndex = 19;
            this.lbl_paymode.Text = "Payment Mode:";
            this.lbl_paymode.Click += new System.EventHandler(this.lbl_paymode_Click);
            // 
            // txt_totalamt
            // 
            this.txt_totalamt.Location = new System.Drawing.Point(794, 414);
            this.txt_totalamt.Name = "txt_totalamt";
            this.txt_totalamt.Size = new System.Drawing.Size(121, 22);
            this.txt_totalamt.TabIndex = 20;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(794, 452);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 21;
            // 
            // lbl_salesheading
            // 
            this.lbl_salesheading.AutoSize = true;
            this.lbl_salesheading.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_salesheading.Location = new System.Drawing.Point(386, 9);
            this.lbl_salesheading.Name = "lbl_salesheading";
            this.lbl_salesheading.Size = new System.Drawing.Size(147, 29);
            this.lbl_salesheading.TabIndex = 22;
            this.lbl_salesheading.Text = "Sales Page";
            // 
            // lbl_customerdetails
            // 
            this.lbl_customerdetails.AutoSize = true;
            this.lbl_customerdetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_customerdetails.Location = new System.Drawing.Point(47, 152);
            this.lbl_customerdetails.Name = "lbl_customerdetails";
            this.lbl_customerdetails.Size = new System.Drawing.Size(190, 25);
            this.lbl_customerdetails.TabIndex = 23;
            this.lbl_customerdetails.Text = "Customer Details :";
            // 
            // lbl_productdetails
            // 
            this.lbl_productdetails.AutoSize = true;
            this.lbl_productdetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_productdetails.Location = new System.Drawing.Point(320, 152);
            this.lbl_productdetails.Name = "lbl_productdetails";
            this.lbl_productdetails.Size = new System.Drawing.Size(182, 25);
            this.lbl_productdetails.TabIndex = 24;
            this.lbl_productdetails.Text = "Products Details :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 497);
            this.Controls.Add(this.lbl_productdetails);
            this.Controls.Add(this.lbl_customerdetails);
            this.Controls.Add(this.lbl_salesheading);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txt_totalamt);
            this.Controls.Add(this.lbl_paymode);
            this.Controls.Add(this.lbl_totalamt);
            this.Controls.Add(this.dgv_productdetails);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.cb_salesman);
            this.Controls.Add(this.txt_loyalty);
            this.Controls.Add(this.txt_remark);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.txt_cname);
            this.Controls.Add(this.txt_billdate);
            this.Controls.Add(this.txt_billno);
            this.Controls.Add(this.lbl_salesman);
            this.Controls.Add(this.lbl_loyalty);
            this.Controls.Add(this.lbl_remark);
            this.Controls.Add(this.lbl_cphone);
            this.Controls.Add(this.lbl_cname);
            this.Controls.Add(this.lbl_billdate);
            this.Controls.Add(this.lbl_billno);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productdetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_billno;
        private System.Windows.Forms.Label lbl_billdate;
        private System.Windows.Forms.Label lbl_cname;
        private System.Windows.Forms.Label lbl_cphone;
        private System.Windows.Forms.Label lbl_remark;
        private System.Windows.Forms.Label lbl_loyalty;
        private System.Windows.Forms.Label lbl_salesman;
        private System.Windows.Forms.TextBox txt_billno;
        private System.Windows.Forms.TextBox txt_billdate;
        private System.Windows.Forms.TextBox txt_cname;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox txt_remark;
        private System.Windows.Forms.TextBox txt_loyalty;
        private System.Windows.Forms.ComboBox cb_salesman;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.DataGridView dgv_productdetails;
        private System.Windows.Forms.Label lbl_totalamt;
        private System.Windows.Forms.Label lbl_paymode;
        private System.Windows.Forms.TextBox txt_totalamt;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbl_salesheading;
        private System.Windows.Forms.Label lbl_customerdetails;
        private System.Windows.Forms.Label lbl_productdetails;
    }
}

