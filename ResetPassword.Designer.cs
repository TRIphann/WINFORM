namespace BTLLTTQ
{
    partial class ResetPassword
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetPassword));
            this.pnlImage = new System.Windows.Forms.Panel();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.picResetLock = new System.Windows.Forms.PictureBox();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.btnHoanTat = new System.Windows.Forms.Button();
            this.txtXacNhanMatKhau = new System.Windows.Forms.TextBox();
            this.txtMatKhauMoi = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.picConfirmLock = new System.Windows.Forms.PictureBox();
            this.picNewLock = new System.Windows.Forms.PictureBox();
            this.pnlImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picResetLock)).BeginInit();
            this.pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picConfirmLock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNewLock)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlImage
            // 
            this.pnlImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.pnlImage.Controls.Add(this.lblInstruction);
            this.pnlImage.Controls.Add(this.picResetLock);
            this.pnlImage.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlImage.Location = new System.Drawing.Point(0, 0);
            this.pnlImage.Name = "pnlImage";
            this.pnlImage.Size = new System.Drawing.Size(350, 450);
            this.pnlImage.TabIndex = 0;
            // 
            // lblInstruction
            // 
            this.lblInstruction.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction.ForeColor = System.Drawing.Color.Navy;
            this.lblInstruction.Location = new System.Drawing.Point(10, 330);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(330, 80);
            this.lblInstruction.TabIndex = 1;
            this.lblInstruction.Text = "Nhập mật khẩu mới. Mật khẩu phải đủ mạnh và dễ nhớ với bạn!";
            this.lblInstruction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picResetLock
            // 
            this.picResetLock.Image = ((System.Drawing.Image)(resources.GetObject("picResetLock.Image")));
            this.picResetLock.Location = new System.Drawing.Point(70, 100);
            this.picResetLock.Name = "picResetLock";
            this.picResetLock.Size = new System.Drawing.Size(210, 210);
            this.picResetLock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picResetLock.TabIndex = 0;
            this.picResetLock.TabStop = false;
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.White;
            this.pnlLogin.Controls.Add(this.btnHoanTat);
            this.pnlLogin.Controls.Add(this.txtXacNhanMatKhau);
            this.pnlLogin.Controls.Add(this.txtMatKhauMoi);
            this.pnlLogin.Controls.Add(this.lblTitle);
            this.pnlLogin.Controls.Add(this.picConfirmLock);
            this.pnlLogin.Controls.Add(this.picNewLock);
            this.pnlLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLogin.Location = new System.Drawing.Point(350, 0);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(450, 450);
            this.pnlLogin.TabIndex = 1;
            // 
            // btnHoanTat
            // 
            this.btnHoanTat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btnHoanTat.FlatAppearance.BorderSize = 0;
            this.btnHoanTat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoanTat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoanTat.ForeColor = System.Drawing.Color.White;
            this.btnHoanTat.Location = new System.Drawing.Point(30, 320);
            this.btnHoanTat.Name = "btnHoanTat";
            this.btnHoanTat.Size = new System.Drawing.Size(395, 55);
            this.btnHoanTat.TabIndex = 5;
            this.btnHoanTat.Text = "HOÀN TẤT ĐẶT LẠI";
            this.btnHoanTat.UseVisualStyleBackColor = false;
            this.btnHoanTat.Click += new System.EventHandler(this.btnHoanTat_Click);
            // 
            // txtXacNhanMatKhau
            // 
            this.txtXacNhanMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtXacNhanMatKhau.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXacNhanMatKhau.Location = new System.Drawing.Point(70, 245); // ⭐️ ĐÃ CHỈNH Y
            this.txtXacNhanMatKhau.Name = "txtXacNhanMatKhau";
            this.txtXacNhanMatKhau.Size = new System.Drawing.Size(355, 27);
            this.txtXacNhanMatKhau.TabIndex = 4;
            this.txtXacNhanMatKhau.Enter += new System.EventHandler(this.txtXacNhanMatKhau_Enter);
            this.txtXacNhanMatKhau.Leave += new System.EventHandler(this.txtXacNhanMatKhau_Leave);
            // 
            // txtMatKhauMoi
            // 
            this.txtMatKhauMoi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMatKhauMoi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhauMoi.Location = new System.Drawing.Point(70, 155); // ⭐️ ĐÃ CHỈNH Y
            this.txtMatKhauMoi.Name = "txtMatKhauMoi";
            this.txtMatKhauMoi.Size = new System.Drawing.Size(355, 27);
            this.txtMatKhauMoi.TabIndex = 2;
            this.txtMatKhauMoi.Enter += new System.EventHandler(this.txtMatKhauMoi_Enter);
            this.txtMatKhauMoi.Leave += new System.EventHandler(this.txtMatKhauMoi_Leave);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(110, 40);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(237, 38);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "ĐẶT LẠI MẬT KHẨU";
            // 
            // picConfirmLock
            // 
            this.picConfirmLock.Image = ((System.Drawing.Image)(resources.GetObject("picConfirmLock.Image")));
            this.picConfirmLock.Location = new System.Drawing.Point(30, 230); // ⭐️ ĐÃ CHỈNH Y
            this.picConfirmLock.Name = "picConfirmLock";
            this.picConfirmLock.Size = new System.Drawing.Size(30, 45);
            this.picConfirmLock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picConfirmLock.TabIndex = 8;
            this.picConfirmLock.TabStop = false;
            // 
            // picNewLock
            // 
            this.picNewLock.Image = ((System.Drawing.Image)(resources.GetObject("picNewLock.Image")));
            this.picNewLock.Location = new System.Drawing.Point(30, 140); // ⭐️ ĐÃ CHỈNH Y
            this.picNewLock.Name = "picNewLock";
            this.picNewLock.Size = new System.Drawing.Size(30, 45);
            this.picNewLock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picNewLock.TabIndex = 7;
            this.picNewLock.TabStop = false;
            // 
            // ResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.pnlImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ResetPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đặt lại Mật khẩu";
            this.pnlImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picResetLock)).EndInit();
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picConfirmLock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNewLock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlImage;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox picResetLock;
        private System.Windows.Forms.TextBox txtXacNhanMatKhau;
        private System.Windows.Forms.TextBox txtMatKhauMoi;
        private System.Windows.Forms.Button btnHoanTat;
        private System.Windows.Forms.PictureBox picConfirmLock;
        private System.Windows.Forms.PictureBox picNewLock;
        private System.Windows.Forms.Label lblInstruction;
    }
}