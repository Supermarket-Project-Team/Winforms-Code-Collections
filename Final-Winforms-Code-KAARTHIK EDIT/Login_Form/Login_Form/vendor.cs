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
    public partial class form_vendor : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adp;
        DataSet ds;
        public form_vendor()
        {
            InitializeComponent();
        }

        private void btn_vendor_back_Click(object sender, EventArgs e)
        {
            AdminLanding objadminlanding = new AdminLanding();
            this.Hide();
            objadminlanding.Show();
        }

        private void form_vendor_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("data source=.; database=supermarket; user ID=sa; Password=12345678");
            con.Open();
            adp = new SqlDataAdapter("SELECT * FROM VENDOR", con);
            ds = new DataSet();
            adp.Fill(ds, "VENDOR");

            dgv_vendor_details.DataSource = ds;
            dgv_vendor_details.DataMember = "VENDOR";
        }
        private void dgv_vendor_details_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_vendor_details.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgv_vendor_details.CurrentRow.Selected = true;
                txt_vendor_id.Text = dgv_vendor_details.Rows[e.RowIndex].Cells["VENDOR_ID"].FormattedValue.ToString();
                txt_name.Text = dgv_vendor_details.Rows[e.RowIndex].Cells["VENDOR_NAME"].FormattedValue.ToString();
                txt_phonenumber.Text = dgv_vendor_details.Rows[e.RowIndex].Cells["VENDOR_PHONE"].FormattedValue.ToString();
                txt_location.Text = dgv_vendor_details.Rows[e.RowIndex].Cells["LOCATION"].FormattedValue.ToString();
            }
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            string VENDOR_NAME = txt_name.Text;
            string VENDOR_PHONE = txt_phonenumber.Text;
            string LOCATION = txt_location.Text;
            string str = "insert into VENDOR values('" + VENDOR_NAME + "', " + VENDOR_PHONE + ",'" + LOCATION + "')";

            adp = new SqlDataAdapter();
            adp.InsertCommand = new SqlCommand(str, con);
            adp.InsertCommand.ExecuteNonQuery();
            adp = new SqlDataAdapter("select * from VENDOR", con);
            ds = new DataSet();
            adp.Fill(ds, "VENDOR");
            dgv_vendor_details.DataSource = ds;
            dgv_vendor_details.DataMember = "VENDOR";

            MessageBox.Show("Succesfully Added");
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("UPDATE VENDOR SET VENDOR_NAME=@name,VENDOR_PHONE=@phone,LOCATION=@location WHERE VENDOR_ID=@vendor_id", con);
            cmd.Parameters.AddWithValue("@vendor_id", txt_vendor_id.Text);
            cmd.Parameters.AddWithValue("@name", txt_name.Text);
            cmd.Parameters.AddWithValue("@phone",txt_phonenumber.Text);
            cmd.Parameters.AddWithValue("@location", txt_location.Text);
            cmd.ExecuteNonQuery();

            adp = new SqlDataAdapter("SELECT * FROM VENDOR", con);
            ds = new DataSet();
            adp.Fill(ds, "VENDOR");
            dgv_vendor_details.DataSource = ds;
            dgv_vendor_details.DataMember = "VENDOR";

            MessageBox.Show("Data Updated Successfully");
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("DELETE VENDOR WHERE VENDOR_NAME=@VENDOR_NAME", con);
            cmd.Parameters.AddWithValue("@VENDOR_NAME", txt_name.Text);
            cmd.ExecuteNonQuery();

            adp = new SqlDataAdapter("SELECT * FROM VENDOR", con);
            ds = new DataSet();
            adp.Fill(ds, "VENDOR");
            dgv_vendor_details.DataSource = ds;
            dgv_vendor_details.DataMember = "VENDOR";
            {
                MessageBox.Show("Data Deleted");
            }
        }

        
    }
}
