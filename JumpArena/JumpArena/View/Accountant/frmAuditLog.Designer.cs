namespace JumpArena
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnClearFilter = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchInvoice = new System.Windows.Forms.TextBox();
            this.lblFind = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblToDate = new System.Windows.Forms.Label();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlCheckDiscount = new System.Windows.Forms.Panel();
            this.txtDiscountLogDetails = new System.Windows.Forms.TextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.lblTotalDiscount = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbDiscountReason = new System.Windows.Forms.ComboBox();
            this.lblReason = new System.Windows.Forms.Label();
            this.cbEmployeeFilter = new System.Windows.Forms.ComboBox();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.lblDiscountSection = new System.Windows.Forms.Label();
            this.pnlEditCancelAudit = new System.Windows.Forms.Panel();
            this.btnVerifyLog = new System.Windows.Forms.Button();
            this.txtOldNewValues = new System.Windows.Forms.TextBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.dgvEditCancelLogs = new System.Windows.Forms.DataGridView();
            this.cbManagerFilter = new System.Windows.Forms.ComboBox();
            this.lblManagerFilter = new System.Windows.Forms.Label();
            this.cbActionType = new System.Windows.Forms.ComboBox();
            this.lblActionType = new System.Windows.Forms.Label();
            this.lblEditCancelSection = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlCheckDiscount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlEditCancelAudit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditCancelLogs)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.btnClearFilter);
            this.pnlHeader.Controls.Add(this.btnSearch);
            this.pnlHeader.Controls.Add(this.txtSearchInvoice);
            this.pnlHeader.Controls.Add(this.lblFind);
            this.pnlHeader.Controls.Add(this.dateTimePicker1);
            this.pnlHeader.Controls.Add(this.dtpStartDate);
            this.pnlHeader.Controls.Add(this.lblToDate);
            this.pnlHeader.Controls.Add(this.lblFromDate);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1300, 110);
            this.pnlHeader.TabIndex = 1;
            // 
            // btnClearFilter
            // 
            this.btnClearFilter.BackColor = System.Drawing.Color.Aqua;
            this.btnClearFilter.FlatAppearance.BorderSize = 0;
            this.btnClearFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearFilter.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearFilter.Location = new System.Drawing.Point(1111, 46);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(127, 45);
            this.btnClearFilter.TabIndex = 8;
            this.btnClearFilter.Text = "Xuất File";
            this.btnClearFilter.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Aqua;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.lblFind.Location = new System.Drawing.Point(794, 6);
            this.lblFind.Name = "lblFind";
            this.lblFind.Size = new System.Drawing.Size(122, 34);
            this.lblFind.TabIndex = 5;
            this.lblFind.Text = "Nhập Mã Bill";
            this.lblFind.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(479, 61);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(309, 31);
            this.dateTimePicker1.TabIndex = 4;
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
            this.lblTitle.Location = new System.Drawing.Point(26, 31);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(293, 38);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "NHẬT KÝ GIAO DỊCH";
            // 
            // pnlCheckDiscount
            // 
            this.pnlCheckDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCheckDiscount.Controls.Add(this.txtDiscountLogDetails);
            this.pnlCheckDiscount.Controls.Add(this.lblNotes);
            this.pnlCheckDiscount.Controls.Add(this.lblTotalDiscount);
            this.pnlCheckDiscount.Controls.Add(this.dataGridView1);
            this.pnlCheckDiscount.Controls.Add(this.cbDiscountReason);
            this.pnlCheckDiscount.Controls.Add(this.lblReason);
            this.pnlCheckDiscount.Controls.Add(this.cbEmployeeFilter);
            this.pnlCheckDiscount.Controls.Add(this.lblEmployee);
            this.pnlCheckDiscount.Controls.Add(this.lblDiscountSection);
            this.pnlCheckDiscount.Location = new System.Drawing.Point(0, 110);
            this.pnlCheckDiscount.Name = "pnlCheckDiscount";
            this.pnlCheckDiscount.Size = new System.Drawing.Size(640, 640);
            this.pnlCheckDiscount.TabIndex = 2;
            // 
            // txtDiscountLogDetails
            // 
            this.txtDiscountLogDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiscountLogDetails.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscountLogDetails.Location = new System.Drawing.Point(15, 450);
            this.txtDiscountLogDetails.Multiline = true;
            this.txtDiscountLogDetails.Name = "txtDiscountLogDetails";
            this.txtDiscountLogDetails.Size = new System.Drawing.Size(597, 135);
            this.txtDiscountLogDetails.TabIndex = 8;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotes.Location = new System.Drawing.Point(15, 422);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(83, 25);
            this.lblNotes.TabIndex = 7;
            this.lblNotes.Text = "Chi tiết :";
            // 
            // lblTotalDiscount
            // 
            this.lblTotalDiscount.AutoSize = true;
            this.lblTotalDiscount.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDiscount.Location = new System.Drawing.Point(15, 385);
            this.lblTotalDiscount.Name = "lblTotalDiscount";
            this.lblTotalDiscount.Size = new System.Drawing.Size(155, 25);
            this.lblTotalDiscount.TabIndex = 6;
            this.lblTotalDiscount.Text = "Tổng Tiền giảm :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 152);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(597, 216);
            this.dataGridView1.TabIndex = 5;
            // 
            // cbDiscountReason
            // 
            this.cbDiscountReason.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDiscountReason.FormattingEnabled = true;
            this.cbDiscountReason.Location = new System.Drawing.Point(130, 104);
            this.cbDiscountReason.Name = "cbDiscountReason";
            this.cbDiscountReason.Size = new System.Drawing.Size(215, 33);
            this.cbDiscountReason.TabIndex = 4;
            // 
            // lblReason
            // 
            this.lblReason.AutoSize = true;
            this.lblReason.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReason.Location = new System.Drawing.Point(15, 112);
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(67, 25);
            this.lblReason.TabIndex = 3;
            this.lblReason.Text = "Lý do :";
            // 
            // cbEmployeeFilter
            // 
            this.cbEmployeeFilter.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEmployeeFilter.FormattingEnabled = true;
            this.cbEmployeeFilter.Location = new System.Drawing.Point(130, 62);
            this.cbEmployeeFilter.Name = "cbEmployeeFilter";
            this.cbEmployeeFilter.Size = new System.Drawing.Size(215, 33);
            this.cbEmployeeFilter.TabIndex = 2;
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployee.Location = new System.Drawing.Point(15, 70);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(109, 25);
            this.lblEmployee.TabIndex = 1;
            this.lblEmployee.Text = "Nhân viên :";
            // 
            // lblDiscountSection
            // 
            this.lblDiscountSection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblDiscountSection.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDiscountSection.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscountSection.ForeColor = System.Drawing.Color.White;
            this.lblDiscountSection.Location = new System.Drawing.Point(0, 0);
            this.lblDiscountSection.Name = "lblDiscountSection";
            this.lblDiscountSection.Size = new System.Drawing.Size(638, 28);
            this.lblDiscountSection.TabIndex = 0;
            this.lblDiscountSection.Text = "KIỂM TRA GIẢM GIÁ";
            this.lblDiscountSection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlEditCancelAudit
            // 
            this.pnlEditCancelAudit.Controls.Add(this.btnVerifyLog);
            this.pnlEditCancelAudit.Controls.Add(this.txtOldNewValues);
            this.pnlEditCancelAudit.Controls.Add(this.lblNote);
            this.pnlEditCancelAudit.Controls.Add(this.dgvEditCancelLogs);
            this.pnlEditCancelAudit.Controls.Add(this.cbManagerFilter);
            this.pnlEditCancelAudit.Controls.Add(this.lblManagerFilter);
            this.pnlEditCancelAudit.Controls.Add(this.cbActionType);
            this.pnlEditCancelAudit.Controls.Add(this.lblActionType);
            this.pnlEditCancelAudit.Controls.Add(this.lblEditCancelSection);
            this.pnlEditCancelAudit.Location = new System.Drawing.Point(640, 110);
            this.pnlEditCancelAudit.Name = "pnlEditCancelAudit";
            this.pnlEditCancelAudit.Size = new System.Drawing.Size(660, 640);
            this.pnlEditCancelAudit.TabIndex = 3;
            // 
            // btnVerifyLog
            // 
            this.btnVerifyLog.AutoSize = true;
            this.btnVerifyLog.BackColor = System.Drawing.Color.Aqua;
            this.btnVerifyLog.FlatAppearance.BorderSize = 0;
            this.btnVerifyLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerifyLog.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerifyLog.Location = new System.Drawing.Point(521, 592);
            this.btnVerifyLog.Name = "btnVerifyLog";
            this.btnVerifyLog.Size = new System.Drawing.Size(127, 45);
            this.btnVerifyLog.TabIndex = 7;
            this.btnVerifyLog.Text = "Kiểm tra";
            this.btnVerifyLog.UseVisualStyleBackColor = false;
            // 
            // txtOldNewValues
            // 
            this.txtOldNewValues.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOldNewValues.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOldNewValues.Location = new System.Drawing.Point(22, 450);
            this.txtOldNewValues.Multiline = true;
            this.txtOldNewValues.Name = "txtOldNewValues";
            this.txtOldNewValues.Size = new System.Drawing.Size(626, 136);
            this.txtOldNewValues.TabIndex = 6;
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.Location = new System.Drawing.Point(22, 422);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(142, 25);
            this.lblNote.TabIndex = 5;
            this.lblNote.Text = "Giá trị Cũ/Mới :";
            // 
            // dgvEditCancelLogs
            // 
            this.dgvEditCancelLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEditCancelLogs.Location = new System.Drawing.Point(22, 153);
            this.dgvEditCancelLogs.Name = "dgvEditCancelLogs";
            this.dgvEditCancelLogs.RowHeadersWidth = 51;
            this.dgvEditCancelLogs.RowTemplate.Height = 24;
            this.dgvEditCancelLogs.Size = new System.Drawing.Size(626, 216);
            this.dgvEditCancelLogs.TabIndex = 4;
            // 
            // cbManagerFilter
            // 
            this.cbManagerFilter.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbManagerFilter.Location = new System.Drawing.Point(194, 105);
            this.cbManagerFilter.Name = "cbManagerFilter";
            this.cbManagerFilter.Size = new System.Drawing.Size(215, 33);
            this.cbManagerFilter.TabIndex = 0;
            // 
            // lblManagerFilter
            // 
            this.lblManagerFilter.AutoSize = true;
            this.lblManagerFilter.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManagerFilter.Location = new System.Drawing.Point(22, 113);
            this.lblManagerFilter.Name = "lblManagerFilter";
            this.lblManagerFilter.Size = new System.Drawing.Size(88, 25);
            this.lblManagerFilter.TabIndex = 3;
            this.lblManagerFilter.Text = "Quản lý :";
            // 
            // cbActionType
            // 
            this.cbActionType.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbActionType.FormattingEnabled = true;
            this.cbActionType.Location = new System.Drawing.Point(194, 63);
            this.cbActionType.Name = "cbActionType";
            this.cbActionType.Size = new System.Drawing.Size(215, 33);
            this.cbActionType.TabIndex = 2;
            // 
            // lblActionType
            // 
            this.lblActionType.AutoSize = true;
            this.lblActionType.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActionType.Location = new System.Drawing.Point(22, 71);
            this.lblActionType.Name = "lblActionType";
            this.lblActionType.Size = new System.Drawing.Size(154, 25);
            this.lblActionType.TabIndex = 1;
            this.lblActionType.Text = "Loại hành động :";
            // 
            // lblEditCancelSection
            // 
            this.lblEditCancelSection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblEditCancelSection.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblEditCancelSection.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditCancelSection.ForeColor = System.Drawing.Color.White;
            this.lblEditCancelSection.Location = new System.Drawing.Point(0, 0);
            this.lblEditCancelSection.Name = "lblEditCancelSection";
            this.lblEditCancelSection.Size = new System.Drawing.Size(660, 30);
            this.lblEditCancelSection.TabIndex = 0;
            this.lblEditCancelSection.Text = "KIỂM TRA SỬA ĐƠN VÀ HỦY ĐƠN";
            this.lblEditCancelSection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmAuditLog
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1300, 751);
            this.Controls.Add(this.pnlEditCancelAudit);
            this.Controls.Add(this.pnlCheckDiscount);
            this.Controls.Add(this.pnlHeader);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAuditLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " NHẬT KÝ GIAO DỊCH";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlCheckDiscount.ResumeLayout(false);
            this.pnlCheckDiscount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlEditCancelAudit.ResumeLayout(false);
            this.pnlEditCancelAudit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditCancelLogs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.Button btnClearFilter;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchInvoice;
        private System.Windows.Forms.Label lblFind;
        private System.Windows.Forms.Panel pnlCheckDiscount;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbDiscountReason;
        private System.Windows.Forms.Label lblReason;
        private System.Windows.Forms.ComboBox cbEmployeeFilter;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.Label lblDiscountSection;
        private System.Windows.Forms.TextBox txtDiscountLogDetails;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Label lblTotalDiscount;
        private System.Windows.Forms.Panel pnlEditCancelAudit;
        private System.Windows.Forms.Label lblEditCancelSection;
        private System.Windows.Forms.ComboBox cbManagerFilter;
        private System.Windows.Forms.Label lblManagerFilter;
        private System.Windows.Forms.ComboBox cbActionType;
        private System.Windows.Forms.Label lblActionType;
        private System.Windows.Forms.Button btnVerifyLog;
        private System.Windows.Forms.TextBox txtOldNewValues;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.DataGridView dgvEditCancelLogs;
    }
}