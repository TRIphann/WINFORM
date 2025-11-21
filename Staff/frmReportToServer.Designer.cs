namespace JumpArena.Views.Staff
{
    partial class frmReportToServer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportToServer));
            pnlHeaderMain = new Panel();
            pbLogo = new PictureBox();
            btnCheckInOut = new Button();
            btnMore = new Button();
            btnInShop = new Button();
            btnReport = new Button();
            btnBillSearch = new Button();
            btnHoldList = new Button();
            btnOnline = new Button();
            pnlAuth = new Panel();
            pnlSeparator1 = new Panel();
            txtStaffPass = new TextBox();
            lblPassText = new Label();
            btnVerify = new Button();
            lblUserText = new Label();
            lblAuthTitle = new Label();
            txtStaffUser = new TextBox();
            lblAuthStatus = new Label();
            pnlContent = new Panel();
            btnAttachFile = new Button();
            lblReportContent = new Label();
            txtReportContent = new TextBox();
            cbPriority = new ComboBox();
            txtRelatedBillID = new TextBox();
            txtSubject = new TextBox();
            cbReportType = new ComboBox();
            lblSubject = new Label();
            lblPriority = new Label();
            lblcbReportType = new Label();
            lblRelatedBillID = new Label();
            lblReportHeader = new Label();
            btnCancel = new Button();
            btnSaveDraft = new Button();
            btnSendReport = new Button();
            pnlSeparator2 = new Panel();
            pnlHeaderMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            pnlAuth.SuspendLayout();
            pnlContent.SuspendLayout();
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
            pnlHeaderMain.Location = new Point(3, 3);
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
            // pnlAuth
            // 
            pnlAuth.BackColor = Color.White;
            pnlAuth.Controls.Add(pnlSeparator1);
            pnlAuth.Controls.Add(txtStaffPass);
            pnlAuth.Controls.Add(lblPassText);
            pnlAuth.Controls.Add(btnVerify);
            pnlAuth.Controls.Add(lblUserText);
            pnlAuth.Controls.Add(lblAuthTitle);
            pnlAuth.Controls.Add(txtStaffUser);
            pnlAuth.Controls.Add(lblAuthStatus);
            pnlAuth.Location = new Point(6, 64);
            pnlAuth.Name = "pnlAuth";
            pnlAuth.Size = new Size(539, 473);
            pnlAuth.TabIndex = 10;
            // 
            // pnlSeparator1
            // 
            pnlSeparator1.BackColor = Color.Black;
            pnlSeparator1.Location = new Point(3, 246);
            pnlSeparator1.Name = "pnlSeparator1";
            pnlSeparator1.Size = new Size(536, 3);
            pnlSeparator1.TabIndex = 11;
            // 
            // txtStaffPass
            // 
            txtStaffPass.Location = new Point(163, 130);
            txtStaffPass.Multiline = true;
            txtStaffPass.Name = "txtStaffPass";
            txtStaffPass.Size = new Size(361, 35);
            txtStaffPass.TabIndex = 33;
            // 
            // lblPassText
            // 
            lblPassText.AutoSize = true;
            lblPassText.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lblPassText.Location = new Point(7, 140);
            lblPassText.Name = "lblPassText";
            lblPassText.Size = new Size(103, 25);
            lblPassText.TabIndex = 25;
            lblPassText.Text = "Mật khẩu :";
            // 
            // btnVerify
            // 
            btnVerify.BackColor = Color.DarkGreen;
            btnVerify.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btnVerify.ForeColor = Color.White;
            btnVerify.Location = new Point(383, 185);
            btnVerify.Name = "btnVerify";
            btnVerify.Size = new Size(141, 44);
            btnVerify.TabIndex = 22;
            btnVerify.Text = "Kiểm tra";
            btnVerify.UseVisualStyleBackColor = false;
            // 
            // lblUserText
            // 
            lblUserText.AutoSize = true;
            lblUserText.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lblUserText.Location = new Point(3, 89);
            lblUserText.Name = "lblUserText";
            lblUserText.Size = new Size(150, 25);
            lblUserText.TabIndex = 24;
            lblUserText.Text = "Tên Đăng nhập :";
            // 
            // lblAuthTitle
            // 
            lblAuthTitle.BackColor = Color.Tomato;
            lblAuthTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAuthTitle.Location = new Point(7, 14);
            lblAuthTitle.Name = "lblAuthTitle";
            lblAuthTitle.Size = new Size(517, 51);
            lblAuthTitle.TabIndex = 23;
            lblAuthTitle.Text = "XÁC THỰC THÔNG TIN NHÂN VIÊN";
            lblAuthTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtStaffUser
            // 
            txtStaffUser.Location = new Point(163, 79);
            txtStaffUser.Multiline = true;
            txtStaffUser.Name = "txtStaffUser";
            txtStaffUser.Size = new Size(361, 35);
            txtStaffUser.TabIndex = 19;
            // 
            // lblAuthStatus
            // 
            lblAuthStatus.AutoSize = true;
            lblAuthStatus.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAuthStatus.Location = new Point(6, 269);
            lblAuthStatus.Name = "lblAuthStatus";
            lblAuthStatus.Size = new Size(109, 25);
            lblAuthStatus.TabIndex = 16;
            lblAuthStatus.Text = "Trạng thái :";
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.White;
            pnlContent.Controls.Add(btnAttachFile);
            pnlContent.Controls.Add(lblReportContent);
            pnlContent.Controls.Add(txtReportContent);
            pnlContent.Controls.Add(cbPriority);
            pnlContent.Controls.Add(txtRelatedBillID);
            pnlContent.Controls.Add(txtSubject);
            pnlContent.Controls.Add(cbReportType);
            pnlContent.Controls.Add(lblSubject);
            pnlContent.Controls.Add(lblPriority);
            pnlContent.Controls.Add(lblcbReportType);
            pnlContent.Controls.Add(lblRelatedBillID);
            pnlContent.Controls.Add(lblReportHeader);
            pnlContent.Location = new Point(551, 64);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(730, 601);
            pnlContent.TabIndex = 11;
            // 
            // btnAttachFile
            // 
            btnAttachFile.BackColor = Color.DarkGreen;
            btnAttachFile.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btnAttachFile.ForeColor = Color.White;
            btnAttachFile.Location = new Point(580, 533);
            btnAttachFile.Name = "btnAttachFile";
            btnAttachFile.Size = new Size(141, 59);
            btnAttachFile.TabIndex = 34;
            btnAttachFile.Text = "Đính kèm";
            btnAttachFile.UseVisualStyleBackColor = false;
            // 
            // lblReportContent
            // 
            lblReportContent.AutoSize = true;
            lblReportContent.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lblReportContent.Location = new Point(17, 334);
            lblReportContent.Name = "lblReportContent";
            lblReportContent.Size = new Size(101, 25);
            lblReportContent.TabIndex = 42;
            lblReportContent.Text = "Nội dung :";
            // 
            // txtReportContent
            // 
            txtReportContent.Location = new Point(145, 302);
            txtReportContent.Multiline = true;
            txtReportContent.Name = "txtReportContent";
            txtReportContent.Size = new Size(576, 206);
            txtReportContent.TabIndex = 41;
            // 
            // cbPriority
            // 
            cbPriority.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            cbPriority.FormattingEnabled = true;
            cbPriority.Location = new Point(483, 81);
            cbPriority.Name = "cbPriority";
            cbPriority.Size = new Size(168, 33);
            cbPriority.TabIndex = 40;
            // 
            // txtRelatedBillID
            // 
            txtRelatedBillID.Location = new Point(145, 152);
            txtRelatedBillID.Multiline = true;
            txtRelatedBillID.Name = "txtRelatedBillID";
            txtRelatedBillID.Size = new Size(322, 25);
            txtRelatedBillID.TabIndex = 39;
            // 
            // txtSubject
            // 
            txtSubject.Location = new Point(145, 211);
            txtSubject.Multiline = true;
            txtSubject.Name = "txtSubject";
            txtSubject.Size = new Size(506, 54);
            txtSubject.TabIndex = 34;
            // 
            // cbReportType
            // 
            cbReportType.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            cbReportType.FormattingEnabled = true;
            cbReportType.Location = new Point(145, 81);
            cbReportType.Name = "cbReportType";
            cbReportType.Size = new Size(175, 33);
            cbReportType.TabIndex = 38;
            // 
            // lblSubject
            // 
            lblSubject.AutoSize = true;
            lblSubject.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lblSubject.Location = new Point(21, 211);
            lblSubject.Name = "lblSubject";
            lblSubject.Size = new Size(81, 25);
            lblSubject.TabIndex = 34;
            lblSubject.Text = "Chủ đề :";
            // 
            // lblPriority
            // 
            lblPriority.AutoSize = true;
            lblPriority.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lblPriority.Location = new Point(355, 84);
            lblPriority.Name = "lblPriority";
            lblPriority.Size = new Size(85, 25);
            lblPriority.TabIndex = 35;
            lblPriority.Text = "Ưu tiên :";
            // 
            // lblcbReportType
            // 
            lblcbReportType.AutoSize = true;
            lblcbReportType.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lblcbReportType.Location = new Point(17, 79);
            lblcbReportType.Name = "lblcbReportType";
            lblcbReportType.Size = new Size(101, 25);
            lblcbReportType.TabIndex = 36;
            lblcbReportType.Text = "Phân loại :";
            // 
            // lblRelatedBillID
            // 
            lblRelatedBillID.AutoSize = true;
            lblRelatedBillID.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lblRelatedBillID.Location = new Point(21, 151);
            lblRelatedBillID.Name = "lblRelatedBillID";
            lblRelatedBillID.Size = new Size(81, 25);
            lblRelatedBillID.TabIndex = 37;
            lblRelatedBillID.Text = "Mã Bill :";
            // 
            // lblReportHeader
            // 
            lblReportHeader.BackColor = Color.DeepSkyBlue;
            lblReportHeader.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReportHeader.Location = new Point(17, 14);
            lblReportHeader.Name = "lblReportHeader";
            lblReportHeader.Size = new Size(704, 51);
            lblReportHeader.TabIndex = 34;
            lblReportHeader.Text = "NỘI DUNG BÁO CÁO GỬI CÔNG TY CHỦ";
            lblReportHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.DarkGreen;
            btnCancel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(9, 573);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(141, 68);
            btnCancel.TabIndex = 43;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnSaveDraft
            // 
            btnSaveDraft.BackColor = Color.DarkGreen;
            btnSaveDraft.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btnSaveDraft.ForeColor = Color.White;
            btnSaveDraft.Location = new Point(186, 573);
            btnSaveDraft.Name = "btnSaveDraft";
            btnSaveDraft.Size = new Size(141, 68);
            btnSaveDraft.TabIndex = 44;
            btnSaveDraft.Text = "Lưu";
            btnSaveDraft.UseVisualStyleBackColor = false;
            // 
            // btnSendReport
            // 
            btnSendReport.BackColor = Color.DarkGreen;
            btnSendReport.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btnSendReport.ForeColor = Color.White;
            btnSendReport.Location = new Point(360, 573);
            btnSendReport.Name = "btnSendReport";
            btnSendReport.Size = new Size(141, 68);
            btnSendReport.TabIndex = 45;
            btnSendReport.Text = "Gửi";
            btnSendReport.UseVisualStyleBackColor = false;
            // 
            // pnlSeparator2
            // 
            pnlSeparator2.BackColor = Color.Black;
            pnlSeparator2.Location = new Point(13, 543);
            pnlSeparator2.Name = "pnlSeparator2";
            pnlSeparator2.Size = new Size(536, 3);
            pnlSeparator2.TabIndex = 12;
            // 
            // frmReportToServer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1284, 668);
            Controls.Add(pnlSeparator2);
            Controls.Add(btnCancel);
            Controls.Add(btnSaveDraft);
            Controls.Add(btnSendReport);
            Controls.Add(pnlContent);
            Controls.Add(pnlAuth);
            Controls.Add(pnlHeaderMain);
            Name = "frmReportToServer";
            Text = "frmReportToServer";
            pnlHeaderMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            pnlAuth.ResumeLayout(false);
            pnlAuth.PerformLayout();
            pnlContent.ResumeLayout(false);
            pnlContent.PerformLayout();
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
        private Panel pnlAuth;
        private TextBox txtStaffPass;
        private TextBox txtCustomerDetails;
        private Label lblPhoto;
        private Label lblName;
        private Label lblPassText;
        private Label lblUserText;
        private Label lblAuthTitle;
        private TextBox txtStaffUser;
        private Label lblAuthStatus;
        private Button btnVerify;
        private Panel pnlSeparator1;
        private Panel pnlContent;
        private Label lblSubject;
        private Label lblPriority;
        private Label lblcbReportType;
        private Label lblRelatedBillID;
        private Label lblReportHeader;
        private ComboBox cbReportType;
        private TextBox txtSubject;
        private TextBox txtRelatedBillID;
        private ComboBox cbPriority;
        private Button btnAttachFile;
        private Label lblReportContent;
        private TextBox txtReportContent;
        private ComboBox cbDataSource;
        private Button btnCancel;
        private Button btnSaveDraft;
        private Button btnSendReport;
        private Panel pnlSeparator2;
    }
}