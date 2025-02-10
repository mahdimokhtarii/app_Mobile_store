namespace app_mobile_store
{
    partial class manage_personnel
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
            this.back_btn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            this.txt_acount_num = new System.Windows.Forms.TextBox();
            this.txt_mobile = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_city = new System.Windows.Forms.TextBox();
            this.txt_n_code = new System.Windows.Forms.TextBox();
            this.txt_lname = new System.Windows.Forms.TextBox();
            this.txt_fname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grid_personnel = new System.Windows.Forms.DataGridView();
            this.delete_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_personnel)).BeginInit();
            this.SuspendLayout();
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.Color.LightSlateGray;
            this.back_btn.Location = new System.Drawing.Point(189, 706);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(232, 62);
            this.back_btn.TabIndex = 31;
            this.back_btn.Text = "بازگشت";
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.BackColor = System.Drawing.Color.Gold;
            this.edit_btn.Location = new System.Drawing.Point(598, 706);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(232, 62);
            this.edit_btn.TabIndex = 30;
            this.edit_btn.Text = "ویرایش";
            this.edit_btn.UseVisualStyleBackColor = false;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // txt_acount_num
            // 
            this.txt_acount_num.Location = new System.Drawing.Point(801, 608);
            this.txt_acount_num.Name = "txt_acount_num";
            this.txt_acount_num.Size = new System.Drawing.Size(273, 52);
            this.txt_acount_num.TabIndex = 29;
            // 
            // txt_mobile
            // 
            this.txt_mobile.Location = new System.Drawing.Point(801, 520);
            this.txt_mobile.Name = "txt_mobile";
            this.txt_mobile.Size = new System.Drawing.Size(273, 52);
            this.txt_mobile.TabIndex = 28;
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(47, 520);
            this.txt_address.Multiline = true;
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(415, 140);
            this.txt_address.TabIndex = 27;
            // 
            // txt_city
            // 
            this.txt_city.Location = new System.Drawing.Point(189, 432);
            this.txt_city.Name = "txt_city";
            this.txt_city.Size = new System.Drawing.Size(273, 52);
            this.txt_city.TabIndex = 26;
            // 
            // txt_n_code
            // 
            this.txt_n_code.Location = new System.Drawing.Point(189, 344);
            this.txt_n_code.Name = "txt_n_code";
            this.txt_n_code.Size = new System.Drawing.Size(273, 52);
            this.txt_n_code.TabIndex = 25;
            // 
            // txt_lname
            // 
            this.txt_lname.Location = new System.Drawing.Point(801, 432);
            this.txt_lname.Name = "txt_lname";
            this.txt_lname.Size = new System.Drawing.Size(273, 52);
            this.txt_lname.TabIndex = 24;
            // 
            // txt_fname
            // 
            this.txt_fname.Location = new System.Drawing.Point(801, 344);
            this.txt_fname.Name = "txt_fname";
            this.txt_fname.Size = new System.Drawing.Size(273, 52);
            this.txt_fname.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1158, 611);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(197, 46);
            this.label7.TabIndex = 22;
            this.label7.Text = "شماره حساب:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1171, 523);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(184, 46);
            this.label6.TabIndex = 21;
            this.label6.Text = "شماره همراه:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(488, 523);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(186, 46);
            this.label5.TabIndex = 20;
            this.label5.Text = "آدرس پرسنل:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(510, 435);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(164, 46);
            this.label4.TabIndex = 19;
            this.label4.Text = "شهر پرسنل:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(468, 347);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(206, 46);
            this.label3.TabIndex = 18;
            this.label3.Text = "کد ملی پرسنل:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1080, 438);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(275, 46);
            this.label2.TabIndex = 17;
            this.label2.Text = "نام خانوادگی پرسنل:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1203, 347);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(152, 46);
            this.label1.TabIndex = 16;
            this.label1.Text = "نام پرسنل:";
            // 
            // grid_personnel
            // 
            this.grid_personnel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_personnel.Location = new System.Drawing.Point(47, 31);
            this.grid_personnel.Name = "grid_personnel";
            this.grid_personnel.RowHeadersWidth = 51;
            this.grid_personnel.RowTemplate.Height = 24;
            this.grid_personnel.Size = new System.Drawing.Size(1300, 291);
            this.grid_personnel.TabIndex = 32;
            this.grid_personnel.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grid_personnel_RowHeaderMouseClick);
            // 
            // delete_btn
            // 
            this.delete_btn.BackColor = System.Drawing.Color.IndianRed;
            this.delete_btn.Location = new System.Drawing.Point(1029, 706);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(232, 62);
            this.delete_btn.TabIndex = 33;
            this.delete_btn.Text = "حذف";
            this.delete_btn.UseVisualStyleBackColor = false;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // manage_personnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1403, 817);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.grid_personnel);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.txt_acount_num);
            this.Controls.Add(this.txt_mobile);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.txt_city);
            this.Controls.Add(this.txt_n_code);
            this.Controls.Add(this.txt_lname);
            this.Controls.Add(this.txt_fname);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("IRANSans", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "manage_personnel";
            this.Text = "manage_personnel";
            this.Load += new System.EventHandler(this.manage_personnel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_personnel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.TextBox txt_acount_num;
        private System.Windows.Forms.TextBox txt_mobile;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.TextBox txt_city;
        private System.Windows.Forms.TextBox txt_n_code;
        private System.Windows.Forms.TextBox txt_lname;
        private System.Windows.Forms.TextBox txt_fname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grid_personnel;
        private System.Windows.Forms.Button delete_btn;
    }
}