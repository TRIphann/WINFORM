namespace YourProjectNamespace
{
    partial class ReportAndFeedbackForm
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
            // Khai báo Controls
            this.lblTitle = new System.Windows.Forms.Label();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlRight = new System.Windows.Forms.Panel();

            // Controls Khung Trái
            this.lblLeftTitle = new System.Windows.Forms.Label();
            this.lblVoucherStatus = new System.Windows.Forms.Label();
            this.cmbVoucherStatus = new System.Windows.Forms.ComboBox();
            this.lblCheckInUser = new System.Windows.Forms.Label();
            this.cmbCheckInUser = new System.Windows.Forms.ComboBox();
            this.lblCheckInTime = new System.Windows.Forms.Label();
            this.dtpCheckInTime = new System.Windows.Forms.DateTimePicker();
            this.lblInventory = new System.Windows.Forms.Label();
            this.cmbInventory = new System.Windows.Forms.ComboBox();
            this.lblOrderHistory = new System.Windows.Forms.Label();
            this.cmbOrderHistory = new System.Windows.Forms.ComboBox();

            // Controls Khung Phải
            this.lblRightTitle = new System.Windows.Forms.Label();
            this.lblReportType = new System.Windows.Forms.Label();
            this.cmbReportType = new System.Windows.Forms.ComboBox();
            this.lblReportContent = new System.Windows.Forms.Label();
            this.txtReportContent = new System.Windows.Forms.TextBox();
            this.lblReplyTo = new System.Windows.Forms.Label();
            this.cmbReplyTo = new System.Windows.Forms.ComboBox();
            this.lblReplyText = new System.Windows.Forms.Label();
            this.txtReplyText = new System.Windows.Forms.TextBox();
            this.btnConfirmReply = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.SuspendLayout();

            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1200, 55);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "HỆ THỐNG BÁO CÁO & PHẢN HỒI NỘI BỘ";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 55);
            this.splitContainerMain.Name = "splitContainerMain";

            // 
            // splitContainerMain.Panel1 (Khung Trái - Thống kê Dữ liệu)
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.pnlLeft);
            this.splitContainerMain.Panel1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // splitContainerMain.Panel2 (Khung Phải - Báo cáo & Phản hồi)
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.pnlRight);
            this.splitContainerMain.Panel2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainerMain.Size = new System.Drawing.Size(1200, 650);
            this.splitContainerMain.SplitterDistance = 400;
            this.splitContainerMain.TabIndex = 1;

            // 
            // pnlLeft (Bố cục Controls Khung Trái)
            // 
            this.pnlLeft.Controls.Add(this.lblLeftTitle);
            this.pnlLeft.Controls.Add(this.lblVoucherStatus);
            this.pnlLeft.Controls.Add(this.cmbVoucherStatus);
            this.pnlLeft.Controls.Add(this.lblCheckInUser);
            this.pnlLeft.Controls.Add(this.cmbCheckInUser);
            this.pnlLeft.Controls.Add(this.lblCheckInTime);
            this.pnlLeft.Controls.Add(this.dtpCheckInTime);
            this.pnlLeft.Controls.Add(this.lblInventory);
            this.pnlLeft.Controls.Add(this.cmbInventory);
            this.pnlLeft.Controls.Add(this.lblOrderHistory);
            this.pnlLeft.Controls.Add(this.cmbOrderHistory);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(400, 650);
            this.pnlLeft.TabIndex = 0;

            // 
            // pnlRight (Bố cục Controls Khung Phải)
            // 
            this.pnlRight.Controls.Add(this.lblRightTitle);
            this.pnlRight.Controls.Add(this.lblReportType);
            this.pnlRight.Controls.Add(this.cmbReportType);
            this.pnlRight.Controls.Add(this.lblReportContent);
            this.pnlRight.Controls.Add(this.txtReportContent);
            this.pnlRight.Controls.Add(this.lblReplyTo);
            this.pnlRight.Controls.Add(this.cmbReplyTo);
            this.pnlRight.Controls.Add(this.lblReplyText);
            this.pnlRight.Controls.Add(this.txtReplyText);
            this.pnlRight.Controls.Add(this.btnConfirmReply);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(0, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(796, 650);
            this.pnlRight.TabIndex = 0;

            // --- Controls Khung Trái (Thống kê Dữ liệu) ---

            // lblLeftTitle
            this.lblLeftTitle.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblLeftTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLeftTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeftTitle.ForeColor = System.Drawing.Color.White;
            this.lblLeftTitle.Location = new System.Drawing.Point(0, 0);
            this.lblLeftTitle.Name = "lblLeftTitle";
            this.lblLeftTitle.Size = new System.Drawing.Size(400, 30);
            this.lblLeftTitle.Text = "THỐNG KÊ DỮ LIỆU ĐẦU VÀO";
            this.lblLeftTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblVoucherStatus
            this.lblVoucherStatus.AutoSize = true;
            this.lblVoucherStatus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVoucherStatus.Location = new System.Drawing.Point(10, 50);
            this.lblVoucherStatus.Name = "lblVoucherStatus";
            this.lblVoucherStatus.Size = new System.Drawing.Size(188, 24);
            this.lblVoucherStatus.TabIndex = 1;
            this.lblVoucherStatus.Text = "Trạng thái Voucher:";

            // cmbVoucherStatus
            this.cmbVoucherStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbVoucherStatus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbVoucherStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVoucherStatus.FormattingEnabled = true;
            this.cmbVoucherStatus.Location = new System.Drawing.Point(10, 75);
            this.cmbVoucherStatus.Name = "cmbVoucherStatus";
            this.cmbVoucherStatus.Size = new System.Drawing.Size(380, 31);
            this.cmbVoucherStatus.TabIndex = 2;

            // lblCheckInUser
            this.lblCheckInUser.AutoSize = true;
            this.lblCheckInUser.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckInUser.Location = new System.Drawing.Point(10, 120);
            this.lblCheckInUser.Name = "lblCheckInUser";
            this.lblCheckInUser.Size = new System.Drawing.Size(185, 24);
            this.lblCheckInUser.TabIndex = 3;
            this.lblCheckInUser.Text = "Người Check-in Voucher:";

            // cmbCheckInUser
            this.cmbCheckInUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCheckInUser.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCheckInUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCheckInUser.FormattingEnabled = true;
            this.cmbCheckInUser.Location = new System.Drawing.Point(10, 145);
            this.cmbCheckInUser.Name = "cmbCheckInUser";
            this.cmbCheckInUser.Size = new System.Drawing.Size(380, 31);
            this.cmbCheckInUser.TabIndex = 4;

            // lblCheckInTime
            this.lblCheckInTime.AutoSize = true;
            this.lblCheckInTime.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckInTime.Location = new System.Drawing.Point(10, 190);
            this.lblCheckInTime.Name = "lblCheckInTime";
            this.lblCheckInTime.Size = new System.Drawing.Size(180, 24);
            this.lblCheckInTime.TabIndex = 5;
            this.lblCheckInTime.Text = "Thời gian Check-in:";

            // dtpCheckInTime
            this.dtpCheckInTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpCheckInTime.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpCheckInTime.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCheckInTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCheckInTime.Location = new System.Drawing.Point(10, 215);
            this.dtpCheckInTime.Name = "dtpCheckInTime";
            this.dtpCheckInTime.Size = new System.Drawing.Size(380, 30);
            this.dtpCheckInTime.TabIndex = 6;

            // lblInventory
            this.lblInventory.AutoSize = true;
            this.lblInventory.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventory.Location = new System.Drawing.Point(10, 260);
            this.lblInventory.Name = "lblInventory";
            this.lblInventory.Size = new System.Drawing.Size(193, 24);
            this.lblInventory.TabIndex = 7;
            this.lblInventory.Text = "Sản phẩm còn lại (>):";

            // cmbInventory
            this.cmbInventory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbInventory.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbInventory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInventory.FormattingEnabled = true;
            this.cmbInventory.Location = new System.Drawing.Point(10, 285);
            this.cmbInventory.Name = "cmbInventory";
            this.cmbInventory.Size = new System.Drawing.Size(380, 31);
            this.cmbInventory.TabIndex = 8;

            // lblOrderHistory
            this.lblOrderHistory.AutoSize = true;
            this.lblOrderHistory.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderHistory.Location = new System.Drawing.Point(10, 330);
            this.lblOrderHistory.Name = "lblOrderHistory";
            this.lblOrderHistory.Size = new System.Drawing.Size(185, 24);
            this.lblOrderHistory.TabIndex = 9;
            this.lblOrderHistory.Text = "Lịch sử Đơn hàng:";

            // cmbOrderHistory
            this.cmbOrderHistory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbOrderHistory.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOrderHistory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrderHistory.FormattingEnabled = true;
            this.cmbOrderHistory.Location = new System.Drawing.Point(10, 355);
            this.cmbOrderHistory.Name = "cmbOrderHistory";
            this.cmbOrderHistory.Size = new System.Drawing.Size(380, 31);
            this.cmbOrderHistory.TabIndex = 10;

            // --- Controls Khung Phải (Báo cáo & Phản hồi) ---

            // lblRightTitle
            this.lblRightTitle.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblRightTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRightTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRightTitle.ForeColor = System.Drawing.Color.White;
            this.lblRightTitle.Location = new System.Drawing.Point(0, 0);
            this.lblRightTitle.Name = "lblRightTitle";
            this.lblRightTitle.Size = new System.Drawing.Size(796, 30);
            this.lblRightTitle.Text = "BÁO CÁO TỔNG HỢP & PHẢN HỒI";
            this.lblRightTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblReportType (ĐÃ CẬP NHẬT VỊ TRÍ Y: 50 -> 60)
            this.lblReportType.AutoSize = true;
            this.lblReportType.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportType.Location = new System.Drawing.Point(10, 60); // <-- ĐÃ THAY ĐỔI
            this.lblReportType.Name = "lblReportType";
            this.lblReportType.Size = new System.Drawing.Size(107, 24);
            this.lblReportType.TabIndex = 1;
            this.lblReportType.Text = "Xem Báo Cáo:";

            // cmbReportType (ĐÃ CẬP NHẬT VỊ TRÍ Y: 50 -> 60)
            this.cmbReportType.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbReportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReportType.FormattingEnabled = true;
            this.cmbReportType.Location = new System.Drawing.Point(170, 50); // <-- ĐÃ THAY ĐỔI
            this.cmbReportType.Name = "cmbReportType";
            this.cmbReportType.Size = new System.Drawing.Size(250, 31);
            this.cmbReportType.TabIndex = 2;
            this.cmbReportType.SelectedIndexChanged += new System.EventHandler(this.cmbReportType_SelectedIndexChanged);

            // lblReportContent
            this.lblReportContent.AutoSize = true;
            this.lblReportContent.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportContent.Location = new System.Drawing.Point(10, 110); // Đã tăng Y
            this.lblReportContent.Name = "lblReportContent";
            this.lblReportContent.Size = new System.Drawing.Size(155, 24);
            this.lblReportContent.TabIndex = 3;
            this.lblReportContent.Text = "Nội dung Báo cáo:";

            // txtReportContent 
            this.txtReportContent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReportContent.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReportContent.Location = new System.Drawing.Point(10, 135); // Đã tăng Y
            this.txtReportContent.Multiline = true;
            this.txtReportContent.ReadOnly = true;
            this.txtReportContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReportContent.Name = "txtReportContent";
            this.txtReportContent.Size = new System.Drawing.Size(776, 200);
            this.txtReportContent.TabIndex = 4;
            this.txtReportContent.Text = "(Nội dung báo cáo chi tiết của Kế toán/Quản lý/Nhân viên sẽ hiển thị ở đây)";

            // lblReplyTo
            this.lblReplyTo.AutoSize = true;
            this.lblReplyTo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReplyTo.Location = new System.Drawing.Point(10, 350);
            this.lblReplyTo.Name = "lblReplyTo";
            this.lblReplyTo.Size = new System.Drawing.Size(158, 24);
            this.lblReplyTo.TabIndex = 5;
            this.lblReplyTo.Text = "Trả lời/Phản hồi đến:";

            // cmbReplyTo
            this.cmbReplyTo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbReplyTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReplyTo.FormattingEnabled = true;
            this.cmbReplyTo.Location = new System.Drawing.Point(250, 340);
            this.cmbReplyTo.Name = "cmbReplyTo";
            this.cmbReplyTo.Size = new System.Drawing.Size(200, 31);
            this.cmbReplyTo.TabIndex = 6;

            // lblReplyText
            this.lblReplyText.AutoSize = true;
            this.lblReplyText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReplyText.Location = new System.Drawing.Point(10, 400);
            this.lblReplyText.Name = "lblReplyText";
            this.lblReplyText.Size = new System.Drawing.Size(161, 24);
            this.lblReplyText.TabIndex = 7;
            this.lblReplyText.Text = "Nội dung trả lời:";

            // txtReplyText 
            this.txtReplyText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReplyText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReplyText.Location = new System.Drawing.Point(10, 425);
            this.txtReplyText.Multiline = true;
            this.txtReplyText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReplyText.Name = "txtReplyText";
            this.txtReplyText.Size = new System.Drawing.Size(776, 130);
            this.txtReplyText.TabIndex = 8;

            // btnConfirmReply (ĐÃ CẬP NHẬT: Kích thước 130x80, Chữ Đen)
            this.btnConfirmReply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirmReply.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnConfirmReply.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmReply.ForeColor = System.Drawing.Color.Black; // MÀU CHỮ ĐEN
            this.btnConfirmReply.Location = new System.Drawing.Point(600, 565); // VỊ TRÍ MỚI (796 - 130 - 10 = 656)
            this.btnConfirmReply.Name = "btnConfirmReply";
            this.btnConfirmReply.Size = new System.Drawing.Size(160, 80); // KÍCH THƯỚC MỚI 130x80
            this.btnConfirmReply.TabIndex = 9;
            this.btnConfirmReply.Text = "XÁC NHẬN ";
            this.btnConfirmReply.UseVisualStyleBackColor = false;
            this.btnConfirmReply.Click += new System.EventHandler(this.btnConfirmReply_Click);

            // 
            // ReportAndFeedbackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 705);
            this.Controls.Add(this.splitContainerMain);
            this.Controls.Add(this.lblTitle);
            this.MinimumSize = new System.Drawing.Size(1100, 700);
            this.Name = "ReportAndFeedbackForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống Báo cáo và Phản hồi";
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel1.PerformLayout();
            this.splitContainerMain.Panel2.ResumeLayout(false);
            this.splitContainerMain.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        // Khai báo các biến
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlRight;

        // Controls Khung Trái
        private System.Windows.Forms.Label lblLeftTitle;
        private System.Windows.Forms.Label lblVoucherStatus;
        private System.Windows.Forms.ComboBox cmbVoucherStatus;
        private System.Windows.Forms.Label lblCheckInUser;
        private System.Windows.Forms.ComboBox cmbCheckInUser;
        private System.Windows.Forms.Label lblCheckInTime;
        private System.Windows.Forms.DateTimePicker dtpCheckInTime;
        private System.Windows.Forms.Label lblInventory;
        private System.Windows.Forms.ComboBox cmbInventory;
        private System.Windows.Forms.Label lblOrderHistory;
        private System.Windows.Forms.ComboBox cmbOrderHistory;

        // Controls Khung Phải
        private System.Windows.Forms.Label lblRightTitle;
        private System.Windows.Forms.Label lblReportType;
        private System.Windows.Forms.ComboBox cmbReportType;
        private System.Windows.Forms.Label lblReportContent;
        private System.Windows.Forms.TextBox txtReportContent;
        private System.Windows.Forms.Label lblReplyTo;
        private System.Windows.Forms.ComboBox cmbReplyTo;
        private System.Windows.Forms.Label lblReplyText;
        private System.Windows.Forms.TextBox txtReplyText;
        private System.Windows.Forms.Button btnConfirmReply;
    }
}