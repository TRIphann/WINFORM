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
            this.dgvCustomerDetails = new System.Windows.Forms.DataGridView();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPhoto = new System.Windows.Forms.Label();
            this.lblCollectionText = new System.Windows.Forms.Label();
            this.lblFamilyMembersText = new System.Windows.Forms.Label();
            this.lblCustomerAddressText = new System.Windows.Forms.Label();
            this.lblCustomerPointsText = new System.Windows.Forms.Label();
            this.lblCustomerEmailText = new System.Windows.Forms.Label();
            this.lblCustomerNameText = new System.Windows.Forms.Label();
            this.lblCustomerInfoTitle = new System.Windows.Forms.Label();
            this.btnSearchCustomer = new System.Windows.Forms.Button();
            this.txtSearchInput = new System.Windows.Forms.TextBox();
            this.cbDataSource = new System.Windows.Forms.ComboBox();
            this.lblDataSourceText = new System.Windows.Forms.Label();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.dgvOrderItems = new System.Windows.Forms.DataGridView();
            this.pnlOrderHeader = new System.Windows.Forms.Panel();
            this.pnlvertical3 = new System.Windows.Forms.Panel();
            this.pnlvertical2 = new System.Windows.Forms.Panel();
            this.pnlvertical1 = new System.Windows.Forms.Panel();
            this.lblQuantityText = new System.Windows.Forms.Label();
            this.lblUnitText = new System.Windows.Forms.Label();
            this.lblDescriptionText = new System.Windows.Forms.Label();
            this.btnCheckDiscount = new System.Windows.Forms.Button();
            this.txtDiscountCode = new System.Windows.Forms.TextBox();
            this.lblDiscountCode = new System.Windows.Forms.Label();
            this.lblOrderIDText = new System.Windows.Forms.Label();
            this.btnCapturePhoto = new System.Windows.Forms.Button();
            this.pnlSeparator3 = new System.Windows.Forms.Panel();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerDetails)).BeginInit();
            this.pnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderItems)).BeginInit();
            this.pnlOrderHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.White;
            this.pnlLeft.Controls.Add(this.dgvCustomerDetails);
            this.pnlLeft.Controls.Add(this.btnCapturePhoto);
            this.pnlLeft.Controls.Add(this.lblName);
            this.pnlLeft.Controls.Add(this.lblPhoto);
            this.pnlLeft.Controls.Add(this.lblCollectionText);
            this.pnlLeft.Controls.Add(this.lblFamilyMembersText);
            this.pnlLeft.Controls.Add(this.lblCustomerAddressText);
            this.pnlLeft.Controls.Add(this.lblCustomerPointsText);
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
            // dgvCustomerDetails
            // 
            this.dgvCustomerDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerDetails.Location = new System.Drawing.Point(22, 466);
            this.dgvCustomerDetails.Name = "dgvCustomerDetails";
            this.dgvCustomerDetails.RowHeadersWidth = 51;
            this.dgvCustomerDetails.RowTemplate.Height = 24;
            this.dgvCustomerDetails.Size = new System.Drawing.Size(388, 111);
            this.dgvCustomerDetails.TabIndex = 14;
            // 
            // lblName
            // 
            this.lblName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(199, 435);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(211, 34);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPhoto
            // 
            this.lblPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPhoto.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoto.Location = new System.Drawing.Point(22, 435);
            this.lblPhoto.Name = "lblPhoto";
            this.lblPhoto.Size = new System.Drawing.Size(108, 34);
            this.lblPhoto.TabIndex = 11;
            this.lblPhoto.Text = "Photo";
            this.lblPhoto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCollectionText
            // 
            this.lblCollectionText.AutoSize = true;
            this.lblCollectionText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCollectionText.Location = new System.Drawing.Point(22, 391);
            this.lblCollectionText.Name = "lblCollectionText";
            this.lblCollectionText.Size = new System.Drawing.Size(114, 28);
            this.lblCollectionText.TabIndex = 10;
            this.lblCollectionText.Text = "Bộ sưu tập";
            // 
            // lblFamilyMembersText
            // 
            this.lblFamilyMembersText.AutoSize = true;
            this.lblFamilyMembersText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFamilyMembersText.Location = new System.Drawing.Point(20, 347);
            this.lblFamilyMembersText.Name = "lblFamilyMembersText";
            this.lblFamilyMembersText.Size = new System.Drawing.Size(166, 28);
            this.lblFamilyMembersText.TabIndex = 9;
            this.lblFamilyMembersText.Text = "Family members";
            // 
            // lblCustomerAddressText
            // 
            this.lblCustomerAddressText.AutoSize = true;
            this.lblCustomerAddressText.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerAddressText.Location = new System.Drawing.Point(37, 309);
            this.lblCustomerAddressText.Name = "lblCustomerAddressText";
            this.lblCustomerAddressText.Size = new System.Drawing.Size(80, 25);
            this.lblCustomerAddressText.TabIndex = 8;
            this.lblCustomerAddressText.Text = "Địa chỉ :";
            // 
            // lblCustomerPointsText
            // 
            this.lblCustomerPointsText.AutoSize = true;
            this.lblCustomerPointsText.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerPointsText.Location = new System.Drawing.Point(36, 271);
            this.lblCustomerPointsText.Name = "lblCustomerPointsText";
            this.lblCustomerPointsText.Size = new System.Drawing.Size(66, 25);
            this.lblCustomerPointsText.TabIndex = 7;
            this.lblCustomerPointsText.Text = "Điểm :";
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
            this.lblCustomerNameText.Location = new System.Drawing.Point(36, 201);
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
            this.txtSearchInput.TextChanged += new System.EventHandler(this.txtSearchInput_TextChanged);
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
            this.pnlRight.Controls.Add(this.pnlSeparator3);
            this.pnlRight.Controls.Add(this.dgvOrderItems);
            this.pnlRight.Controls.Add(this.pnlOrderHeader);
            this.pnlRight.Controls.Add(this.btnCheckDiscount);
            this.pnlRight.Controls.Add(this.txtDiscountCode);
            this.pnlRight.Controls.Add(this.lblDiscountCode);
            this.pnlRight.Controls.Add(this.lblOrderIDText);
            this.pnlRight.Location = new System.Drawing.Point(525, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(775, 596);
            this.pnlRight.TabIndex = 3;
            // 
            // dgvOrderItems
            // 
            this.dgvOrderItems.BackgroundColor = System.Drawing.Color.White;
            this.dgvOrderItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderItems.Location = new System.Drawing.Point(12, 162);
            this.dgvOrderItems.Name = "dgvOrderItems";
            this.dgvOrderItems.RowHeadersWidth = 51;
            this.dgvOrderItems.RowTemplate.Height = 24;
            this.dgvOrderItems.Size = new System.Drawing.Size(751, 415);
            this.dgvOrderItems.TabIndex = 5;
            // 
            // pnlOrderHeader
            // 
            this.pnlOrderHeader.BackColor = System.Drawing.Color.Red;
            this.pnlOrderHeader.Controls.Add(this.pnlvertical3);
            this.pnlOrderHeader.Controls.Add(this.pnlvertical2);
            this.pnlOrderHeader.Controls.Add(this.pnlvertical1);
            this.pnlOrderHeader.Controls.Add(this.lblQuantityText);
            this.pnlOrderHeader.Controls.Add(this.lblUnitText);
            this.pnlOrderHeader.Controls.Add(this.lblDescriptionText);
            this.pnlOrderHeader.Location = new System.Drawing.Point(12, 123);
            this.pnlOrderHeader.Name = "pnlOrderHeader";
            this.pnlOrderHeader.Size = new System.Drawing.Size(751, 39);
            this.pnlOrderHeader.TabIndex = 4;
            // 
            // pnlvertical3
            // 
            this.pnlvertical3.BackColor = System.Drawing.Color.White;
            this.pnlvertical3.Location = new System.Drawing.Point(609, 0);
            this.pnlvertical3.Name = "pnlvertical3";
            this.pnlvertical3.Size = new System.Drawing.Size(3, 39);
            this.pnlvertical3.TabIndex = 5;
            // 
            // pnlvertical2
            // 
            this.pnlvertical2.BackColor = System.Drawing.Color.White;
            this.pnlvertical2.Location = new System.Drawing.Point(473, 0);
            this.pnlvertical2.Name = "pnlvertical2";
            this.pnlvertical2.Size = new System.Drawing.Size(3, 39);
            this.pnlvertical2.TabIndex = 4;
            // 
            // pnlvertical1
            // 
            this.pnlvertical1.BackColor = System.Drawing.Color.White;
            this.pnlvertical1.Location = new System.Drawing.Point(38, 0);
            this.pnlvertical1.Name = "pnlvertical1";
            this.pnlvertical1.Size = new System.Drawing.Size(3, 39);
            this.pnlvertical1.TabIndex = 3;
            // 
            // lblQuantityText
            // 
            this.lblQuantityText.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantityText.ForeColor = System.Drawing.Color.White;
            this.lblQuantityText.Location = new System.Drawing.Point(618, 6);
            this.lblQuantityText.Name = "lblQuantityText";
            this.lblQuantityText.Size = new System.Drawing.Size(94, 25);
            this.lblQuantityText.TabIndex = 2;
            this.lblQuantityText.Text = "Số lượng";
            this.lblQuantityText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUnitText
            // 
            this.lblUnitText.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitText.ForeColor = System.Drawing.Color.White;
            this.lblUnitText.Location = new System.Drawing.Point(479, 6);
            this.lblUnitText.Name = "lblUnitText";
            this.lblUnitText.Size = new System.Drawing.Size(76, 25);
            this.lblUnitText.TabIndex = 1;
            this.lblUnitText.Text = "Đơn vị";
            this.lblUnitText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDescriptionText
            // 
            this.lblDescriptionText.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescriptionText.ForeColor = System.Drawing.Color.White;
            this.lblDescriptionText.Location = new System.Drawing.Point(38, 6);
            this.lblDescriptionText.Name = "lblDescriptionText";
            this.lblDescriptionText.Size = new System.Drawing.Size(80, 25);
            this.lblDescriptionText.TabIndex = 0;
            this.lblDescriptionText.Text = "Mô tả";
            this.lblDescriptionText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // btnCapturePhoto
            // 
            this.btnCapturePhoto.Image = global::JumpArena.Properties.Resources.icons8_camera_30;
            this.btnCapturePhoto.Location = new System.Drawing.Point(445, 381);
            this.btnCapturePhoto.Name = "btnCapturePhoto";
            this.btnCapturePhoto.Size = new System.Drawing.Size(52, 38);
            this.btnCapturePhoto.TabIndex = 13;
            this.btnCapturePhoto.UseVisualStyleBackColor = true;
            // 
            // pnlSeparator3
            // 
            this.pnlSeparator3.BackColor = System.Drawing.Color.Black;
            this.pnlSeparator3.Location = new System.Drawing.Point(0, 0);
            this.pnlSeparator3.Name = "pnlSeparator3";
            this.pnlSeparator3.Size = new System.Drawing.Size(2, 596);
            this.pnlSeparator3.TabIndex = 5;
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerDetails)).EndInit();
            this.pnlRight.ResumeLayout(false);
            this.pnlRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderItems)).EndInit();
            this.pnlOrderHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Button btnSearchCustomer;
        private System.Windows.Forms.TextBox txtSearchInput;
        private System.Windows.Forms.ComboBox cbDataSource;
        private System.Windows.Forms.Label lblDataSourceText;
        private System.Windows.Forms.Label lblPhoto;
        private System.Windows.Forms.Label lblCollectionText;
        private System.Windows.Forms.Label lblFamilyMembersText;
        private System.Windows.Forms.Label lblCustomerAddressText;
        private System.Windows.Forms.Label lblCustomerPointsText;
        private System.Windows.Forms.Label lblCustomerEmailText;
        private System.Windows.Forms.Label lblCustomerNameText;
        private System.Windows.Forms.Label lblCustomerInfoTitle;
        private System.Windows.Forms.DataGridView dgvCustomerDetails;
        private System.Windows.Forms.Button btnCapturePhoto;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.TextBox txtDiscountCode;
        private System.Windows.Forms.Label lblDiscountCode;
        private System.Windows.Forms.Label lblOrderIDText;
        private System.Windows.Forms.Panel pnlOrderHeader;
        private System.Windows.Forms.Label lblUnitText;
        private System.Windows.Forms.Label lblDescriptionText;
        private System.Windows.Forms.Button btnCheckDiscount;
        private System.Windows.Forms.Panel pnlvertical1;
        private System.Windows.Forms.Label lblQuantityText;
        private System.Windows.Forms.Panel pnlvertical2;
        private System.Windows.Forms.DataGridView dgvOrderItems;
        private System.Windows.Forms.Panel pnlvertical3;
        private System.Windows.Forms.Panel pnlSeparator3;
    }
}