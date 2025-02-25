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
using System.Linq.Expressions;

namespace app_mobile_store
{
    public partial class customer_form : Form
    {
        SqlConnection cnn;
        string connection;
        string old_mobile;
        bool isValid;
       
        public customer_form()
        {
            connection = @"server=.;database=DB_Mobile_Store;integrated security=true";
            cnn = new SqlConnection(connection);
            cnn.Open();
            InitializeComponent();
        }

        public Form back_main { get; set; }

        private void customer_form_Load(object sender, EventArgs e)
        {
            grid_update();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            cnn.Close();
            back_main.Visible = true;
        }

        void grid_update()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select * from tbl_Customer", cnn);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "tbl_Customer");
            grid_customer.DataSource = ds.Tables["tbl_Customer"].DefaultView;
        }

        private void insert_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_f_name.Text != "" && txt_l_name.Text != string.Empty && txt_mobile.Text != string.Empty)
                {
                    if (isValid)
                    {
                        string query = "insert into tbl_Customer Values(N'" + txt_mobile.Text + "',N'" + txt_f_name.Text + "',N'" + txt_l_name.Text + "',N'" + txt_address.Text + "')";
                        SqlCommand cmd = new SqlCommand(query, cnn);
                        cmd.ExecuteNonQuery();
                        grid_update();
                        cmd.Dispose();
                        txt_mobile.BackColor = Color.White;
                    }
                    else
                    {
                        MessageBox.Show("شماره نامعتبر است");
                    }
                } 
                else
                {
                    MessageBox.Show("مشخصات را تکمیل کنید");
                }
                txt_mobile.Text = string.Empty;
                txt_f_name.Text = string.Empty;
                txt_l_name.Text = string.Empty;
                txt_address.Text = string.Empty;
            }
            catch (Exception ex) 
            {
                MessageBox.Show("این شماره قبلا ثبت شده است");
            }
        }

        private void grid_customer_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_mobile.Text = grid_customer.Rows[e.RowIndex].Cells[0].Value.ToString();
            old_mobile = txt_mobile.Text;
            txt_f_name.Text = grid_customer.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_l_name.Text = grid_customer.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_address.Text = grid_customer.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_mobile.Text != string.Empty)
                {
                    string query = "delete from tbl_Customer where Customer_id=N'" + txt_mobile.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, cnn);
                    cmd.ExecuteNonQuery();
                    grid_update();
                    cmd.Dispose();
                }
                else
                {
                    MessageBox.Show("برای حذف, شماره تلفن مشتری را وارد کنید");
                }
                txt_mobile.Text = string.Empty;
                txt_f_name.Text = string.Empty;
                txt_l_name.Text = string.Empty;
                txt_address.Text = string.Empty;
                txt_mobile.BackColor = Color.White;
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
                if (txt_mobile.Text != string.Empty)
                {
                    if (isValid)
                    {
                        string query = "update tbl_Customer set Customer_id=N'" + txt_mobile.Text + "',Customer_first_name=N'" + txt_f_name.Text + "',Customer_last_name=N'" + txt_l_name.Text + "',Customer_address=N'" + txt_address.Text + "' where Customer_id=N'" + old_mobile + "'";
                        SqlCommand cmd = new SqlCommand(query, cnn);
                        cmd.ExecuteNonQuery();
                        grid_update();
                        cmd.Dispose();
                        txt_mobile.BackColor = Color.White;
                    }
                    else
                    {
                        MessageBox.Show("شماره نا معتبر است");
                    }
                }
                else
                {
                    MessageBox.Show("برای ویرایش, شماره تلفن مشتری را وارد کنید");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("رکورد قابل تغییر نیست");
            }
        }

        private void txt_mobile_TextChanged(object sender, EventArgs e)
        {
            Validity check_num = new Validity();
            isValid = check_num.isvalid_num(txt_mobile.Text);
            if (isValid)
            {
                txt_mobile.BackColor = Color.Lime;
            }
            else
            {
                txt_mobile.BackColor = Color.IndianRed;
            }
        }
    }
}
