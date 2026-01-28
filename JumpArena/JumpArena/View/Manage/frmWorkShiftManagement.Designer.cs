namespace JumpArena
{
    partial class frmWorkShiftManagement
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
            this.pnlFiltersSummary = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblBranchFilter = new System.Windows.Forms.Label();
            this.lblActiveCount = new System.Windows.Forms.Label();
            this.lblSearchStaff = new System.Windows.Forms.Label();
            this.lblRoleFilter = new System.Windows.Forms.Label();
            this.lblLateCount = new System.Windows.Forms.Label();
            this.cbBranchFilter = new System.Windows.Forms.ComboBox();
            this.txtSearchStaff = new System.Windows.Forms.TextBox();
            this.cbRoleFilter = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblActiveShifts = new System.Windows.Forms.Label();
            this.dgvActiveShifts = new System.Windows.Forms.DataGridView();
            this.pnlActionsLog = new System.Windows.Forms.Panel();
            this.lblPersonalLogTitle = new System.Windows.Forms.Label();
            this.dgvPersonalShiftHistory = new System.Windows.Forms.DataGridView();
            this.btnStartNewShift = new System.Windows.Forms.Button();
            this.btnEndSelectedShifts = new System.Windows.Forms.Button();
            this.pnlFiltersSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActiveShifts)).BeginInit();
            this.pnlActionsLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonalShiftHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFiltersSummary
            // 
            this.pnlFiltersSummary.Controls.Add(this.btnRefresh);
            this.pnlFiltersSummary.Controls.Add(this.btnSearch);
            this.pnlFiltersSummary.Controls.Add(this.cbRoleFilter);
            this.pnlFiltersSummary.Controls.Add(this.txtSearchStaff);
            this.pnlFiltersSummary.Controls.Add(this.cbBranchFilter);
            this.pnlFiltersSummary.Controls.Add(this.lblLateCount);
            this.pnlFiltersSummary.Controls.Add(this.lblRoleFilter);
            this.pnlFiltersSummary.Controls.Add(this.lblSearchStaff);
            this.pnlFiltersSummary.Controls.Add(this.lblActiveCount);
            this.pnlFiltersSummary.Controls.Add(this.lblBranchFilter);
            this.pnlFiltersSummary.Controls.Add(this.lblTitle);
            this.pnlFiltersSummary.Location = new System.Drawing.Point(0, 0);
            this.pnlFiltersSummary.Name = "pnlFiltersSummary";
            this.pnlFiltersSummary.Size = new System.Drawing.Size(1271, 155);
            this.pnlFiltersSummary.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Crimson;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitle.Location = new System.Drawing.Point(0, 3);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1271, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "QUẢN LÝ  CA LÀM VIỆC";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBranchFilter
            // 
            this.lblBranchFilter.AutoSize = true;
            this.lblBranchFilter.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBranchFilter.Location = new System.Drawing.Point(30, 68);
            this.lblBranchFilter.Name = "lblBranchFilter";
            this.lblBranchFilter.Size = new System.Drawing.Size(108, 25);
            this.lblBranchFilter.TabIndex = 1;
            this.lblBranchFilter.Text = "Chi nhánh :";
            // 
            // lblActiveCount
            // 
            this.lblActiveCount.AutoSize = true;
            this.lblActiveCount.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveCount.Location = new System.Drawing.Point(385, 71);
            this.lblActiveCount.Name = "lblActiveCount";
            this.lblActiveCount.Size = new System.Drawing.Size(142, 25);
            this.lblActiveCount.TabIndex = 2;
            this.lblActiveCount.Text = "Đang làm việc :";
            // 
            // lblSearchStaff
            // 
            this.lblSearchStaff.AutoSize = true;
            this.lblSearchStaff.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchStaff.Location = new System.Drawing.Point(737, 63);
            this.lblSearchStaff.Name = "lblSearchStaff";
            this.lblSearchStaff.Size = new System.Drawing.Size(131, 25);
            this.lblSearchStaff.TabIndex = 3;
            this.lblSearchStaff.Text = "Tìm kiếm NV :";
            // 
            // lblRoleFilter
            // 
            this.lblRoleFilter.AutoSize = true;
            this.lblRoleFilter.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoleFilter.Location = new System.Drawing.Point(30, 124);
            this.lblRoleFilter.Name = "lblRoleFilter";
            this.lblRoleFilter.Size = new System.Drawing.Size(78, 25);
            this.lblRoleFilter.TabIndex = 4;
            this.lblRoleFilter.Text = "Vai trò :";
            // 
            // lblLateCount
            // 
            this.lblLateCount.AutoSize = true;
            this.lblLateCount.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLateCount.Location = new System.Drawing.Point(385, 124);
            this.lblLateCount.Name = "lblLateCount";
            this.lblLateCount.Size = new System.Drawing.Size(81, 25);
            this.lblLateCount.TabIndex = 5;
            this.lblLateCount.Text = "Trễ giờ :";
            // 
            // cbBranchFilter
            // 
            this.cbBranchFilter.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBranchFilter.FormattingEnabled = true;
            this.cbBranchFilter.Location = new System.Drawing.Point(148, 63);
            this.cbBranchFilter.Name = "cbBranchFilter";
            this.cbBranchFilter.Size = new System.Drawing.Size(191, 33);
            this.cbBranchFilter.TabIndex = 6;
            // 
            // txtSearchStaff
            // 
            this.txtSearchStaff.Location = new System.Drawing.Point(874, 59);
            this.txtSearchStaff.Multiline = true;
            this.txtSearchStaff.Name = "txtSearchStaff";
            this.txtSearchStaff.Size = new System.Drawing.Size(259, 34);
            this.txtSearchStaff.TabIndex = 7;
            // 
            // cbRoleFilter
            // 
            this.cbRoleFilter.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRoleFilter.FormattingEnabled = true;
            this.cbRoleFilter.Location = new System.Drawing.Point(148, 116);
            this.cbRoleFilter.Name = "cbRoleFilter";
            this.cbRoleFilter.Size = new System.Drawing.Size(191, 33);
            this.cbRoleFilter.TabIndex = 8;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Aqua;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(874, 99);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 46);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Aqua;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(1039, 99);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(94, 46);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // lblActiveShifts
            // 
            this.lblActiveShifts.BackColor = System.Drawing.Color.DarkTurquoise;
            this.lblActiveShifts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveShifts.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblActiveShifts.Location = new System.Drawing.Point(28, 161);
            this.lblActiveShifts.Name = "lblActiveShifts";
            this.lblActiveShifts.Size = new System.Drawing.Size(665, 53);
            this.lblActiveShifts.TabIndex = 1;
            this.lblActiveShifts.Text = "DỮ LIỆU CA LÀM VIỆC ";
            this.lblActiveShifts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvActiveShifts
            // 
            this.dgvActiveShifts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActiveShifts.Location = new System.Drawing.Point(28, 238);
            this.dgvActiveShifts.Name = "dgvActiveShifts";
            this.dgvActiveShifts.RowHeadersWidth = 51;
            this.dgvActiveShifts.RowTemplate.Height = 24;
            this.dgvActiveShifts.Size = new System.Drawing.Size(665, 321);
            this.dgvActiveShifts.TabIndex = 2;
            // 
            // pnlActionsLog
            // 
            this.pnlActionsLog.Controls.Add(this.btnEndSelectedShifts);
            this.pnlActionsLog.Controls.Add(this.btnStartNewShift);
            this.pnlActionsLog.Controls.Add(this.dgvPersonalShiftHistory);
            this.pnlActionsLog.Controls.Add(this.lblPersonalLogTitle);
            this.pnlActionsLog.Location = new System.Drawing.Point(715, 161);
            this.pnlActionsLog.Name = "pnlActionsLog";
            this.pnlActionsLog.Size = new System.Drawing.Size(532, 417);
            this.pnlActionsLog.TabIndex = 3;
            // 
            // lblPersonalLogTitle
            // 
            this.lblPersonalLogTitle.BackColor = System.Drawing.Color.ForestGreen;
            this.lblPersonalLogTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonalLogTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPersonalLogTitle.Location = new System.Drawing.Point(0, 0);
            this.lblPersonalLogTitle.Name = "lblPersonalLogTitle";
            this.lblPersonalLogTitle.Size = new System.Drawing.Size(532, 53);
            this.lblPersonalLogTitle.TabIndex = 0;
            this.lblPersonalLogTitle.Text = "LỊCH SỬ CÁ NHÂN ";
            this.lblPersonalLogTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvPersonalShiftHistory
            // 
            this.dgvPersonalShiftHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonalShiftHistory.Location = new System.Drawing.Point(0, 75);
            this.dgvPersonalShiftHistory.Name = "dgvPersonalShiftHistory";
            this.dgvPersonalShiftHistory.RowHeadersWidth = 51;
            this.dgvPersonalShiftHistory.RowTemplate.Height = 24;
            this.dgvPersonalShiftHistory.Size = new System.Drawing.Size(532, 256);
            this.dgvPersonalShiftHistory.TabIndex = 1;
            // 
            // btnStartNewShift
            // 
            this.btnStartNewShift.BackColor = System.Drawing.Color.Aqua;
            this.btnStartNewShift.FlatAppearance.BorderSize = 0;
            this.btnStartNewShift.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartNewShift.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartNewShift.Location = new System.Drawing.Point(275, 339);
            this.btnStartNewShift.Name = "btnStartNewShift";
            this.btnStartNewShift.Size = new System.Drawing.Size(109, 59);
            this.btnStartNewShift.TabIndex = 2;
            this.btnStartNewShift.Text = "New";
            this.btnStartNewShift.UseVisualStyleBackColor = false;
            // 
            // btnEndSelectedShifts
            // 
            this.btnEndSelectedShifts.BackColor = System.Drawing.Color.Aqua;
            this.btnEndSelectedShifts.FlatAppearance.BorderSize = 0;
            this.btnEndSelectedShifts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEndSelectedShifts.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEndSelectedShifts.Location = new System.Drawing.Point(420, 339);
            this.btnEndSelectedShifts.Name = "btnEndSelectedShifts";
            this.btnEndSelectedShifts.Size = new System.Drawing.Size(109, 59);
            this.btnEndSelectedShifts.TabIndex = 3;
            this.btnEndSelectedShifts.Text = "End";
            this.btnEndSelectedShifts.UseVisualStyleBackColor = false;
            // 
            // frmWorkShiftManagement
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1270, 586);
            this.Controls.Add(this.pnlActionsLog);
            this.Controls.Add(this.dgvActiveShifts);
            this.Controls.Add(this.lblActiveShifts);
            this.Controls.Add(this.pnlFiltersSummary);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmWorkShiftManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ CA LÀM VIỆC";
            this.pnlFiltersSummary.ResumeLayout(false);
            this.pnlFiltersSummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActiveShifts)).EndInit();
            this.pnlActionsLog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonalShiftHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFiltersSummary;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cbRoleFilter;
        private System.Windows.Forms.TextBox txtSearchStaff;
        private System.Windows.Forms.ComboBox cbBranchFilter;
        private System.Windows.Forms.Label lblLateCount;
        private System.Windows.Forms.Label lblRoleFilter;
        private System.Windows.Forms.Label lblSearchStaff;
        private System.Windows.Forms.Label lblActiveCount;
        private System.Windows.Forms.Label lblBranchFilter;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblActiveShifts;
        private System.Windows.Forms.DataGridView dgvActiveShifts;
        private System.Windows.Forms.Panel pnlActionsLog;
        private System.Windows.Forms.Label lblPersonalLogTitle;
        private System.Windows.Forms.Button btnEndSelectedShifts;
        private System.Windows.Forms.Button btnStartNewShift;
        private System.Windows.Forms.DataGridView dgvPersonalShiftHistory;
    }
}