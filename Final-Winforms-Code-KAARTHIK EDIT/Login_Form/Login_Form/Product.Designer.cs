namespace Login_Form
{
    partial class form_Product
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
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.dgv_product = new System.Windows.Forms.DataGridView();
            this.PRO_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUBCATEGORY_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRO_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COST_PRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SELL_PRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUANTITY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EXP_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VENDOR_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DISCOUNT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CGST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SGST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THRESHOLD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbo_subCategory = new System.Windows.Forms.ComboBox();
            this.txt_sgst = new System.Windows.Forms.TextBox();
            this.txt_discount = new System.Windows.Forms.TextBox();
            this.txt_threshold = new System.Windows.Forms.TextBox();
            this.txt_mrp = new System.Windows.Forms.TextBox();
            this.txt_vendor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_cgst = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_pro_id = new System.Windows.Forms.TextBox();
            this.txt_qty = new System.Windows.Forms.TextBox();
            this.txt_costprice = new System.Windows.Forms.TextBox();
            this.cbo_category = new System.Windows.Forms.ComboBox();
            this.lbl_pro_id = new System.Windows.Forms.Label();
            this.lbl_qty = new System.Windows.Forms.Label();
            this.lbl_costprice = new System.Windows.Forms.Label();
            this.lbl_prodname = new System.Windows.Forms.Label();
            this.lbl_category = new System.Windows.Forms.Label();
            this.lbl_heading = new System.Windows.Forms.Label();
            this.btn_pro_back = new System.Windows.Forms.Button();
            this.lbl_expirydate = new System.Windows.Forms.Label();
            this.exp_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cbo_product = new System.Windows.Forms.ComboBox();
            this.link_lbl_category = new System.Windows.Forms.LinkLabel();
            this.link_lbl_subcategory = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_product)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Cancel.Location = new System.Drawing.Point(810, 327);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(87, 40);
            this.btn_Cancel.TabIndex = 59;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_edit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_edit.Location = new System.Drawing.Point(531, 327);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(87, 40);
            this.btn_edit.TabIndex = 57;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_save.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_save.Location = new System.Drawing.Point(669, 327);
            this.btn_save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(95, 40);
            this.btn_save.TabIndex = 56;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // dgv_product
            // 
            this.dgv_product.BackgroundColor = System.Drawing.Color.White;
            this.dgv_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_product.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PRO_ID,
            this.SUBCATEGORY_ID,
            this.PRO_NAME,
            this.COST_PRICE,
            this.SELL_PRICE,
            this.QUANTITY,
            this.EXP_DATE,
            this.VENDOR_ID,
            this.DISCOUNT,
            this.CGST,
            this.SGST,
            this.THRESHOLD});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_product.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_product.Location = new System.Drawing.Point(12, 385);
            this.dgv_product.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_product.Name = "dgv_product";
            this.dgv_product.RowHeadersWidth = 51;
            this.dgv_product.RowTemplate.Height = 24;
            this.dgv_product.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_product.Size = new System.Drawing.Size(1347, 257);
            this.dgv_product.TabIndex = 55;
            // 
            // PRO_ID
            // 
            this.PRO_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PRO_ID.DataPropertyName = "PRO_ID";
            this.PRO_ID.HeaderText = "PRODUCT ID";
            this.PRO_ID.MinimumWidth = 6;
            this.PRO_ID.Name = "PRO_ID";
            // 
            // SUBCATEGORY_ID
            // 
            this.SUBCATEGORY_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SUBCATEGORY_ID.DataPropertyName = "SUBCATEGORY_ID";
            this.SUBCATEGORY_ID.HeaderText = "SUBCATEGORY ID";
            this.SUBCATEGORY_ID.MinimumWidth = 6;
            this.SUBCATEGORY_ID.Name = "SUBCATEGORY_ID";
            // 
            // PRO_NAME
            // 
            this.PRO_NAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PRO_NAME.DataPropertyName = "PRO_NAME";
            this.PRO_NAME.HeaderText = "PRODUCT NAME";
            this.PRO_NAME.MinimumWidth = 6;
            this.PRO_NAME.Name = "PRO_NAME";
            // 
            // COST_PRICE
            // 
            this.COST_PRICE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.COST_PRICE.DataPropertyName = "COST_PRICE";
            this.COST_PRICE.HeaderText = "COST PRICE";
            this.COST_PRICE.MinimumWidth = 6;
            this.COST_PRICE.Name = "COST_PRICE";
            // 
            // SELL_PRICE
            // 
            this.SELL_PRICE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SELL_PRICE.DataPropertyName = "SELL_PRICE";
            this.SELL_PRICE.HeaderText = "MRP";
            this.SELL_PRICE.MinimumWidth = 6;
            this.SELL_PRICE.Name = "SELL_PRICE";
            // 
            // QUANTITY
            // 
            this.QUANTITY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.QUANTITY.DataPropertyName = "QUANTITY";
            this.QUANTITY.HeaderText = "QUANTITY";
            this.QUANTITY.MinimumWidth = 6;
            this.QUANTITY.Name = "QUANTITY";
            // 
            // EXP_DATE
            // 
            this.EXP_DATE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EXP_DATE.DataPropertyName = "EXP_DATE";
            this.EXP_DATE.HeaderText = "EXP DATE";
            this.EXP_DATE.MinimumWidth = 6;
            this.EXP_DATE.Name = "EXP_DATE";
            // 
            // VENDOR_ID
            // 
            this.VENDOR_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.VENDOR_ID.DataPropertyName = "VENDOR_ID";
            this.VENDOR_ID.HeaderText = "VENDOR ID";
            this.VENDOR_ID.MinimumWidth = 6;
            this.VENDOR_ID.Name = "VENDOR_ID";
            // 
            // DISCOUNT
            // 
            this.DISCOUNT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DISCOUNT.DataPropertyName = "DISCOUNT";
            this.DISCOUNT.HeaderText = "DISCOUNT";
            this.DISCOUNT.MinimumWidth = 6;
            this.DISCOUNT.Name = "DISCOUNT";
            // 
            // CGST
            // 
            this.CGST.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CGST.DataPropertyName = "CGST";
            this.CGST.HeaderText = "CGST";
            this.CGST.MinimumWidth = 6;
            this.CGST.Name = "CGST";
            // 
            // SGST
            // 
            this.SGST.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SGST.DataPropertyName = "SGST";
            this.SGST.HeaderText = "SGST";
            this.SGST.MinimumWidth = 6;
            this.SGST.Name = "SGST";
            // 
            // THRESHOLD
            // 
            this.THRESHOLD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.THRESHOLD.DataPropertyName = "THRESHOLD";
            this.THRESHOLD.HeaderText = "THRESHOLD QTY";
            this.THRESHOLD.MinimumWidth = 6;
            this.THRESHOLD.Name = "THRESHOLD";
            // 
            // cbo_subCategory
            // 
            this.cbo_subCategory.FormattingEnabled = true;
            this.cbo_subCategory.Location = new System.Drawing.Point(842, 62);
            this.cbo_subCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbo_subCategory.Name = "cbo_subCategory";
            this.cbo_subCategory.Size = new System.Drawing.Size(243, 26);
            this.cbo_subCategory.TabIndex = 54;
            this.cbo_subCategory.Text = "--Select--";
            this.cbo_subCategory.SelectedIndexChanged += new System.EventHandler(this.cbo_subCategory_SelectedIndexChanged);
            // 
            // txt_sgst
            // 
            this.txt_sgst.Location = new System.Drawing.Point(844, 253);
            this.txt_sgst.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_sgst.Name = "txt_sgst";
            this.txt_sgst.Size = new System.Drawing.Size(242, 24);
            this.txt_sgst.TabIndex = 53;
            // 
            // txt_discount
            // 
            this.txt_discount.Location = new System.Drawing.Point(266, 250);
            this.txt_discount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_discount.Name = "txt_discount";
            this.txt_discount.Size = new System.Drawing.Size(242, 24);
            this.txt_discount.TabIndex = 52;
            // 
            // txt_threshold
            // 
            this.txt_threshold.Location = new System.Drawing.Point(266, 211);
            this.txt_threshold.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_threshold.Name = "txt_threshold";
            this.txt_threshold.Size = new System.Drawing.Size(242, 24);
            this.txt_threshold.TabIndex = 51;
            // 
            // txt_mrp
            // 
            this.txt_mrp.Location = new System.Drawing.Point(843, 134);
            this.txt_mrp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_mrp.Name = "txt_mrp";
            this.txt_mrp.Size = new System.Drawing.Size(242, 24);
            this.txt_mrp.TabIndex = 50;
            // 
            // txt_vendor
            // 
            this.txt_vendor.Location = new System.Drawing.Point(843, 177);
            this.txt_vendor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_vendor.Name = "txt_vendor";
            this.txt_vendor.Size = new System.Drawing.Size(243, 24);
            this.txt_vendor.TabIndex = 49;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(720, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 18);
            this.label7.TabIndex = 48;
            this.label7.Text = "SGST%:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(103, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 18);
            this.label6.TabIndex = 47;
            this.label6.Text = "Discount%:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 18);
            this.label5.TabIndex = 46;
            this.label5.Text = "Threshold Quantity:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(728, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 18);
            this.label4.TabIndex = 45;
            this.label4.Text = "MRP:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(728, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 18);
            this.label3.TabIndex = 44;
            this.label3.Text = "Vendor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(666, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 18);
            this.label2.TabIndex = 43;
            this.label2.Text = "Sub Category:";
            // 
            // txt_cgst
            // 
            this.txt_cgst.Location = new System.Drawing.Point(844, 214);
            this.txt_cgst.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_cgst.Name = "txt_cgst";
            this.txt_cgst.Size = new System.Drawing.Size(242, 24);
            this.txt_cgst.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(714, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 41;
            this.label1.Text = "CGST %:";
            // 
            // txt_pro_id
            // 
            this.txt_pro_id.Location = new System.Drawing.Point(264, 103);
            this.txt_pro_id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_pro_id.Name = "txt_pro_id";
            this.txt_pro_id.Size = new System.Drawing.Size(242, 24);
            this.txt_pro_id.TabIndex = 40;
            // 
            // txt_qty
            // 
            this.txt_qty.Location = new System.Drawing.Point(264, 174);
            this.txt_qty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_qty.Name = "txt_qty";
            this.txt_qty.Size = new System.Drawing.Size(242, 24);
            this.txt_qty.TabIndex = 39;
            // 
            // txt_costprice
            // 
            this.txt_costprice.Location = new System.Drawing.Point(264, 137);
            this.txt_costprice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_costprice.Name = "txt_costprice";
            this.txt_costprice.Size = new System.Drawing.Size(242, 24);
            this.txt_costprice.TabIndex = 38;
            // 
            // cbo_category
            // 
            this.cbo_category.FormattingEnabled = true;
            this.cbo_category.Location = new System.Drawing.Point(264, 70);
            this.cbo_category.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbo_category.Name = "cbo_category";
            this.cbo_category.Size = new System.Drawing.Size(242, 26);
            this.cbo_category.TabIndex = 37;
            this.cbo_category.Text = "--Select--";
            // 
            // lbl_pro_id
            // 
            this.lbl_pro_id.AutoSize = true;
            this.lbl_pro_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pro_id.Location = new System.Drawing.Point(100, 109);
            this.lbl_pro_id.Name = "lbl_pro_id";
            this.lbl_pro_id.Size = new System.Drawing.Size(93, 18);
            this.lbl_pro_id.TabIndex = 35;
            this.lbl_pro_id.Text = "Product ID:";
            // 
            // lbl_qty
            // 
            this.lbl_qty.AutoSize = true;
            this.lbl_qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qty.Location = new System.Drawing.Point(123, 174);
            this.lbl_qty.Name = "lbl_qty";
            this.lbl_qty.Size = new System.Drawing.Size(75, 18);
            this.lbl_qty.TabIndex = 34;
            this.lbl_qty.Text = "Quantity:";
            // 
            // lbl_costprice
            // 
            this.lbl_costprice.AutoSize = true;
            this.lbl_costprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_costprice.Location = new System.Drawing.Point(100, 143);
            this.lbl_costprice.Name = "lbl_costprice";
            this.lbl_costprice.Size = new System.Drawing.Size(93, 18);
            this.lbl_costprice.TabIndex = 33;
            this.lbl_costprice.Text = "Cost Price:";
            // 
            // lbl_prodname
            // 
            this.lbl_prodname.AutoSize = true;
            this.lbl_prodname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prodname.Location = new System.Drawing.Point(659, 100);
            this.lbl_prodname.Name = "lbl_prodname";
            this.lbl_prodname.Size = new System.Drawing.Size(121, 18);
            this.lbl_prodname.TabIndex = 32;
            this.lbl_prodname.Text = "Product Name:";
            // 
            // lbl_category
            // 
            this.lbl_category.AutoSize = true;
            this.lbl_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_category.Location = new System.Drawing.Point(100, 73);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(81, 18);
            this.lbl_category.TabIndex = 31;
            this.lbl_category.Text = "Category:";
            // 
            // lbl_heading
            // 
            this.lbl_heading.AutoSize = true;
            this.lbl_heading.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_heading.Location = new System.Drawing.Point(536, 12);
            this.lbl_heading.Name = "lbl_heading";
            this.lbl_heading.Size = new System.Drawing.Size(194, 39);
            this.lbl_heading.TabIndex = 30;
            this.lbl_heading.Text = "PRODUCT";
            // 
            // btn_pro_back
            // 
            this.btn_pro_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_pro_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pro_back.Location = new System.Drawing.Point(13, 12);
            this.btn_pro_back.Name = "btn_pro_back";
            this.btn_pro_back.Size = new System.Drawing.Size(66, 34);
            this.btn_pro_back.TabIndex = 60;
            this.btn_pro_back.Text = "<-";
            this.btn_pro_back.UseVisualStyleBackColor = false;
            this.btn_pro_back.Click += new System.EventHandler(this.btn_pro_back_Click);
            // 
            // lbl_expirydate
            // 
            this.lbl_expirydate.AutoSize = true;
            this.lbl_expirydate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_expirydate.Location = new System.Drawing.Point(100, 287);
            this.lbl_expirydate.Name = "lbl_expirydate";
            this.lbl_expirydate.Size = new System.Drawing.Size(99, 18);
            this.lbl_expirydate.TabIndex = 62;
            this.lbl_expirydate.Text = "Expiry Date:";
            // 
            // exp_dateTimePicker
            // 
            this.exp_dateTimePicker.Location = new System.Drawing.Point(264, 281);
            this.exp_dateTimePicker.Name = "exp_dateTimePicker";
            this.exp_dateTimePicker.Size = new System.Drawing.Size(242, 24);
            this.exp_dateTimePicker.TabIndex = 63;
            // 
            // cbo_product
            // 
            this.cbo_product.FormattingEnabled = true;
            this.cbo_product.Location = new System.Drawing.Point(842, 97);
            this.cbo_product.Name = "cbo_product";
            this.cbo_product.Size = new System.Drawing.Size(243, 26);
            this.cbo_product.TabIndex = 64;
            this.cbo_product.Text = "--Select--";
            this.cbo_product.SelectedIndexChanged += new System.EventHandler(this.cbo_product_SelectedIndexChanged);
            // 
            // link_lbl_category
            // 
            this.link_lbl_category.AutoSize = true;
            this.link_lbl_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_lbl_category.ForeColor = System.Drawing.Color.White;
            this.link_lbl_category.Location = new System.Drawing.Point(1078, 20);
            this.link_lbl_category.Name = "link_lbl_category";
            this.link_lbl_category.Size = new System.Drawing.Size(84, 20);
            this.link_lbl_category.TabIndex = 65;
            this.link_lbl_category.TabStop = true;
            this.link_lbl_category.Text = "Category";
            this.link_lbl_category.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_lbl_category_LinkClicked);
            // 
            // link_lbl_subcategory
            // 
            this.link_lbl_subcategory.AutoSize = true;
            this.link_lbl_subcategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_lbl_subcategory.ForeColor = System.Drawing.Color.White;
            this.link_lbl_subcategory.Location = new System.Drawing.Point(1191, 20);
            this.link_lbl_subcategory.Name = "link_lbl_subcategory";
            this.link_lbl_subcategory.Size = new System.Drawing.Size(116, 20);
            this.link_lbl_subcategory.TabIndex = 66;
            this.link_lbl_subcategory.TabStop = true;
            this.link_lbl_subcategory.Text = "SubCategory";
            this.link_lbl_subcategory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_lbl_subcategory_LinkClicked);
            // 
            // form_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1382, 653);
            this.Controls.Add(this.link_lbl_subcategory);
            this.Controls.Add(this.link_lbl_category);
            this.Controls.Add(this.cbo_product);
            this.Controls.Add(this.exp_dateTimePicker);
            this.Controls.Add(this.lbl_expirydate);
            this.Controls.Add(this.btn_pro_back);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.dgv_product);
            this.Controls.Add(this.cbo_subCategory);
            this.Controls.Add(this.txt_sgst);
            this.Controls.Add(this.txt_discount);
            this.Controls.Add(this.txt_threshold);
            this.Controls.Add(this.txt_mrp);
            this.Controls.Add(this.txt_vendor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_cgst);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_pro_id);
            this.Controls.Add(this.txt_qty);
            this.Controls.Add(this.txt_costprice);
            this.Controls.Add(this.cbo_category);
            this.Controls.Add(this.lbl_pro_id);
            this.Controls.Add(this.lbl_qty);
            this.Controls.Add(this.lbl_costprice);
            this.Controls.Add(this.lbl_prodname);
            this.Controls.Add(this.lbl_category);
            this.Controls.Add(this.lbl_heading);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "form_Product";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product";
            this.Load += new System.EventHandler(this.Product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_product)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.DataGridView dgv_product;
        private System.Windows.Forms.ComboBox cbo_subCategory;
        private System.Windows.Forms.TextBox txt_sgst;
        private System.Windows.Forms.TextBox txt_discount;
        private System.Windows.Forms.TextBox txt_threshold;
        private System.Windows.Forms.TextBox txt_mrp;
        private System.Windows.Forms.TextBox txt_vendor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_cgst;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_pro_id;
        private System.Windows.Forms.TextBox txt_qty;
        private System.Windows.Forms.TextBox txt_costprice;
        private System.Windows.Forms.ComboBox cbo_category;
        private System.Windows.Forms.Label lbl_pro_id;
        private System.Windows.Forms.Label lbl_qty;
        private System.Windows.Forms.Label lbl_costprice;
        private System.Windows.Forms.Label lbl_prodname;
        private System.Windows.Forms.Label lbl_category;
        private System.Windows.Forms.Label lbl_heading;
        private System.Windows.Forms.Button btn_pro_back;
        private System.Windows.Forms.Label lbl_expirydate;
        private System.Windows.Forms.DateTimePicker exp_dateTimePicker;
        private System.Windows.Forms.ComboBox cbo_product;
        private System.Windows.Forms.LinkLabel link_lbl_category;
        private System.Windows.Forms.LinkLabel link_lbl_subcategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRO_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUBCATEGORY_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRO_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn COST_PRICE;
        private System.Windows.Forms.DataGridViewTextBoxColumn SELL_PRICE;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUANTITY;
        private System.Windows.Forms.DataGridViewTextBoxColumn EXP_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn VENDOR_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DISCOUNT;
        private System.Windows.Forms.DataGridViewTextBoxColumn CGST;
        private System.Windows.Forms.DataGridViewTextBoxColumn SGST;
        private System.Windows.Forms.DataGridViewTextBoxColumn THRESHOLD;
    }
}