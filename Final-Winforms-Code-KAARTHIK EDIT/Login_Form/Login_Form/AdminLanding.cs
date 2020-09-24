using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Form
{
    public partial class AdminLanding : Form
    {
        public AdminLanding()
        {
            InitializeComponent();
        }

        private void btn_stock_ad_Click(object sender, EventArgs e)
        {
            form_Product objproduct = new form_Product();
            this.Hide();
            objproduct.Show();
        }

        private void btn_vendor_ad_Click(object sender, EventArgs e)
        {
            form_vendor objvendor = new form_vendor();
            this.Hide();
            objvendor.Show();
        }

        private void btn_staff_ad_Click(object sender, EventArgs e)
        {
            form_Staff objstaff = new form_Staff();
            this.Hide();
            objstaff.Show();
        }

        private void btn_userc_ad_Click(object sender, EventArgs e)
        {
            form_User objuser = new form_User();
            this.Hide();
            objuser.Show();
        }

        private void btn_customer_Click(object sender, EventArgs e)
        {
            form_Customer objcustomer = new form_Customer();
            this.Hide();
            objcustomer.Show();
        }

        private void btn_logout_ad_Click(object sender, EventArgs e)
        {
            form_login objlogin = new form_login();
            this.Hide();
            objlogin.Show();
        }

        private void AdminLanding_Load(object sender, EventArgs e)
        {

        }
    }
}
