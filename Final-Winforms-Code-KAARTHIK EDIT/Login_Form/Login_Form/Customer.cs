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
    public partial class form_Customer : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adp;
        DataSet ds;
        public form_Customer()
        {
            InitializeComponent();
        }

        private void btn_cust_back_Click(object sender, EventArgs e)
        {
            AdminLanding objadminlanding = new AdminLanding();
            this.Hide();
            objadminlanding.Show();
        }

        private void form_Customer_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("data source=.; database=supermarket; user ID=sa; Password=12345678");
            con.Open();
            adp = new SqlDataAdapter("SELECT * FROM CUSTOMER", con);
            ds = new DataSet();
            adp.Fill(ds, "CUSTOMER");

            dgv_customers.DataSource = ds;
            dgv_customers.DataMember = "CUSTOMER";
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string CUST_NAME = txt_CUSTOMERNAME.Text;
            string CUST_PHONE = txt_PHONENUMBER.Text;
            string str = "insert into CUSTOMER values('" + CUST_NAME + "', " + CUST_PHONE + ")";

            adp = new SqlDataAdapter();
            adp.InsertCommand = new SqlCommand(str, con);
            adp.InsertCommand.ExecuteNonQuery();
            adp = new SqlDataAdapter("select * from CUSTOMER", con);
            ds = new DataSet();
            adp.Fill(ds, "CUSTOMER");
            dgv_customers.DataSource = ds;
            dgv_customers.DataMember = "CUSTOMER";

            MessageBox.Show("Succesfully Added");
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            //METHOD 1

            cmd = new SqlCommand("UPDATE CUSTOMER SET CUST_NAME=@custname,CUST_PHONE=@custphone WHERE CUST_ID=@cust_id", con);
            cmd.Parameters.AddWithValue("@cust_id", txt_cust_id.Text);
            cmd.Parameters.AddWithValue("@custname", txt_CUSTOMERNAME.Text);
            cmd.Parameters.AddWithValue("@custphone", txt_PHONENUMBER.Text);
            cmd.ExecuteNonQuery();

            adp = new SqlDataAdapter("SELECT * FROM CUSTOMER", con);
            ds = new DataSet();
            adp.Fill(ds, "CUSTOMER");
            dgv_customers.DataSource = ds;
            dgv_customers.DataMember = "CUSTOMER";

            MessageBox.Show("Data Updated Successfully");
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("DELETE CUSTOMER WHERE CUST_NAME=@CUST_NAME", con);
            cmd.Parameters.AddWithValue("@CUST_NAME", txt_CUSTOMERNAME.Text);
            cmd.ExecuteNonQuery();

            adp = new SqlDataAdapter("SELECT * FROM CUSTOMER", con);
            ds = new DataSet();
            adp.Fill(ds, "CUSTOMER");
            dgv_customers.DataSource = ds;
            dgv_customers.DataMember = "CUSTOMER";

            {
                MessageBox.Show("Data Deleted");
            }
        }

        private void dgv_customers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_customers.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgv_customers.CurrentRow.Selected = true;
                txt_cust_id.Text = dgv_customers.Rows[e.RowIndex].Cells["CUST_ID"].FormattedValue.ToString();
                txt_CUSTOMERNAME.Text = dgv_customers.Rows[e.RowIndex].Cells["CUST_NAME"].FormattedValue.ToString();
                txt_PHONENUMBER.Text = dgv_customers.Rows[e.RowIndex].Cells["CUST_PHONE"].FormattedValue.ToString();
            }
        }
    }
}
