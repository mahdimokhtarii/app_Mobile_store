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
    public partial class category_form : Form
    {
        string connection;
        SqlConnection cnn;
        string old_name;
        public category_form()
        {
            connection = @"Server=.;Database=DB_Mobile_Store;Integrated Security=True";
            cnn = new SqlConnection(connection);
            cnn.Open();
            InitializeComponent();
        }

        public Form back_main { get; set; }

        private void back_main_btn_Click(object sender, EventArgs e)
        {
            cnn.Close();
            this.back_main.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_name.Text != "")
                {
                    string query = "update tbl_Category set Category_name=N'" + txt_name.Text + "' where Category_name=N'" + old_name + "'";
                    SqlCommand command = new SqlCommand(query, cnn);
                    command.ExecuteNonQuery();
                    command.Dispose();
                    update_grid();
                    txt_name.Text = "";
                }
                else
                {
                    MessageBox.Show("مقدار را وارد کنید");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("نام دسته تکراری است");
            }
       
        }

        private void category_form_Load(object sender, EventArgs e)
        {
            update_grid();
        }

        void update_grid()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select * from tbl_Category", cnn);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "tbl_Category");
            dataGridView1.DataSource = ds.Tables["tbl_Category"].DefaultView;
            dataGridView1.Columns[0].HeaderText = "نام دسته";
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void insert_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_name.Text != "")
                {
                    string query = "insert into tbl_Category Values(N'" + txt_name.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, cnn);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    update_grid();
                    txt_name.Text = "";
                }
                else
                {
                    MessageBox.Show("مقدار را وارد کنید");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("نام دسته تکراری است");
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_name.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            old_name = txt_name.Text;
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_name.Text != "")
                {
                    string query = "delete tbl_Category where Category_name=N'" + txt_name.Text + "'";
                    SqlCommand command = new SqlCommand(query, cnn);
                    command.ExecuteNonQuery();
                    command.Dispose();
                    update_grid();
                    txt_name.Text = "";
                }
                else
                {
                    MessageBox.Show("مقدار را وارد کنید");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("رکورد قابل حذف شدن نست");
            }
            
        }
    }
}
