namespace JumpArena.Views
{
    partial class frmInvoiceConfirmation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInvoiceConfirmation));
            btnSearch = new Button();
            btnClearFilter = new Button();
            lblTitle = new Label();
            lblFromDate = new Label();
            lblToDate = new Label();
            dtpStartDate = new DateTimePicker();
            dtpEndDate = new DateTimePicker();
            pnlHeader = new Panel();
            lblFind = new Label();
            txtSearchInvoice = new TextBox();
            dgvPendingInvoices = new DataGridView();
            pnlSummaryDetail = new Panel();
            lblNote = new Label();
            txtNotes = new TextBox();
            lblInvoiceStatus = new Label();
            lblTotalAmount = new Label();
            lblSummaryTitle = new Label();
            pnlActions = new Panel();
            btnCancel = new Button();
            btnConfirmSelected = new Button();
            btnOpenReport = new Button();
            btnRejectSelected = new Button();
            btnOnline = new Button();
            btnHoldList = new Button();
            btnBillSearch = new Button();
            btnReport = new Button();
            btnMore = new Button();
            pbLogo = new PictureBox();
            pnlHeaderMain = new Panel();
            sqliteCommand1 = new Microsoft.Data.Sqlite.SqliteCommand();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPendingInvoices).BeginInit();
            pnlSummaryDetail.SuspendLayout();
            pnlActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            pnlHeaderMain.SuspendLayout();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Aqua;
            btnSearch.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btnSearch.Location = new Point(922, 46);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(127, 45);
            btnSearch.TabIndex = 9;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnClearFilter
            // 
            btnClearFilter.BackColor = Color.Aqua;
            btnClearFilter.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btnClearFilter.Location = new Point(1137, 46);
            btnClearFilter.Name = "btnClearFilter";
            btnClearFilter.Size = new Size(127, 45);
            btnClearFilter.TabIndex = 10;
            btnClearFilter.Text = "Xóa";
            btnClearFilter.UseVisualStyleBackColor = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(39, 29);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(308, 38);
            lblTitle.TabIndex = 11;
            lblTitle.Text = "XÁC NHẬN HÓA ĐƠN";
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
            // dtpEndDate
            // 
            dtpEndDate.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            dtpEndDate.Location = new Point(479, 61);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(309, 31);
            dtpEndDate.TabIndex = 15;
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
            pnlHeader.Location = new Point(1, 64);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1281, 99);
            pnlHeader.TabIndex = 16;
            // 
            // lblFind
            // 
            lblFind.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFind.Location = new Point(826, 6);
            lblFind.Name = "lblFind";
            lblFind.Size = new Size(90, 34);
            lblFind.TabIndex = 17;
            lblFind.Text = "Nhập Mã";
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
            // dgvPendingInvoices
            // 
            dgvPendingInvoices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPendingInvoices.Location = new Point(-4, 161);
            dgvPendingInvoices.Name = "dgvPendingInvoices";
            dgvPendingInvoices.RowHeadersWidth = 51;
            dgvPendingInvoices.Size = new Size(736, 496);
            dgvPendingInvoices.TabIndex = 17;
            // 
            // pnlSummaryDetail
            // 
            pnlSummaryDetail.Controls.Add(lblNote);
            pnlSummaryDetail.Controls.Add(txtNotes);
            pnlSummaryDetail.Controls.Add(lblInvoiceStatus);
            pnlSummaryDetail.Controls.Add(lblTotalAmount);
            pnlSummaryDetail.Controls.Add(lblSummaryTitle);
            pnlSummaryDetail.Location = new Point(738, 161);
            pnlSummaryDetail.Name = "pnlSummaryDetail";
            pnlSummaryDetail.Size = new Size(544, 398);
            pnlSummaryDetail.TabIndex = 18;
            // 
            // lblNote
            // 
            lblNote.AutoSize = true;
            lblNote.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lblNote.Location = new Point(22, 179);
            lblNote.Name = "lblNote";
            lblNote.Size = new Size(89, 25);
            lblNote.TabIndex = 4;
            lblNote.Text = "Ghi Chú :";
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(22, 202);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(505, 183);
            txtNotes.TabIndex = 3;
            // 
            // lblInvoiceStatus
            // 
            lblInvoiceStatus.AutoSize = true;
            lblInvoiceStatus.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lblInvoiceStatus.Location = new Point(22, 132);
            lblInvoiceStatus.Name = "lblInvoiceStatus";
            lblInvoiceStatus.Size = new Size(113, 25);
            lblInvoiceStatus.TabIndex = 2;
            lblInvoiceStatus.Text = "Trạng Thái :";
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lblTotalAmount.Location = new Point(22, 74);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(126, 25);
            lblTotalAmount.TabIndex = 1;
            lblTotalAmount.Text = "Tổng Giá Trị :";
            // 
            // lblSummaryTitle
            // 
            lblSummaryTitle.BackColor = Color.Red;
            lblSummaryTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSummaryTitle.ForeColor = Color.White;
            lblSummaryTitle.Location = new Point(0, 0);
            lblSummaryTitle.Name = "lblSummaryTitle";
            lblSummaryTitle.Size = new Size(541, 44);
            lblSummaryTitle.TabIndex = 0;
            lblSummaryTitle.Text = "TỔNG KẾT HÓA ĐƠN ĐÃ CHỌN";
            lblSummaryTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlActions
            // 
            pnlActions.Controls.Add(btnCancel);
            pnlActions.Controls.Add(btnConfirmSelected);
            pnlActions.Controls.Add(btnOpenReport);
            pnlActions.Controls.Add(btnRejectSelected);
            pnlActions.Location = new Point(738, 565);
            pnlActions.Name = "pnlActions";
            pnlActions.Size = new Size(544, 92);
            pnlActions.TabIndex = 19;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Aqua;
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCancel.ForeColor = Color.Black;
            btnCancel.ImageAlign = ContentAlignment.TopLeft;
            btnCancel.Location = new Point(0, 15);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(132, 59);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Đóng";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnConfirmSelected
            // 
            btnConfirmSelected.BackColor = Color.Aqua;
            btnConfirmSelected.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnConfirmSelected.ForeColor = Color.Black;
            btnConfirmSelected.ImageAlign = ContentAlignment.TopLeft;
            btnConfirmSelected.Location = new Point(412, 15);
            btnConfirmSelected.Name = "btnConfirmSelected";
            btnConfirmSelected.Size = new Size(132, 59);
            btnConfirmSelected.TabIndex = 0;
            btnConfirmSelected.Text = "Xác nhận";
            btnConfirmSelected.UseVisualStyleBackColor = false;
            // 
            // btnOpenReport
            // 
            btnOpenReport.BackColor = Color.Aqua;
            btnOpenReport.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnOpenReport.ForeColor = Color.Black;
            btnOpenReport.ImageAlign = ContentAlignment.TopLeft;
            btnOpenReport.Location = new Point(138, 15);
            btnOpenReport.Name = "btnOpenReport";
            btnOpenReport.Size = new Size(132, 59);
            btnOpenReport.TabIndex = 4;
            btnOpenReport.Text = "Kiểm tra ";
            btnOpenReport.UseVisualStyleBackColor = false;
            // 
            // btnRejectSelected
            // 
            btnRejectSelected.BackColor = Color.Aqua;
            btnRejectSelected.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnRejectSelected.ForeColor = Color.Black;
            btnRejectSelected.ImageAlign = ContentAlignment.TopLeft;
            btnRejectSelected.Location = new Point(274, 15);
            btnRejectSelected.Name = "btnRejectSelected";
            btnRejectSelected.Size = new Size(132, 59);
            btnRejectSelected.TabIndex = 1;
            btnRejectSelected.Text = "Hủy";
            btnRejectSelected.UseVisualStyleBackColor = false;
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
            // pnlHeaderMain
            // 
            pnlHeaderMain.BackColor = Color.White;
            pnlHeaderMain.Controls.Add(pbLogo);
            pnlHeaderMain.Controls.Add(btnMore);
            pnlHeaderMain.Controls.Add(btnReport);
            pnlHeaderMain.Controls.Add(btnBillSearch);
            pnlHeaderMain.Controls.Add(btnHoldList);
            pnlHeaderMain.Controls.Add(btnOnline);
            pnlHeaderMain.Location = new Point(1, 3);
            pnlHeaderMain.Name = "pnlHeaderMain";
            pnlHeaderMain.Size = new Size(1281, 61);
            pnlHeaderMain.TabIndex = 8;
            // 
            // sqliteCommand1
            // 
            sqliteCommand1.CommandTimeout = 30;
            sqliteCommand1.Connection = null;
            sqliteCommand1.Transaction = null;
            sqliteCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // frmInvoiceConfirmation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1283, 669);
            Controls.Add(pnlActions);
            Controls.Add(pnlSummaryDetail);
            Controls.Add(dgvPendingInvoices);
            Controls.Add(pnlHeader);
            Controls.Add(pnlHeaderMain);
            Name = "frmInvoiceConfirmation";
            Text = "frmInvoiceConfirmation";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPendingInvoices).EndInit();
            pnlSummaryDetail.ResumeLayout(false);
            pnlSummaryDetail.PerformLayout();
            pnlActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            pnlHeaderMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnSearch;
        private Button btnClearFilter;
        private Label lblTitle;
        private Label lblFromDate;
        private Label lblToDate;
        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpEndDate;
        private Panel pnlHeader;
        private TextBox txtSearchInvoice;
        private DataGridView dgvPendingInvoices;
        private Panel pnlSummaryDetail;
        private Label lblInvoiceStatus;
        private Label lblTotalAmount;
        private Label lblSummaryTitle;
        private TextBox txtNotes;
        private Label lblNote;
        private Panel pnlActions;
        private Button btnCancel;
        private Button btnRejectSelected;
        private Button btnConfirmSelected;
        private Button btnOpenReport;
        private Label lblFind;
        private Button btnOnline;
        private Button btnHoldList;
        private Button btnBillSearch;
        private Button btnReport;
        private Button btnMore;
        private PictureBox pbLogo;
        private Panel pnlHeaderMain;
        private Microsoft.Data.Sqlite.SqliteCommand sqliteCommand1;
    }
}