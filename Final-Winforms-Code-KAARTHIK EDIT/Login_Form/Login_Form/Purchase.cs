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
    public partial class form_Purchase : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adp;
        DataSet ds;
        public form_Purchase()
        {
            InitializeComponent();
        }

        private void Purchase_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("data source=.; database=supermarket; user ID=sa; Password=12345678");
            con.Open();
            adp = new SqlDataAdapter("SELECT * FROM ORDER_PLACED", con);
            ds = new DataSet();
            adp.Fill(ds, "ORDER_PLACED");

            dgv_orders.DataSource = ds;
            dgv_orders.DataMember = "ORDER_PLACED";
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            int ORDER_NO = Convert.ToInt32(txt_order_no.Text);
            DateTime ORD_DATE = Convert.ToDateTime(txt_order_date.Text);
            string VENDOR_ID = txt_ventorid.Text;
            int TOTAL_AMT = Convert.ToInt32(txt_totalamount.Text);
            string str = "insert into ORDER_PLACED values(" + ORDER_NO + ", '" + ORD_DATE + "','" + VENDOR_ID + "'," + TOTAL_AMT + ")";

            adp = new SqlDataAdapter();
            adp.InsertCommand = new SqlCommand(str, con);
            adp.InsertCommand.ExecuteNonQuery();
            adp = new SqlDataAdapter("select * from ORDER_PLACED", con);
            ds = new DataSet();
            adp.Fill(ds, "ORDER_PLACED");
            dgv_orders.DataSource = ds;
            dgv_orders.DataMember = "ORDER_PLACED";

            MessageBox.Show("Succesfully Added");
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("DELETE ORDER_PLACED WHERE ORDER_NO=@ORDER_NO", con);
            cmd.Parameters.AddWithValue("@ORDER_NO", txt_order_no.Text);
            cmd.ExecuteNonQuery();

            adp = new SqlDataAdapter("SELECT * FROM ORDER_PLACED", con);
            ds = new DataSet();
            adp.Fill(ds, "ORDER_PLACED");
            dgv_orders.DataSource = ds;
            dgv_orders.DataMember = "ORDER_PLACED";

            {
                MessageBox.Show("Data Deleted");
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("UPDATE ORDER_PLACED SET ORDER_NO=@ORDER_NO,ORD_DATE=@ORD_DATE,VENDOR_ID=@VENDOR_ID,TOTAL_AMT=@TOTAL_AMT,WHERE ORDER_NO=@ORDER_NO", con);
            cmd.Parameters.AddWithValue("@ORDER_NO", txt_order_no.Text);
            cmd.Parameters.AddWithValue("@ORD_DATE", txt_order_date.Text);
            cmd.Parameters.AddWithValue("@VENDOR_ID", txt_ventorid.Text);
            cmd.Parameters.AddWithValue("@TOTAL_AMT", txt_totalamount.Text);


            adp = new SqlDataAdapter("SELECT * FROM ORDER_PLACED", con);
            ds = new DataSet();
            adp.Fill(ds, "ORDER_PLACED");
            dgv_orders.DataSource = ds;
            dgv_orders.DataMember = "ORDER_PLACED";

            MessageBox.Show("Data Updated Successfully");
        }
    }
}
