namespace JumpArena
{
    partial class frmVoucherCheckIn
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblThang = new System.Windows.Forms.Label();
            this.cbThang = new System.Windows.Forms.ComboBox();
            this.lblNam = new System.Windows.Forms.Label();
            this.cbNam = new System.Windows.Forms.ComboBox();
            this.btnXem = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlDangApDung = new System.Windows.Forms.Panel();
            this.lblDangApDungTitle = new System.Windows.Forms.Label();
            this.dgvDangApDung = new System.Windows.Forms.DataGridView();
            this.pnlHetHan = new System.Windows.Forms.Panel();
            this.lblHetHanTitle = new System.Windows.Forms.Label();
            this.dgvHetHan = new System.Windows.Forms.DataGridView();
            this.pnlBieuDo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.chartVoucherTop = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlHeader.SuspendLayout();
            this.pnlDangApDung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDangApDung)).BeginInit();
            this.pnlHetHan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHetHan)).BeginInit();
            this.pnlBieuDo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartVoucherTop)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.button1);
            this.pnlHeader.Controls.Add(this.btnXem);
            this.pnlHeader.Controls.Add(this.cbNam);
            this.pnlHeader.Controls.Add(this.lblNam);
            this.pnlHeader.Controls.Add(this.cbThang);
            this.pnlHeader.Controls.Add(this.lblThang);
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
            this.lblTitle.Size = new System.Drawing.Size(384, 41);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "XEM VOUCHER CHECK-IN";
            // 
            // lblThang
            // 
            this.lblThang.AutoSize = true;
            this.lblThang.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThang.Location = new System.Drawing.Point(720, 22);
            this.lblThang.Name = "lblThang";
            this.lblThang.Size = new System.Drawing.Size(71, 25);
            this.lblThang.TabIndex = 1;
            this.lblThang.Text = "Tháng:";
            // 
            // cbThang
            // 
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
            this.cbThang.Size = new System.Drawing.Size(120, 31);
            this.cbThang.TabIndex = 2;
            // 
            // lblNam
            // 
            this.lblNam.AutoSize = true;
            this.lblNam.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNam.Location = new System.Drawing.Point(720, 65);
            this.lblNam.Name = "lblNam";
            this.lblNam.Size = new System.Drawing.Size(57, 25);
            this.lblNam.TabIndex = 3;
            this.lblNam.Text = "Năm:";
            // 
            // cbNam
            // 
            this.cbNam.FormattingEnabled = true;
            this.cbNam.Items.AddRange(new object[] {
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026"});
            this.cbNam.Location = new System.Drawing.Point(820, 63);
            this.cbNam.Name = "cbNam";
            this.cbNam.Size = new System.Drawing.Size(120, 31);
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Aqua;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1120, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 45);
            this.button1.TabIndex = 6;
            this.button1.Text = "XUẤT FILE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // pnlDangApDung
            // 
            this.pnlDangApDung.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDangApDung.Controls.Add(this.dgvDangApDung);
            this.pnlDangApDung.Controls.Add(this.lblDangApDungTitle);
            this.pnlDangApDung.Location = new System.Drawing.Point(0, 130);
            this.pnlDangApDung.Name = "pnlDangApDung";
            this.pnlDangApDung.Size = new System.Drawing.Size(650, 250);
            this.pnlDangApDung.TabIndex = 1;
            // 
            // lblDangApDungTitle
            // 
            this.lblDangApDungTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblDangApDungTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDangApDungTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDangApDungTitle.ForeColor = System.Drawing.Color.White;
            this.lblDangApDungTitle.Location = new System.Drawing.Point(0, 0);
            this.lblDangApDungTitle.Name = "lblDangApDungTitle";
            this.lblDangApDungTitle.Size = new System.Drawing.Size(648, 30);
            this.lblDangApDungTitle.TabIndex = 0;
            this.lblDangApDungTitle.Text = "VOUCHER ĐANG ÁP DỤNG";
            this.lblDangApDungTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvDangApDung
            // 
            this.dgvDangApDung.AllowUserToAddRows = false;
            this.dgvDangApDung.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDangApDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDangApDung.Location = new System.Drawing.Point(10, 40);
            this.dgvDangApDung.Name = "dgvDangApDung";
            this.dgvDangApDung.ReadOnly = true;
            this.dgvDangApDung.RowHeadersWidth = 51;
            this.dgvDangApDung.RowTemplate.Height = 24;
            this.dgvDangApDung.Size = new System.Drawing.Size(630, 200);
            this.dgvDangApDung.TabIndex = 1;
            // 
            // pnlHetHan
            // 
            this.pnlHetHan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHetHan.Controls.Add(this.dgvHetHan);
            this.pnlHetHan.Controls.Add(this.lblHetHanTitle);
            this.pnlHetHan.Location = new System.Drawing.Point(650, 130);
            this.pnlHetHan.Name = "pnlHetHan";
            this.pnlHetHan.Size = new System.Drawing.Size(650, 250);
            this.pnlHetHan.TabIndex = 2;
            // 
            // lblHetHanTitle
            // 
            this.lblHetHanTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblHetHanTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHetHanTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHetHanTitle.ForeColor = System.Drawing.Color.White;
            this.lblHetHanTitle.Location = new System.Drawing.Point(0, 0);
            this.lblHetHanTitle.Name = "lblHetHanTitle";
            this.lblHetHanTitle.Size = new System.Drawing.Size(648, 30);
            this.lblHetHanTitle.TabIndex = 0;
            this.lblHetHanTitle.Text = "VOUCHER ĐÃ HẾT HẠN";
            this.lblHetHanTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvHetHan
            // 
            this.dgvHetHan.AllowUserToAddRows = false;
            this.dgvHetHan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHetHan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHetHan.Location = new System.Drawing.Point(10, 40);
            this.dgvHetHan.Name = "dgvHetHan";
            this.dgvHetHan.ReadOnly = true;
            this.dgvHetHan.RowHeadersWidth = 51;
            this.dgvHetHan.RowTemplate.Height = 24;
            this.dgvHetHan.Size = new System.Drawing.Size(630, 200);
            this.dgvHetHan.TabIndex = 1;
            // 
            // pnlBieuDo
            // 
            this.pnlBieuDo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBieuDo.Controls.Add(this.chartVoucherTop);
            this.pnlBieuDo.Controls.Add(this.label1);
            this.pnlBieuDo.Location = new System.Drawing.Point(0, 377);
            this.pnlBieuDo.Name = "pnlBieuDo";
            this.pnlBieuDo.Size = new System.Drawing.Size(1300, 327);
            this.pnlBieuDo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1296, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "BIỂU ĐỒ TOP VOUCHER ÁP DỤNG NHIỀU NHẤT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chartVoucherTop
            // 
            chartArea2.Name = "ChartArea1";
            this.chartVoucherTop.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartVoucherTop.Legends.Add(legend2);
            this.chartVoucherTop.Location = new System.Drawing.Point(15, 35);
            this.chartVoucherTop.Name = "chartVoucherTop";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartVoucherTop.Series.Add(series2);
            this.chartVoucherTop.Size = new System.Drawing.Size(1253, 278);
            this.chartVoucherTop.TabIndex = 1;
            this.chartVoucherTop.Text = "chart1";
            // 
            // frmVoucherCheckIn
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1282, 704);
            this.Controls.Add(this.pnlBieuDo);
            this.Controls.Add(this.pnlHetHan);
            this.Controls.Add(this.pnlDangApDung);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmVoucherCheckIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XEM VOUCHER CHECK-IN";
            this.Click += new System.EventHandler(this.frmVoucherCheckIn_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlDangApDung.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDangApDung)).EndInit();
            this.pnlHetHan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHetHan)).EndInit();
            this.pnlBieuDo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartVoucherTop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.ComboBox cbThang;
        private System.Windows.Forms.Label lblThang;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.ComboBox cbNam;
        private System.Windows.Forms.Label lblNam;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlDangApDung;
        private System.Windows.Forms.DataGridView dgvDangApDung;
        private System.Windows.Forms.Label lblDangApDungTitle;
        private System.Windows.Forms.Panel pnlHetHan;
        private System.Windows.Forms.DataGridView dgvHetHan;
        private System.Windows.Forms.Label lblHetHanTitle;
        private System.Windows.Forms.Panel pnlBieuDo;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartVoucherTop;
        private System.Windows.Forms.Label label1;
    }
}