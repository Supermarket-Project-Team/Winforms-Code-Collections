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
    public partial class form_User : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adp;
        DataSet ds;
        public form_User()
        {
            InitializeComponent();
        }

        private void btn_user_back_Click(object sender, EventArgs e)
        {
            AdminLanding objadminlanding = new AdminLanding();
            this.Hide();
            objadminlanding.Show();
        }

        private void form_User_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("data source=KRIPARAJ\\SQLEXPRESS; database=SuperMarket; user ID=sa; password=Sukritha7###");
            con.Open();
            adp = new SqlDataAdapter("SELECT A.STAFF_ID,A.NAME, B.USER_NAME,B.PASSWORD,B.DESIGNATION FROM STAFF A, USER_TABLE B WHERE A.STAFF_ID=B.STAFF_ID", con);
            ds = new DataSet();
            adp.Fill(ds, "USER_TABLE");

            dgv_user_create.DataSource = ds;
            dgv_user_create.DataMember = "USER_TABLE";
        }
       

        private void dgv_user_create_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_user_create.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgv_user_create.CurrentRow.Selected = true;
                txt_staffid.Text = dgv_user_create.Rows[e.RowIndex].Cells["STAFF_ID"].FormattedValue.ToString();
                txt_name_user.Text = dgv_user_create.Rows[e.RowIndex].Cells["NAME"].FormattedValue.ToString();
                cb_designation.Text = dgv_user_create.Rows[e.RowIndex].Cells["DESIGNATION"].FormattedValue.ToString();
                txt_username.Text = dgv_user_create.Rows[e.RowIndex].Cells["USER_NAME"].FormattedValue.ToString();
                txt_password.Text = dgv_user_create.Rows[e.RowIndex].Cells["PASSWORD"].FormattedValue.ToString();
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string NAME_USER = txt_name_user.Text;
            string DESIGNATION = cb_designation.Text;
            string USER_NAME = txt_username.Text;
            string PASSWORD = txt_password.Text;


            
            string str = "INSERT INTO USER_TABLE VALUES('" + NAME_USER + "', '" + DESIGNATION + "','" + USER_NAME + "','" + PASSWORD + "')";

            adp = new SqlDataAdapter();
            adp.InsertCommand = new SqlCommand(str, con);
            adp.InsertCommand.ExecuteNonQuery();
            adp = new SqlDataAdapter("select * from USER_TABLE", con);
            ds = new DataSet();
            adp.Fill(ds, "USER_TABLE");
            dgv_user_create.DataSource = ds;
            dgv_user_create.DataMember = "USER_TABLE";

            MessageBox.Show("Succesfully Added");
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("UPDATE USER_TABLE SET NAME=@name,DESIGNATION=@designation,USERNAME=@username,PASSWORD=@password WHERE STAFF_ID=@staff_id", con);
            cmd.Parameters.AddWithValue("@staff_id", txt_staffid.Text);
            cmd.Parameters.AddWithValue("@name", txt_name_user.Text);
            cmd.Parameters.AddWithValue("@designation", cb_designation.Text);
            cmd.Parameters.AddWithValue("@username", txt_username.Text);
            cmd.Parameters.AddWithValue("@password", txt_password.Text);
            cmd.ExecuteNonQuery();

            adp = new SqlDataAdapter("SELECT * FROM USER_TABLE", con);
            ds = new DataSet();
            adp.Fill(ds, "USER_TABLE");
            dgv_user_create.DataSource = ds;
            dgv_user_create.DataMember = "USER_TABLE";

            MessageBox.Show("Data Updated Successfully");
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("DELETE USER_TABLE WHERE STAFF_ID=@staff_id", con);
            cmd.Parameters.AddWithValue("@staff_id", txt_staffid.Text);
            cmd.ExecuteNonQuery();

            adp = new SqlDataAdapter("SELECT * FROM USER_TABLE", con);
            ds = new DataSet();
            adp.Fill(ds, "USER_TABLE");
            dgv_user_create.DataSource = ds;
            dgv_user_create.DataMember = "USER_TABLE";

            MessageBox.Show("Data Deleted Successfully");
        }

        private void btn_add_Click(object sender, EventArgs e)
        {

        }
    }
}
