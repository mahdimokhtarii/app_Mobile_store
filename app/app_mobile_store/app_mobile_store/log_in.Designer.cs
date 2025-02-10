namespace app_mobile_store
{
    partial class log_in
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
            this.P_id_lable = new System.Windows.Forms.Label();
            this.txt_Personel_id = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // P_id_lable
            // 
            this.P_id_lable.AutoSize = true;
            this.P_id_lable.Location = new System.Drawing.Point(770, 213);
            this.P_id_lable.Name = "P_id_lable";
            this.P_id_lable.Size = new System.Drawing.Size(150, 46);
            this.P_id_lable.TabIndex = 0;
            this.P_id_lable.Text = "کد پرسنلی";
            // 
            // txt_Personel_id
            // 
            this.txt_Personel_id.Location = new System.Drawing.Point(588, 210);
            this.txt_Personel_id.Name = "txt_Personel_id";
            this.txt_Personel_id.Size = new System.Drawing.Size(166, 52);
            this.txt_Personel_id.TabIndex = 1;
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(708, 309);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(111, 57);
            this.Login.TabIndex = 2;
            this.Login.Text = "ورود";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // log_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 621);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.txt_Personel_id);
            this.Controls.Add(this.P_id_lable);
            this.Font = new System.Drawing.Font("IRANSans", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.MaximizeBox = false;
            this.Name = "log_in";
            this.Text = "صفحه ورود به فروشگاه";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label P_id_lable;
        private System.Windows.Forms.TextBox txt_Personel_id;
        private System.Windows.Forms.Button Login;
    }
}

