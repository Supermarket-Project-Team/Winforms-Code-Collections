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
    public partial class SubCategory : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adp;
        DataSet ds;
        public SubCategory()
        {
            InitializeComponent();
        }

        private void SubCategory_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("data source=.; database=supermarket; user ID=sa; Password=12345678");
            con.Open();
            adp = new SqlDataAdapter("SELECT * FROM SUB_CATEGORY", con);
            ds = new DataSet();
            adp.Fill(ds, "SUB_CATEGORY");

            dgv_sub_category.DataSource = ds;
            dgv_sub_category.DataMember = "SUB_CATEGORY";
        }

        private void link_Category_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Category().Show();
            this.Hide();
        }

        private void btn_subcate_back_Click(object sender, EventArgs e)
        {
            form_Product Objproduct = new form_Product();
            this.Hide();
            Objproduct.Show();
        }
    }
}
