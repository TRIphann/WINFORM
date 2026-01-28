namespace JumpArena
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnClearFilter = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchInvoice = new System.Windows.Forms.TextBox();
            this.lblFind = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblToDate = new System.Windows.Forms.Label();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvPendingInvoices = new System.Windows.Forms.DataGridView();
            this.pnlSummaryDetail = new System.Windows.Forms.Panel();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.lblInvoiceStatus = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblSummaryTitle = new System.Windows.Forms.Label();
            this.pnlActions = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnOpenReport = new System.Windows.Forms.Button();
            this.btnRejectSelected = new System.Windows.Forms.Button();
            this.btnConfirmSelected = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPendingInvoices)).BeginInit();
            this.pnlSummaryDetail.SuspendLayout();
            this.pnlActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.btnClearFilter);
            this.pnlHeader.Controls.Add(this.btnSearch);
            this.pnlHeader.Controls.Add(this.txtSearchInvoice);
            this.pnlHeader.Controls.Add(this.lblFind);
            this.pnlHeader.Controls.Add(this.dtpEndDate);
            this.pnlHeader.Controls.Add(this.dtpStartDate);
            this.pnlHeader.Controls.Add(this.lblToDate);
            this.pnlHeader.Controls.Add(this.lblFromDate);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1290, 100);
            this.pnlHeader.TabIndex = 1;
            // 
            // btnClearFilter
            // 
            this.btnClearFilter.BackColor = System.Drawing.Color.Aqua;
            this.btnClearFilter.FlatAppearance.BorderSize = 0;
            this.btnClearFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearFilter.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearFilter.ForeColor = System.Drawing.Color.Black;
            this.btnClearFilter.Location = new System.Drawing.Point(1111, 46);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(127, 45);
            this.btnClearFilter.TabIndex = 8;
            this.btnClearFilter.Text = "Xóa";
            this.btnClearFilter.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Aqua;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(951, 46);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(127, 45);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtSearchInvoice
            // 
            this.txtSearchInvoice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchInvoice.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchInvoice.Location = new System.Drawing.Point(922, 6);
            this.txtSearchInvoice.Multiline = true;
            this.txtSearchInvoice.Name = "txtSearchInvoice";
            this.txtSearchInvoice.Size = new System.Drawing.Size(342, 34);
            this.txtSearchInvoice.TabIndex = 6;
            // 
            // lblFind
            // 
            this.lblFind.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFind.Location = new System.Drawing.Point(826, 6);
            this.lblFind.Name = "lblFind";
            this.lblFind.Size = new System.Drawing.Size(90, 34);
            this.lblFind.TabIndex = 5;
            this.lblFind.Text = "Nhập Mã";
            this.lblFind.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDate.Location = new System.Drawing.Point(479, 61);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(309, 31);
            this.dtpEndDate.TabIndex = 4;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.Location = new System.Drawing.Point(479, 10);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(309, 31);
            this.dtpStartDate.TabIndex = 3;
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToDate.Location = new System.Drawing.Point(370, 61);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(106, 25);
            this.lblToDate.TabIndex = 2;
            this.lblToDate.Text = "Đến Ngày :";
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromDate.Location = new System.Drawing.Point(370, 15);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(95, 25);
            this.lblFromDate.TabIndex = 1;
            this.lblFromDate.Text = "Từ Ngày :";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(39, 29);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(308, 38);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "XÁC NHẬN HÓA ĐƠN";
            // 
            // dgvPendingInvoices
            // 
            this.dgvPendingInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPendingInvoices.Location = new System.Drawing.Point(12, 108);
            this.dgvPendingInvoices.Name = "dgvPendingInvoices";
            this.dgvPendingInvoices.RowHeadersWidth = 51;
            this.dgvPendingInvoices.RowTemplate.Height = 24;
            this.dgvPendingInvoices.Size = new System.Drawing.Size(722, 419);
            this.dgvPendingInvoices.TabIndex = 2;
            // 
            // pnlSummaryDetail
            // 
            this.pnlSummaryDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSummaryDetail.Controls.Add(this.txtNotes);
            this.pnlSummaryDetail.Controls.Add(this.lblNote);
            this.pnlSummaryDetail.Controls.Add(this.lblInvoiceStatus);
            this.pnlSummaryDetail.Controls.Add(this.lblTotalAmount);
            this.pnlSummaryDetail.Controls.Add(this.lblSummaryTitle);
            this.pnlSummaryDetail.Location = new System.Drawing.Point(740, 108);
            this.pnlSummaryDetail.Name = "pnlSummaryDetail";
            this.pnlSummaryDetail.Size = new System.Drawing.Size(550, 346);
            this.pnlSummaryDetail.TabIndex = 3;
            // 
            // txtNotes
            // 
            this.txtNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNotes.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotes.Location = new System.Drawing.Point(27, 213);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(496, 125);
            this.txtNotes.TabIndex = 4;
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.Location = new System.Drawing.Point(22, 179);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(89, 25);
            this.lblNote.TabIndex = 3;
            this.lblNote.Text = "Ghi Chú :";
            // 
            // lblInvoiceStatus
            // 
            this.lblInvoiceStatus.AutoSize = true;
            this.lblInvoiceStatus.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceStatus.Location = new System.Drawing.Point(22, 132);
            this.lblInvoiceStatus.Name = "lblInvoiceStatus";
            this.lblInvoiceStatus.Size = new System.Drawing.Size(118, 25);
            this.lblInvoiceStatus.TabIndex = 2;
            this.lblInvoiceStatus.Text = "Trạng Thái : ";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.Location = new System.Drawing.Point(22, 74);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(126, 25);
            this.lblTotalAmount.TabIndex = 1;
            this.lblTotalAmount.Text = "Tổng Giá Trị :";
            // 
            // lblSummaryTitle
            // 
            this.lblSummaryTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblSummaryTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSummaryTitle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSummaryTitle.ForeColor = System.Drawing.Color.White;
            this.lblSummaryTitle.Location = new System.Drawing.Point(0, 0);
            this.lblSummaryTitle.Name = "lblSummaryTitle";
            this.lblSummaryTitle.Size = new System.Drawing.Size(548, 31);
            this.lblSummaryTitle.TabIndex = 0;
            this.lblSummaryTitle.Text = "TỔNG KẾT HÓA ĐƠN ĐÃ CHỌN";
            this.lblSummaryTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlActions
            // 
            this.pnlActions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlActions.Controls.Add(this.button2);
            this.pnlActions.Controls.Add(this.btnOpenReport);
            this.pnlActions.Controls.Add(this.btnRejectSelected);
            this.pnlActions.Controls.Add(this.btnConfirmSelected);
            this.pnlActions.Location = new System.Drawing.Point(740, 453);
            this.pnlActions.Name = "pnlActions";
            this.pnlActions.Size = new System.Drawing.Size(550, 74);
            this.pnlActions.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Aqua;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(6, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 59);
            this.button2.TabIndex = 3;
            this.button2.Text = "Đóng";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnOpenReport
            // 
            this.btnOpenReport.BackColor = System.Drawing.Color.Aqua;
            this.btnOpenReport.FlatAppearance.BorderSize = 0;
            this.btnOpenReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenReport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenReport.Location = new System.Drawing.Point(141, 6);
            this.btnOpenReport.Name = "btnOpenReport";
            this.btnOpenReport.Size = new System.Drawing.Size(129, 59);
            this.btnOpenReport.TabIndex = 2;
            this.btnOpenReport.Text = "Kiểm tra";
            this.btnOpenReport.UseVisualStyleBackColor = false;
            // 
            // btnRejectSelected
            // 
            this.btnRejectSelected.BackColor = System.Drawing.Color.Aqua;
            this.btnRejectSelected.FlatAppearance.BorderSize = 0;
            this.btnRejectSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRejectSelected.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRejectSelected.Location = new System.Drawing.Point(276, 6);
            this.btnRejectSelected.Name = "btnRejectSelected";
            this.btnRejectSelected.Size = new System.Drawing.Size(129, 59);
            this.btnRejectSelected.TabIndex = 1;
            this.btnRejectSelected.Text = "Hủy";
            this.btnRejectSelected.UseVisualStyleBackColor = false;
            // 
            // btnConfirmSelected
            // 
            this.btnConfirmSelected.BackColor = System.Drawing.Color.Aqua;
            this.btnConfirmSelected.FlatAppearance.BorderSize = 0;
            this.btnConfirmSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmSelected.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmSelected.Location = new System.Drawing.Point(411, 6);
            this.btnConfirmSelected.Name = "btnConfirmSelected";
            this.btnConfirmSelected.Size = new System.Drawing.Size(129, 59);
            this.btnConfirmSelected.TabIndex = 0;
            this.btnConfirmSelected.Text = "Xác nhận";
            this.btnConfirmSelected.UseVisualStyleBackColor = false;
            // 
            // frmInvoiceConfirmation
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1300, 537);
            this.Controls.Add(this.pnlActions);
            this.Controls.Add(this.pnlSummaryDetail);
            this.Controls.Add(this.dgvPendingInvoices);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmInvoiceConfirmation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XÁC NHẬN HÓA ĐƠN";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPendingInvoices)).EndInit();
            this.pnlSummaryDetail.ResumeLayout(false);
            this.pnlSummaryDetail.PerformLayout();
            this.pnlActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchInvoice;
        private System.Windows.Forms.Label lblFind;
        private System.Windows.Forms.Button btnClearFilter;
        private System.Windows.Forms.DataGridView dgvPendingInvoices;
        private System.Windows.Forms.Panel pnlSummaryDetail;
        private System.Windows.Forms.Label lblSummaryTitle;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Label lblInvoiceStatus;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Panel pnlActions;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnOpenReport;
        private System.Windows.Forms.Button btnRejectSelected;
        private System.Windows.Forms.Button btnConfirmSelected;
    }
}