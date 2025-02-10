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
    public partial class record_sales_form : Form
    {
        SqlConnection cnn;
        string connection;
        int id_personnel;
        double[] array_cost;
        string[] array_model;
        int[] array_id;
        double cost;
        public record_sales_form()
        {
            InitializeComponent();
        }

        public record_sales_form(int id)
        {
            connection = "server=.;database=DB_Mobile_Store;integrated security=true";
            cnn = new SqlConnection(connection);
            cnn.Open();
            id_personnel = id;
            cost = 0;
            InitializeComponent();
        }

        public Form back_main { get; set; }

        private void back_btn_Click(object sender, EventArgs e)
        {
            cnn.Close();
            this.Hide();
            back_main.Visible = true;
        }

        private void record_sales_form_Load(object sender, EventArgs e)
        {
            try
            {
                string query = "select tbl_Device.Device_model , tbl_Mydevice.Mydevice_cost , tbl_Mydevice.Mydevice_id from tbl_Mydevice inner join tbl_device ON tbl_Mydevice.device_id = tbl_Device.Device_id";
                SqlCommand cmd = new SqlCommand(query, cnn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    array_cost = new double[reader.FieldCount];
                    array_id = new int[reader.FieldCount];
                    array_model = new string[reader.FieldCount];
                    int i = 0;
                    while (reader.Read())
                    {
                        comboBox_device.Items.Add(reader.GetValue(0).ToString());
                        array_model[i] = reader.GetValue(0).ToString();
                        array_cost[i] = Convert.ToInt32(reader.GetValue(1));
                        array_id[i] = Convert.ToInt32(reader.GetValue(2));
                        i++;
                    }
                    comboBox_device.SelectedIndex = 0;
                }
                reader.Close();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

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
                    MessageBox.Show("مشتری با این شماره وجود ندارد\nدر صورت نیاز ثبت شود");
                }
                reader.Close();
                cmd.Dispose();
            }
            else
            {
                MessageBox.Show("شماره مشتری را وارد کنید");
            }
        }

        private void insert_btn_Click(object sender, EventArgs e)
        {
            listView_device.Items.Add(comboBox_device.SelectedItem.ToString());
            cost += array_cost[comboBox_device.SelectedIndex];
            txt_price.Text = cost.ToString();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (listView_device.SelectedItems.Count > 0)
            {
                int i = listView_device.SelectedIndices[0];
                int j = Array.IndexOf(array_model, listView_device.SelectedItems[0].Text);
                listView_device.Items.RemoveAt(i);
                cost -= array_cost[j];
                txt_price.Text = cost.ToString();
            }
            else
            {
                MessageBox.Show("مدلی برای حذف انتخاب نشده است");
            }
        }

        bool check(int id)
        {
            string query = "select * from tbl_Factor_buy where Factor_buy_id=N'" + id.ToString() + "'";
            SqlCommand cmd = new SqlCommand(query,cnn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Close();
                cmd.Dispose();
                return false;
            }
            reader.Close ();
            cmd.Dispose();
            return true;
        }

        private void record_factor_btn_Click(object sender, EventArgs e)
        {
            bool isnum;
            int outputValue = 0;
            isnum = int.TryParse(txt_code.Text, out outputValue);

            if (isnum == false)
            {
                MessageBox.Show("شماره فاکتور باید عدد باشد");
            }
            else if (txt_customerinfo.Text != string.Empty && txt_customernum.Text != string.Empty && listView_device.Items.Count >= 1)
            {
                try
                {
                    if (!check(outputValue))
                    {
                        MessageBox.Show("شماره فاکتور تکراری است");
                    }
                    else
                    {
                        DateTime date_now = DateTime.Now;
                        string date_n = date_now.Year.ToString() + "/" + date_now.Month.ToString() + "/" + date_now.Day.ToString();
                        string query = "insert into tbl_Factor_buy values('" + outputValue.ToString() + "','" + id_personnel.ToString() + "',N'" + txt_customernum.Text + "','" +
                            date_n + "',N'" + txt_price.Text + "')";
                        SqlCommand cmd = new SqlCommand(query, cnn);
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        for (int i = 0; i < comboBox_device.Items.Count; i++)
                        {
                            int num = 0;
                            for (int j = 0; j < listView_device.Items.Count; j++)
                            {
                                if (listView_device.Items[j].Text == comboBox_device.Items[i].ToString())
                                {
                                    num++;
                                }
                            }
                            if (num > 0)
                            {
                                string quety = "insert into tbl_Factor_device_buy values(" + num.ToString() + "," + array_id[i].ToString() + "," + txt_code.Text + ")";
                                SqlCommand cmd1 = new SqlCommand(quety, cnn);
                                cmd1.ExecuteNonQuery();
                                cmd.Dispose();
                            }
                        }
                        txt_price.Text = string.Empty;
                        txt_code.Text = string.Empty;
                        txt_checknum.Text = string.Empty;
                        txt_customernum.Text = string.Empty;
                        txt_customerinfo.Text = string.Empty;   
                        listView_device.Items.Clear();
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
