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
    public partial class SalesmanLanding : Form
    {
        SqlConnection con;
        public SalesmanLanding()
        {
            InitializeComponent();
        }
        public void ab(string Na)
        {
            Name = Na.ToString();
        }
        private void SalesmanLanding_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("data source=.; database=supermarket; user ID=sa; Password=12345678");
            con.Open();

            lbl_salesman_name.Text = Name;
        }
        

        private void btn_billing_Click(object sender, EventArgs e)
        {
            Billing Objbilling = new Billing();
            this.Hide();
            Objbilling.Show();
        }

        private void btn_logout_salesman_Click(object sender, EventArgs e)
        {
            form_login Objlogin = new form_login();
            this.Hide();
            Objlogin.Show();
        }
    }
}
