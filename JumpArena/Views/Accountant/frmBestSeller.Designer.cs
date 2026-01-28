namespace JumpArena
{
    partial class frmBestSeller
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.cbThang = new System.Windows.Forms.ComboBox();
            this.lblNam = new System.Windows.Forms.Label();
            this.cbNam = new System.Windows.Forms.ComboBox();
            this.btnXem = new System.Windows.Forms.Button();
            this.btnXuat = new System.Windows.Forms.Button();
            this.pnlBieuDo = new System.Windows.Forms.Panel();
            this.lblBieuDoSection = new System.Windows.Forms.Label();
            this.chartSanPhamBanChay = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlChiTiet = new System.Windows.Forms.Panel();
            this.lblChiTietSection = new System.Windows.Forms.Label();
            this.dgvSanPhamBanChay = new System.Windows.Forms.DataGridView();
            this.pnlHeader.SuspendLayout();
            this.pnlBieuDo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSanPhamBanChay)).BeginInit();
            this.pnlChiTiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPhamBanChay)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.btnXuat);
            this.pnlHeader.Controls.Add(this.btnXem);
            this.pnlHeader.Controls.Add(this.cbNam);
            this.pnlHeader.Controls.Add(this.lblNam);
            this.pnlHeader.Controls.Add(this.cbThang);
            this.pnlHeader.Controls.Add(this.lblFrom);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1300, 130);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(30, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(507, 41);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "XEM SẢN PHẨM BÁN CHẠY NHẤT";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.Location = new System.Drawing.Point(720, 22);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(76, 25);
            this.lblFrom.TabIndex = 1;
            this.lblFrom.Text = "Tháng :";
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
            // lblNam
            // 
            this.lblNam.AutoSize = true;
            this.lblNam.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNam.Location = new System.Drawing.Point(720, 65);
            this.lblNam.Name = "lblNam";
            this.lblNam.Size = new System.Drawing.Size(62, 25);
            this.lblNam.TabIndex = 3;
            this.lblNam.Text = "Năm :";
            // 
            // cbNam
            // 
            this.cbNam.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNam.FormattingEnabled = true;
            this.cbNam.Items.AddRange(new object[] {
            "2022",
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
            // pnlBieuDo
            // 
            this.pnlBieuDo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBieuDo.Controls.Add(this.chartSanPhamBanChay);
            this.pnlBieuDo.Controls.Add(this.lblBieuDoSection);
            this.pnlBieuDo.Location = new System.Drawing.Point(0, 130);
            this.pnlBieuDo.Name = "pnlBieuDo";
            this.pnlBieuDo.Size = new System.Drawing.Size(1300, 340);
            this.pnlBieuDo.TabIndex = 1;
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
            this.lblBieuDoSection.TabIndex = 0;
            this.lblBieuDoSection.Text = "BIỂU ĐỒ TOP 10 SẢN PHẨM BÁN CHẠY";
            this.lblBieuDoSection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chartSanPhamBanChay
            // 
            chartArea3.Name = "ChartArea1";
            this.chartSanPhamBanChay.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartSanPhamBanChay.Legends.Add(legend3);
            this.chartSanPhamBanChay.Location = new System.Drawing.Point(10, 35);
            this.chartSanPhamBanChay.Name = "chartSanPhamBanChay";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartSanPhamBanChay.Series.Add(series3);
            this.chartSanPhamBanChay.Size = new System.Drawing.Size(1258, 297);
            this.chartSanPhamBanChay.TabIndex = 1;
            this.chartSanPhamBanChay.Text = "chart1";
            // 
            // pnlChiTiet
            // 
            this.pnlChiTiet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlChiTiet.Controls.Add(this.dgvSanPhamBanChay);
            this.pnlChiTiet.Controls.Add(this.lblChiTietSection);
            this.pnlChiTiet.Location = new System.Drawing.Point(0, 470);
            this.pnlChiTiet.Name = "pnlChiTiet";
            this.pnlChiTiet.Size = new System.Drawing.Size(1300, 232);
            this.pnlChiTiet.TabIndex = 2;
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
            this.lblChiTietSection.TabIndex = 0;
            this.lblChiTietSection.Text = "DANH SÁCH TOP SẢN PHẨM BÁN CHẠY";
            this.lblChiTietSection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvSanPhamBanChay
            // 
            this.dgvSanPhamBanChay.AllowUserToAddRows = false;
            this.dgvSanPhamBanChay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSanPhamBanChay.ColumnHeadersHeight = 35;
            this.dgvSanPhamBanChay.Location = new System.Drawing.Point(11, 35);
            this.dgvSanPhamBanChay.Name = "dgvSanPhamBanChay";
            this.dgvSanPhamBanChay.ReadOnly = true;
            this.dgvSanPhamBanChay.RowHeadersWidth = 51;
            this.dgvSanPhamBanChay.RowTemplate.Height = 24;
            this.dgvSanPhamBanChay.Size = new System.Drawing.Size(1258, 186);
            this.dgvSanPhamBanChay.TabIndex = 1;
            // 
            // frmBestSeller
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1282, 704);
            this.Controls.Add(this.pnlChiTiet);
            this.Controls.Add(this.pnlBieuDo);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmBestSeller";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XEM SẢN PHẨM BÁN CHẠY NHẤT";
            this.Click += new System.EventHandler(this.frmSanPhamBanChay_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlBieuDo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartSanPhamBanChay)).EndInit();
            this.pnlChiTiet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPhamBanChay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnXuat;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.ComboBox cbNam;
        private System.Windows.Forms.Label lblNam;
        private System.Windows.Forms.ComboBox cbThang;
        private System.Windows.Forms.Panel pnlBieuDo;
        private System.Windows.Forms.Label lblBieuDoSection;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSanPhamBanChay;
        private System.Windows.Forms.Panel pnlChiTiet;
        private System.Windows.Forms.DataGridView dgvSanPhamBanChay;
        private System.Windows.Forms.Label lblChiTietSection;
    }
}