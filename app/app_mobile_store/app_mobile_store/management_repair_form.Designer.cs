namespace app_mobile_store
{
    partial class management_repair_form
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
            this.btn_back = new System.Windows.Forms.Button();
            this.grid_repair = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grid_repair)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_back.Location = new System.Drawing.Point(479, 469);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(219, 54);
            this.btn_back.TabIndex = 3;
            this.btn_back.Text = "بازگشت";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // grid_repair
            // 
            this.grid_repair.BackgroundColor = System.Drawing.Color.Snow;
            this.grid_repair.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_repair.Location = new System.Drawing.Point(129, 92);
            this.grid_repair.Name = "grid_repair";
            this.grid_repair.RowHeadersWidth = 51;
            this.grid_repair.RowTemplate.Height = 24;
            this.grid_repair.Size = new System.Drawing.Size(903, 299);
            this.grid_repair.TabIndex = 2;
            // 
            // management_repair_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1143, 638);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.grid_repair);
            this.Font = new System.Drawing.Font("IRANSans", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "management_repair_form";
            this.Text = "management_repair_form";
            this.Load += new System.EventHandler(this.management_repair_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_repair)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.DataGridView grid_repair;
    }
}