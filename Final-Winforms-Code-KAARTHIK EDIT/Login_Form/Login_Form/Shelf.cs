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
    public partial class form_Shelf : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adp;
        DataSet ds;
        public form_Shelf()
        {
            InitializeComponent();
        }

        private void Shelf_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("data source=.; database=supermarket; user ID=sa; Password=12345678");
            con.Open();
            adp = new SqlDataAdapter("SELECT * FROM SHELF", con);
            ds = new DataSet();
            adp.Fill(ds, "SHELF");

            dgv_shelf.DataSource = ds;
            dgv_shelf.DataMember = "SHELF";
        }

        private void btn_shelf_back_Click(object sender, EventArgs e)
        {
            ManagerLanding Objmanagerlanding = new ManagerLanding();
            this.Hide();
            Objmanagerlanding.Show();
        }
    }
}
