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
    public partial class ManagerLanding : Form
    {
        public ManagerLanding()
        {
            InitializeComponent();
        }

        private void btn_stock_mgr_Click(object sender, EventArgs e)
        {
            form_Product objproduct = new form_Product();
            this.Hide();
            objproduct.Show();
        }

        private void btn_vendor_mgr_Click(object sender, EventArgs e)
        {
            form_vendor objvendor = new form_vendor();
            this.Hide();
            objvendor.Show();
        }

        private void btn_order_mgr_Click(object sender, EventArgs e)
        {
            form_Purchase objpurchase = new form_Purchase();
            this.Hide();
            objpurchase.Show();
        }

        private void btn_shelf_mgr_Click(object sender, EventArgs e)
        {
            form_Shelf objshelf = new form_Shelf();
            this.Hide();
            objshelf.Show();
        }

        private void btn_logout_mgr_Click(object sender, EventArgs e)
        {
            form_login objlogin = new form_login();
            this.Hide();
            objlogin.Show();
        }
    }
}
