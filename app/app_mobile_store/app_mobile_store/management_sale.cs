using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace app_mobile_store
{
    public partial class management_sale : Form
    {
        string connection;
        SqlConnection cnn;
        public management_sale()
        {
            connection = "server=.;database=DB_Mobile_Store;integrated security=true";
            cnn = new SqlConnection(connection);
            cnn.Open();
            InitializeComponent();
        }

        public Form back_main { get; set; }

        void update_grid()
        {
            string query = "select * from tbl_Factor_buy inner join tbl_Factor_device_buy ON tbl_Factor_buy.Factor_buy_id=tbl_Factor_device_buy.Factor_buy_id";
            SqlDataAdapter adapter = new SqlDataAdapter(query,cnn);
            DataSet ds = new DataSet();
            adapter.Fill(ds ,"tbl_Factor");
            grid_sale.DataSource = ds.Tables["tbl_Factor"].DefaultView;
        }

        private void management_sale_Load(object sender, EventArgs e)
        {
            update_grid();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            cnn.Close();
            back_main.Visible = true;
        }
    }
}
