using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Login_Form
{
    public partial class form_Product : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adp;
        DataSet ds;
        int i;
        public form_Product()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("UPDATE PRODUCT SET COST_PRICE=@COST,SELL_PRICE=@SELL,QUANTITY=@QTY,VENDOR_ID=@VENDOR,DISCOUNT=@DIS,CGST=@CGST,SGST=@SGST,THRESHOLD_QUANTITY=@THRESHOLD,EXP_DATE=@DATE  WHERE PRO_ID=@PROID", con);
            cmd.Parameters.AddWithValue("@PROID", txt_pro_id.Text);
            cmd.Parameters.AddWithValue("@COST", txt_costprice.Text);
            cmd.Parameters.AddWithValue("@SELL", txt_mrp.Text);
            cmd.Parameters.AddWithValue("@QTY", txt_qty.Text);
            cmd.Parameters.AddWithValue("@DATE", exp_dateTimePicker.Text);
            cmd.Parameters.AddWithValue("@VENDOR", txt_vendor.Text);
            cmd.Parameters.AddWithValue("@DIS", txt_discount.Text);
            cmd.Parameters.AddWithValue("@CGST", txt_cgst.Text);
            cmd.Parameters.AddWithValue("@SGST", txt_sgst.Text);
            cmd.Parameters.AddWithValue("THRESHOLD", txt_threshold.Text);
            cmd.ExecuteNonQuery();

            adp = new SqlDataAdapter("SELECT * FROM PRODUCT", con);
            ds = new DataSet();
            adp.Fill(ds, "PRODUCT");
            dgv_product.DataSource = ds;
            dgv_product.DataMember = "PRODUCT";
            MessageBox.Show("Updated");

            con.Close();

            txt_pro_id.Enabled = false;
            cbo_category.Enabled = false;
            cbo_subCategory.Enabled = false;
            cbo_product.Enabled = false;
            txt_costprice.Enabled = false;
            txt_mrp.Enabled = false;
            txt_qty.Enabled = false;
            txt_vendor.Enabled = false;
            txt_discount.Enabled = false;
            txt_threshold.Enabled = false;
            txt_cgst.Enabled = false;
            txt_sgst.Enabled = false;
            exp_dateTimePicker.Enabled = false;
        }

        private void Product_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("data source=.; database=supermarket; user ID=sa; Password=12345678");
            con.Open();
            adp = new SqlDataAdapter("SELECT * FROM PRODUCT", con);
            ds = new DataSet();
            adp.Fill(ds, "PRODUCT");

            dgv_product.DataSource = ds;
            dgv_product.DataMember = "PRODUCT";

            if (ds.Tables["PRODUCT"].Rows.Count >= 0)
            {
                i = 0;
                txt_pro_id.Text = ds.Tables["PRODUCT"].Rows[i]["PRO_ID"].ToString();
                txt_costprice.Text = ds.Tables["PRODUCT"].Rows[i]["COST_PRICE"].ToString();
                txt_mrp.Text = ds.Tables["PRODUCT"].Rows[i]["SELL_PRICE"].ToString();
                txt_qty.Text = ds.Tables["PRODUCT"].Rows[i]["QUANTITY"].ToString();
                txt_vendor.Text = ds.Tables["PRODUCT"].Rows[i]["VENDOR_ID"].ToString();
                txt_discount.Text = ds.Tables["PRODUCT"].Rows[i]["DISCOUNT"].ToString();
                txt_threshold.Text = ds.Tables["PRODUCT"].Rows[i]["THRESHOLD_QUANTITY"].ToString();
                txt_cgst.Text = ds.Tables["PRODUCT"].Rows[i]["CGST"].ToString();
                txt_sgst.Text = ds.Tables["PRODUCT"].Rows[i]["SGST"].ToString();
                exp_dateTimePicker.Text = ds.Tables["PRODUCT"].Rows[i]["EXP_DATE"].ToString();
            }


            adp = new SqlDataAdapter("select * from CATEGORY", con);
            adp.Fill(ds, "CATEGORY");
            cbo_category.DataSource = ds.Tables["CATEGORY"];
            cbo_category.ValueMember = "CATEGORY_NAME".ToString();

            adp = new SqlDataAdapter("select * from SUB_CATEGORY", con);
            adp.Fill(ds, "SUB_CATEGORY");
            cbo_subCategory.DataSource = ds.Tables["SUB_CATEGORY"];
            cbo_subCategory.ValueMember = "SUBCATEGORY_NAME".ToString();

            con.Close();

            txt_pro_id.Enabled = false;
            cbo_category.Enabled = false;
            cbo_subCategory.Enabled = false;
            cbo_product.Enabled = false;
            txt_costprice.Enabled = false;
            txt_mrp.Enabled = false;
            txt_qty.Enabled = false;
            txt_vendor.Enabled = false;
            txt_discount.Enabled = false;
            txt_threshold.Enabled = false;
            txt_cgst.Enabled = false;
            txt_sgst.Enabled = false;
            exp_dateTimePicker.Enabled = false;
        }

        private void btn_pro_back_Click(object sender, EventArgs e)
        {
            AdminLanding objadminlanding = new AdminLanding();
            this.Hide();
            objadminlanding.Show();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            txt_pro_id.Enabled = true;
            cbo_category.Enabled = true;
            cbo_subCategory.Enabled = true;
            cbo_product.Enabled = true;
            txt_costprice.Enabled = true;
            txt_mrp.Enabled = true;
            txt_qty.Enabled = true;
            txt_vendor.Enabled = true;
            txt_discount.Enabled = true;
            txt_threshold.Enabled = true;
            txt_cgst.Enabled = true;
            txt_sgst.Enabled = true;
            exp_dateTimePicker.Enabled = true;
        }

        private void cbo_product_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select * from product where PRO_NAME='" + cbo_product.Text + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                int id = (int)dr["PRO_ID"];
                txt_pro_id.Text = id.ToString();
                string cost = dr["COST_PRICE"].ToString();
                txt_costprice.Text = cost;
                string sell = dr["SELL_PRICE"].ToString();
                txt_mrp.Text = sell;
                string qty = dr["QUANTITY"].ToString();
                txt_qty.Text = qty;
                int vendor = (int)dr["VENDOR_ID"];
                txt_vendor.Text = vendor.ToString();
                string SGST = dr["SGST"].ToString();
                txt_cgst.Text = SGST;
                string CGST = dr["CGST"].ToString();
                txt_sgst.Text = CGST;
                string threshold = dr["THRESHOLD_QUANTITY"].ToString();
                txt_threshold.Text = threshold;
                string disc = dr["DISCOUNT"].ToString();
                txt_discount.Text = disc;
                DateTime dateTime = (DateTime)dr["EXP_DATE"];
                exp_dateTimePicker.Value = dateTime;
            }

            con.Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            txt_pro_id.Enabled = false;
            cbo_category.Enabled = false;
            cbo_subCategory.Enabled = false;
            cbo_product.Enabled = false;
            txt_costprice.Enabled = false;
            txt_mrp.Enabled = false;
            txt_qty.Enabled = false;
            txt_vendor.Enabled = false;
            txt_discount.Enabled = false;
            txt_threshold.Enabled = false;
            txt_cgst.Enabled = false;
            txt_sgst.Enabled = false;
            exp_dateTimePicker.Enabled = false;
        }

        private void cbo_subCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("select PRO_NAME from product a, SUB_CATEGORY b where a.SUBCATEGORY_ID = b.SUBCATEGORY_ID and b.SUBCATEGORY_NAME= '" + cbo_subCategory.Text + "'", con);
            adp.Fill(ds, "PRO_NAME");
            cbo_product.DataSource = ds.Tables["PRO_NAME"];
            cbo_product.ValueMember = "PRO_NAME".ToString();
            cbo_product.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbo_product.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void link_lbl_category_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Category().Show();
            this.Hide();
        }

        private void link_lbl_subcategory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new SubCategory().Show();
            this.Hide();
        }
    }
}
