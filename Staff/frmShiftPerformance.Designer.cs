namespace JumpArena.Views.Staff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShiftPerformance));
            Panel pnlSeparator2;
            Panel panel1;
            pnlHeaderMain = new Panel();
            pbLogo = new PictureBox();
            btnCheckInOut = new Button();
            btnMore = new Button();
            btnInShop = new Button();
            btnReport = new Button();
            btnBillSearch = new Button();
            btnHoldList = new Button();
            btnOnline = new Button();
            pnlShiftInfo = new Panel();
            lblStartTime = new Label();
            lblStaffIDt = new Label();
            lblTitle = new Label();
            lblEndTime = new Label();
            lblSelectDate = new Label();
            dtpSelectDate = new DateTimePicker();
            dgvProductSold = new DataGridView();
            lblDetailTitle = new Label();
            lblKPITitle = new Label();
            lblTotalRevenue = new Label();
            lblTotalBills = new Label();
            lblTotalProductsSold = new Label();
            lblTotalDiscount = new Label();
            pnlSeparator2 = new Panel();
            panel1 = new Panel();
            pnlHeaderMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            pnlShiftInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductSold).BeginInit();
            SuspendLayout();
            // 
            // pnlHeaderMain
            // 
            pnlHeaderMain.BackColor = Color.White;
            pnlHeaderMain.Controls.Add(pbLogo);
            pnlHeaderMain.Controls.Add(btnCheckInOut);
            pnlHeaderMain.Controls.Add(btnMore);
            pnlHeaderMain.Controls.Add(btnInShop);
            pnlHeaderMain.Controls.Add(btnReport);
            pnlHeaderMain.Controls.Add(btnBillSearch);
            pnlHeaderMain.Controls.Add(btnHoldList);
            pnlHeaderMain.Controls.Add(btnOnline);
            pnlHeaderMain.Location = new Point(-3, 1);
            pnlHeaderMain.Name = "pnlHeaderMain";
            pnlHeaderMain.Size = new Size(1281, 61);
            pnlHeaderMain.TabIndex = 10;
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
            // btnCheckInOut
            // 
            btnCheckInOut.BackColor = Color.White;
            btnCheckInOut.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCheckInOut.ForeColor = Color.Orange;
            btnCheckInOut.Image = (Image)resources.GetObject("btnCheckInOut.Image");
            btnCheckInOut.ImageAlign = ContentAlignment.TopCenter;
            btnCheckInOut.Location = new Point(490, 3);
            btnCheckInOut.Name = "btnCheckInOut";
            btnCheckInOut.Size = new Size(141, 52);
            btnCheckInOut.TabIndex = 3;
            btnCheckInOut.Text = "CHECK IN / OUT";
            btnCheckInOut.TextAlign = ContentAlignment.BottomCenter;
            btnCheckInOut.UseVisualStyleBackColor = false;
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
            // btnInShop
            // 
            btnInShop.BackColor = Color.White;
            btnInShop.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnInShop.ForeColor = Color.Orange;
            btnInShop.Image = (Image)resources.GetObject("btnInShop.Image");
            btnInShop.ImageAlign = ContentAlignment.TopCenter;
            btnInShop.Location = new Point(637, 3);
            btnInShop.Name = "btnInShop";
            btnInShop.Size = new Size(94, 52);
            btnInShop.TabIndex = 4;
            btnInShop.Text = "IN SHOP";
            btnInShop.TextAlign = ContentAlignment.BottomCenter;
            btnInShop.UseVisualStyleBackColor = false;
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
            // pnlShiftInfo
            // 
            pnlShiftInfo.BackColor = Color.White;
            pnlShiftInfo.Controls.Add(lblTotalDiscount);
            pnlShiftInfo.Controls.Add(lblTotalProductsSold);
            pnlShiftInfo.Controls.Add(lblTotalBills);
            pnlShiftInfo.Controls.Add(lblTotalRevenue);
            pnlShiftInfo.Controls.Add(lblKPITitle);
            pnlShiftInfo.Controls.Add(panel1);
            pnlShiftInfo.Controls.Add(pnlSeparator2);
            pnlShiftInfo.Controls.Add(lblDetailTitle);
            pnlShiftInfo.Controls.Add(dgvProductSold);
            pnlShiftInfo.Controls.Add(dtpSelectDate);
            pnlShiftInfo.Controls.Add(lblSelectDate);
            pnlShiftInfo.Controls.Add(lblStartTime);
            pnlShiftInfo.Controls.Add(lblStaffIDt);
            pnlShiftInfo.Controls.Add(lblTitle);
            pnlShiftInfo.Controls.Add(lblEndTime);
            pnlShiftInfo.Location = new Point(0, 62);
            pnlShiftInfo.Name = "pnlShiftInfo";
            pnlShiftInfo.Size = new Size(1278, 607);
            pnlShiftInfo.TabIndex = 11;
            // 
            // lblStartTime
            // 
            lblStartTime.AutoSize = true;
            lblStartTime.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lblStartTime.Location = new Point(834, 72);
            lblStartTime.Name = "lblStartTime";
            lblStartTime.Size = new Size(173, 25);
            lblStartTime.TabIndex = 25;
            lblStartTime.Text = "Thời gian Bắt đầu :";
            // 
            // lblStaffIDt
            // 
            lblStaffIDt.AutoSize = true;
            lblStaffIDt.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lblStaffIDt.Location = new Point(335, 18);
            lblStaffIDt.Name = "lblStaffIDt";
            lblStaffIDt.Size = new Size(143, 25);
            lblStaffIDt.TabIndex = 24;
            lblStaffIDt.Text = "Mã Nhân Viên :";
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.IndianRed;
            lblTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(12, 33);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(213, 51);
            lblTitle.TabIndex = 23;
            lblTitle.Text = " CA LÀM VIỆC";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEndTime
            // 
            lblEndTime.AutoSize = true;
            lblEndTime.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEndTime.Location = new Point(822, 18);
            lblEndTime.Name = "lblEndTime";
            lblEndTime.Size = new Size(174, 25);
            lblEndTime.TabIndex = 16;
            lblEndTime.Text = "Thời gian Kết thúc:";
            // 
            // lblSelectDate
            // 
            lblSelectDate.AutoSize = true;
            lblSelectDate.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSelectDate.Location = new Point(335, 78);
            lblSelectDate.Name = "lblSelectDate";
            lblSelectDate.Size = new Size(107, 25);
            lblSelectDate.TabIndex = 34;
            lblSelectDate.Text = "Thời gian  :";
            // 
            // dtpSelectDate
            // 
            dtpSelectDate.CalendarFont = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpSelectDate.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpSelectDate.Location = new Point(487, 72);
            dtpSelectDate.Name = "dtpSelectDate";
            dtpSelectDate.Size = new Size(320, 31);
            dtpSelectDate.TabIndex = 35;
            // 
            // dgvProductSold
            // 
            dgvProductSold.BackgroundColor = SystemColors.ActiveBorder;
            dgvProductSold.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductSold.Location = new Point(4, 401);
            dgvProductSold.Name = "dgvProductSold";
            dgvProductSold.RowHeadersWidth = 51;
            dgvProductSold.Size = new Size(1265, 203);
            dgvProductSold.TabIndex = 36;
            // 
            // lblDetailTitle
            // 
            lblDetailTitle.AutoSize = true;
            lblDetailTitle.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDetailTitle.Location = new Point(7, 363);
            lblDetailTitle.Name = "lblDetailTitle";
            lblDetailTitle.Size = new Size(243, 25);
            lblDetailTitle.TabIndex = 37;
            lblDetailTitle.Text = "Số lượng sản phẩm đã bán ";
            // 
            // pnlSeparator2
            // 
            pnlSeparator2.BackColor = Color.DimGray;
            pnlSeparator2.ForeColor = SystemColors.ControlLightLight;
            pnlSeparator2.Location = new Point(7, 348);
            pnlSeparator2.Name = "pnlSeparator2";
            pnlSeparator2.Size = new Size(1271, 3);
            pnlSeparator2.TabIndex = 38;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.ForeColor = SystemColors.ControlLightLight;
            panel1.Location = new Point(7, 119);
            panel1.Name = "panel1";
            panel1.Size = new Size(1271, 3);
            panel1.TabIndex = 39;
            // 
            // lblKPITitle
            // 
            lblKPITitle.BackColor = Color.Red;
            lblKPITitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKPITitle.ForeColor = Color.White;
            lblKPITitle.Location = new Point(4, 137);
            lblKPITitle.Name = "lblKPITitle";
            lblKPITitle.Size = new Size(1265, 51);
            lblKPITitle.TabIndex = 40;
            lblKPITitle.Text = "TỔNG SỐ  CA LÀM VIỆC";
            lblKPITitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalRevenue
            // 
            lblTotalRevenue.AutoSize = true;
            lblTotalRevenue.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lblTotalRevenue.Location = new Point(60, 292);
            lblTotalRevenue.Name = "lblTotalRevenue";
            lblTotalRevenue.Size = new Size(108, 25);
            lblTotalRevenue.TabIndex = 41;
            lblTotalRevenue.Text = "Tổng Tiền :";
            // 
            // lblTotalBills
            // 
            lblTotalBills.AutoSize = true;
            lblTotalBills.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lblTotalBills.Location = new Point(60, 213);
            lblTotalBills.Name = "lblTotalBills";
            lblTotalBills.Size = new Size(144, 25);
            lblTotalBills.TabIndex = 42;
            lblTotalBills.Text = "Tổng Hóa đơn :";
            // 
            // lblTotalProductsSold
            // 
            lblTotalProductsSold.AutoSize = true;
            lblTotalProductsSold.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lblTotalProductsSold.Location = new Point(585, 203);
            lblTotalProductsSold.Name = "lblTotalProductsSold";
            lblTotalProductsSold.Size = new Size(155, 25);
            lblTotalProductsSold.TabIndex = 43;
            lblTotalProductsSold.Text = "Tổng Sản phẩm :";
            // 
            // lblTotalDiscount
            // 
            lblTotalDiscount.AutoSize = true;
            lblTotalDiscount.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lblTotalDiscount.Location = new Point(585, 292);
            lblTotalDiscount.Name = "lblTotalDiscount";
            lblTotalDiscount.Size = new Size(146, 25);
            lblTotalDiscount.TabIndex = 44;
            lblTotalDiscount.Text = "Tổng Giảm giá :";
            // 
            // frmShiftPerformance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1279, 681);
            Controls.Add(pnlShiftInfo);
            Controls.Add(pnlHeaderMain);
            Name = "frmShiftPerformance";
            Text = "frmShiftPerformance";
            pnlHeaderMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            pnlShiftInfo.ResumeLayout(false);
            pnlShiftInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductSold).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeaderMain;
        private PictureBox pbLogo;
        private Button btnCheckInOut;
        private Button btnMore;
        private Button btnInShop;
        private Button btnReport;
        private Button btnBillSearch;
        private Button btnHoldList;
        private Button btnOnline;
        private Panel pnlShiftInfo;
        private DateTimePicker dtpSelectDate;
        private Label lblSelectDate;
        private Label lblStartTime;
        private Label lblStaffIDt;
        private Label lblTitle;
        private Label lblEndTime;
        private Label lblDetailTitle;
        private DataGridView dgvProductSold;
        private Label lblTotalDiscount;
        private Label lblTotalProductsSold;
        private Label lblTotalBills;
        private Label lblTotalRevenue;
        private Label lblKPITitle;
    }
}