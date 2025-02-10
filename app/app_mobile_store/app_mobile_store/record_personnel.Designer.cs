namespace app_mobile_store
{
    partial class record_personnel
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_fname = new System.Windows.Forms.TextBox();
            this.txt_lname = new System.Windows.Forms.TextBox();
            this.txt_n_code = new System.Windows.Forms.TextBox();
            this.txt_city = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_mobile = new System.Windows.Forms.TextBox();
            this.txt_acount_num = new System.Windows.Forms.TextBox();
            this.insert_btn = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(682, 78);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(152, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام پرسنل:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(559, 144);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(275, 46);
            this.label2.TabIndex = 1;
            this.label2.Text = "نام خانوادگی پرسنل:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(628, 209);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(206, 46);
            this.label3.TabIndex = 2;
            this.label3.Text = "کد ملی پرسنل:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(670, 277);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(164, 46);
            this.label4.TabIndex = 3;
            this.label4.Text = "شهر پرسنل:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(648, 345);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(186, 46);
            this.label5.TabIndex = 4;
            this.label5.Text = "آدرس پرسنل:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(650, 498);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(184, 46);
            this.label6.TabIndex = 5;
            this.label6.Text = "شماره همراه:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(637, 563);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(197, 46);
            this.label7.TabIndex = 6;
            this.label7.Text = "شماره حساب:";
            // 
            // txt_fname
            // 
            this.txt_fname.Location = new System.Drawing.Point(280, 75);
            this.txt_fname.Name = "txt_fname";
            this.txt_fname.Size = new System.Drawing.Size(273, 52);
            this.txt_fname.TabIndex = 7;
            // 
            // txt_lname
            // 
            this.txt_lname.Location = new System.Drawing.Point(280, 141);
            this.txt_lname.Name = "txt_lname";
            this.txt_lname.Size = new System.Drawing.Size(273, 52);
            this.txt_lname.TabIndex = 8;
            // 
            // txt_n_code
            // 
            this.txt_n_code.Location = new System.Drawing.Point(280, 206);
            this.txt_n_code.Name = "txt_n_code";
            this.txt_n_code.Size = new System.Drawing.Size(273, 52);
            this.txt_n_code.TabIndex = 9;
            // 
            // txt_city
            // 
            this.txt_city.Location = new System.Drawing.Point(280, 274);
            this.txt_city.Name = "txt_city";
            this.txt_city.Size = new System.Drawing.Size(273, 52);
            this.txt_city.TabIndex = 10;
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(138, 342);
            this.txt_address.Multiline = true;
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(415, 140);
            this.txt_address.TabIndex = 11;
            // 
            // txt_mobile
            // 
            this.txt_mobile.Location = new System.Drawing.Point(280, 495);
            this.txt_mobile.Name = "txt_mobile";
            this.txt_mobile.Size = new System.Drawing.Size(273, 52);
            this.txt_mobile.TabIndex = 12;
            this.txt_mobile.TextChanged += new System.EventHandler(this.txt_mobile_TextChanged);
            // 
            // txt_acount_num
            // 
            this.txt_acount_num.Location = new System.Drawing.Point(280, 560);
            this.txt_acount_num.Name = "txt_acount_num";
            this.txt_acount_num.Size = new System.Drawing.Size(273, 52);
            this.txt_acount_num.TabIndex = 13;
            // 
            // insert_btn
            // 
            this.insert_btn.BackColor = System.Drawing.Color.LimeGreen;
            this.insert_btn.Location = new System.Drawing.Point(492, 696);
            this.insert_btn.Name = "insert_btn";
            this.insert_btn.Size = new System.Drawing.Size(232, 62);
            this.insert_btn.TabIndex = 14;
            this.insert_btn.Text = "ثبت";
            this.insert_btn.UseVisualStyleBackColor = false;
            this.insert_btn.Click += new System.EventHandler(this.insert_btn_Click);
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.Color.IndianRed;
            this.back_btn.Location = new System.Drawing.Point(155, 696);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(232, 62);
            this.back_btn.TabIndex = 15;
            this.back_btn.Text = "بازگشت";
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // record_personnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(857, 836);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.insert_btn);
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
            this.Name = "record_personnel";
            this.Text = "record_personnel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_fname;
        private System.Windows.Forms.TextBox txt_lname;
        private System.Windows.Forms.TextBox txt_n_code;
        private System.Windows.Forms.TextBox txt_city;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.TextBox txt_mobile;
        private System.Windows.Forms.TextBox txt_acount_num;
        private System.Windows.Forms.Button insert_btn;
        private System.Windows.Forms.Button back_btn;
    }
}