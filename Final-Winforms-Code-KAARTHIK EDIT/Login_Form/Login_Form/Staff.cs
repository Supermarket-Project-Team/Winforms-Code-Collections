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
    public partial class form_Staff : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adp;
        DataSet ds;
        public form_Staff()
        {
            InitializeComponent();
        }

        private void Staff_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("data source=.; database=supermarket; user ID=sa; Password=12345678");
            con.Open();
            adp = new SqlDataAdapter("SELECT * FROM STAFF", con);
            ds = new DataSet();
            adp.Fill(ds, "STAFF");

            dgv_staff.DataSource = ds;
            dgv_staff.DataMember = "STAFF";
        }

        void Clear()
        {
            txt_staff_id.Text = " ";
            txt_staff_name.Text = " ";
            dt_jdate.Value = DateTime.Now;
            txt_salary.Text = " ";
            cmb_designation.SelectedItem = "--Select--";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Clear();
            btn_edit.Enabled = false;
            btn_delete.Enabled = false;
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            string STAFF_NAME = txt_staff_name.Text;
            string JDATE = dt_jdate.Text;
            string SALARY = txt_salary.Text;
            string DESIGNATION = cmb_designation.Text;
            string str = "insert into STAFF values('" + STAFF_NAME + "', '" + JDATE + "'," + SALARY + ",'" + DESIGNATION + "')";

            adp = new SqlDataAdapter();
            adp.InsertCommand = new SqlCommand(str, con);
            adp.InsertCommand.ExecuteNonQuery();
            adp = new SqlDataAdapter("select * from STAFF", con);
            ds = new DataSet();
            adp.Fill(ds, "STAFF");
            dgv_staff.DataSource = ds;
            dgv_staff.DataMember = "STAFF";

            MessageBox.Show("Succesfully Added");
            btn_edit.Enabled = true;
            btn_delete.Enabled = true;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("UPDATE STAFF SET NAME=@name,JDATE=@jdate,SALARY=@salary,DESIGNATION=@designation WHERE STAFF_ID=@staff_id", con);
            cmd.Parameters.AddWithValue("@staff_id", txt_staff_id.Text);
            cmd.Parameters.AddWithValue("@name", txt_staff_name.Text);
            cmd.Parameters.AddWithValue("@jdate", dt_jdate.Text);
            cmd.Parameters.AddWithValue("@salary", txt_salary.Text);
            cmd.Parameters.AddWithValue("@designation", cmb_designation.Text);
            cmd.ExecuteNonQuery();

            adp = new SqlDataAdapter("SELECT * FROM STAFF", con);
            ds = new DataSet();
            adp.Fill(ds, "STAFF");
            dgv_staff.DataSource = ds;
            dgv_staff.DataMember = "STAFF";

            MessageBox.Show("Data Updated Successfully");
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("DELETE STAFF WHERE STAFF_ID=@staff_id", con);
            cmd.Parameters.AddWithValue("@staff_id", txt_staff_id.Text);
            cmd.ExecuteNonQuery();

            adp = new SqlDataAdapter("SELECT * FROM STAFF", con);
            ds = new DataSet();
            adp.Fill(ds, "STAFF");
            dgv_staff.DataSource = ds;
            dgv_staff.DataMember = "STAFF";

            MessageBox.Show("Data Deleted Successfully");
        }
        private void btn_staff_back_Click(object sender, EventArgs e)
        {
            AdminLanding objadminlanding = new AdminLanding();
            this.Hide();
            objadminlanding.Show();
        }

        private void dgv_staff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgv_staff.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgv_staff.CurrentRow.Selected = true;
                txt_staff_id.Text = dgv_staff.Rows[e.RowIndex].Cells["STAFF_ID"].FormattedValue.ToString();
                txt_staff_name.Text = dgv_staff.Rows[e.RowIndex].Cells["NAME"].FormattedValue.ToString();
                dt_jdate.Text = dgv_staff.Rows[e.RowIndex].Cells["JDATE"].FormattedValue.ToString();
                txt_salary.Text = dgv_staff.Rows[e.RowIndex].Cells["SALARY"].FormattedValue.ToString();
                cmb_designation.Text = dgv_staff.Rows[e.RowIndex].Cells["DESIGNATION"].FormattedValue.ToString();
            }
        }
    }
}
