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
using System.Configuration;

namespace Login_Form
{
    public partial class Billing : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adp;
        DataSet ds;
        SqlDataReader sdr;
        DataTable dt;
        decimal totalAmount =0;
        
        public Billing()
        {
            InitializeComponent();
            
        }

        private void Billing_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'superMarketDataSet.BILLING' table. You can move, or remove it, as needed.
            this.bILLINGTableAdapter.Fill(this.superMarketDataSet.BILLING);
            con = new SqlConnection("data source=.; database=supermarket; user ID=sa; Password=12345678");
            con.Open();
            cmd = new SqlCommand("SELECT PRO_NAME FROM PRODUCT", con);
            cmd.ExecuteNonQuery();
            sdr = cmd.ExecuteReader();
            AutoCompleteStringCollection autotext = new AutoCompleteStringCollection();
            while (sdr.Read())
            {
                autotext.Add(sdr.GetString(0));
            }
            txt_Pro_Search.AutoCompleteMode = AutoCompleteMode.Suggest;
            txt_Pro_Search.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txt_Pro_Search.AutoCompleteCustomSource = autotext;
            dt = new DataTable();
            dt.Columns.Add("PRO_ID");
            dt.Columns.Add ("PRODUCT");
            dt.Columns.Add("QUANTITY");
            dt.Columns.Add("MRP");
            dt.Columns.Add("DISCOUNT");
            dt.Columns.Add("SGST");
            dt.Columns.Add("CGST");
            dt.Columns.Add("AMOUNT");
            con.Close();
        }

        private void btn_bill_back_Click(object sender, EventArgs e)
        {
            SalesmanLanding Objsalesmanlanding = new SalesmanLanding();
            this.Hide();
            Objsalesmanlanding.Show();
        }

        private void txt_Pro_Search_TextChanged(object sender, EventArgs e)
        {
            con = new SqlConnection("data source=.; database=supermarket; user ID=sa; Password=12345678");
            con.Open();
            txt_Product.Text = txt_Pro_Search.Text;
            
            cmd = new SqlCommand("SELECT * FROM PRODUCT WHERE PRO_NAME=@pro_name", con);
            cmd.Parameters.AddWithValue("@pro_name", txt_Product.Text);
            cmd.ExecuteNonQuery();
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                int id = (int)dr["PRO_ID"];
                txt_pro_id.Text = id.ToString();
                string sell = dr["SELL_PRICE"].ToString();
                txt_MRP.Text = sell;
                string SGST = dr["SGST"].ToString();
                txt_SGST.Text = SGST;
                string CGST = dr["CGST"].ToString();
                txt_CGST.Text = CGST;
                string disc = dr["DISCOUNT"].ToString();
                txt_Discount.Text = disc;
            }
            con.Close();
        }
        
        private void btn_Add_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("data source=.; database=supermarket; user ID=sa; Password=12345678");
            con.Open();
            if(txt_quantity.Text != " ")
            {
                string pro_id = txt_pro_id.Text;
                string proname = txt_Product.Text;
                string sgst = txt_SGST.Text;
                string cgst = txt_CGST.Text;
                decimal quantity = decimal.Parse(txt_quantity.Text);
                decimal discount = decimal.Parse(txt_Discount.Text);
                decimal mrp = decimal.Parse(txt_MRP.Text);
                decimal amount = (quantity * mrp) - (quantity * mrp * discount / 100);
                if (proname == " ")
                {
                    MessageBox.Show("Select the product and quantity");
                }
                else
                {
                    cmd = new SqlCommand("INSERT INTO BILL_DETAILED (BILL_ID,PRO_ID,QUANTITY) VALUES ('" + txt_billno.Text + "', '" + txt_pro_id.Text + "','" + txt_quantity.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    dt.Rows.Add(pro_id, proname, quantity, mrp, discount, sgst, cgst, amount);
                    dgv_productdetails.DataSource = dt;

                    clear();
                }
                totalAmount = totalAmount + amount;
                txt_totalamt.Text = totalAmount.ToString();
            }
            else
            {
                MessageBox.Show("Select quantity");
                
            }
            con.Close();
        }

        private void dgv_productdetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_productdetails.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgv_productdetails.CurrentRow.Selected = true;
                txt_Product.Text = dgv_productdetails.Rows[e.RowIndex].Cells["PRODUCT"].FormattedValue.ToString();
                txt_pro_id.Text = dgv_productdetails.Rows[e.RowIndex].Cells["PRO_ID"].FormattedValue.ToString();
                txt_quantity.Text = dgv_productdetails.Rows[e.RowIndex].Cells["QUANTITY"].FormattedValue.ToString();
                txt_MRP.Text = dgv_productdetails.Rows[e.RowIndex].Cells["MRP"].FormattedValue.ToString();
                txt_Discount.Text = dgv_productdetails.Rows[e.RowIndex].Cells["DISCOUNT"].FormattedValue.ToString();
                txt_SGST.Text = dgv_productdetails.Rows[e.RowIndex].Cells["SGST"].FormattedValue.ToString();
                txt_CGST.Text = dgv_productdetails.Rows[e.RowIndex].Cells["CGST"].FormattedValue.ToString();
                txt_amount.Text = dgv_productdetails.Rows[e.RowIndex].Cells["AMOUNT"].FormattedValue.ToString();
            }
        }
        public void clear()
        {
            txt_Product.Text = " ";
            txt_pro_id.Text = " ";
            txt_quantity.Text = " ";
            txt_MRP.Text = " ";
            txt_SGST.Text = " ";
            txt_CGST.Text = " ";
            txt_Discount.Text = " ";
        }
        private void btn_delete_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("data source=.; database=supermarket; user ID=sa; Password=12345678");
            con.Open();
            totalAmount = decimal.Parse(txt_totalamt.Text);
            cmd = new SqlCommand("DELETE BILL_DETAILED WHERE BILL_ID=@billid AND PRO_ID=@proid", con);
            cmd.Parameters.AddWithValue("@billid", txt_billno.Text);
            cmd.Parameters.AddWithValue("@proid", txt_pro_id.Text);
            cmd.ExecuteNonQuery();
            int RowIndex = dgv_productdetails.CurrentCell.RowIndex;
            dgv_productdetails.Rows.RemoveAt(RowIndex);
            totalAmount = totalAmount - decimal.Parse(txt_amount.Text);
            txt_totalamt.Text = totalAmount.ToString();
            con.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("data source=.; database=supermarket; user ID=sa; Password=12345678");
            con.Open();
            cmd = new SqlCommand("INSERT INTO CUSTOMER(CUST_NAME,CUST_PHONE) VALUES(@custname,@custphone)",con);
            cmd.Parameters.AddWithValue("@custname", txt_customername.Text);
            cmd.Parameters.AddWithValue("@custphone", txt_phone.Text);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            
            cmd = new SqlCommand("INSERT INTO BILL_DETAILED (BILL_DATE,BILL_AMT,PAYMENT_MODE,SALESMAN_ID) VALUES ('" + dt_bill_date.Value + "', '" + txt_totalamt.Text + "','" + cb_paymode.Text + "','"+ cb_salesman.Text +"')", con);
            cmd.ExecuteNonQuery();
        }

        private void cb_salesman_MouseClick(object sender, MouseEventArgs e)
        {
            con = new SqlConnection("data source=.; database=supermarket; user ID=sa; Password=12345678");
            con.Open();
            adp = new SqlDataAdapter("SELECT * FROM STAFF", con);
            ds = new DataSet();
            adp.Fill(ds, "SALESMAN");
            cb_salesman.DataSource = ds.Tables["SALESMAN"];
            cb_salesman.ValueMember = "NAME".ToString();
            con.Close();

            sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                int id = (int)sdr["STAFF_ID"];
                lbl_salesman_id.Text = id.ToString();
            }
        }
    }
}
