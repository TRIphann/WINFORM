namespace JumpArena.View.Accountant
{
    partial class MENUAUC
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
            this.btnLogout = new System.Windows.Forms.Button();
            this.lbJump = new System.Windows.Forms.Label();
            this.btnfrmBestSeller = new System.Windows.Forms.Button();
            this.btnfrmVoucherCheckIn = new System.Windows.Forms.Button();
            this.btnfrmRevenueReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(317, 414);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(185, 26);
            this.btnLogout.TabIndex = 11;
            this.btnLogout.Text = "Đăng Xuất";
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // lbJump
            // 
            this.lbJump.AutoSize = true;
            this.lbJump.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbJump.Location = new System.Drawing.Point(228, 11);
            this.lbJump.Name = "lbJump";
            this.lbJump.Size = new System.Drawing.Size(368, 36);
            this.lbJump.TabIndex = 10;
            this.lbJump.Text = "KẾ TOÁN JUMP ARENA";
            // 
            // btnfrmBestSeller
            // 
            this.btnfrmBestSeller.BackColor = System.Drawing.Color.Yellow;
            this.btnfrmBestSeller.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfrmBestSeller.Location = new System.Drawing.Point(450, 235);
            this.btnfrmBestSeller.Name = "btnfrmBestSeller";
            this.btnfrmBestSeller.Size = new System.Drawing.Size(300, 168);
            this.btnfrmBestSeller.TabIndex = 9;
            this.btnfrmBestSeller.Text = "frmBestSeller";
            this.btnfrmBestSeller.UseVisualStyleBackColor = false;
            // 
            // btnfrmVoucherCheckIn
            // 
            this.btnfrmVoucherCheckIn.BackColor = System.Drawing.Color.Yellow;
            this.btnfrmVoucherCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfrmVoucherCheckIn.Location = new System.Drawing.Point(50, 235);
            this.btnfrmVoucherCheckIn.Name = "btnfrmVoucherCheckIn";
            this.btnfrmVoucherCheckIn.Size = new System.Drawing.Size(312, 168);
            this.btnfrmVoucherCheckIn.TabIndex = 8;
            this.btnfrmVoucherCheckIn.Text = "frmVoucherCheckIn";
            this.btnfrmVoucherCheckIn.UseVisualStyleBackColor = false;
            // 
            // btnfrmRevenueReport
            // 
            this.btnfrmRevenueReport.BackColor = System.Drawing.Color.Yellow;
            this.btnfrmRevenueReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfrmRevenueReport.Location = new System.Drawing.Point(257, 50);
            this.btnfrmRevenueReport.Name = "btnfrmRevenueReport";
            this.btnfrmRevenueReport.Size = new System.Drawing.Size(300, 179);
            this.btnfrmRevenueReport.TabIndex = 7;
            this.btnfrmRevenueReport.Text = "frmRevenueReport";
            this.btnfrmRevenueReport.UseVisualStyleBackColor = false;
            // 
            // MENUAUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lbJump);
            this.Controls.Add(this.btnfrmBestSeller);
            this.Controls.Add(this.btnfrmVoucherCheckIn);
            this.Controls.Add(this.btnfrmRevenueReport);
            this.Name = "MENUAUC";
            this.Text = "MENUAUC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lbJump;
        private System.Windows.Forms.Button btnfrmBestSeller;
        private System.Windows.Forms.Button btnfrmVoucherCheckIn;
        private System.Windows.Forms.Button btnfrmRevenueReport;
    }
}