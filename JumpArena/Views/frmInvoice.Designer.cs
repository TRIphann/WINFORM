namespace JumpArena.View
{
    partial class frmInvoice
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbInvoiceInfo = new System.Windows.Forms.GroupBox();
            this.lblInvoiceID = new System.Windows.Forms.Label();
            this.lblCreatedDate = new System.Windows.Forms.Label();
            this.lblStaff = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.dgvInvoiceDetail = new System.Windows.Forms.DataGridView();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbPayment = new System.Windows.Forms.GroupBox();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblFinalTotal = new System.Windows.Forms.Label();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.btnPrintAndClose = new System.Windows.Forms.Button();
            this.gbInvoiceInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceDetail)).BeginInit();
            this.gbPayment.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(882, 55);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "JUMP ARENA";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbInvoiceInfo
            // 
            this.gbInvoiceInfo.Controls.Add(this.lblPhone);
            this.gbInvoiceInfo.Controls.Add(this.lblCustomer);
            this.gbInvoiceInfo.Controls.Add(this.lblStaff);
            this.gbInvoiceInfo.Controls.Add(this.lblCreatedDate);
            this.gbInvoiceInfo.Controls.Add(this.lblInvoiceID);
            this.gbInvoiceInfo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInvoiceInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.gbInvoiceInfo.Location = new System.Drawing.Point(20, 70);
            this.gbInvoiceInfo.Name = "gbInvoiceInfo";
            this.gbInvoiceInfo.Size = new System.Drawing.Size(860, 130);
            this.gbInvoiceInfo.TabIndex = 1;
            this.gbInvoiceInfo.TabStop = false;
            this.gbInvoiceInfo.Text = "Thông tin hóa đơn";
            // 
            // lblInvoiceID
            // 
            this.lblInvoiceID.AutoSize = true;
            this.lblInvoiceID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lblInvoiceID.Location = new System.Drawing.Point(20, 30);
            this.lblInvoiceID.Name = "lblInvoiceID";
            this.lblInvoiceID.Size = new System.Drawing.Size(71, 23);
            this.lblInvoiceID.TabIndex = 0;
            this.lblInvoiceID.Text = "Mã HĐ:";
            // 
            // lblCreatedDate
            // 
            this.lblCreatedDate.AutoSize = true;
            this.lblCreatedDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lblCreatedDate.Location = new System.Drawing.Point(20, 60);
            this.lblCreatedDate.Name = "lblCreatedDate";
            this.lblCreatedDate.Size = new System.Drawing.Size(57, 23);
            this.lblCreatedDate.TabIndex = 1;
            this.lblCreatedDate.Text = "Ngày:";
            // 
            // lblStaff
            // 
            this.lblStaff.AutoSize = true;
            this.lblStaff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lblStaff.Location = new System.Drawing.Point(450, 30);
            this.lblStaff.Name = "lblStaff";
            this.lblStaff.Size = new System.Drawing.Size(95, 23);
            this.lblStaff.TabIndex = 2;
            this.lblStaff.Text = "Nhân viên:";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lblCustomer.Location = new System.Drawing.Point(450, 60);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(108, 23);
            this.lblCustomer.TabIndex = 3;
            this.lblCustomer.Text = "Khách hàng:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lblPhone.Location = new System.Drawing.Point(450, 90);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(48, 23);
            this.lblPhone.TabIndex = 4;
            this.lblPhone.Text = "SĐT:";
            // 
            // dgvInvoiceDetail
            // 
            this.dgvInvoiceDetail.AllowUserToAddRows = false;
            this.dgvInvoiceDetail.AllowUserToDeleteRows = false;
            this.dgvInvoiceDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInvoiceDetail.BackgroundColor = System.Drawing.Color.White;
            this.dgvInvoiceDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoiceDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductName,
            this.Quantity,
            this.Price,
            this.Total});
            this.dgvInvoiceDetail.Location = new System.Drawing.Point(20, 210);
            this.dgvInvoiceDetail.Name = "dgvInvoiceDetail";
            this.dgvInvoiceDetail.ReadOnly = true;
            this.dgvInvoiceDetail.RowHeadersVisible = false;
            this.dgvInvoiceDetail.RowHeadersWidth = 51;
            this.dgvInvoiceDetail.RowTemplate.Height = 24;
            this.dgvInvoiceDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInvoiceDetail.Size = new System.Drawing.Size(860, 250);
            this.dgvInvoiceDetail.TabIndex = 2;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Sản phẩm";
            this.ProductName.MinimumWidth = 6;
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "SL";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Đơn giá";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Thành tiền";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // gbPayment
            // 
            this.gbPayment.Controls.Add(this.btnPrintAndClose);
            this.gbPayment.Controls.Add(this.lblPaymentMethod);
            this.gbPayment.Controls.Add(this.lblFinalTotal);
            this.gbPayment.Controls.Add(this.lblDiscount);
            this.gbPayment.Controls.Add(this.lblSubtotal);
            this.gbPayment.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPayment.Location = new System.Drawing.Point(20, 470);
            this.gbPayment.Name = "gbPayment";
            this.gbPayment.Size = new System.Drawing.Size(860, 110);
            this.gbPayment.TabIndex = 3;
            this.gbPayment.TabStop = false;
            this.gbPayment.Text = "Thanh toán";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(20, 35);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(82, 23);
            this.lblSubtotal.TabIndex = 0;
            this.lblSubtotal.Text = "Tạm tính";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(20, 65);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(82, 23);
            this.lblDiscount.TabIndex = 1;
            this.lblDiscount.Text = "Giảm giá";
            // 
            // lblFinalTotal
            // 
            this.lblFinalTotal.AutoSize = true;
            this.lblFinalTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.lblFinalTotal.Location = new System.Drawing.Point(450, 35);
            this.lblFinalTotal.Name = "lblFinalTotal";
            this.lblFinalTotal.Size = new System.Drawing.Size(87, 23);
            this.lblFinalTotal.TabIndex = 2;
            this.lblFinalTotal.Text = "Tổng tiền";
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.AutoSize = true;
            this.lblPaymentMethod.Location = new System.Drawing.Point(450, 65);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(100, 23);
            this.lblPaymentMethod.TabIndex = 3;
            this.lblPaymentMethod.Text = "Thanh toán";
            // 
            // btnPrintAndClose
            // 
            this.btnPrintAndClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnPrintAndClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintAndClose.FlatAppearance.BorderSize = 0;
            this.btnPrintAndClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.btnPrintAndClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintAndClose.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintAndClose.ForeColor = System.Drawing.Color.White;
            this.btnPrintAndClose.Location = new System.Drawing.Point(679, 40);
            this.btnPrintAndClose.Name = "btnPrintAndClose";
            this.btnPrintAndClose.Size = new System.Drawing.Size(160, 40);
            this.btnPrintAndClose.TabIndex = 4;
            this.btnPrintAndClose.Text = "In và đóng";
            this.btnPrintAndClose.UseVisualStyleBackColor = false;
            this.btnPrintAndClose.Click += new System.EventHandler(this.btnPrintAndClose_Click);
            // 
            // frmInvoice
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(882, 573);
            this.Controls.Add(this.gbPayment);
            this.Controls.Add(this.dgvInvoiceDetail);
            this.Controls.Add(this.gbInvoiceInfo);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "frmInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HÓA ĐƠN THANH TOÁN";
            this.Load += new System.EventHandler(this.frmInvoice_Load);
            this.Click += new System.EventHandler(this.frmInvoice_Load);
            this.gbInvoiceInfo.ResumeLayout(false);
            this.gbInvoiceInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceDetail)).EndInit();
            this.gbPayment.ResumeLayout(false);
            this.gbPayment.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbInvoiceInfo;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblStaff;
        private System.Windows.Forms.Label lblCreatedDate;
        private System.Windows.Forms.Label lblInvoiceID;
        private System.Windows.Forms.DataGridView dgvInvoiceDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.GroupBox gbPayment;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblPaymentMethod;
        private System.Windows.Forms.Label lblFinalTotal;
        private System.Windows.Forms.Button btnPrintAndClose;
    }
}