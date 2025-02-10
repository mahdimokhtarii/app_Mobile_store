namespace app_mobile_store
{
    partial class category_form
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
            this.back_main_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.insert_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // back_main_btn
            // 
            this.back_main_btn.Location = new System.Drawing.Point(879, 30);
            this.back_main_btn.Name = "back_main_btn";
            this.back_main_btn.Size = new System.Drawing.Size(210, 107);
            this.back_main_btn.TabIndex = 0;
            this.back_main_btn.Text = "بازگشت";
            this.back_main_btn.UseVisualStyleBackColor = true;
            this.back_main_btn.Click += new System.EventHandler(this.back_main_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(209, 227);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(502, 226);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(521, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "دسته بندی";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(257, 142);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(146, 52);
            this.txt_name.TabIndex = 3;
            this.txt_name.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // insert_btn
            // 
            this.insert_btn.BackColor = System.Drawing.Color.SpringGreen;
            this.insert_btn.Location = new System.Drawing.Point(595, 509);
            this.insert_btn.Name = "insert_btn";
            this.insert_btn.Size = new System.Drawing.Size(116, 49);
            this.insert_btn.TabIndex = 4;
            this.insert_btn.Text = "ثبت";
            this.insert_btn.UseVisualStyleBackColor = false;
            this.insert_btn.Click += new System.EventHandler(this.insert_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.BackColor = System.Drawing.Color.Crimson;
            this.delete_btn.Location = new System.Drawing.Point(209, 509);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(114, 49);
            this.delete_btn.TabIndex = 5;
            this.delete_btn.Text = "حذف";
            this.delete_btn.UseVisualStyleBackColor = false;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.BackColor = System.Drawing.Color.Yellow;
            this.edit_btn.Location = new System.Drawing.Point(394, 509);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(125, 49);
            this.edit_btn.TabIndex = 6;
            this.edit_btn.Text = "ویرایش";
            this.edit_btn.UseVisualStyleBackColor = false;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // category_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(1130, 779);
            this.ControlBox = false;
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.insert_btn);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.back_main_btn);
            this.Font = new System.Drawing.Font("IRANSans", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "category_form";
            this.Text = "دسته بندی محصولات";
            this.Load += new System.EventHandler(this.category_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back_main_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Button insert_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button edit_btn;
    }
}