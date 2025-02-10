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
    public partial class management_mydevice_form : Form
    {
        SqlConnection cnn;
        string connection;
        string mydevice_id;
        public management_mydevice_form()
        {
            connection = @"server=.;database=DB_Mobile_Store;integrated security=true";
            cnn = new SqlConnection(connection);
            cnn.Open();
            InitializeComponent();
        }
        public Form back_main { get; set; }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void management_mydevice_form_Load(object sender, EventArgs e)
        {
            try
            {
                grid_update();
                string query = "select Device_id from tbl_device";
                SqlCommand cmd = new SqlCommand(query, cnn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        combo_device_code.Items.Add(reader.GetValue(0).ToString());
                    }
                }
                reader.Close();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void grid_update()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select * from tbl_Mydevice", cnn);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "tbl_Mydevice");
            grid_mydevice.DataSource = ds.Tables["tbl_Mydevice"].DefaultView;
        }
        private void delete_btn_Click(object sender, EventArgs e)
        {
            string query = "delete from tbl_Mydevice where Mydevice_id=N'" + mydevice_id + "'";
            SqlCommand cmd = new SqlCommand(query, cnn);
            cmd.ExecuteNonQuery();
            grid_update();
            cmd.Dispose();
            txt_cost.Text = string.Empty;
            txt_number.Text = string.Empty;
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            cnn.Close();
            this.Hide();
            back_main.Visible = true;
        }

        private void grid_mydevice_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            mydevice_id = grid_mydevice.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_number.Text = grid_mydevice.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_cost.Text = grid_mydevice.Rows[e.RowIndex].Cells[2].Value.ToString();
            combo_device_code.SelectedItem = grid_mydevice.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "update tbl_Mydevice set Mydevice_number=N'" + txt_number.Text + "',Mydevice_cost=N'" + txt_cost.Text
                + "' where Mydevice_id=N'" + mydevice_id + "'";
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.ExecuteNonQuery();
                grid_update();
                cmd.Dispose();
                txt_cost.Text = string.Empty;
                txt_number.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
