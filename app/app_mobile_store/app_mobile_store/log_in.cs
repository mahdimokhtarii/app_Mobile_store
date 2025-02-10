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
    public partial class log_in : Form
    {
        public log_in()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            string connection = @"Server=.;Database=DB_Mobile_Store;Integrated Security=True";
            SqlConnection sqlcnn = new SqlConnection(connection);
            sqlcnn.Open();
            if (txt_Personel_id.Text != string.Empty)
            {
                string query = $"select * from tbl_Personnel where Personnel_id={txt_Personel_id.Text}";
                SqlCommand cmd = new SqlCommand(query, sqlcnn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    string output = reader.GetValue(0).ToString();
                    string name = reader.GetValue(1).ToString() + " " + reader.GetValue(2).ToString();
                    if (output == "111")
                    {
                        main_management management_form = new main_management(output, name);
                        management_form.back_login = this;
                        this.Visible = false;
                        management_form.Show();
                    }
                    else
                    {
                        main_personnel personnel_form = new main_personnel(output, name);
                        personnel_form.back_login = this;
                        this.Visible = false;
                        personnel_form.Show();
                    }
                }
                else
                {
                    MessageBox.Show("کد پرسنلی یافت نشد");
                }
                reader.Close();
                cmd.Dispose();
                sqlcnn.Close();
                txt_Personel_id.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("کد پرسنلی را وارد کنید");
            }
        }
    }
}
