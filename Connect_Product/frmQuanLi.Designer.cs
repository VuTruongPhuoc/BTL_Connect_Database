namespace Connect_Product
{
    partial class frmQuanLi
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
            this.btnThuTuc = new Guna.UI2.WinForms.Guna2Button();
            this.btnSP = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // btnThuTuc
            // 
            this.btnThuTuc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThuTuc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThuTuc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThuTuc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThuTuc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThuTuc.ForeColor = System.Drawing.Color.White;
            this.btnThuTuc.Location = new System.Drawing.Point(159, 280);
            this.btnThuTuc.Name = "btnThuTuc";
            this.btnThuTuc.Size = new System.Drawing.Size(180, 45);
            this.btnThuTuc.TabIndex = 2;
            this.btnThuTuc.Text = "Thủ Tục ";
            this.btnThuTuc.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // btnSP
            // 
            this.btnSP.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSP.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSP.ForeColor = System.Drawing.Color.White;
            this.btnSP.Location = new System.Drawing.Point(159, 393);
            this.btnSP.Name = "btnSP";
            this.btnSP.Size = new System.Drawing.Size(180, 45);
            this.btnSP.TabIndex = 5;
            this.btnSP.Text = "Quản lí sản phẩm";
            this.btnSP.Click += new System.EventHandler(this.btnSP_Click);
            // 
            // frmQuanLi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 627);
            this.Controls.Add(this.btnSP);
            this.Controls.Add(this.btnThuTuc);
            this.Name = "frmQuanLi";
            this.Text = "frmQuanLi";
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnThuTuc;
        private Guna.UI2.WinForms.Guna2Button btnSP;
    }
}