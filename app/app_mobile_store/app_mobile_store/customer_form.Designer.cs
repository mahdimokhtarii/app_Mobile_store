namespace app_mobile_store
{
    partial class customer_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_f_name = new System.Windows.Forms.TextBox();
            this.txt_l_name = new System.Windows.Forms.TextBox();
            this.txt_mobile = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.insert_btn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.grid_customer = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grid_customer)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_f_name
            // 
            this.txt_f_name.Location = new System.Drawing.Point(874, 80);
            this.txt_f_name.Name = "txt_f_name";
            this.txt_f_name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_f_name.Size = new System.Drawing.Size(187, 52);
            this.txt_f_name.TabIndex = 0;
            // 
            // txt_l_name
            // 
            this.txt_l_name.Location = new System.Drawing.Point(636, 80);
            this.txt_l_name.Name = "txt_l_name";
            this.txt_l_name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_l_name.Size = new System.Drawing.Size(187, 52);
            this.txt_l_name.TabIndex = 1;
            // 
            // txt_mobile
            // 
            this.txt_mobile.Location = new System.Drawing.Point(636, 205);
            this.txt_mobile.Name = "txt_mobile";
            this.txt_mobile.Size = new System.Drawing.Size(425, 52);
            this.txt_mobile.TabIndex = 2;
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(315, 331);
            this.txt_address.Multiline = true;
            this.txt_address.Name = "txt_address";
            this.txt_address.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_address.Size = new System.Drawing.Size(746, 142);
            this.txt_address.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1013, 31);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(56, 46);
            this.label1.TabIndex = 4;
            this.label1.Text = "نام";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(908, 156);
            this.label.Name = "label";
            this.label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label.Size = new System.Drawing.Size(161, 46);
            this.label.TabIndex = 5;
            this.label.Text = "تلفن همراه";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(640, 31);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(191, 46);
            this.label3.TabIndex = 6;
            this.label3.Text = "نام خوانوادگی";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(979, 282);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(90, 46);
            this.label2.TabIndex = 7;
            this.label2.Text = "آدرس";
            // 
            // insert_btn
            // 
            this.insert_btn.BackColor = System.Drawing.Color.SpringGreen;
            this.insert_btn.Location = new System.Drawing.Point(895, 524);
            this.insert_btn.Name = "insert_btn";
            this.insert_btn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.insert_btn.Size = new System.Drawing.Size(166, 53);
            this.insert_btn.TabIndex = 8;
            this.insert_btn.Text = "ثبت";
            this.insert_btn.UseVisualStyleBackColor = false;
            this.insert_btn.Click += new System.EventHandler(this.insert_btn_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.BackColor = System.Drawing.Color.Yellow;
            this.edit_btn.Location = new System.Drawing.Point(700, 524);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.edit_btn.Size = new System.Drawing.Size(166, 53);
            this.edit_btn.TabIndex = 9;
            this.edit_btn.Text = "ویرایش";
            this.edit_btn.UseVisualStyleBackColor = false;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.BackColor = System.Drawing.Color.Crimson;
            this.delete_btn.Location = new System.Drawing.Point(509, 524);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.delete_btn.Size = new System.Drawing.Size(166, 53);
            this.delete_btn.TabIndex = 10;
            this.delete_btn.Text = "حذف";
            this.delete_btn.UseVisualStyleBackColor = false;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.Color.LightSlateGray;
            this.back_btn.Location = new System.Drawing.Point(315, 524);
            this.back_btn.Name = "back_btn";
            this.back_btn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.back_btn.Size = new System.Drawing.Size(166, 53);
            this.back_btn.TabIndex = 11;
            this.back_btn.Text = "بازگشت";
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // grid_customer
            // 
            this.grid_customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_customer.Location = new System.Drawing.Point(38, 80);
            this.grid_customer.Name = "grid_customer";
            this.grid_customer.RowHeadersWidth = 51;
            this.grid_customer.RowTemplate.Height = 24;
            this.grid_customer.Size = new System.Drawing.Size(558, 177);
            this.grid_customer.TabIndex = 12;
            this.grid_customer.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grid_customer_RowHeaderMouseClick);
            // 
            // customer_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1115, 661);
            this.Controls.Add(this.grid_customer);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.insert_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.txt_mobile);
            this.Controls.Add(this.txt_l_name);
            this.Controls.Add(this.txt_f_name);
            this.Font = new System.Drawing.Font("IRANSans", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "customer_form";
            this.Text = "customer_form";
            this.Load += new System.EventHandler(this.customer_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_customer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_f_name;
        private System.Windows.Forms.TextBox txt_l_name;
        private System.Windows.Forms.TextBox txt_mobile;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button insert_btn;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.DataGridView grid_customer;
    }
}