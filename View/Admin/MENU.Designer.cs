namespace JumpArena.View.Admin
{
    partial class MENU
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
            this.btnAddProductForm = new System.Windows.Forms.Button();
            this.btnCompanyAccountsForm = new System.Windows.Forms.Button();
            this.btnCreateVoucherForm = new System.Windows.Forms.Button();
            this.btnReportInboxForm = new System.Windows.Forms.Button();
            this.lbJump = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddProductForm
            // 
            this.btnAddProductForm.BackColor = System.Drawing.Color.Yellow;
            this.btnAddProductForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProductForm.Location = new System.Drawing.Point(24, 48);
            this.btnAddProductForm.Name = "btnAddProductForm";
            this.btnAddProductForm.Size = new System.Drawing.Size(312, 179);
            this.btnAddProductForm.TabIndex = 0;
            this.btnAddProductForm.Text = "AddProductForm";
            this.btnAddProductForm.UseVisualStyleBackColor = false;
            // 
            // btnCompanyAccountsForm
            // 
            this.btnCompanyAccountsForm.BackColor = System.Drawing.Color.Yellow;
            this.btnCompanyAccountsForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompanyAccountsForm.Location = new System.Drawing.Point(424, 48);
            this.btnCompanyAccountsForm.Name = "btnCompanyAccountsForm";
            this.btnCompanyAccountsForm.Size = new System.Drawing.Size(300, 179);
            this.btnCompanyAccountsForm.TabIndex = 1;
            this.btnCompanyAccountsForm.Text = "CompanyAccountsForm";
            this.btnCompanyAccountsForm.UseVisualStyleBackColor = false;
            // 
            // btnCreateVoucherForm
            // 
            this.btnCreateVoucherForm.BackColor = System.Drawing.Color.Yellow;
            this.btnCreateVoucherForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateVoucherForm.Location = new System.Drawing.Point(24, 233);
            this.btnCreateVoucherForm.Name = "btnCreateVoucherForm";
            this.btnCreateVoucherForm.Size = new System.Drawing.Size(312, 168);
            this.btnCreateVoucherForm.TabIndex = 2;
            this.btnCreateVoucherForm.Text = "CreateVoucherForm";
            this.btnCreateVoucherForm.UseVisualStyleBackColor = false;
            // 
            // btnReportInboxForm
            // 
            this.btnReportInboxForm.BackColor = System.Drawing.Color.Yellow;
            this.btnReportInboxForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportInboxForm.Location = new System.Drawing.Point(424, 233);
            this.btnReportInboxForm.Name = "btnReportInboxForm";
            this.btnReportInboxForm.Size = new System.Drawing.Size(300, 168);
            this.btnReportInboxForm.TabIndex = 3;
            this.btnReportInboxForm.Text = "ReportInboxForm";
            this.btnReportInboxForm.UseVisualStyleBackColor = false;
            // 
            // lbJump
            // 
            this.lbJump.AutoSize = true;
            this.lbJump.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbJump.Location = new System.Drawing.Point(116, 9);
            this.lbJump.Name = "lbJump";
            this.lbJump.Size = new System.Drawing.Size(535, 36);
            this.lbJump.TabIndex = 4;
            this.lbJump.Text = "CHÀO MỪNG ADMIN JUMP ARENA";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(291, 412);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(185, 26);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Đăng Xuất";
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // MENU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lbJump);
            this.Controls.Add(this.btnReportInboxForm);
            this.Controls.Add(this.btnCreateVoucherForm);
            this.Controls.Add(this.btnCompanyAccountsForm);
            this.Controls.Add(this.btnAddProductForm);
            this.Name = "MENU";
            this.Text = "MENU";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddProductForm;
        private System.Windows.Forms.Button btnCompanyAccountsForm;
        private System.Windows.Forms.Button btnCreateVoucherForm;
        private System.Windows.Forms.Button btnReportInboxForm;
        private System.Windows.Forms.Label lbJump;
        private System.Windows.Forms.Button btnLogout;
    }
}