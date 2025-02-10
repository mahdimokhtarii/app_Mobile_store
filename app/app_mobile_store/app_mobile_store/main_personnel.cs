using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_mobile_store
{
    public partial class main_personnel : Form
    {

        string personnel_name;
        string personnel_id;

        public Form back_login { get; set; }

        public main_personnel()
        {
            InitializeComponent();
        }

        public main_personnel(string id, string name)
        {
            personnel_id = id;
            personnel_name = name;
            InitializeComponent();
        }

        private void main_personnel_Load(object sender, EventArgs e)
        {
            label_name.Text = personnel_name;
            label_pcode.Text = personnel_id + " : کد پرسنلی";
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            log_in login_form = new log_in();
            this.Hide();
            back_login.Visible = true;
        }

        private void label_name_Click(object sender, EventArgs e)
        {

        }

        private void sale_manage_btn_Click(object sender, EventArgs e)
        {
            management_sale manage_sale = new management_sale();
            manage_sale.back_main = this;
            this.Visible = false;
            manage_sale.Show();
        }

        private void customer_btn_Click(object sender, EventArgs e)
        {
            customer_form customer = new customer_form();
            customer.back_main = this;
            this.Visible = false;
            customer.Show();
        }

        private void sale_btn_Click(object sender, EventArgs e)
        {
            record_sales_form sales_Form = new record_sales_form(Convert.ToInt32(personnel_id));
            sales_Form.back_main = this;
            this.Visible=false;
            sales_Form.Show();
        }

        private void category_btn_Click(object sender, EventArgs e)
        {
            category_form category = new category_form();
            category.back_main = this;
            this.Visible = false;
            category.Show();
        }

        private void repair_btn_Click(object sender, EventArgs e)
        {
            record_repair repair_form = new record_repair(Convert.ToInt32(personnel_id));
            repair_form.back_main= this;
            this.Visible=false;
            repair_form.Show();
        }

        private void repair_manage_btn_Click(object sender, EventArgs e)
        {
            management_repair_form repair_management_form = new management_repair_form();
            repair_management_form.back_main = this;
            this.Visible = true;
            repair_management_form.Show();
        }

        private void device_register_btn_Click(object sender, EventArgs e)
        {
            record_device_form record_Device = new record_device_form();
            record_Device.back_main = this;
            this.Visible = false;
            record_Device.Show();
        }

        private void device_reg_manage_btn_Click(object sender, EventArgs e)
        {
            device_management_form device_Management = new device_management_form();
            device_Management.back_main = this;
            device_Management.Show();
            this.Visible = false;
        }

        private void mydevice_btn_Click(object sender, EventArgs e)
        {
            record_mydevice_form mydevice_Form = new record_mydevice_form();
            mydevice_Form.back_main = this;
            this .Visible = false;
            mydevice_Form.Show();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mydevice_manage_btn_Click(object sender, EventArgs e)
        {
            management_mydevice_form mydevice_manage_form = new management_mydevice_form();
            mydevice_manage_form.back_main = this;
            this.Visible=false;
            mydevice_manage_form.Show();
        }
    }
}
