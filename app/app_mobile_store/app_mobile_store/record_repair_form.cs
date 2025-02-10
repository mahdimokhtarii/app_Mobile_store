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
    public partial class record_repair : Form
    {
        SqlConnection cnn;
        string connection;
        int id_perrsonel;
        public record_repair()
        {
            InitializeComponent();
        }

        public record_repair(int id)
        {
            connection = "server=.;database=DB_Mobile_Store;integrated security=true";
            cnn = new SqlConnection(connection);
            cnn.Open();
            id_perrsonel = id;
            InitializeComponent();
        }

        public Form back_main { get; set; }
        private void check_btn_Click(object sender, EventArgs e)
        {
            if (txt_checknum.Text != string.Empty)
            {
                string query = "select * from tbl_Customer where Customer_id=N'" + txt_checknum.Text + "'";
                SqlCommand cmd = new SqlCommand(query, cnn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    txt_customernum.Text = reader.GetValue(0).ToString();
                    txt_customerinfo.Text = reader.GetValue(1).ToString() + " " + reader.GetValue(2).ToString();
                    reader.Close();
                    cmd.Dispose();
                }
                else
                {
                    MessageBox.Show("شماره یافت نشد\nدر صورت نیاز مشتری ثبت شود");
                    reader.Close();
                    cmd.Dispose();
                }
                
            }
            else
            {
                MessageBox.Show("شماره مشتری را وارد کنید");
            }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            cnn.Close();
            back_main.Visible = true;
        }

        private void insert_btn_Click(object sender, EventArgs e)
        {
            if (txt_deviceinfo.Text != string.Empty)
            {
                listView_device.Items.Add(txt_deviceinfo.Text);
                txt_deviceinfo.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("مشخصات را وارد کنید");
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (listView_device.SelectedItems.Count > 0)
            {
                int i = listView_device.SelectedIndices[0];
                listView_device.Items.RemoveAt(i);
                
            }
            else
            {
                MessageBox.Show("مدلی برای حذف انتخاب نشده است");
            }
        }

        bool check(int id)
        {
            string query = "select * from tbl_Factor_repair where Factor_repair_id=N'" + id.ToString() + "'";
            SqlCommand cmd = new SqlCommand(query, cnn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Close();
                cmd.Dispose();
                return false;
            }
            reader.Close();
            cmd.Dispose();
            return true;
        }
        private void record_factor_btn_Click(object sender, EventArgs e)
        {
            bool isnumber;
            int outputvalue = 0;
            isnumber= int.TryParse(txt_code.Text, out outputvalue);

            if (isnumber == false) {
                MessageBox.Show("کد فاکتور باید عدد باشد");
            }
            else if (isnumber == true && txt_customerinfo.Text != string.Empty && listView_device.Items.Count > 0 && txt_price.Text != string.Empty)
            {
                try
                {
                    if (!check(outputvalue))
                    {
                        MessageBox.Show("شماره فاکتور تکراری است");
                    }
                    else
                    {
                        DateTime date_now = DateTime.Now;
                        string date_n = date_now.Year.ToString() + "/" + date_now.Month.ToString() + "/" + date_now.Day.ToString();
                        string query = "insert into tbl_Factor_repair values('" + outputvalue + "','" + date_n + "','" + id_perrsonel.ToString() + "',N'" + txt_customernum.Text + "',N'" + txt_price.Text + "')";
                        SqlCommand cmd = new SqlCommand(query,cnn);
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();

                        for (int j = 0; j < listView_device.Items.Count; j++)
                        {
                            string query1 = "insert into tbl_Factor_repair_device values(N'" + listView_device.Items[j].Text + "',N'" + txt_code.Text + "')";
                            SqlCommand cmd1 = new SqlCommand( query1,cnn);
                            cmd1.ExecuteNonQuery();
                            cmd1.Dispose();
                        }
                        txt_price.Text = string.Empty;
                        txt_deviceinfo.Text = string.Empty;
                        txt_customernum.Text = string.Empty;
                        txt_customerinfo.Text = string.Empty;
                        txt_code.Text = string.Empty;
                        txt_checknum.Text = string.Empty;
                        listView_device.Clear();
                        MessageBox.Show("فاکتور ثبت شد");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
