namespace JumpArena
{
    partial class frmShiftPerformance
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
            this.pnlShiftInfo = new System.Windows.Forms.Panel();
            this.dgvProductSold = new System.Windows.Forms.DataGridView();
            this.lblDetailTitle = new System.Windows.Forms.Label();
            this.pnlSeparator2 = new System.Windows.Forms.Panel();
            this.lblTotalDiscount = new System.Windows.Forms.Label();
            this.lblTotalProductsSold = new System.Windows.Forms.Label();
            this.lblTotalRevenue = new System.Windows.Forms.Label();
            this.lblTotalBills = new System.Windows.Forms.Label();
            this.lblKPITitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.dtpSelectDate = new System.Windows.Forms.DateTimePicker();
            this.lblSelectDate = new System.Windows.Forms.Label();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.lblStaffIDt = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlShiftInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductSold)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlShiftInfo
            // 
            this.pnlShiftInfo.BackColor = System.Drawing.Color.White;
            this.pnlShiftInfo.Controls.Add(this.dgvProductSold);
            this.pnlShiftInfo.Controls.Add(this.lblDetailTitle);
            this.pnlShiftInfo.Controls.Add(this.pnlSeparator2);
            this.pnlShiftInfo.Controls.Add(this.lblTotalDiscount);
            this.pnlShiftInfo.Controls.Add(this.lblTotalProductsSold);
            this.pnlShiftInfo.Controls.Add(this.lblTotalRevenue);
            this.pnlShiftInfo.Controls.Add(this.lblTotalBills);
            this.pnlShiftInfo.Controls.Add(this.lblKPITitle);
            this.pnlShiftInfo.Controls.Add(this.panel1);
            this.pnlShiftInfo.Controls.Add(this.lblStartTime);
            this.pnlShiftInfo.Controls.Add(this.dtpSelectDate);
            this.pnlShiftInfo.Controls.Add(this.lblSelectDate);
            this.pnlShiftInfo.Controls.Add(this.lblEndTime);
            this.pnlShiftInfo.Controls.Add(this.lblStaffIDt);
            this.pnlShiftInfo.Controls.Add(this.lblTitle);
            this.pnlShiftInfo.Location = new System.Drawing.Point(0, -3);
            this.pnlShiftInfo.Name = "pnlShiftInfo";
            this.pnlShiftInfo.Size = new System.Drawing.Size(1278, 684);
            this.pnlShiftInfo.TabIndex = 1;
            // 
            // dgvProductSold
            // 
            this.dgvProductSold.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvProductSold.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductSold.Location = new System.Drawing.Point(12, 404);
            this.dgvProductSold.Name = "dgvProductSold";
            this.dgvProductSold.RowHeadersWidth = 51;
            this.dgvProductSold.RowTemplate.Height = 24;
            this.dgvProductSold.Size = new System.Drawing.Size(1255, 268);
            this.dgvProductSold.TabIndex = 14;
            // 
            // lblDetailTitle
            // 
            this.lblDetailTitle.AutoSize = true;
            this.lblDetailTitle.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailTitle.Location = new System.Drawing.Point(7, 363);
            this.lblDetailTitle.Name = "lblDetailTitle";
            this.lblDetailTitle.Size = new System.Drawing.Size(243, 25);
            this.lblDetailTitle.TabIndex = 13;
            this.lblDetailTitle.Text = "Số lượng sản phẩm đã bán ";
            // 
            // pnlSeparator2
            // 
            this.pnlSeparator2.BackColor = System.Drawing.Color.DimGray;
            this.pnlSeparator2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlSeparator2.Location = new System.Drawing.Point(7, 348);
            this.pnlSeparator2.Name = "pnlSeparator2";
            this.pnlSeparator2.Size = new System.Drawing.Size(1271, 3);
            this.pnlSeparator2.TabIndex = 12;
            // 
            // lblTotalDiscount
            // 
            this.lblTotalDiscount.AutoSize = true;
            this.lblTotalDiscount.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDiscount.Location = new System.Drawing.Point(585, 292);
            this.lblTotalDiscount.Name = "lblTotalDiscount";
            this.lblTotalDiscount.Size = new System.Drawing.Size(146, 25);
            this.lblTotalDiscount.TabIndex = 11;
            this.lblTotalDiscount.Text = "Tổng Giảm giá :";
            // 
            // lblTotalProductsSold
            // 
            this.lblTotalProductsSold.AutoSize = true;
            this.lblTotalProductsSold.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalProductsSold.Location = new System.Drawing.Point(585, 203);
            this.lblTotalProductsSold.Name = "lblTotalProductsSold";
            this.lblTotalProductsSold.Size = new System.Drawing.Size(155, 25);
            this.lblTotalProductsSold.TabIndex = 10;
            this.lblTotalProductsSold.Text = "Tổng Sản phẩm :";
            // 
            // lblTotalRevenue
            // 
            this.lblTotalRevenue.AutoSize = true;
            this.lblTotalRevenue.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRevenue.Location = new System.Drawing.Point(60, 292);
            this.lblTotalRevenue.Name = "lblTotalRevenue";
            this.lblTotalRevenue.Size = new System.Drawing.Size(108, 25);
            this.lblTotalRevenue.TabIndex = 9;
            this.lblTotalRevenue.Text = "Tổng Tiền :";
            // 
            // lblTotalBills
            // 
            this.lblTotalBills.AutoSize = true;
            this.lblTotalBills.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBills.Location = new System.Drawing.Point(60, 213);
            this.lblTotalBills.Name = "lblTotalBills";
            this.lblTotalBills.Size = new System.Drawing.Size(144, 25);
            this.lblTotalBills.TabIndex = 8;
            this.lblTotalBills.Text = "Tổng Hóa đơn :";
            // 
            // lblKPITitle
            // 
            this.lblKPITitle.BackColor = System.Drawing.Color.Red;
            this.lblKPITitle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKPITitle.ForeColor = System.Drawing.Color.White;
            this.lblKPITitle.Location = new System.Drawing.Point(4, 137);
            this.lblKPITitle.Name = "lblKPITitle";
            this.lblKPITitle.Size = new System.Drawing.Size(1271, 51);
            this.lblKPITitle.TabIndex = 7;
            this.lblKPITitle.Text = "TỔNG SỐ  CA LÀM VIỆC";
            this.lblKPITitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(7, 119);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1271, 3);
            this.panel1.TabIndex = 6;
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartTime.Location = new System.Drawing.Point(823, 72);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(173, 25);
            this.lblStartTime.TabIndex = 5;
            this.lblStartTime.Text = "Thời gian Bắt đầu :";
            // 
            // dtpSelectDate
            // 
            this.dtpSelectDate.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSelectDate.Location = new System.Drawing.Point(487, 72);
            this.dtpSelectDate.Name = "dtpSelectDate";
            this.dtpSelectDate.Size = new System.Drawing.Size(320, 31);
            this.dtpSelectDate.TabIndex = 4;
            // 
            // lblSelectDate
            // 
            this.lblSelectDate.AutoSize = true;
            this.lblSelectDate.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectDate.Location = new System.Drawing.Point(335, 78);
            this.lblSelectDate.Name = "lblSelectDate";
            this.lblSelectDate.Size = new System.Drawing.Size(107, 25);
            this.lblSelectDate.TabIndex = 3;
            this.lblSelectDate.Text = "Thời gian  :";
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndTime.Location = new System.Drawing.Point(822, 18);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(174, 25);
            this.lblEndTime.TabIndex = 2;
            this.lblEndTime.Text = "Thời gian Kết thúc:";
            // 
            // lblStaffIDt
            // 
            this.lblStaffIDt.AutoSize = true;
            this.lblStaffIDt.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffIDt.Location = new System.Drawing.Point(335, 18);
            this.lblStaffIDt.Name = "lblStaffIDt";
            this.lblStaffIDt.Size = new System.Drawing.Size(143, 25);
            this.lblStaffIDt.TabIndex = 1;
            this.lblStaffIDt.Text = "Mã Nhân Viên :";
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.IndianRed;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 33);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(213, 51);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "CA LÀM VIỆC";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmShiftPerformance
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1279, 681);
            this.Controls.Add(this.pnlShiftInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmShiftPerformance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HIỆU SUẤT CA LÀM VIỆC";
            this.pnlShiftInfo.ResumeLayout(false);
            this.pnlShiftInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductSold)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlShiftInfo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblKPITitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.DateTimePicker dtpSelectDate;
        private System.Windows.Forms.Label lblSelectDate;
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.Label lblStaffIDt;
        private System.Windows.Forms.DataGridView dgvProductSold;
        private System.Windows.Forms.Label lblDetailTitle;
        private System.Windows.Forms.Panel pnlSeparator2;
        private System.Windows.Forms.Label lblTotalDiscount;
        private System.Windows.Forms.Label lblTotalProductsSold;
        private System.Windows.Forms.Label lblTotalRevenue;
        private System.Windows.Forms.Label lblTotalBills;
    }
}