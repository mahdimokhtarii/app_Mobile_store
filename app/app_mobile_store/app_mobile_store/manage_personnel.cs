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
    public partial class manage_personnel : Form
    {
        SqlConnection cnn;
        string connection;
        int old_id;
        bool isValid;
        public manage_personnel()
        {
            connection = "server=.;database=DB_Mobile_Store;integrated security=true";
            cnn = new SqlConnection(connection);
            cnn.Open();
            InitializeComponent();
        }

        public Form back_main { get; set; }

        private void manage_personnel_Load(object sender, EventArgs e)
        {
            update_grid();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            cnn.Close();
            back_main.Visible = true;
        }

        void update_grid ()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select * from tbl_Personnel", cnn);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "tbl_Personnel");
            grid_personnel.DataSource = ds.Tables["tbl_Personnel"].DefaultView;
        }

        private void grid_personnel_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            old_id = Convert.ToInt32(grid_personnel.Rows[e.RowIndex].Cells[0].Value);
            txt_fname.Text = grid_personnel.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_lname.Text = grid_personnel.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_n_code.Text = grid_personnel.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_city.Text = grid_personnel.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_address.Text = grid_personnel.Rows[e.RowIndex].Cells[5].Value.ToString();
            txt_mobile.Text = grid_personnel.Rows[e.RowIndex].Cells[6].Value.ToString();
            txt_acount_num.Text = grid_personnel.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_acount_num.Text != string.Empty && txt_address.Text != string.Empty && txt_city.Text != string.Empty && txt_fname.Text != string.Empty && txt_lname.Text != string.Empty && txt_mobile.Text != string.Empty && txt_n_code.Text != string.Empty)
                {
                    string query = "delete from tbl_Personnel where Personnel_id=N'" + old_id + "'";
                    SqlCommand cmd = new SqlCommand(query, cnn);
                    cmd.ExecuteNonQuery();
                    update_grid();
                    cmd.Dispose();
                    reset();
                }
                else
                {
                    MessageBox.Show("اطلاعات را کامل کنید");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("رکورد قابل حذف شدن نیست");
            }
        }

        void reset ()
        {
            txt_fname.Text = string.Empty;
            txt_lname.Text = string.Empty;
            txt_n_code.Text = string.Empty;
            txt_city.Text = string.Empty;
            txt_address.Text = string.Empty;
            txt_mobile.Text = string.Empty;
            txt_acount_num.Text = string.Empty;
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_acount_num.Text != string.Empty && txt_address.Text != string.Empty && txt_city.Text != string.Empty && txt_fname.Text != string.Empty && txt_lname.Text != string.Empty && txt_mobile.Text != string.Empty && txt_n_code.Text != string.Empty)
                {
                    if (isValid)
                    {
                        string query = "update tbl_Personnel set Personnel_first_name=N'" + txt_fname.Text +
                            "',personnel_last_name=N'" + txt_lname.Text +
                            "',Personnel_national_code=N'" + txt_n_code.Text +
                            "',Personnel_city=N'" + txt_city.Text +
                            "',Personnel_address=N'" + txt_address.Text +
                            "',Personnel_mobile=N'" + txt_mobile.Text +
                            "',Personnel_account_number=N'" + txt_acount_num.Text +
                            "' where Personnel_id=N'" + old_id.ToString() + "'";
                        SqlCommand cmd = new SqlCommand(query, cnn);
                        cmd.ExecuteNonQuery();
                        update_grid();
                        cmd.Dispose();
                        MessageBox.Show("اطلاعات ویرایش شد");
                        reset();
                        txt_mobile.BackColor = Color.White;
                    }
                    else
                    {
                        MessageBox.Show("شماره نا معتبر است");
                    }
                }
                else
                {
                    MessageBox.Show("اطلاعات را کامل کنید");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("اطلاعات ویرایش نشد");
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
