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
    public partial class record_personnel : Form
    {
        SqlConnection cnn;
        string connection;
        bool isValid;

        public record_personnel()
        {
            connection = "server=.;database=DB_Mobile_Store;integrated security=true";
            cnn = new SqlConnection(connection);
            cnn.Open();
            InitializeComponent();
        }

        public Form back_main { get; set; }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            cnn.Close();
            back_main.Visible = true;
        }

        private void insert_btn_Click(object sender, EventArgs e)
        {
            if (txt_acount_num.Text != string.Empty && txt_address.Text != string.Empty && txt_city.Text != string.Empty && txt_fname.Text != string.Empty && txt_lname.Text != string.Empty && txt_mobile.Text != string.Empty && txt_n_code.Text != string.Empty)
            {
                try
                {
                    if (isValid)
                    {
                        string query = "insert into tbl_Personnel(Personnel_first_name,personnel_last_name,Personnel_national_code,Personnel_city,Personnel_address,Personnel_mobile,Personnel_account_number) values(N'" + txt_fname.Text + "',N'" + txt_lname.Text + "',N'" + txt_n_code.Text + "',N'" + txt_city.Text
                            + "',N'" + txt_address.Text + "',N'" + txt_mobile.Text + "',N'" + txt_acount_num.Text + "')";
                        SqlCommand cmd = new SqlCommand(query, cnn);
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        MessageBox.Show("اطلاعات با موفقیت ثبت شد");
                        txt_acount_num.Text = txt_address.Text = txt_city.Text = txt_fname.Text = txt_lname.Text = txt_mobile.Text = txt_n_code.Text = string.Empty;
                        txt_mobile.BackColor = Color.White;
                    }
                    else
                    {
                        MessageBox.Show("شماره وارد شده نامعتبر است");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("اطلاعات را تکمیل کنید");
            }
        }

        private void txt_mobile_TextChanged(object sender, EventArgs e)
        {
            Validity check_num = new Validity();
            isValid = check_num.isvalid_num(txt_mobile.Text.ToString());
            if (!isValid)
            {
                txt_mobile.BackColor = Color.IndianRed;
            }
            else
            {
                txt_mobile.BackColor = Color.Lime;
            }
        }
    }
}
