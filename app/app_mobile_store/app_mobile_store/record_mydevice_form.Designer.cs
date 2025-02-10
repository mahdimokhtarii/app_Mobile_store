namespace app_mobile_store
{
    partial class record_mydevice_form
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
            this.insert_btn = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.combo_device_code = new System.Windows.Forms.ComboBox();
            this.txt_model = new System.Windows.Forms.Label();
            this.txt_cost = new System.Windows.Forms.TextBox();
            this.txt_number = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(628, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "کد دستگاه";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(693, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 46);
            this.label2.TabIndex = 4;
            this.label2.Text = "تعداد";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(686, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 46);
            this.label3.TabIndex = 5;
            this.label3.Text = "قیمت";
            // 
            // insert_btn
            // 
            this.insert_btn.BackColor = System.Drawing.Color.SeaGreen;
            this.insert_btn.Location = new System.Drawing.Point(397, 437);
            this.insert_btn.Name = "insert_btn";
            this.insert_btn.Size = new System.Drawing.Size(382, 60);
            this.insert_btn.TabIndex = 6;
            this.insert_btn.Text = "ثبت";
            this.insert_btn.UseVisualStyleBackColor = false;
            this.insert_btn.Click += new System.EventHandler(this.insert_btn_Click);
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.Color.Crimson;
            this.back_btn.Location = new System.Drawing.Point(397, 518);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(382, 60);
            this.back_btn.TabIndex = 7;
            this.back_btn.Text = "بازگشت";
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // combo_device_code
            // 
            this.combo_device_code.BackColor = System.Drawing.Color.RosyBrown;
            this.combo_device_code.FormattingEnabled = true;
            this.combo_device_code.Location = new System.Drawing.Point(397, 137);
            this.combo_device_code.Name = "combo_device_code";
            this.combo_device_code.Size = new System.Drawing.Size(190, 53);
            this.combo_device_code.TabIndex = 8;
            this.combo_device_code.SelectedIndexChanged += new System.EventHandler(this.combo_device_code_SelectedIndexChanged);
            // 
            // txt_model
            // 
            this.txt_model.AutoSize = true;
            this.txt_model.BackColor = System.Drawing.Color.DarkOrange;
            this.txt_model.Location = new System.Drawing.Point(217, 144);
            this.txt_model.Name = "txt_model";
            this.txt_model.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_model.Size = new System.Drawing.Size(0, 46);
            this.txt_model.TabIndex = 9;
            // 
            // txt_cost
            // 
            this.txt_cost.BackColor = System.Drawing.Color.RosyBrown;
            this.txt_cost.Location = new System.Drawing.Point(397, 341);
            this.txt_cost.Name = "txt_cost";
            this.txt_cost.Size = new System.Drawing.Size(190, 52);
            this.txt_cost.TabIndex = 10;
            // 
            // txt_number
            // 
            this.txt_number.BackColor = System.Drawing.Color.RosyBrown;
            this.txt_number.Location = new System.Drawing.Point(397, 239);
            this.txt_number.Name = "txt_number";
            this.txt_number.Size = new System.Drawing.Size(190, 52);
            this.txt_number.TabIndex = 11;
            // 
            // record_mydevice_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(841, 656);
            this.Controls.Add(this.txt_number);
            this.Controls.Add(this.txt_cost);
            this.Controls.Add(this.txt_model);
            this.Controls.Add(this.combo_device_code);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.insert_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("IRANSans", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "record_mydevice_form";
            this.Text = "record_mydevice_form";
            this.Load += new System.EventHandler(this.record_mydevice_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button insert_btn;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.ComboBox combo_device_code;
        private System.Windows.Forms.Label txt_model;
        private System.Windows.Forms.TextBox txt_cost;
        private System.Windows.Forms.TextBox txt_number;
    }
}