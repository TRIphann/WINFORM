namespace JumpArena.View.Admin
{
    partial class CreateVoucherForm
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
            this.tblMainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.lblProgramName = new System.Windows.Forms.Label();
            this.txtProgramName = new System.Windows.Forms.TextBox();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblPercentValue = new System.Windows.Forms.Label();
            this.txtPercentValue = new System.Windows.Forms.TextBox();
            this.lblFixedValue = new System.Windows.Forms.Label();
            this.txtFixedValue = new System.Windows.Forms.TextBox();
            this.dgvVouchers = new System.Windows.Forms.DataGridView();
            this.lblVoucherListTitle = new System.Windows.Forms.Label();
            this.pnlActionsBottom = new System.Windows.Forms.Panel();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblCodeVoucher = new System.Windows.Forms.Label();
            this.txtCodeVoucher = new System.Windows.Forms.TextBox();
            this.lblMin = new System.Windows.Forms.Label();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.tblMainLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVouchers)).BeginInit();
            this.dgvVouchers.SuspendLayout();
            this.pnlActionsBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMainLayout
            // 
            this.tblMainLayout.ColumnCount = 1;
            this.tblMainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMainLayout.Controls.Add(this.lblTitle, 0, 0);
            this.tblMainLayout.Controls.Add(this.splitContainerMain, 0, 1);
            this.tblMainLayout.Controls.Add(this.dgvVouchers, 0, 2);
            this.tblMainLayout.Controls.Add(this.pnlActionsBottom, 0, 3);
            this.tblMainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMainLayout.Location = new System.Drawing.Point(0, 0);
            this.tblMainLayout.Name = "tblMainLayout";
            this.tblMainLayout.RowCount = 4;
            this.tblMainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tblMainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 260F));
            this.tblMainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tblMainLayout.Size = new System.Drawing.Size(999, 540);
            this.tblMainLayout.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(3, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(993, 55);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "QUẢN LÝ VOUCHER/MÃ KHUYẾN MÃI";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(3, 58);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.pnlLeft);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.pnlRight);
            this.splitContainerMain.Size = new System.Drawing.Size(993, 254);
            this.splitContainerMain.SplitterDistance = 350;
            this.splitContainerMain.TabIndex = 0;
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.lblProgramName);
            this.pnlLeft.Controls.Add(this.txtProgramName);
            this.pnlLeft.Controls.Add(this.lblStartDate);
            this.pnlLeft.Controls.Add(this.dtpStartDate);
            this.pnlLeft.Controls.Add(this.lblEndDate);
            this.pnlLeft.Controls.Add(this.dtpEndDate);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(350, 254);
            this.pnlLeft.TabIndex = 0;
            // 
            // lblProgramName
            // 
            this.lblProgramName.AutoSize = true;
            this.lblProgramName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgramName.Location = new System.Drawing.Point(10, 20);
            this.lblProgramName.Name = "lblProgramName";
            this.lblProgramName.Size = new System.Drawing.Size(193, 24);
            this.lblProgramName.TabIndex = 1;
            this.lblProgramName.Text = "Tên Chương Trình:";
            // 
            // txtProgramName
            // 
            this.txtProgramName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProgramName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProgramName.Location = new System.Drawing.Point(10, 45);
            this.txtProgramName.Name = "txtProgramName";
            this.txtProgramName.Size = new System.Drawing.Size(410, 30);
            this.txtProgramName.TabIndex = 2;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(10, 90);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(192, 24);
            this.lblStartDate.TabIndex = 3;
            this.lblStartDate.Text = "Thời Gian Bắt Đầu:";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpStartDate.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpStartDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(10, 115);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(410, 30);
            this.dtpStartDate.TabIndex = 4;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.Location = new System.Drawing.Point(10, 160);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(203, 24);
            this.lblEndDate.TabIndex = 5;
            this.lblEndDate.Text = "Thời Gian Kết Thúc:";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpEndDate.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpEndDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(10, 185);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(410, 30);
            this.dtpEndDate.TabIndex = 6;
            // 
            // pnlRight
            // 
            this.pnlRight.Controls.Add(this.txtMin);
            this.pnlRight.Controls.Add(this.lblMin);
            this.pnlRight.Controls.Add(this.txtCodeVoucher);
            this.pnlRight.Controls.Add(this.lblCodeVoucher);
            this.pnlRight.Controls.Add(this.lblQuantity);
            this.pnlRight.Controls.Add(this.txtQuantity);
            this.pnlRight.Controls.Add(this.lblPercentValue);
            this.pnlRight.Controls.Add(this.txtPercentValue);
            this.pnlRight.Controls.Add(this.lblFixedValue);
            this.pnlRight.Controls.Add(this.txtFixedValue);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(0, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(639, 254);
            this.pnlRight.TabIndex = 0;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(10, 20);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(112, 24);
            this.lblQuantity.TabIndex = 7;
            this.lblQuantity.Text = "Số Lượng:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuantity.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(10, 45);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(112, 30);
            this.txtQuantity.TabIndex = 8;
            this.txtQuantity.Text = "100";
            // 
            // lblPercentValue
            // 
            this.lblPercentValue.AutoSize = true;
            this.lblPercentValue.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentValue.Location = new System.Drawing.Point(10, 90);
            this.lblPercentValue.Name = "lblPercentValue";
            this.lblPercentValue.Size = new System.Drawing.Size(157, 24);
            this.lblPercentValue.TabIndex = 9;
            this.lblPercentValue.Text = "Giảm (Phần %):";
            // 
            // txtPercentValue
            // 
            this.txtPercentValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPercentValue.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPercentValue.Location = new System.Drawing.Point(10, 115);
            this.txtPercentValue.Name = "txtPercentValue";
            this.txtPercentValue.Size = new System.Drawing.Size(112, 30);
            this.txtPercentValue.TabIndex = 10;
            this.txtPercentValue.Text = "0";
            // 
            // lblFixedValue
            // 
            this.lblFixedValue.AutoSize = true;
            this.lblFixedValue.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFixedValue.Location = new System.Drawing.Point(10, 160);
            this.lblFixedValue.Name = "lblFixedValue";
            this.lblFixedValue.Size = new System.Drawing.Size(158, 24);
            this.lblFixedValue.TabIndex = 11;
            this.lblFixedValue.Text = "Giảm (Số Tiền):";
            // 
            // txtFixedValue
            // 
            this.txtFixedValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFixedValue.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFixedValue.Location = new System.Drawing.Point(10, 185);
            this.txtFixedValue.Name = "txtFixedValue";
            this.txtFixedValue.Size = new System.Drawing.Size(112, 30);
            this.txtFixedValue.TabIndex = 12;
            this.txtFixedValue.Text = "0";
            // 
            // dgvVouchers
            // 
            this.dgvVouchers.AllowUserToAddRows = false;
            this.dgvVouchers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVouchers.Controls.Add(this.lblVoucherListTitle);
            this.dgvVouchers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVouchers.Location = new System.Drawing.Point(3, 318);
            this.dgvVouchers.Name = "dgvVouchers";
            this.dgvVouchers.ReadOnly = true;
            this.dgvVouchers.RowHeadersWidth = 51;
            this.dgvVouchers.RowTemplate.Height = 24;
            this.dgvVouchers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVouchers.Size = new System.Drawing.Size(993, 141);
            this.dgvVouchers.TabIndex = 1;
            // 
            // lblVoucherListTitle
            // 
            this.lblVoucherListTitle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblVoucherListTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblVoucherListTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVoucherListTitle.ForeColor = System.Drawing.Color.White;
            this.lblVoucherListTitle.Location = new System.Drawing.Point(0, 0);
            this.lblVoucherListTitle.Name = "lblVoucherListTitle";
            this.lblVoucherListTitle.Size = new System.Drawing.Size(993, 30);
            this.lblVoucherListTitle.TabIndex = 0;
            this.lblVoucherListTitle.Text = "DANH SÁCH VOUCHER HIỆN TẠI";
            this.lblVoucherListTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlActionsBottom
            // 
            this.pnlActionsBottom.Controls.Add(this.btnConfirm);
            this.pnlActionsBottom.Controls.Add(this.btnEdit);
            this.pnlActionsBottom.Controls.Add(this.btnDelete);
            this.pnlActionsBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlActionsBottom.Location = new System.Drawing.Point(3, 465);
            this.pnlActionsBottom.Name = "pnlActionsBottom";
            this.pnlActionsBottom.Size = new System.Drawing.Size(993, 72);
            this.pnlActionsBottom.TabIndex = 2;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirm.BackColor = System.Drawing.Color.Aqua;
            this.btnConfirm.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.Black;
            this.btnConfirm.Location = new System.Drawing.Point(819, 0);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(160, 63);
            this.btnConfirm.TabIndex = 13;
            this.btnConfirm.Text = "XÁC NHẬN ";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.BackColor = System.Drawing.Color.Aqua;
            this.btnEdit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(649, 0);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(160, 63);
            this.btnEdit.TabIndex = 15;
            this.btnEdit.Text = "SỬA";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.Aqua;
            this.btnDelete.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(479, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(160, 63);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "XÓA";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblCodeVoucher
            // 
            this.lblCodeVoucher.AutoSize = true;
            this.lblCodeVoucher.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodeVoucher.Location = new System.Drawing.Point(247, 20);
            this.lblCodeVoucher.Name = "lblCodeVoucher";
            this.lblCodeVoucher.Size = new System.Drawing.Size(135, 24);
            this.lblCodeVoucher.TabIndex = 13;
            this.lblCodeVoucher.Text = "Mã Voucher: ";
            // 
            // txtCodeVoucher
            // 
            this.txtCodeVoucher.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodeVoucher.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodeVoucher.Location = new System.Drawing.Point(251, 47);
            this.txtCodeVoucher.Name = "txtCodeVoucher";
            this.txtCodeVoucher.Size = new System.Drawing.Size(112, 30);
            this.txtCodeVoucher.TabIndex = 14;
            this.txtCodeVoucher.Text = "100";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMin.Location = new System.Drawing.Point(247, 90);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(140, 24);
            this.lblMin.TabIndex = 15;
            this.lblMin.Text = "Đơn tối thiểu:";
            // 
            // txtMin
            // 
            this.txtMin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMin.Location = new System.Drawing.Point(251, 118);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(112, 30);
            this.txtMin.TabIndex = 16;
            this.txtMin.Text = "0";
            // 
            // CreateVoucherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 540);
            this.Controls.Add(this.tblMainLayout);
            this.MinimumSize = new System.Drawing.Size(750, 550);
            this.Name = "CreateVoucherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Voucher";
            this.tblMainLayout.ResumeLayout(false);
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.pnlRight.ResumeLayout(false);
            this.pnlRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVouchers)).EndInit();
            this.dgvVouchers.ResumeLayout(false);
            this.pnlActionsBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        // Khai báo các biến
        private System.Windows.Forms.TableLayoutPanel tblMainLayout;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.DataGridView dgvVouchers;
        private System.Windows.Forms.Panel pnlActionsBottom;

        // Controls Top
        private System.Windows.Forms.Label lblProgramName;
        private System.Windows.Forms.TextBox txtProgramName;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblPercentValue;
        private System.Windows.Forms.TextBox txtPercentValue;
        private System.Windows.Forms.Label lblFixedValue;
        private System.Windows.Forms.TextBox txtFixedValue;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblVoucherListTitle;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.TextBox txtCodeVoucher;
        private System.Windows.Forms.Label lblCodeVoucher;
    }
}