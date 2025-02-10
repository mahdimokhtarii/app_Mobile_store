namespace app_mobile_store
{
    partial class management_sale
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
            this.grid_sale = new System.Windows.Forms.DataGridView();
            this.btn_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_sale)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_sale
            // 
            this.grid_sale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_sale.Location = new System.Drawing.Point(130, 78);
            this.grid_sale.Name = "grid_sale";
            this.grid_sale.RowHeadersWidth = 51;
            this.grid_sale.RowTemplate.Height = 24;
            this.grid_sale.Size = new System.Drawing.Size(903, 299);
            this.grid_sale.TabIndex = 0;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(466, 446);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(219, 54);
            this.btn_back.TabIndex = 1;
            this.btn_back.Text = "بازگشت";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // management_sale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1159, 647);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.grid_sale);
            this.Font = new System.Drawing.Font("IRANSans", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "management_sale";
            this.Text = "management_sale";
            this.Load += new System.EventHandler(this.management_sale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_sale)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_sale;
        private System.Windows.Forms.Button btn_back;
    }
}