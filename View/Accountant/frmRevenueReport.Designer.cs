namespace JumpArena
{
    partial class frmRevenueReport
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea13 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend13 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlBieuDo = new System.Windows.Forms.Panel();
            this.pnlChiTiet = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.cbThang = new System.Windows.Forms.ComboBox();
            this.lblTo = new System.Windows.Forms.Label();
            this.cbNam = new System.Windows.Forms.ComboBox();
            this.btnXem = new System.Windows.Forms.Button();
            this.btnXuat = new System.Windows.Forms.Button();
            this.lblBieuDoSection = new System.Windows.Forms.Label();
            this.lblChiTietSection = new System.Windows.Forms.Label();
            this.chartDoanhThu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvDoanhThuChiTiet = new System.Windows.Forms.DataGridView();
            this.lblTongDoanhThu = new System.Windows.Forms.Label();
            this.lblSoHoaDon = new System.Windows.Forms.Label();
            this.lblTrungBinhNgay = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlBieuDo.SuspendLayout();
            this.pnlChiTiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThuChiTiet)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lblTrungBinhNgay);
            this.pnlHeader.Controls.Add(this.lblSoHoaDon);
            this.pnlHeader.Controls.Add(this.lblTongDoanhThu);
            this.pnlHeader.Controls.Add(this.btnXuat);
            this.pnlHeader.Controls.Add(this.btnXem);
            this.pnlHeader.Controls.Add(this.cbNam);
            this.pnlHeader.Controls.Add(this.lblTo);
            this.pnlHeader.Controls.Add(this.cbThang);
            this.pnlHeader.Controls.Add(this.lblFrom);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1300, 130);
            this.pnlHeader.TabIndex = 0;
            // 
            // pnlBieuDo
            // 
            this.pnlBieuDo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBieuDo.Controls.Add(this.chartDoanhThu);
            this.pnlBieuDo.Controls.Add(this.lblBieuDoSection);
            this.pnlBieuDo.Location = new System.Drawing.Point(0, 130);
            this.pnlBieuDo.Name = "pnlBieuDo";
            this.pnlBieuDo.Size = new System.Drawing.Size(1300, 340);
            this.pnlBieuDo.TabIndex = 2;
            // 
            // pnlChiTiet
            // 
            this.pnlChiTiet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlChiTiet.Controls.Add(this.dgvDoanhThuChiTiet);
            this.pnlChiTiet.Controls.Add(this.lblChiTietSection);
            this.pnlChiTiet.Location = new System.Drawing.Point(0, 470);
            this.pnlChiTiet.Name = "pnlChiTiet";
            this.pnlChiTiet.Size = new System.Drawing.Size(1300, 232);
            this.pnlChiTiet.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(30, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(362, 41);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "THỐNG KÊ DOANH THU";
            // 
            // lblFrom
            // 
            this.lblFrom.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.Location = new System.Drawing.Point(720, 22);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(100, 30);
            this.lblFrom.TabIndex = 1;
            this.lblFrom.Text = "Từ tháng :";
            // 
            // cbThang
            // 
            this.cbThang.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbThang.FormattingEnabled = true;
            this.cbThang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbThang.Location = new System.Drawing.Point(820, 20);
            this.cbThang.Name = "cbThang";
            this.cbThang.Size = new System.Drawing.Size(120, 33);
            this.cbThang.TabIndex = 2;
            // 
            // lblTo
            // 
            this.lblTo.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.Location = new System.Drawing.Point(720, 65);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(117, 30);
            this.lblTo.TabIndex = 3;
            this.lblTo.Text = "Đến tháng :";
            // 
            // cbNam
            // 
            this.cbNam.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNam.FormattingEnabled = true;
            this.cbNam.Items.AddRange(new object[] {
            "2023",
            "2024",
            "2025",
            "2026"});
            this.cbNam.Location = new System.Drawing.Point(820, 63);
            this.cbNam.Name = "cbNam";
            this.cbNam.Size = new System.Drawing.Size(120, 33);
            this.cbNam.TabIndex = 4;
            // 
            // btnXem
            // 
            this.btnXem.BackColor = System.Drawing.Color.Aqua;
            this.btnXem.FlatAppearance.BorderSize = 0;
            this.btnXem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXem.Location = new System.Drawing.Point(980, 45);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(127, 45);
            this.btnXem.TabIndex = 5;
            this.btnXem.Text = "XEM";
            this.btnXem.UseVisualStyleBackColor = false;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // btnXuat
            // 
            this.btnXuat.BackColor = System.Drawing.Color.Aqua;
            this.btnXuat.FlatAppearance.BorderSize = 0;
            this.btnXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuat.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuat.Location = new System.Drawing.Point(1120, 45);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(127, 45);
            this.btnXuat.TabIndex = 6;
            this.btnXuat.Text = "XUẤT FILE";
            this.btnXuat.UseVisualStyleBackColor = false;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // lblBieuDoSection
            // 
            this.lblBieuDoSection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblBieuDoSection.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBieuDoSection.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBieuDoSection.ForeColor = System.Drawing.Color.White;
            this.lblBieuDoSection.Location = new System.Drawing.Point(0, 0);
            this.lblBieuDoSection.Name = "lblBieuDoSection";
            this.lblBieuDoSection.Size = new System.Drawing.Size(1296, 28);
            this.lblBieuDoSection.TabIndex = 1;
            this.lblBieuDoSection.Text = "BIỂU ĐỒ DOANH THU THEO NGÀY";
            this.lblBieuDoSection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblChiTietSection
            // 
            this.lblChiTietSection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblChiTietSection.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblChiTietSection.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiTietSection.ForeColor = System.Drawing.Color.White;
            this.lblChiTietSection.Location = new System.Drawing.Point(0, 0);
            this.lblChiTietSection.Name = "lblChiTietSection";
            this.lblChiTietSection.Size = new System.Drawing.Size(1298, 28);
            this.lblChiTietSection.TabIndex = 2;
            this.lblChiTietSection.Text = "DANH SÁCH DOANH THU CHI TIẾT";
            this.lblChiTietSection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chartDoanhThu
            // 
            chartArea13.Name = "ChartArea1";
            this.chartDoanhThu.ChartAreas.Add(chartArea13);
            legend13.Name = "Legend1";
            this.chartDoanhThu.Legends.Add(legend13);
            this.chartDoanhThu.Location = new System.Drawing.Point(15, 35);
            this.chartDoanhThu.Name = "chartDoanhThu";
            series13.ChartArea = "ChartArea1";
            series13.Legend = "Legend1";
            series13.Name = "Series1";
            this.chartDoanhThu.Series.Add(series13);
            this.chartDoanhThu.Size = new System.Drawing.Size(1270, 280);
            this.chartDoanhThu.TabIndex = 2;
            this.chartDoanhThu.Text = "chart1";
            // 
            // dgvDoanhThuChiTiet
            // 
            this.dgvDoanhThuChiTiet.AllowUserToAddRows = false;
            this.dgvDoanhThuChiTiet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDoanhThuChiTiet.ColumnHeadersHeight = 35;
            this.dgvDoanhThuChiTiet.Location = new System.Drawing.Point(15, 35);
            this.dgvDoanhThuChiTiet.Name = "dgvDoanhThuChiTiet";
            this.dgvDoanhThuChiTiet.ReadOnly = true;
            this.dgvDoanhThuChiTiet.RowHeadersVisible = false;
            this.dgvDoanhThuChiTiet.RowHeadersWidth = 51;
            this.dgvDoanhThuChiTiet.RowTemplate.Height = 24;
            this.dgvDoanhThuChiTiet.Size = new System.Drawing.Size(1254, 186);
            this.dgvDoanhThuChiTiet.TabIndex = 3;
            // 
            // lblTongDoanhThu
            // 
            this.lblTongDoanhThu.AutoSize = true;
            this.lblTongDoanhThu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongDoanhThu.Location = new System.Drawing.Point(30, 65);
            this.lblTongDoanhThu.Name = "lblTongDoanhThu";
            this.lblTongDoanhThu.Size = new System.Drawing.Size(309, 28);
            this.lblTongDoanhThu.TabIndex = 7;
            this.lblTongDoanhThu.Text = "Tổng doanh thu tháng: --- VNĐ";
            // 
            // lblSoHoaDon
            // 
            this.lblSoHoaDon.AutoSize = true;
            this.lblSoHoaDon.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoHoaDon.Location = new System.Drawing.Point(30, 90);
            this.lblSoHoaDon.Name = "lblSoHoaDon";
            this.lblSoHoaDon.Size = new System.Drawing.Size(194, 25);
            this.lblSoHoaDon.TabIndex = 8;
            this.lblSoHoaDon.Text = "Số lượng hóa đơn: ---";
            // 
            // lblTrungBinhNgay
            // 
            this.lblTrungBinhNgay.AutoSize = true;
            this.lblTrungBinhNgay.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrungBinhNgay.Location = new System.Drawing.Point(380, 90);
            this.lblTrungBinhNgay.Name = "lblTrungBinhNgay";
            this.lblTrungBinhNgay.Size = new System.Drawing.Size(255, 25);
            this.lblTrungBinhNgay.TabIndex = 9;
            this.lblTrungBinhNgay.Text = "Doanh thu TB/ngày: --- VNĐ";
            // 
            // frmRevenueReport
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1282, 704);
            this.Controls.Add(this.pnlChiTiet);
            this.Controls.Add(this.pnlBieuDo);
            this.Controls.Add(this.pnlHeader);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmRevenueReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THỐNG KÊ DOANH THU";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlBieuDo.ResumeLayout(false);
            this.pnlChiTiet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThuChiTiet)).EndInit();
            this.Load += new System.EventHandler(this.frmRevenueReport_Load);

            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlBieuDo;
        private System.Windows.Forms.Panel pnlChiTiet;
        private System.Windows.Forms.ComboBox cbThang;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnXuat;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.ComboBox cbNam;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblBieuDoSection;
        private System.Windows.Forms.Label lblChiTietSection;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDoanhThu;
        private System.Windows.Forms.DataGridView dgvDoanhThuChiTiet;
        private System.Windows.Forms.Label lblTrungBinhNgay;
        private System.Windows.Forms.Label lblSoHoaDon;
        private System.Windows.Forms.Label lblTongDoanhThu;
    }
}