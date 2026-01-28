namespace JumpArena
{
    partial class frmCheck_in
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
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.lblStaffRoleValue = new System.Windows.Forms.Label();
            this.lblCustomerRoleText = new System.Windows.Forms.Label();
            this.lblStaffAddressValue = new System.Windows.Forms.Label();
            this.lblStaffEmailValue = new System.Windows.Forms.Label();
            this.lblStaffNameValue = new System.Windows.Forms.Label();
            this.lblCustomerAddressText = new System.Windows.Forms.Label();
            this.lblCustomerEmailText = new System.Windows.Forms.Label();
            this.lblCustomerNameText = new System.Windows.Forms.Label();
            this.lblCustomerInfoTitle = new System.Windows.Forms.Label();
            this.btnSearchCustomer = new System.Windows.Forms.Button();
            this.txtSearchInput = new System.Windows.Forms.TextBox();
            this.cbDataSource = new System.Windows.Forms.ComboBox();
            this.lblDataSourceText = new System.Windows.Forms.Label();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.buttonCheckIn = new System.Windows.Forms.Button();
            this.pnlSeparator3 = new System.Windows.Forms.Panel();
            this.dgvOrderItems = new System.Windows.Forms.DataGridView();
            this.btnCheckDiscount = new System.Windows.Forms.Button();
            this.txtDiscountCode = new System.Windows.Forms.TextBox();
            this.lblDiscountCode = new System.Windows.Forms.Label();
            this.lblOrderIDText = new System.Windows.Forms.Label();
            this.pnlLeft.SuspendLayout();
            this.pnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderItems)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.White;
            this.pnlLeft.Controls.Add(this.lblStaffRoleValue);
            this.pnlLeft.Controls.Add(this.lblCustomerRoleText);
            this.pnlLeft.Controls.Add(this.lblStaffAddressValue);
            this.pnlLeft.Controls.Add(this.lblStaffEmailValue);
            this.pnlLeft.Controls.Add(this.lblStaffNameValue);
            this.pnlLeft.Controls.Add(this.lblCustomerAddressText);
            this.pnlLeft.Controls.Add(this.lblCustomerEmailText);
            this.pnlLeft.Controls.Add(this.lblCustomerNameText);
            this.pnlLeft.Controls.Add(this.lblCustomerInfoTitle);
            this.pnlLeft.Controls.Add(this.btnSearchCustomer);
            this.pnlLeft.Controls.Add(this.txtSearchInput);
            this.pnlLeft.Controls.Add(this.cbDataSource);
            this.pnlLeft.Controls.Add(this.lblDataSourceText);
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(525, 596);
            this.pnlLeft.TabIndex = 2;
            // 
            // lblStaffRoleValue
            // 
            this.lblStaffRoleValue.AutoSize = true;
            this.lblStaffRoleValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffRoleValue.Location = new System.Drawing.Point(118, 316);
            this.lblStaffRoleValue.Name = "lblStaffRoleValue";
            this.lblStaffRoleValue.Size = new System.Drawing.Size(66, 20);
            this.lblStaffRoleValue.TabIndex = 19;
            this.lblStaffRoleValue.Text = "Quản Lý";
            // 
            // lblCustomerRoleText
            // 
            this.lblCustomerRoleText.AutoSize = true;
            this.lblCustomerRoleText.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerRoleText.Location = new System.Drawing.Point(37, 312);
            this.lblCustomerRoleText.Name = "lblCustomerRoleText";
            this.lblCustomerRoleText.Size = new System.Drawing.Size(78, 25);
            this.lblCustomerRoleText.TabIndex = 18;
            this.lblCustomerRoleText.Text = "Vai trò :";
            // 
            // lblStaffAddressValue
            // 
            this.lblStaffAddressValue.AutoSize = true;
            this.lblStaffAddressValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffAddressValue.Location = new System.Drawing.Point(118, 280);
            this.lblStaffAddressValue.Name = "lblStaffAddressValue";
            this.lblStaffAddressValue.Size = new System.Drawing.Size(121, 20);
            this.lblStaffAddressValue.TabIndex = 17;
            this.lblStaffAddressValue.Text = "Quận 3, TP.HCM";
            // 
            // lblStaffEmailValue
            // 
            this.lblStaffEmailValue.AutoSize = true;
            this.lblStaffEmailValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffEmailValue.Location = new System.Drawing.Point(118, 241);
            this.lblStaffEmailValue.Name = "lblStaffEmailValue";
            this.lblStaffEmailValue.Size = new System.Drawing.Size(112, 20);
            this.lblStaffEmailValue.TabIndex = 16;
            this.lblStaffEmailValue.Text = "ex@gmail.com";
            // 
            // lblStaffNameValue
            // 
            this.lblStaffNameValue.AutoSize = true;
            this.lblStaffNameValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffNameValue.Location = new System.Drawing.Point(118, 205);
            this.lblStaffNameValue.Name = "lblStaffNameValue";
            this.lblStaffNameValue.Size = new System.Drawing.Size(114, 20);
            this.lblStaffNameValue.TabIndex = 15;
            this.lblStaffNameValue.Text = "DEFAUL NAME";
            // 
            // lblCustomerAddressText
            // 
            this.lblCustomerAddressText.AutoSize = true;
            this.lblCustomerAddressText.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerAddressText.Location = new System.Drawing.Point(37, 275);
            this.lblCustomerAddressText.Name = "lblCustomerAddressText";
            this.lblCustomerAddressText.Size = new System.Drawing.Size(80, 25);
            this.lblCustomerAddressText.TabIndex = 8;
            this.lblCustomerAddressText.Text = "Địa chỉ :";
            // 
            // lblCustomerEmailText
            // 
            this.lblCustomerEmailText.AutoSize = true;
            this.lblCustomerEmailText.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerEmailText.Location = new System.Drawing.Point(37, 236);
            this.lblCustomerEmailText.Name = "lblCustomerEmailText";
            this.lblCustomerEmailText.Size = new System.Drawing.Size(68, 25);
            this.lblCustomerEmailText.TabIndex = 6;
            this.lblCustomerEmailText.Text = "Email :";
            // 
            // lblCustomerNameText
            // 
            this.lblCustomerNameText.AutoSize = true;
            this.lblCustomerNameText.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerNameText.Location = new System.Drawing.Point(37, 201);
            this.lblCustomerNameText.Name = "lblCustomerNameText";
            this.lblCustomerNameText.Size = new System.Drawing.Size(52, 25);
            this.lblCustomerNameText.TabIndex = 5;
            this.lblCustomerNameText.Text = "Tên :";
            // 
            // lblCustomerInfoTitle
            // 
            this.lblCustomerInfoTitle.AutoSize = true;
            this.lblCustomerInfoTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerInfoTitle.Location = new System.Drawing.Point(20, 158);
            this.lblCustomerInfoTitle.Name = "lblCustomerInfoTitle";
            this.lblCustomerInfoTitle.Size = new System.Drawing.Size(219, 28);
            this.lblCustomerInfoTitle.TabIndex = 4;
            this.lblCustomerInfoTitle.Text = "Thông tin khách hàng";
            // 
            // btnSearchCustomer
            // 
            this.btnSearchCustomer.BackColor = System.Drawing.Color.Aqua;
            this.btnSearchCustomer.FlatAppearance.BorderSize = 0;
            this.btnSearchCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchCustomer.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchCustomer.ForeColor = System.Drawing.Color.Black;
            this.btnSearchCustomer.Location = new System.Drawing.Point(363, 82);
            this.btnSearchCustomer.Name = "btnSearchCustomer";
            this.btnSearchCustomer.Size = new System.Drawing.Size(127, 35);
            this.btnSearchCustomer.TabIndex = 3;
            this.btnSearchCustomer.Text = "Tìm kiếm";
            this.btnSearchCustomer.UseVisualStyleBackColor = false;
            // 
            // txtSearchInput
            // 
            this.txtSearchInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchInput.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchInput.Location = new System.Drawing.Point(31, 82);
            this.txtSearchInput.Multiline = true;
            this.txtSearchInput.Name = "txtSearchInput";
            this.txtSearchInput.Size = new System.Drawing.Size(311, 35);
            this.txtSearchInput.TabIndex = 2;
            // 
            // cbDataSource
            // 
            this.cbDataSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDataSource.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDataSource.FormattingEnabled = true;
            this.cbDataSource.Location = new System.Drawing.Point(245, 20);
            this.cbDataSource.Name = "cbDataSource";
            this.cbDataSource.Size = new System.Drawing.Size(247, 36);
            this.cbDataSource.TabIndex = 1;
            // 
            // lblDataSourceText
            // 
            this.lblDataSourceText.AutoSize = true;
            this.lblDataSourceText.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataSourceText.Location = new System.Drawing.Point(24, 22);
            this.lblDataSourceText.Name = "lblDataSourceText";
            this.lblDataSourceText.Size = new System.Drawing.Size(215, 38);
            this.lblDataSourceText.TabIndex = 0;
            this.lblDataSourceText.Text = "Lấy dữ liệu từ :";
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.White;
            this.pnlRight.Controls.Add(this.buttonCheckIn);
            this.pnlRight.Controls.Add(this.pnlSeparator3);
            this.pnlRight.Controls.Add(this.dgvOrderItems);
            this.pnlRight.Controls.Add(this.btnCheckDiscount);
            this.pnlRight.Controls.Add(this.txtDiscountCode);
            this.pnlRight.Controls.Add(this.lblDiscountCode);
            this.pnlRight.Controls.Add(this.lblOrderIDText);
            this.pnlRight.Location = new System.Drawing.Point(525, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(775, 596);
            this.pnlRight.TabIndex = 3;
            // 
            // buttonCheckIn
            // 
            this.buttonCheckIn.BackColor = System.Drawing.Color.Aqua;
            this.buttonCheckIn.FlatAppearance.BorderSize = 0;
            this.buttonCheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCheckIn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCheckIn.ForeColor = System.Drawing.Color.Black;
            this.buttonCheckIn.Location = new System.Drawing.Point(589, 511);
            this.buttonCheckIn.Name = "buttonCheckIn";
            this.buttonCheckIn.Size = new System.Drawing.Size(159, 35);
            this.buttonCheckIn.TabIndex = 6;
            this.buttonCheckIn.Text = "Xác Nhận Vé";
            this.buttonCheckIn.UseVisualStyleBackColor = false;
            // 
            // pnlSeparator3
            // 
            this.pnlSeparator3.BackColor = System.Drawing.Color.Black;
            this.pnlSeparator3.Location = new System.Drawing.Point(0, 0);
            this.pnlSeparator3.Name = "pnlSeparator3";
            this.pnlSeparator3.Size = new System.Drawing.Size(2, 596);
            this.pnlSeparator3.TabIndex = 5;
            // 
            // dgvOrderItems
            // 
            this.dgvOrderItems.BackgroundColor = System.Drawing.Color.White;
            this.dgvOrderItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderItems.Location = new System.Drawing.Point(12, 123);
            this.dgvOrderItems.Name = "dgvOrderItems";
            this.dgvOrderItems.RowHeadersWidth = 51;
            this.dgvOrderItems.RowTemplate.Height = 24;
            this.dgvOrderItems.Size = new System.Drawing.Size(751, 352);
            this.dgvOrderItems.TabIndex = 5;
            // 
            // btnCheckDiscount
            // 
            this.btnCheckDiscount.AutoSize = true;
            this.btnCheckDiscount.BackColor = System.Drawing.Color.Aqua;
            this.btnCheckDiscount.FlatAppearance.BorderSize = 0;
            this.btnCheckDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckDiscount.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckDiscount.Location = new System.Drawing.Point(589, 80);
            this.btnCheckDiscount.Name = "btnCheckDiscount";
            this.btnCheckDiscount.Size = new System.Drawing.Size(127, 37);
            this.btnCheckDiscount.TabIndex = 3;
            this.btnCheckDiscount.Text = "Kiểm tra";
            this.btnCheckDiscount.UseVisualStyleBackColor = false;
            // 
            // txtDiscountCode
            // 
            this.txtDiscountCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiscountCode.Location = new System.Drawing.Point(256, 82);
            this.txtDiscountCode.Multiline = true;
            this.txtDiscountCode.Name = "txtDiscountCode";
            this.txtDiscountCode.Size = new System.Drawing.Size(311, 35);
            this.txtDiscountCode.TabIndex = 2;
            // 
            // lblDiscountCode
            // 
            this.lblDiscountCode.AutoSize = true;
            this.lblDiscountCode.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscountCode.Location = new System.Drawing.Point(69, 92);
            this.lblDiscountCode.Name = "lblDiscountCode";
            this.lblDiscountCode.Size = new System.Drawing.Size(179, 25);
            this.lblDiscountCode.TabIndex = 1;
            this.lblDiscountCode.Text = "Số phiếu giảm giá : ";
            // 
            // lblOrderIDText
            // 
            this.lblOrderIDText.AutoSize = true;
            this.lblOrderIDText.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderIDText.Location = new System.Drawing.Point(24, 22);
            this.lblOrderIDText.Name = "lblOrderIDText";
            this.lblOrderIDText.Size = new System.Drawing.Size(194, 38);
            this.lblOrderIDText.TabIndex = 0;
            this.lblOrderIDText.Text = "Mã đơn hàng";
            this.lblOrderIDText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmCheck_in
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1300, 596);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmCheck_in";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CHECK-IN/CHECK-OUT";
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.pnlRight.ResumeLayout(false);
            this.pnlRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Button btnSearchCustomer;
        private System.Windows.Forms.TextBox txtSearchInput;
        private System.Windows.Forms.ComboBox cbDataSource;
        private System.Windows.Forms.Label lblDataSourceText;
        private System.Windows.Forms.Label lblCustomerAddressText;
        private System.Windows.Forms.Label lblCustomerEmailText;
        private System.Windows.Forms.Label lblCustomerNameText;
        private System.Windows.Forms.Label lblCustomerInfoTitle;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.TextBox txtDiscountCode;
        private System.Windows.Forms.Label lblDiscountCode;
        private System.Windows.Forms.Label lblOrderIDText;
        private System.Windows.Forms.Button btnCheckDiscount;
        private System.Windows.Forms.DataGridView dgvOrderItems;
        private System.Windows.Forms.Panel pnlSeparator3;
        private System.Windows.Forms.Button buttonCheckIn;
        private System.Windows.Forms.Label lblStaffNameValue;
        private System.Windows.Forms.Label lblStaffRoleValue;
        private System.Windows.Forms.Label lblCustomerRoleText;
        private System.Windows.Forms.Label lblStaffAddressValue;
        private System.Windows.Forms.Label lblStaffEmailValue;
    }
}