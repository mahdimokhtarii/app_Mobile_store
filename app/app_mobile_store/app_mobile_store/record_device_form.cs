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

namespace app_mobile_store
{
    public partial class record_device_form : Form
    {
        SqlConnection cnn;
        string connection;


        public record_device_form()
        {
            connection = "server=.;database=DB_Mobile_Store;integrated security=true";
            cnn = new SqlConnection(connection);
            cnn.Open();
            InitializeComponent();
        }
        public Form back_main {  get; set; }

        private void reset()
        {
            txt_model.Text = string.Empty;
            txt_display.Text = string.Empty;
            txt_dim.Text = string.Empty;
            txt_storage.Text = string.Empty;
            txt_ram.Text = string.Empty;
            txt_discription.Text = string.Empty;
        }

        private void record_device_form_Load(object sender, EventArgs e)
        {
            string query = "select * from tbl_Category";
            SqlCommand cmd = new SqlCommand(query, cnn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    comboBox_category.Items.Add(reader.GetValue(0).ToString());
                }
            }
            reader.Close();
            cmd.Dispose();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            cnn.Close();
            back_main.Visible = true;
        }

        private void insert_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_model.Text != string.Empty)
                {
                    string query = "insert into tbl_Device(Device_model,Device_display_type,Device_dim,Device_memory,Device_ram,Device_coment,Category_name) values(N'" + txt_model.Text +
                     "',N'" + txt_display.Text + "',N'" + txt_dim.Text + "',N'" + txt_storage.Text + "',N'" + txt_ram.Text + "',N'" + txt_discription.Text + "',N'" + comboBox_category.SelectedItem.ToString() + "')";
                    SqlCommand cmd = new SqlCommand(query, cnn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("اطلاعات با موفقیت ثبت شد");
                    cmd.Dispose();
                    reset();
                }
                else 
                {
                    MessageBox.Show("مدل را مشخص کنید");
                }
            }
            catch (Exception ex)
            { 
                MessageBox.Show("اطلاعات ثبت نشد");
            }
           
        }

        private void combo_caregory_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_category.SelectedItem.ToString() != "موبایل" && comboBox_category.SelectedItem.ToString() != "تبلت")
            {
                txt_ram.Enabled = false;
                txt_storage.Enabled = false;
                txt_display.Enabled = false;
                txt_dim.Enabled = false;
            }
            else
            {
                txt_ram.Enabled = true;
                txt_storage.Enabled = true;
                txt_display.Enabled = true;
                txt_dim.Enabled = true;
            }
                
        }
    }
}
