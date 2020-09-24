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
    public partial class Category : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adp;
        DataSet ds;
        public Category()
        {
            InitializeComponent();
        }

        private void Category_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("data source=.; database=supermarket; user ID=sa; Password=12345678");
            con.Open();
            adp = new SqlDataAdapter("SELECT * FROM CATEGORY", con);
            ds = new DataSet();
            adp.Fill(ds, "CATEGORY");

            dgv_category.DataSource = ds;
            dgv_category.DataMember = "CATEGORY";
        }

        private void btn_category_back_Click(object sender, EventArgs e)
        {
            form_Product Objproduct = new form_Product();
            this.Hide();
            Objproduct.Show();
        }

        private void link_SubCategory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new SubCategory().Show();
            this.Hide();
        }
    }
}
