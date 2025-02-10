namespace app_mobile_store
{
    partial class management_mydevice_form
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
            this.txt_number = new System.Windows.Forms.TextBox();
            this.txt_cost = new System.Windows.Forms.TextBox();
            this.combo_device_code = new System.Windows.Forms.ComboBox();
            this.back_btn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grid_mydevice = new System.Windows.Forms.DataGridView();
            this.delete_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_mydevice)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_number
            // 
            this.txt_number.BackColor = System.Drawing.Color.RosyBrown;
            this.txt_number.Location = new System.Drawing.Point(505, 220);
            this.txt_number.Name = "txt_number";
            this.txt_number.Size = new System.Drawing.Size(190, 52);
            this.txt_number.TabIndex = 19;
            // 
            // txt_cost
            // 
            this.txt_cost.BackColor = System.Drawing.Color.RosyBrown;
            this.txt_cost.Location = new System.Drawing.Point(505, 322);
            this.txt_cost.Name = "txt_cost";
            this.txt_cost.Size = new System.Drawing.Size(190, 52);
            this.txt_cost.TabIndex = 18;
            // 
            // combo_device_code
            // 
            this.combo_device_code.BackColor = System.Drawing.Color.RosyBrown;
            this.combo_device_code.FormattingEnabled = true;
            this.combo_device_code.Location = new System.Drawing.Point(505, 118);
            this.combo_device_code.Name = "combo_device_code";
            this.combo_device_code.Size = new System.Drawing.Size(190, 53);
            this.combo_device_code.TabIndex = 17;
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.Color.Gray;
            this.back_btn.Location = new System.Drawing.Point(290, 517);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(382, 60);
            this.back_btn.TabIndex = 16;
            this.back_btn.Text = "بازگشت";
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.BackColor = System.Drawing.Color.Yellow;
            this.edit_btn.Location = new System.Drawing.Point(505, 418);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(382, 60);
            this.edit_btn.TabIndex = 15;
            this.edit_btn.Text = "ویرایش";
            this.edit_btn.UseVisualStyleBackColor = false;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(794, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 46);
            this.label3.TabIndex = 14;
            this.label3.Text = "قیمت";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(801, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 46);
            this.label2.TabIndex = 13;
            this.label2.Text = "تعداد";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(736, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 46);
            this.label1.TabIndex = 12;
            this.label1.Text = "کد دستگاه";
            // 
            // grid_mydevice
            // 
            this.grid_mydevice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_mydevice.Location = new System.Drawing.Point(81, 118);
            this.grid_mydevice.Name = "grid_mydevice";
            this.grid_mydevice.RowHeadersWidth = 51;
            this.grid_mydevice.RowTemplate.Height = 24;
            this.grid_mydevice.Size = new System.Drawing.Size(382, 256);
            this.grid_mydevice.TabIndex = 20;
            this.grid_mydevice.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.grid_mydevice.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grid_mydevice_RowHeaderMouseClick);
            // 
            // delete_btn
            // 
            this.delete_btn.BackColor = System.Drawing.Color.Crimson;
            this.delete_btn.Location = new System.Drawing.Point(81, 418);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(382, 60);
            this.delete_btn.TabIndex = 21;
            this.delete_btn.Text = "حذف";
            this.delete_btn.UseVisualStyleBackColor = false;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // management_mydevice_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(978, 711);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.grid_mydevice);
            this.Controls.Add(this.txt_number);
            this.Controls.Add(this.txt_cost);
            this.Controls.Add(this.combo_device_code);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("IRANSans", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "management_mydevice_form";
            this.Text = "management_mydevice_form";
            this.Load += new System.EventHandler(this.management_mydevice_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_mydevice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_number;
        private System.Windows.Forms.TextBox txt_cost;
        private System.Windows.Forms.ComboBox combo_device_code;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grid_mydevice;
        private System.Windows.Forms.Button delete_btn;
    }
}