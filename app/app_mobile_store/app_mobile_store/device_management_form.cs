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

namespace app_mobile_store
{
    public partial class device_management_form : Form
    {
        SqlConnection cnn;
        string connection;
        string device_id;
        public device_management_form()
        {
            connection = "server=.;database=DB_Mobile_Store;integrated security=true";
            cnn = new SqlConnection(connection);
            cnn.Open();
            InitializeComponent();
        }

        public Form back_main { get; set; }

        private void reset()
        {
            txt_model.Text = string.Empty;
            txt_display.Text = string.Empty;
            txt_dim.Text = string.Empty;
            txt_storage.Text = string.Empty;
            txt_ram.Text = string.Empty;
            txt_discription.Text = string.Empty;
        }
        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            cnn.Close();
            back_main.Visible = true;
        }

        private void device_management_form_Load(object sender, EventArgs e)
        {
            grid_update();
            string query = "select * from tbl_Category";
            SqlCommand cmd = new SqlCommand(query,cnn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    comboBox_category.Items.Add(reader.GetValue(0).ToString());
                }
            }
            cmd.Dispose();
            reader.Close();
        }

        void grid_update()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select * from tbl_Device", cnn);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "tbl_Device");
            device_grid.DataSource = ds.Tables["tbl_Device"].DefaultView;
        }

        private void device_grid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            device_id = device_grid.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_model.Text = device_grid.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_display.Text = device_grid.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_dim.Text = device_grid.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_storage.Text = device_grid.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_ram.Text = device_grid.Rows[e.RowIndex].Cells[5].Value.ToString();
            txt_discription.Text = device_grid.Rows[e.RowIndex].Cells[6].Value.ToString();
            comboBox_category.SelectedItem = device_grid.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_model.Text != string.Empty)
                {
                    string query = "delete from tbl_Device where Device_id=N'" + device_id + "'";
                    SqlCommand cmd = new SqlCommand(query, cnn);
                    cmd.ExecuteNonQuery();
                    grid_update();
                    cmd.Dispose();
                }
                else
                {
                    MessageBox.Show("برای حذف, مدل را وارد کنید");
                }
                reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show("رکورد قابل حذف شدن نیست");
            }
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_model.Text != string.Empty)
                {
                    string query = "update tbl_Device set Device_model=N'" + txt_model.Text + "',Device_display_type=N'" + txt_display.Text + "',Device_dim=N'" + txt_dim.Text
                        + "',Device_memory=N'" + txt_storage.Text + "',Device_ram=N'" + txt_ram.Text + "',Device_coment=N'" + txt_discription.Text
                        + "', Category_name=N'" + comboBox_category.SelectedItem.ToString()
                        + "' where Device_id=N'" + device_id + "'";
                    SqlCommand cmd = new SqlCommand(query, cnn);
                    cmd.ExecuteNonQuery();
                    grid_update();
                    reset();
                    cmd.Dispose();
                }
                else
                {
                    MessageBox.Show("مدل را مشخص کنید");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("اطلاعات ویرایش نشد");
            }
        }
    }
}
