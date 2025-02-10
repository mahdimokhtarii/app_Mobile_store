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
    public partial class record_mydevice_form : Form
    {
        SqlConnection cnn;
        string connection;
        public record_mydevice_form()
        {
            connection = @"server=.;database=DB_Mobile_Store;integrated security= true";
            cnn = new SqlConnection(connection);
            cnn.Open();
            InitializeComponent();
        }
        public Form back_main { get; set; }

        private void record_mydevice_form_Load(object sender, EventArgs e)
        {
            try
            {
                string query = "select Device_id from tbl_Device";
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

        private void back_btn_Click(object sender, EventArgs e)
        {
            cnn.Close();
            this.Hide();
            back_main.Visible = true;
        }

        private void combo_device_code_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string query = "select * from tbl_Device where Device_ID=" + combo_device_code.SelectedItem.ToString();
                SqlCommand command = new SqlCommand(query, cnn);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    txt_model.Text = reader.GetValue(1).ToString();
                }
                reader.Close();
                command.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void insert_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "insert into tbl_Mydevice(Mydevice_number,Mydevice_cost,Device_id) values(" + txt_number.Text + "," + txt_cost.Text + "," + combo_device_code.SelectedItem.ToString() + ")";
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                txt_cost.Text = string.Empty;
                txt_number.Text = string.Empty;
                MessageBox.Show("اطلاعات با موفقیت ثبت شد");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
