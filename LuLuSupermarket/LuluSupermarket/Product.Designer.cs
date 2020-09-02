namespace LuluSupermarket
{
    partial class form_product
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
            this.lbl_heading = new System.Windows.Forms.Label();
            this.lbl_category = new System.Windows.Forms.Label();
            this.lbl_prodname = new System.Windows.Forms.Label();
            this.lbl_costprice = new System.Windows.Forms.Label();
            this.lbl_qty = new System.Windows.Forms.Label();
            this.lbl_profit = new System.Windows.Forms.Label();
            this.txt_product = new System.Windows.Forms.TextBox();
            this.cbo_category = new System.Windows.Forms.ComboBox();
            this.txt_costprice = new System.Windows.Forms.TextBox();
            this.txt_qty = new System.Windows.Forms.TextBox();
            this.txt_profit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_cgst = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_vendor = new System.Windows.Forms.TextBox();
            this.txt_mrp = new System.Windows.Forms.TextBox();
            this.txt_threshold = new System.Windows.Forms.TextBox();
            this.txt_discount = new System.Windows.Forms.TextBox();
            this.txt_sgst = new System.Windows.Forms.TextBox();
            this.cbo_subCategory = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_print = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_heading
            // 
            this.lbl_heading.AutoSize = true;
            this.lbl_heading.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_heading.Location = new System.Drawing.Point(508, 9);
            this.lbl_heading.Name = "lbl_heading";
            this.lbl_heading.Size = new System.Drawing.Size(115, 31);
            this.lbl_heading.TabIndex = 0;
            this.lbl_heading.Text = "Product";
            // 
            // lbl_category
            // 
            this.lbl_category.AutoSize = true;
            this.lbl_category.Location = new System.Drawing.Point(131, 77);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(69, 17);
            this.lbl_category.TabIndex = 1;
            this.lbl_category.Text = "Category:";
            // 
            // lbl_prodname
            // 
            this.lbl_prodname.AutoSize = true;
            this.lbl_prodname.Location = new System.Drawing.Point(131, 104);
            this.lbl_prodname.Name = "lbl_prodname";
            this.lbl_prodname.Size = new System.Drawing.Size(102, 17);
            this.lbl_prodname.TabIndex = 2;
            this.lbl_prodname.Text = "Product Name:";
            // 
            // lbl_costprice
            // 
            this.lbl_costprice.AutoSize = true;
            this.lbl_costprice.Location = new System.Drawing.Point(131, 135);
            this.lbl_costprice.Name = "lbl_costprice";
            this.lbl_costprice.Size = new System.Drawing.Size(76, 17);
            this.lbl_costprice.TabIndex = 3;
            this.lbl_costprice.Text = "Cost Price:";
            // 
            // lbl_qty
            // 
            this.lbl_qty.AutoSize = true;
            this.lbl_qty.Location = new System.Drawing.Point(131, 168);
            this.lbl_qty.Name = "lbl_qty";
            this.lbl_qty.Size = new System.Drawing.Size(65, 17);
            this.lbl_qty.TabIndex = 4;
            this.lbl_qty.Text = "Quantity:";
            // 
            // lbl_profit
            // 
            this.lbl_profit.AutoSize = true;
            this.lbl_profit.Location = new System.Drawing.Point(131, 203);
            this.lbl_profit.Name = "lbl_profit";
            this.lbl_profit.Size = new System.Drawing.Size(61, 17);
            this.lbl_profit.TabIndex = 5;
            this.lbl_profit.Text = "Profit %:";
            // 
            // txt_product
            // 
            this.txt_product.Location = new System.Drawing.Point(301, 104);
            this.txt_product.Name = "txt_product";
            this.txt_product.Size = new System.Drawing.Size(249, 22);
            this.txt_product.TabIndex = 6;
            // 
            // cbo_category
            // 
            this.cbo_category.FormattingEnabled = true;
            this.cbo_category.Location = new System.Drawing.Point(301, 70);
            this.cbo_category.Name = "cbo_category";
            this.cbo_category.Size = new System.Drawing.Size(249, 24);
            this.cbo_category.TabIndex = 7;
            // 
            // txt_costprice
            // 
            this.txt_costprice.Location = new System.Drawing.Point(301, 135);
            this.txt_costprice.Name = "txt_costprice";
            this.txt_costprice.Size = new System.Drawing.Size(249, 22);
            this.txt_costprice.TabIndex = 8;
            // 
            // txt_qty
            // 
            this.txt_qty.Location = new System.Drawing.Point(301, 168);
            this.txt_qty.Name = "txt_qty";
            this.txt_qty.Size = new System.Drawing.Size(249, 22);
            this.txt_qty.TabIndex = 9;
            // 
            // txt_profit
            // 
            this.txt_profit.Location = new System.Drawing.Point(301, 203);
            this.txt_profit.Name = "txt_profit";
            this.txt_profit.Size = new System.Drawing.Size(249, 22);
            this.txt_profit.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "CGST %:";
            // 
            // txt_cgst
            // 
            this.txt_cgst.Location = new System.Drawing.Point(301, 240);
            this.txt_cgst.Name = "txt_cgst";
            this.txt_cgst.Size = new System.Drawing.Size(249, 22);
            this.txt_cgst.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(657, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Sub Category:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(657, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Vendor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(657, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "MRP:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(657, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Threshold Quantity:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(657, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Discount%:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(657, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "SGST%:";
            // 
            // txt_vendor
            // 
            this.txt_vendor.Location = new System.Drawing.Point(846, 99);
            this.txt_vendor.Name = "txt_vendor";
            this.txt_vendor.Size = new System.Drawing.Size(265, 22);
            this.txt_vendor.TabIndex = 19;
            // 
            // txt_mrp
            // 
            this.txt_mrp.Location = new System.Drawing.Point(846, 138);
            this.txt_mrp.Name = "txt_mrp";
            this.txt_mrp.Size = new System.Drawing.Size(265, 22);
            this.txt_mrp.TabIndex = 20;
            // 
            // txt_threshold
            // 
            this.txt_threshold.Location = new System.Drawing.Point(846, 167);
            this.txt_threshold.Name = "txt_threshold";
            this.txt_threshold.Size = new System.Drawing.Size(265, 22);
            this.txt_threshold.TabIndex = 21;
            // 
            // txt_discount
            // 
            this.txt_discount.Location = new System.Drawing.Point(846, 203);
            this.txt_discount.Name = "txt_discount";
            this.txt_discount.Size = new System.Drawing.Size(265, 22);
            this.txt_discount.TabIndex = 22;
            // 
            // txt_sgst
            // 
            this.txt_sgst.Location = new System.Drawing.Point(846, 243);
            this.txt_sgst.Name = "txt_sgst";
            this.txt_sgst.Size = new System.Drawing.Size(265, 22);
            this.txt_sgst.TabIndex = 23;
            // 
            // cbo_subCategory
            // 
            this.cbo_subCategory.FormattingEnabled = true;
            this.cbo_subCategory.Location = new System.Drawing.Point(846, 61);
            this.cbo_subCategory.Name = "cbo_subCategory";
            this.cbo_subCategory.Size = new System.Drawing.Size(265, 24);
            this.cbo_subCategory.TabIndex = 24;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 290);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1249, 321);
            this.dataGridView1.TabIndex = 25;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_save.Location = new System.Drawing.Point(746, 9);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(84, 31);
            this.btn_save.TabIndex = 26;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_edit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_edit.Location = new System.Drawing.Point(846, 9);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 31);
            this.btn_edit.TabIndex = 27;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = false;
            // 
            // btn_print
            // 
            this.btn_print.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_print.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_print.Location = new System.Drawing.Point(1074, 9);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(75, 31);
            this.btn_print.TabIndex = 28;
            this.btn_print.Text = "Print";
            this.btn_print.UseVisualStyleBackColor = false;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_delete.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_delete.Location = new System.Drawing.Point(928, 9);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(99, 31);
            this.btn_delete.TabIndex = 29;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            // 
            // form_product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 612);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.dataGridView1);
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
            this.Controls.Add(this.txt_profit);
            this.Controls.Add(this.txt_qty);
            this.Controls.Add(this.txt_costprice);
            this.Controls.Add(this.cbo_category);
            this.Controls.Add(this.txt_product);
            this.Controls.Add(this.lbl_profit);
            this.Controls.Add(this.lbl_qty);
            this.Controls.Add(this.lbl_costprice);
            this.Controls.Add(this.lbl_prodname);
            this.Controls.Add(this.lbl_category);
            this.Controls.Add(this.lbl_heading);
            this.Name = "form_product";
            this.Text = "Product";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_heading;
        private System.Windows.Forms.Label lbl_category;
        private System.Windows.Forms.Label lbl_prodname;
        private System.Windows.Forms.Label lbl_costprice;
        private System.Windows.Forms.Label lbl_qty;
        private System.Windows.Forms.Label lbl_profit;
        private System.Windows.Forms.TextBox txt_product;
        private System.Windows.Forms.ComboBox cbo_category;
        private System.Windows.Forms.TextBox txt_costprice;
        private System.Windows.Forms.TextBox txt_qty;
        private System.Windows.Forms.TextBox txt_profit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_cgst;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_vendor;
        private System.Windows.Forms.TextBox txt_mrp;
        private System.Windows.Forms.TextBox txt_threshold;
        private System.Windows.Forms.TextBox txt_discount;
        private System.Windows.Forms.TextBox txt_sgst;
        private System.Windows.Forms.ComboBox cbo_subCategory;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Button btn_delete;
    }
}

