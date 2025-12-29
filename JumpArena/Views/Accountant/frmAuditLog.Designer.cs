namespace JumpArena.Views
{
    partial class frmAuditLog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAuditLog));
            pnlHeaderMain = new Panel();
            pbLogo = new PictureBox();
            btnMore = new Button();
            btnReport = new Button();
            btnBillSearch = new Button();
            btnHoldList = new Button();
            btnOnline = new Button();
            pnlHeader = new Panel();
            lblFind = new Label();
            txtSearchInvoice = new TextBox();
            lblTitle = new Label();
            btnClearFilter = new Button();
            dtpEndDate = new DateTimePicker();
            btnSearch = new Button();
            lblFromDate = new Label();
            lblToDate = new Label();
            dtpStartDate = new DateTimePicker();
            pnlEditCancelAudit = new Panel();
            btnVerifyLog = new Button();
            lblNote = new Label();
            txtOldNewValues = new TextBox();
            lblActionType = new Label();
            lblManagerFilter = new Label();
            lblEditCancelSection = new Label();
            cbActionType = new ComboBox();
            cbManagerFilter = new ComboBox();
            dgvEditCancelLogs = new DataGridView();
            dataGridView1 = new DataGridView();
            pnlCheckDiscount = new Panel();
            lblNotes = new Label();
            txtDiscountLogDetails = new TextBox();
            lblEmployee = new Label();
            lblReason = new Label();
            lblTotalDiscount = new Label();
            lblDiscountSection = new Label();
            cbEmployeeFilter = new ComboBox();
            cbDiscountReason = new ComboBox();
            pnlHeaderMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            pnlHeader.SuspendLayout();
            pnlEditCancelAudit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEditCancelLogs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            pnlCheckDiscount.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeaderMain
            // 
            pnlHeaderMain.BackColor = Color.White;
            pnlHeaderMain.Controls.Add(pbLogo);
            pnlHeaderMain.Controls.Add(btnMore);
            pnlHeaderMain.Controls.Add(btnReport);
            pnlHeaderMain.Controls.Add(btnBillSearch);
            pnlHeaderMain.Controls.Add(btnHoldList);
            pnlHeaderMain.Controls.Add(btnOnline);
            pnlHeaderMain.Location = new Point(1, 2);
            pnlHeaderMain.Name = "pnlHeaderMain";
            pnlHeaderMain.Size = new Size(1281, 61);
            pnlHeaderMain.TabIndex = 9;
            // 
            // pbLogo
            // 
            pbLogo.BackColor = Color.White;
            pbLogo.Image = (Image)resources.GetObject("pbLogo.Image");
            pbLogo.Location = new Point(3, 3);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(103, 52);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 1;
            pbLogo.TabStop = false;
            // 
            // btnMore
            // 
            btnMore.BackColor = Color.White;
            btnMore.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnMore.Image = (Image)resources.GetObject("btnMore.Image");
            btnMore.ImageAlign = ContentAlignment.TopCenter;
            btnMore.Location = new Point(1178, 3);
            btnMore.Name = "btnMore";
            btnMore.Size = new Size(94, 52);
            btnMore.TabIndex = 12;
            btnMore.Text = "MORE";
            btnMore.TextAlign = ContentAlignment.BottomCenter;
            btnMore.UseVisualStyleBackColor = false;
            // 
            // btnReport
            // 
            btnReport.BackColor = Color.White;
            btnReport.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnReport.Image = (Image)resources.GetObject("btnReport.Image");
            btnReport.ImageAlign = ContentAlignment.TopCenter;
            btnReport.Location = new Point(1078, 3);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(94, 52);
            btnReport.TabIndex = 11;
            btnReport.Text = "REPORT";
            btnReport.TextAlign = ContentAlignment.BottomCenter;
            btnReport.UseVisualStyleBackColor = false;
            // 
            // btnBillSearch
            // 
            btnBillSearch.BackColor = Color.White;
            btnBillSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBillSearch.Image = (Image)resources.GetObject("btnBillSearch.Image");
            btnBillSearch.ImageAlign = ContentAlignment.TopCenter;
            btnBillSearch.Location = new Point(937, 3);
            btnBillSearch.Name = "btnBillSearch";
            btnBillSearch.Size = new Size(135, 52);
            btnBillSearch.TabIndex = 10;
            btnBillSearch.Text = "BILL SEARCH";
            btnBillSearch.TextAlign = ContentAlignment.BottomCenter;
            btnBillSearch.UseVisualStyleBackColor = false;
            // 
            // btnHoldList
            // 
            btnHoldList.BackColor = Color.White;
            btnHoldList.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnHoldList.Image = (Image)resources.GetObject("btnHoldList.Image");
            btnHoldList.ImageAlign = ContentAlignment.TopCenter;
            btnHoldList.Location = new Point(737, 3);
            btnHoldList.Name = "btnHoldList";
            btnHoldList.Size = new Size(94, 52);
            btnHoldList.TabIndex = 9;
            btnHoldList.Text = "HOLD LIST";
            btnHoldList.TextAlign = ContentAlignment.BottomCenter;
            btnHoldList.UseVisualStyleBackColor = false;
            // 
            // btnOnline
            // 
            btnOnline.BackColor = Color.White;
            btnOnline.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnOnline.Image = (Image)resources.GetObject("btnOnline.Image");
            btnOnline.ImageAlign = ContentAlignment.TopCenter;
            btnOnline.Location = new Point(837, 3);
            btnOnline.Name = "btnOnline";
            btnOnline.Size = new Size(94, 52);
            btnOnline.TabIndex = 8;
            btnOnline.Text = "ONLINE";
            btnOnline.TextAlign = ContentAlignment.BottomCenter;
            btnOnline.UseVisualStyleBackColor = false;
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(lblFind);
            pnlHeader.Controls.Add(txtSearchInvoice);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(btnClearFilter);
            pnlHeader.Controls.Add(dtpEndDate);
            pnlHeader.Controls.Add(btnSearch);
            pnlHeader.Controls.Add(lblFromDate);
            pnlHeader.Controls.Add(lblToDate);
            pnlHeader.Controls.Add(dtpStartDate);
            pnlHeader.Location = new Point(4, 63);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1281, 99);
            pnlHeader.TabIndex = 17;
            // 
            // lblFind
            // 
            lblFind.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFind.Location = new Point(794, 6);
            lblFind.Name = "lblFind";
            lblFind.Size = new Size(122, 34);
            lblFind.TabIndex = 17;
            lblFind.Text = "Nhập Mã Bill";
            lblFind.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtSearchInvoice
            // 
            txtSearchInvoice.Location = new Point(922, 6);
            txtSearchInvoice.Multiline = true;
            txtSearchInvoice.Name = "txtSearchInvoice";
            txtSearchInvoice.Size = new Size(342, 34);
            txtSearchInvoice.TabIndex = 16;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(26, 31);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(293, 38);
            lblTitle.TabIndex = 11;
            lblTitle.Text = "NHẬT KÝ GIAO DỊCH";
            // 
            // btnClearFilter
            // 
            btnClearFilter.BackColor = Color.Aqua;
            btnClearFilter.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btnClearFilter.Location = new Point(1137, 46);
            btnClearFilter.Name = "btnClearFilter";
            btnClearFilter.Size = new Size(127, 45);
            btnClearFilter.TabIndex = 10;
            btnClearFilter.Text = "Xuất File";
            btnClearFilter.UseVisualStyleBackColor = false;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            dtpEndDate.Location = new Point(479, 61);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(309, 31);
            dtpEndDate.TabIndex = 15;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Aqua;
            btnSearch.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btnSearch.Location = new Point(977, 46);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(127, 45);
            btnSearch.TabIndex = 9;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // lblFromDate
            // 
            lblFromDate.AutoSize = true;
            lblFromDate.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lblFromDate.Location = new Point(370, 15);
            lblFromDate.Name = "lblFromDate";
            lblFromDate.Size = new Size(95, 25);
            lblFromDate.TabIndex = 12;
            lblFromDate.Text = "Từ Ngày :";
            // 
            // lblToDate
            // 
            lblToDate.AutoSize = true;
            lblToDate.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lblToDate.Location = new Point(370, 61);
            lblToDate.Name = "lblToDate";
            lblToDate.Size = new Size(106, 25);
            lblToDate.TabIndex = 13;
            lblToDate.Text = "Đến Ngày :";
            // 
            // dtpStartDate
            // 
            dtpStartDate.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            dtpStartDate.Location = new Point(479, 10);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(309, 31);
            dtpStartDate.TabIndex = 14;
            // 
            // pnlEditCancelAudit
            // 
            pnlEditCancelAudit.Controls.Add(btnVerifyLog);
            pnlEditCancelAudit.Controls.Add(lblNote);
            pnlEditCancelAudit.Controls.Add(txtOldNewValues);
            pnlEditCancelAudit.Controls.Add(lblActionType);
            pnlEditCancelAudit.Controls.Add(lblManagerFilter);
            pnlEditCancelAudit.Controls.Add(lblEditCancelSection);
            pnlEditCancelAudit.Controls.Add(cbActionType);
            pnlEditCancelAudit.Controls.Add(cbManagerFilter);
            pnlEditCancelAudit.Controls.Add(dgvEditCancelLogs);
            pnlEditCancelAudit.Location = new Point(630, 160);
            pnlEditCancelAudit.Name = "pnlEditCancelAudit";
            pnlEditCancelAudit.Size = new Size(652, 591);
            pnlEditCancelAudit.TabIndex = 18;
            // 
            // btnVerifyLog
            // 
            btnVerifyLog.BackColor = Color.Aqua;
            btnVerifyLog.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVerifyLog.Location = new Point(477, 541);
            btnVerifyLog.Name = "btnVerifyLog";
            btnVerifyLog.Size = new Size(142, 45);
            btnVerifyLog.TabIndex = 19;
            btnVerifyLog.Text = "Kiểm tra";
            btnVerifyLog.UseVisualStyleBackColor = false;
            // 
            // lblNote
            // 
            lblNote.AutoSize = true;
            lblNote.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lblNote.Location = new Point(22, 386);
            lblNote.Name = "lblNote";
            lblNote.Size = new Size(142, 25);
            lblNote.TabIndex = 18;
            lblNote.Text = "Giá trị Cũ/Mới :";
            // 
            // txtOldNewValues
            // 
            txtOldNewValues.Location = new Point(22, 423);
            txtOldNewValues.Multiline = true;
            txtOldNewValues.Name = "txtOldNewValues";
            txtOldNewValues.Size = new Size(597, 112);
            txtOldNewValues.TabIndex = 17;
            // 
            // lblActionType
            // 
            lblActionType.AutoSize = true;
            lblActionType.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lblActionType.Location = new Point(22, 71);
            lblActionType.Name = "lblActionType";
            lblActionType.Size = new Size(154, 25);
            lblActionType.TabIndex = 16;
            lblActionType.Text = "Loại hành động :";
            // 
            // lblManagerFilter
            // 
            lblManagerFilter.AutoSize = true;
            lblManagerFilter.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lblManagerFilter.Location = new Point(22, 113);
            lblManagerFilter.Name = "lblManagerFilter";
            lblManagerFilter.Size = new Size(88, 25);
            lblManagerFilter.TabIndex = 15;
            lblManagerFilter.Text = "Quản lý :";
            // 
            // lblEditCancelSection
            // 
            lblEditCancelSection.BackColor = Color.Red;
            lblEditCancelSection.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEditCancelSection.ForeColor = Color.White;
            lblEditCancelSection.Location = new Point(14, 1);
            lblEditCancelSection.Name = "lblEditCancelSection";
            lblEditCancelSection.Size = new Size(624, 44);
            lblEditCancelSection.TabIndex = 13;
            lblEditCancelSection.Text = "KIỂM TRA SỬA ĐƠN VÀ HỦY ĐƠN";
            lblEditCancelSection.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbActionType
            // 
            cbActionType.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            cbActionType.FormattingEnabled = true;
            cbActionType.Location = new Point(194, 68);
            cbActionType.Name = "cbActionType";
            cbActionType.Size = new Size(215, 33);
            cbActionType.TabIndex = 12;
            // 
            // cbManagerFilter
            // 
            cbManagerFilter.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            cbManagerFilter.FormattingEnabled = true;
            cbManagerFilter.Location = new Point(194, 110);
            cbManagerFilter.Name = "cbManagerFilter";
            cbManagerFilter.Size = new Size(215, 33);
            cbManagerFilter.TabIndex = 11;
            // 
            // dgvEditCancelLogs
            // 
            dgvEditCancelLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEditCancelLogs.Location = new Point(22, 153);
            dgvEditCancelLogs.Name = "dgvEditCancelLogs";
            dgvEditCancelLogs.RowHeadersWidth = 51;
            dgvEditCancelLogs.Size = new Size(597, 216);
            dgvEditCancelLogs.TabIndex = 10;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(11, 152);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(597, 216);
            dataGridView1.TabIndex = 0;
            // 
            // pnlCheckDiscount
            // 
            pnlCheckDiscount.Controls.Add(lblNotes);
            pnlCheckDiscount.Controls.Add(txtDiscountLogDetails);
            pnlCheckDiscount.Controls.Add(lblEmployee);
            pnlCheckDiscount.Controls.Add(lblReason);
            pnlCheckDiscount.Controls.Add(lblTotalDiscount);
            pnlCheckDiscount.Controls.Add(lblDiscountSection);
            pnlCheckDiscount.Controls.Add(cbEmployeeFilter);
            pnlCheckDiscount.Controls.Add(cbDiscountReason);
            pnlCheckDiscount.Controls.Add(dataGridView1);
            pnlCheckDiscount.Location = new Point(1, 161);
            pnlCheckDiscount.Name = "pnlCheckDiscount";
            pnlCheckDiscount.Size = new Size(627, 593);
            pnlCheckDiscount.TabIndex = 19;
            // 
            // lblNotes
            // 
            lblNotes.AutoSize = true;
            lblNotes.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lblNotes.Location = new Point(11, 422);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new Size(83, 25);
            lblNotes.TabIndex = 9;
            lblNotes.Text = "Chi tiết :";
            // 
            // txtDiscountLogDetails
            // 
            txtDiscountLogDetails.Location = new Point(11, 450);
            txtDiscountLogDetails.Multiline = true;
            txtDiscountLogDetails.Name = "txtDiscountLogDetails";
            txtDiscountLogDetails.Size = new Size(597, 135);
            txtDiscountLogDetails.TabIndex = 8;
            // 
            // lblEmployee
            // 
            lblEmployee.AutoSize = true;
            lblEmployee.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lblEmployee.Location = new Point(11, 70);
            lblEmployee.Name = "lblEmployee";
            lblEmployee.Size = new Size(109, 25);
            lblEmployee.TabIndex = 7;
            lblEmployee.Text = "Nhân viên :";
            // 
            // lblReason
            // 
            lblReason.AutoSize = true;
            lblReason.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lblReason.Location = new Point(11, 112);
            lblReason.Name = "lblReason";
            lblReason.Size = new Size(67, 25);
            lblReason.TabIndex = 6;
            lblReason.Text = "Lý do :";
            // 
            // lblTotalDiscount
            // 
            lblTotalDiscount.AutoSize = true;
            lblTotalDiscount.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lblTotalDiscount.Location = new Point(11, 385);
            lblTotalDiscount.Name = "lblTotalDiscount";
            lblTotalDiscount.Size = new Size(155, 25);
            lblTotalDiscount.TabIndex = 5;
            lblTotalDiscount.Text = "Tổng Tiền giảm :";
            // 
            // lblDiscountSection
            // 
            lblDiscountSection.BackColor = Color.Red;
            lblDiscountSection.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDiscountSection.ForeColor = Color.White;
            lblDiscountSection.Location = new Point(11, 0);
            lblDiscountSection.Name = "lblDiscountSection";
            lblDiscountSection.Size = new Size(597, 44);
            lblDiscountSection.TabIndex = 4;
            lblDiscountSection.Text = "KIỂM TRA GIẢM GIÁ";
            lblDiscountSection.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbEmployeeFilter
            // 
            cbEmployeeFilter.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            cbEmployeeFilter.FormattingEnabled = true;
            cbEmployeeFilter.Location = new Point(124, 70);
            cbEmployeeFilter.Name = "cbEmployeeFilter";
            cbEmployeeFilter.Size = new Size(215, 33);
            cbEmployeeFilter.TabIndex = 3;
            // 
            // cbDiscountReason
            // 
            cbDiscountReason.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            cbDiscountReason.FormattingEnabled = true;
            cbDiscountReason.Location = new Point(124, 112);
            cbDiscountReason.Name = "cbDiscountReason";
            cbDiscountReason.Size = new Size(215, 33);
            cbDiscountReason.TabIndex = 2;
            // 
            // frmAuditLog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1285, 758);
            Controls.Add(pnlCheckDiscount);
            Controls.Add(pnlEditCancelAudit);
            Controls.Add(pnlHeader);
            Controls.Add(pnlHeaderMain);
            Name = "frmAuditLog";
            Text = "frmAuditLog";
            pnlHeaderMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlEditCancelAudit.ResumeLayout(false);
            pnlEditCancelAudit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEditCancelLogs).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            pnlCheckDiscount.ResumeLayout(false);
            pnlCheckDiscount.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeaderMain;
        private PictureBox pbLogo;
        private Button btnMore;
        private Button btnReport;
        private Button btnBillSearch;
        private Button btnHoldList;
        private Button btnOnline;
        private Panel pnlHeader;
        private Label lblFind;
        private TextBox txtSearchInvoice;
        private Label lblTitle;
        private Button btnClearFilter;
        private DateTimePicker dtpEndDate;
        private Button btnSearch;
        private Label lblFromDate;
        private Label lblToDate;
        private DateTimePicker dtpStartDate;
        private Panel pnlEditCancelAudit;
        private DataGridView dataGridView1;
        private Panel pnlCheckDiscount;
        private ComboBox cbEmployeeFilter;
        private ComboBox cbDiscountReason;
        private Label lblEmployee;
        private Label lblReason;
        private Label lblTotalDiscount;
        private Label lblDiscountSection;
        private Label lblNotes;
        private TextBox txtDiscountLogDetails;
        private Label lblNote;
        private TextBox txtOldNewValues;
        private Label lblActionType;
        private Label lblManagerFilter;
        private Label lblEditCancelSection;
        private ComboBox cbActionType;
        private ComboBox cbManagerFilter;
        private DataGridView dgvEditCancelLogs;
        private Button btnVerifyLog;
    }
}