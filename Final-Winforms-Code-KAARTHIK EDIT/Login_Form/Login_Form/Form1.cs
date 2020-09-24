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
    public partial class form_login : Form
    {
        SqlConnection con;
        SqlDataAdapter adp;
        DataTable dt;
        String Name;
        String Designation;
        public form_login()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("data source=.; database=supermarket; user ID=sa; Password=12345678");
            con.Open();
        }
        
        private void btn_Login_Click(object sender, EventArgs e)
        {
            Name = txt_username.Text;
            Designation = cmb_designation.Text;
            string query = "SELECT * FROM USER_TABLE WHERE USER_NAME= '" + txt_username.Text.Trim() + "' and PASSWORD='" + txt_password.Text.Trim() + "' and DESIGNATION='" + cmb_designation.Text.ToString() + "' ";
            adp = new SqlDataAdapter(query, con);
            dt = new DataTable();
            adp.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                if (cmb_designation.Text == "ADMIN")
                {
                    AdminLanding objadminlanding = new AdminLanding();
                    this.Hide();
                    objadminlanding.Show();

                }
                else if (cmb_designation.Text == "MANAGER")
                {
                    ManagerLanding objmanagerlanding = new ManagerLanding();
                    this.Hide();
                    objmanagerlanding.Show();
                    String designation = cmb_designation.Text;
                }
                else if (cmb_designation.Text == "SALESMAN")
                {
                    SalesmanLanding objsalesmanlanding = new SalesmanLanding();
                    this.Hide();
                    objsalesmanlanding.Show();
                    objsalesmanlanding.ab(Name.ToString());
                }
                else
                {
                    MessageBox.Show("Select designation");
                }
            }
            else
            {
                MessageBox.Show("Data is incorrect");
            }
            
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
