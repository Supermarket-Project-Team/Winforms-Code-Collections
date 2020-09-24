namespace Login_Form
{
    partial class Billing
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_productdetails = new System.Windows.Forms.Label();
            this.lbl_customerdetails = new System.Windows.Forms.Label();
            this.cb_paymode = new System.Windows.Forms.ComboBox();
            this.txt_totalamt = new System.Windows.Forms.TextBox();
            this.lbl_paymode = new System.Windows.Forms.Label();
            this.lbl_totalamt = new System.Windows.Forms.Label();
            this.dgv_productdetails = new System.Windows.Forms.DataGridView();
            this.btn_save = new System.Windows.Forms.Button();
            this.cb_salesman = new System.Windows.Forms.ComboBox();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.txt_billno = new System.Windows.Forms.TextBox();
            this.bILLINGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.superMarketDataSet = new Login_Form.SuperMarketDataSet();
            this.lbl_salesman = new System.Windows.Forms.Label();
            this.lbl_cphone = new System.Windows.Forms.Label();
            this.lbl_billdate = new System.Windows.Forms.Label();
            this.lbl_billno = new System.Windows.Forms.Label();
            this.btn_bill_back = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.dt_bill_date = new System.Windows.Forms.DateTimePicker();
            this.pl_bill_detail = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_pro_id = new System.Windows.Forms.TextBox();
            this.lbl_pro_id = new System.Windows.Forms.Label();
            this.lbl_si_no = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.txt_CGST = new System.Windows.Forms.TextBox();
            this.lbl_CGST = new System.Windows.Forms.Label();
            this.txt_SGST = new System.Windows.Forms.TextBox();
            this.lbl_SGST = new System.Windows.Forms.Label();
            this.txt_Discount = new System.Windows.Forms.TextBox();
            this.lbl_discount = new System.Windows.Forms.Label();
            this.txt_MRP = new System.Windows.Forms.TextBox();
            this.lbl_MRP = new System.Windows.Forms.Label();
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.lbl_Quantity = new System.Windows.Forms.Label();
            this.txt_Product = new System.Windows.Forms.TextBox();
            this.lbl_Product = new System.Windows.Forms.Label();
            this.txt_Pro_Search = new System.Windows.Forms.TextBox();
            this.lbl_Pro_Search = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_customername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_submit = new System.Windows.Forms.Button();
            this.btn_bill_cancel = new System.Windows.Forms.Button();
            this.bILLINGTableAdapter = new Login_Form.SuperMarketDataSetTableAdapters.BILLINGTableAdapter();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.lbl_salesman_id = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productdetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bILLINGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.superMarketDataSet)).BeginInit();
            this.pl_bill_detail.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_productdetails
            // 
            this.lbl_productdetails.AutoSize = true;
            this.lbl_productdetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_productdetails.Location = new System.Drawing.Point(6, 9);
            this.lbl_productdetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_productdetails.Name = "lbl_productdetails";
            this.lbl_productdetails.Size = new System.Drawing.Size(151, 20);
            this.lbl_productdetails.TabIndex = 48;
            this.lbl_productdetails.Text = "Products Details :";
            // 
            // lbl_customerdetails
            // 
            this.lbl_customerdetails.AutoSize = true;
            this.lbl_customerdetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_customerdetails.Location = new System.Drawing.Point(9, 0);
            this.lbl_customerdetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_customerdetails.Name = "lbl_customerdetails";
            this.lbl_customerdetails.Size = new System.Drawing.Size(157, 20);
            this.lbl_customerdetails.TabIndex = 47;
            this.lbl_customerdetails.Text = "Customer Details :";
            // 
            // cb_paymode
            // 
            this.cb_paymode.FormattingEnabled = true;
            this.cb_paymode.Items.AddRange(new object[] {
            "CASH",
            "CREDIT CARD",
            "MOBILE PAYMENT"});
            this.cb_paymode.Location = new System.Drawing.Point(861, 515);
            this.cb_paymode.Margin = new System.Windows.Forms.Padding(2);
            this.cb_paymode.Name = "cb_paymode";
            this.cb_paymode.Size = new System.Drawing.Size(132, 21);
            this.cb_paymode.TabIndex = 46;
            this.cb_paymode.Text = "--Select--";
            // 
            // txt_totalamt
            // 
            this.txt_totalamt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_totalamt.Location = new System.Drawing.Point(1159, 510);
            this.txt_totalamt.Margin = new System.Windows.Forms.Padding(2);
            this.txt_totalamt.Name = "txt_totalamt";
            this.txt_totalamt.Size = new System.Drawing.Size(151, 31);
            this.txt_totalamt.TabIndex = 45;
            // 
            // lbl_paymode
            // 
            this.lbl_paymode.AutoSize = true;
            this.lbl_paymode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_paymode.Location = new System.Drawing.Point(736, 520);
            this.lbl_paymode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_paymode.Name = "lbl_paymode";
            this.lbl_paymode.Size = new System.Drawing.Size(102, 16);
            this.lbl_paymode.TabIndex = 44;
            this.lbl_paymode.Text = "Payment Mode:";
            // 
            // lbl_totalamt
            // 
            this.lbl_totalamt.AutoSize = true;
            this.lbl_totalamt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalamt.Location = new System.Drawing.Point(1065, 516);
            this.lbl_totalamt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_totalamt.Name = "lbl_totalamt";
            this.lbl_totalamt.Size = new System.Drawing.Size(90, 16);
            this.lbl_totalamt.TabIndex = 43;
            this.lbl_totalamt.Text = "Total Amount:";
            // 
            // dgv_productdetails
            // 
            this.dgv_productdetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_productdetails.BackgroundColor = System.Drawing.Color.White;
            this.dgv_productdetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_productdetails.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_productdetails.Location = new System.Drawing.Point(12, 279);
            this.dgv_productdetails.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_productdetails.Name = "dgv_productdetails";
            this.dgv_productdetails.RowHeadersWidth = 51;
            this.dgv_productdetails.RowTemplate.Height = 24;
            this.dgv_productdetails.Size = new System.Drawing.Size(1298, 227);
            this.dgv_productdetails.TabIndex = 42;
            this.dgv_productdetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_productdetails_CellClick);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Location = new System.Drawing.Point(1172, 45);
            this.btn_save.Margin = new System.Windows.Forms.Padding(2);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(56, 26);
            this.btn_save.TabIndex = 39;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // cb_salesman
            // 
            this.cb_salesman.FormattingEnabled = true;
            this.cb_salesman.Location = new System.Drawing.Point(805, 50);
            this.cb_salesman.Margin = new System.Windows.Forms.Padding(2);
            this.cb_salesman.Name = "cb_salesman";
            this.cb_salesman.Size = new System.Drawing.Size(267, 21);
            this.cb_salesman.TabIndex = 38;
            this.cb_salesman.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cb_salesman_MouseClick);
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(403, 52);
            this.txt_phone.Margin = new System.Windows.Forms.Padding(2);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(284, 20);
            this.txt_phone.TabIndex = 35;
            // 
            // txt_billno
            // 
            this.txt_billno.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bILLINGBindingSource, "BILL_ID", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.txt_billno.Location = new System.Drawing.Point(78, 12);
            this.txt_billno.Margin = new System.Windows.Forms.Padding(2);
            this.txt_billno.Name = "txt_billno";
            this.txt_billno.Size = new System.Drawing.Size(126, 20);
            this.txt_billno.TabIndex = 32;
            // 
            // bILLINGBindingSource
            // 
            this.bILLINGBindingSource.DataMember = "BILLING";
            this.bILLINGBindingSource.DataSource = this.superMarketDataSet;
            // 
            // superMarketDataSet
            // 
            this.superMarketDataSet.DataSetName = "SuperMarketDataSet";
            this.superMarketDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbl_salesman
            // 
            this.lbl_salesman.AutoSize = true;
            this.lbl_salesman.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_salesman.Location = new System.Drawing.Point(802, 32);
            this.lbl_salesman.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_salesman.Name = "lbl_salesman";
            this.lbl_salesman.Size = new System.Drawing.Size(72, 16);
            this.lbl_salesman.TabIndex = 31;
            this.lbl_salesman.Text = "Salesman:";
            // 
            // lbl_cphone
            // 
            this.lbl_cphone.AutoSize = true;
            this.lbl_cphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cphone.Location = new System.Drawing.Point(400, 32);
            this.lbl_cphone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_cphone.Name = "lbl_cphone";
            this.lbl_cphone.Size = new System.Drawing.Size(101, 16);
            this.lbl_cphone.TabIndex = 28;
            this.lbl_cphone.Text = "Phone Number:";
            // 
            // lbl_billdate
            // 
            this.lbl_billdate.AutoSize = true;
            this.lbl_billdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_billdate.Location = new System.Drawing.Point(237, 17);
            this.lbl_billdate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_billdate.Name = "lbl_billdate";
            this.lbl_billdate.Size = new System.Drawing.Size(61, 16);
            this.lbl_billdate.TabIndex = 26;
            this.lbl_billdate.Text = "Bill Date:";
            // 
            // lbl_billno
            // 
            this.lbl_billno.AutoSize = true;
            this.lbl_billno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_billno.Location = new System.Drawing.Point(27, 15);
            this.lbl_billno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_billno.Name = "lbl_billno";
            this.lbl_billno.Size = new System.Drawing.Size(50, 16);
            this.lbl_billno.TabIndex = 25;
            this.lbl_billno.Text = "Bill No:";
            // 
            // btn_bill_back
            // 
            this.btn_bill_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_bill_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bill_back.Location = new System.Drawing.Point(12, 12);
            this.btn_bill_back.Name = "btn_bill_back";
            this.btn_bill_back.Size = new System.Drawing.Size(32, 29);
            this.btn_bill_back.TabIndex = 52;
            this.btn_bill_back.Text = "<-";
            this.btn_bill_back.UseVisualStyleBackColor = false;
            this.btn_bill_back.Click += new System.EventHandler(this.btn_bill_back_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(1125, 11);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(56, 26);
            this.btn_Add.TabIndex = 53;
            this.btn_Add.Text = "ADD";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // dt_bill_date
            // 
            this.dt_bill_date.Location = new System.Drawing.Point(304, 15);
            this.dt_bill_date.Name = "dt_bill_date";
            this.dt_bill_date.Size = new System.Drawing.Size(172, 20);
            this.dt_bill_date.TabIndex = 54;
            // 
            // pl_bill_detail
            // 
            this.pl_bill_detail.Controls.Add(this.txt_billno);
            this.pl_bill_detail.Controls.Add(this.dt_bill_date);
            this.pl_bill_detail.Controls.Add(this.lbl_billno);
            this.pl_bill_detail.Controls.Add(this.lbl_billdate);
            this.pl_bill_detail.Location = new System.Drawing.Point(112, 12);
            this.pl_bill_detail.Name = "pl_bill_detail";
            this.pl_bill_detail.Size = new System.Drawing.Size(509, 39);
            this.pl_bill_detail.TabIndex = 55;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Beige;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txt_amount);
            this.panel1.Controls.Add(this.txt_pro_id);
            this.panel1.Controls.Add(this.lbl_pro_id);
            this.panel1.Controls.Add(this.lbl_si_no);
            this.panel1.Controls.Add(this.btn_delete);
            this.panel1.Controls.Add(this.txt_CGST);
            this.panel1.Controls.Add(this.lbl_CGST);
            this.panel1.Controls.Add(this.btn_Add);
            this.panel1.Controls.Add(this.txt_SGST);
            this.panel1.Controls.Add(this.lbl_SGST);
            this.panel1.Controls.Add(this.txt_Discount);
            this.panel1.Controls.Add(this.lbl_discount);
            this.panel1.Controls.Add(this.txt_MRP);
            this.panel1.Controls.Add(this.lbl_MRP);
            this.panel1.Controls.Add(this.txt_quantity);
            this.panel1.Controls.Add(this.lbl_Quantity);
            this.panel1.Controls.Add(this.txt_Product);
            this.panel1.Controls.Add(this.lbl_productdetails);
            this.panel1.Controls.Add(this.lbl_Product);
            this.panel1.Controls.Add(this.txt_Pro_Search);
            this.panel1.Controls.Add(this.lbl_Pro_Search);
            this.panel1.Location = new System.Drawing.Point(12, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1298, 184);
            this.panel1.TabIndex = 56;
            // 
            // txt_pro_id
            // 
            this.txt_pro_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pro_id.Location = new System.Drawing.Point(13, 135);
            this.txt_pro_id.Name = "txt_pro_id";
            this.txt_pro_id.ReadOnly = true;
            this.txt_pro_id.Size = new System.Drawing.Size(307, 24);
            this.txt_pro_id.TabIndex = 59;
            // 
            // lbl_pro_id
            // 
            this.lbl_pro_id.AutoSize = true;
            this.lbl_pro_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pro_id.Location = new System.Drawing.Point(10, 119);
            this.lbl_pro_id.Name = "lbl_pro_id";
            this.lbl_pro_id.Size = new System.Drawing.Size(73, 16);
            this.lbl_pro_id.TabIndex = 58;
            this.lbl_pro_id.Text = "Product ID:";
            // 
            // lbl_si_no
            // 
            this.lbl_si_no.AutoSize = true;
            this.lbl_si_no.Location = new System.Drawing.Point(10, 29);
            this.lbl_si_no.Name = "lbl_si_no";
            this.lbl_si_no.Size = new System.Drawing.Size(0, 13);
            this.lbl_si_no.TabIndex = 57;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Location = new System.Drawing.Point(1207, 10);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(65, 27);
            this.btn_delete.TabIndex = 56;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // txt_CGST
            // 
            this.txt_CGST.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CGST.Location = new System.Drawing.Point(1055, 135);
            this.txt_CGST.Name = "txt_CGST";
            this.txt_CGST.ReadOnly = true;
            this.txt_CGST.Size = new System.Drawing.Size(231, 24);
            this.txt_CGST.TabIndex = 52;
            // 
            // lbl_CGST
            // 
            this.lbl_CGST.AutoSize = true;
            this.lbl_CGST.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CGST.Location = new System.Drawing.Point(1052, 119);
            this.lbl_CGST.Name = "lbl_CGST";
            this.lbl_CGST.Size = new System.Drawing.Size(60, 16);
            this.lbl_CGST.TabIndex = 51;
            this.lbl_CGST.Text = "CGST %";
            // 
            // txt_SGST
            // 
            this.txt_SGST.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SGST.Location = new System.Drawing.Point(713, 135);
            this.txt_SGST.Name = "txt_SGST";
            this.txt_SGST.ReadOnly = true;
            this.txt_SGST.Size = new System.Drawing.Size(278, 24);
            this.txt_SGST.TabIndex = 50;
            // 
            // lbl_SGST
            // 
            this.lbl_SGST.AutoSize = true;
            this.lbl_SGST.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SGST.Location = new System.Drawing.Point(710, 119);
            this.lbl_SGST.Name = "lbl_SGST";
            this.lbl_SGST.Size = new System.Drawing.Size(60, 16);
            this.lbl_SGST.TabIndex = 49;
            this.lbl_SGST.Text = "SGST %";
            // 
            // txt_Discount
            // 
            this.txt_Discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Discount.Location = new System.Drawing.Point(359, 135);
            this.txt_Discount.Name = "txt_Discount";
            this.txt_Discount.ReadOnly = true;
            this.txt_Discount.Size = new System.Drawing.Size(313, 24);
            this.txt_Discount.TabIndex = 9;
            // 
            // lbl_discount
            // 
            this.lbl_discount.AutoSize = true;
            this.lbl_discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_discount.Location = new System.Drawing.Point(359, 119);
            this.lbl_discount.Name = "lbl_discount";
            this.lbl_discount.Size = new System.Drawing.Size(75, 16);
            this.lbl_discount.TabIndex = 8;
            this.lbl_discount.Text = "Discount %";
            // 
            // txt_MRP
            // 
            this.txt_MRP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MRP.Location = new System.Drawing.Point(713, 75);
            this.txt_MRP.Name = "txt_MRP";
            this.txt_MRP.ReadOnly = true;
            this.txt_MRP.Size = new System.Drawing.Size(278, 24);
            this.txt_MRP.TabIndex = 7;
            // 
            // lbl_MRP
            // 
            this.lbl_MRP.AutoSize = true;
            this.lbl_MRP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MRP.Location = new System.Drawing.Point(710, 56);
            this.lbl_MRP.Name = "lbl_MRP";
            this.lbl_MRP.Size = new System.Drawing.Size(41, 16);
            this.lbl_MRP.TabIndex = 6;
            this.lbl_MRP.Text = "MRP:";
            // 
            // txt_quantity
            // 
            this.txt_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_quantity.Location = new System.Drawing.Point(359, 74);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(313, 24);
            this.txt_quantity.TabIndex = 5;
            // 
            // lbl_Quantity
            // 
            this.lbl_Quantity.AutoSize = true;
            this.lbl_Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Quantity.Location = new System.Drawing.Point(366, 58);
            this.lbl_Quantity.Name = "lbl_Quantity";
            this.lbl_Quantity.Size = new System.Drawing.Size(56, 16);
            this.lbl_Quantity.TabIndex = 4;
            this.lbl_Quantity.Text = "Quantity";
            // 
            // txt_Product
            // 
            this.txt_Product.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Product.Location = new System.Drawing.Point(13, 75);
            this.txt_Product.Name = "txt_Product";
            this.txt_Product.ReadOnly = true;
            this.txt_Product.Size = new System.Drawing.Size(307, 24);
            this.txt_Product.TabIndex = 3;
            // 
            // lbl_Product
            // 
            this.lbl_Product.AutoSize = true;
            this.lbl_Product.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product.Location = new System.Drawing.Point(10, 59);
            this.lbl_Product.Name = "lbl_Product";
            this.lbl_Product.Size = new System.Drawing.Size(97, 16);
            this.lbl_Product.TabIndex = 2;
            this.lbl_Product.Text = "Product Name:";
            // 
            // txt_Pro_Search
            // 
            this.txt_Pro_Search.Location = new System.Drawing.Point(353, 11);
            this.txt_Pro_Search.Name = "txt_Pro_Search";
            this.txt_Pro_Search.Size = new System.Drawing.Size(511, 20);
            this.txt_Pro_Search.TabIndex = 1;
            this.txt_Pro_Search.TextChanged += new System.EventHandler(this.txt_Pro_Search_TextChanged);
            // 
            // lbl_Pro_Search
            // 
            this.lbl_Pro_Search.AutoSize = true;
            this.lbl_Pro_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Pro_Search.Location = new System.Drawing.Point(244, 14);
            this.lbl_Pro_Search.Name = "lbl_Pro_Search";
            this.lbl_Pro_Search.Size = new System.Drawing.Size(103, 16);
            this.lbl_Pro_Search.TabIndex = 0;
            this.lbl_Pro_Search.Text = "Search Product:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Beige;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lbl_salesman_id);
            this.panel2.Controls.Add(this.txt_customername);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lbl_cphone);
            this.panel2.Controls.Add(this.txt_phone);
            this.panel2.Controls.Add(this.lbl_customerdetails);
            this.panel2.Controls.Add(this.cb_salesman);
            this.panel2.Controls.Add(this.lbl_salesman);
            this.panel2.Controls.Add(this.btn_save);
            this.panel2.Location = new System.Drawing.Point(12, 547);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1298, 86);
            this.panel2.TabIndex = 57;
            // 
            // txt_customername
            // 
            this.txt_customername.Location = new System.Drawing.Point(10, 52);
            this.txt_customername.Margin = new System.Windows.Forms.Padding(2);
            this.txt_customername.Name = "txt_customername";
            this.txt_customername.Size = new System.Drawing.Size(293, 20);
            this.txt_customername.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 27;
            this.label1.Text = "Customer Name:";
            // 
            // btn_submit
            // 
            this.btn_submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_submit.Location = new System.Drawing.Point(1235, 695);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 61;
            this.btn_submit.Text = "SUBMIT";
            this.btn_submit.UseVisualStyleBackColor = false;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // btn_bill_cancel
            // 
            this.btn_bill_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_bill_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bill_cancel.Location = new System.Drawing.Point(1119, 695);
            this.btn_bill_cancel.Name = "btn_bill_cancel";
            this.btn_bill_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_bill_cancel.TabIndex = 60;
            this.btn_bill_cancel.Text = "Cancel";
            this.btn_bill_cancel.UseVisualStyleBackColor = false;
            // 
            // bILLINGTableAdapter
            // 
            this.bILLINGTableAdapter.ClearBeforeFill = true;
            // 
            // txt_amount
            // 
            this.txt_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_amount.Location = new System.Drawing.Point(1055, 75);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.ReadOnly = true;
            this.txt_amount.Size = new System.Drawing.Size(231, 24);
            this.txt_amount.TabIndex = 60;
            this.txt_amount.Visible = false;
            // 
            // lbl_salesman_id
            // 
            this.lbl_salesman_id.AutoSize = true;
            this.lbl_salesman_id.Location = new System.Drawing.Point(1077, 52);
            this.lbl_salesman_id.Name = "lbl_salesman_id";
            this.lbl_salesman_id.Size = new System.Drawing.Size(0, 13);
            this.lbl_salesman_id.TabIndex = 48;
            // 
            // Billing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1343, 749);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.btn_bill_cancel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pl_bill_detail);
            this.Controls.Add(this.btn_bill_back);
            this.Controls.Add(this.cb_paymode);
            this.Controls.Add(this.txt_totalamt);
            this.Controls.Add(this.lbl_paymode);
            this.Controls.Add(this.lbl_totalamt);
            this.Controls.Add(this.dgv_productdetails);
            this.Name = "Billing";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Billing";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Billing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productdetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bILLINGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.superMarketDataSet)).EndInit();
            this.pl_bill_detail.ResumeLayout(false);
            this.pl_bill_detail.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_productdetails;
        private System.Windows.Forms.Label lbl_customerdetails;
        private System.Windows.Forms.ComboBox cb_paymode;
        private System.Windows.Forms.TextBox txt_totalamt;
        private System.Windows.Forms.Label lbl_paymode;
        private System.Windows.Forms.Label lbl_totalamt;
        private System.Windows.Forms.DataGridView dgv_productdetails;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.ComboBox cb_salesman;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.TextBox txt_billno;
        private System.Windows.Forms.Label lbl_salesman;
        private System.Windows.Forms.Label lbl_cphone;
        private System.Windows.Forms.Label lbl_billdate;
        private System.Windows.Forms.Label lbl_billno;
        private System.Windows.Forms.Button btn_bill_back;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.DateTimePicker dt_bill_date;
        private System.Windows.Forms.Panel pl_bill_detail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_Pro_Search;
        private System.Windows.Forms.Label lbl_Pro_Search;
        private System.Windows.Forms.TextBox txt_Discount;
        private System.Windows.Forms.Label lbl_discount;
        private System.Windows.Forms.TextBox txt_MRP;
        private System.Windows.Forms.Label lbl_MRP;
        private System.Windows.Forms.TextBox txt_quantity;
        private System.Windows.Forms.Label lbl_Quantity;
        private System.Windows.Forms.TextBox txt_Product;
        private System.Windows.Forms.Label lbl_Product;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_CGST;
        private System.Windows.Forms.Label lbl_CGST;
        private System.Windows.Forms.TextBox txt_SGST;
        private System.Windows.Forms.Label lbl_SGST;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.TextBox txt_customername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Button btn_bill_cancel;
        private System.Windows.Forms.Label lbl_si_no;
        private System.Windows.Forms.TextBox txt_pro_id;
        private System.Windows.Forms.Label lbl_pro_id;
        private SuperMarketDataSet superMarketDataSet;
        private System.Windows.Forms.BindingSource bILLINGBindingSource;
        private SuperMarketDataSetTableAdapters.BILLINGTableAdapter bILLINGTableAdapter;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.Label lbl_salesman_id;
    }
}