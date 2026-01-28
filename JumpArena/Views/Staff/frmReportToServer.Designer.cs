namespace JumpArena
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
            this.pnlAuth = new System.Windows.Forms.Panel();
            this.lblAuthStatus = new System.Windows.Forms.Label();
            this.pnlSeparator1 = new System.Windows.Forms.Panel();
            this.btnVerify = new System.Windows.Forms.Button();
            this.txtStaffPass = new System.Windows.Forms.TextBox();
            this.lblPassText = new System.Windows.Forms.Label();
            this.txtStaffUser = new System.Windows.Forms.TextBox();
            this.lblUserText = new System.Windows.Forms.Label();
            this.lblAuthTitle = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.btnAttachFile = new System.Windows.Forms.Button();
            this.txtReportContent = new System.Windows.Forms.TextBox();
            this.lblReportContent = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.txtRelatedBillID = new System.Windows.Forms.TextBox();
            this.lblRelatedBillID = new System.Windows.Forms.Label();
            this.cbPriority = new System.Windows.Forms.ComboBox();
            this.lblPriority = new System.Windows.Forms.Label();
            this.cbReportType = new System.Windows.Forms.ComboBox();
            this.lblcbReportType = new System.Windows.Forms.Label();
            this.lblReportHeader = new System.Windows.Forms.Label();
            this.pnlSeparator2 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveDraft = new System.Windows.Forms.Button();
            this.btnSendReport = new System.Windows.Forms.Button();
            this.pnlSeparator3 = new System.Windows.Forms.Panel();
            this.pnlAuth.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAuth
            // 
            this.pnlAuth.BackColor = System.Drawing.Color.White;
            this.pnlAuth.Controls.Add(this.lblAuthStatus);
            this.pnlAuth.Controls.Add(this.pnlSeparator1);
            this.pnlAuth.Controls.Add(this.btnVerify);
            this.pnlAuth.Controls.Add(this.txtStaffPass);
            this.pnlAuth.Controls.Add(this.pnlSeparator2);
            this.pnlAuth.Controls.Add(this.lblPassText);
            this.pnlAuth.Controls.Add(this.txtStaffUser);
            this.pnlAuth.Controls.Add(this.lblUserText);
            this.pnlAuth.Controls.Add(this.lblAuthTitle);
            this.pnlAuth.Location = new System.Drawing.Point(0, -3);
            this.pnlAuth.Name = "pnlAuth";
            this.pnlAuth.Size = new System.Drawing.Size(554, 540);
            this.pnlAuth.TabIndex = 1;
            // 
            // lblAuthStatus
            // 
            this.lblAuthStatus.AutoSize = true;
            this.lblAuthStatus.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthStatus.Location = new System.Drawing.Point(6, 269);
            this.lblAuthStatus.Name = "lblAuthStatus";
            this.lblAuthStatus.Size = new System.Drawing.Size(109, 25);
            this.lblAuthStatus.TabIndex = 7;
            this.lblAuthStatus.Text = "Trạng thái :";
            // 
            // pnlSeparator1
            // 
            this.pnlSeparator1.BackColor = System.Drawing.Color.Black;
            this.pnlSeparator1.Location = new System.Drawing.Point(0, 246);
            this.pnlSeparator1.Name = "pnlSeparator1";
            this.pnlSeparator1.Size = new System.Drawing.Size(551, 3);
            this.pnlSeparator1.TabIndex = 6;
            // 
            // btnVerify
            // 
            this.btnVerify.BackColor = System.Drawing.Color.DarkGreen;
            this.btnVerify.FlatAppearance.BorderSize = 0;
            this.btnVerify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerify.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerify.ForeColor = System.Drawing.Color.White;
            this.btnVerify.Location = new System.Drawing.Point(383, 185);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(141, 44);
            this.btnVerify.TabIndex = 5;
            this.btnVerify.Text = "Kiểm tra";
            this.btnVerify.UseVisualStyleBackColor = false;
            // 
            // txtStaffPass
            // 
            this.txtStaffPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStaffPass.Location = new System.Drawing.Point(163, 130);
            this.txtStaffPass.Multiline = true;
            this.txtStaffPass.Name = "txtStaffPass";
            this.txtStaffPass.PasswordChar = '*';
            this.txtStaffPass.Size = new System.Drawing.Size(361, 35);
            this.txtStaffPass.TabIndex = 4;
            // 
            // lblPassText
            // 
            this.lblPassText.AutoSize = true;
            this.lblPassText.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassText.Location = new System.Drawing.Point(7, 140);
            this.lblPassText.Name = "lblPassText";
            this.lblPassText.Size = new System.Drawing.Size(103, 25);
            this.lblPassText.TabIndex = 3;
            this.lblPassText.Text = "Mật khẩu :\n";
            // 
            // txtStaffUser
            // 
            this.txtStaffUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStaffUser.Location = new System.Drawing.Point(163, 79);
            this.txtStaffUser.Multiline = true;
            this.txtStaffUser.Name = "txtStaffUser";
            this.txtStaffUser.Size = new System.Drawing.Size(361, 35);
            this.txtStaffUser.TabIndex = 2;
            // 
            // lblUserText
            // 
            this.lblUserText.AutoSize = true;
            this.lblUserText.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserText.Location = new System.Drawing.Point(3, 89);
            this.lblUserText.Name = "lblUserText";
            this.lblUserText.Size = new System.Drawing.Size(150, 25);
            this.lblUserText.TabIndex = 1;
            this.lblUserText.Text = "Tên Đăng nhập :";
            // 
            // lblAuthTitle
            // 
            this.lblAuthTitle.BackColor = System.Drawing.Color.Tomato;
            this.lblAuthTitle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthTitle.Location = new System.Drawing.Point(7, 14);
            this.lblAuthTitle.Name = "lblAuthTitle";
            this.lblAuthTitle.Size = new System.Drawing.Size(517, 51);
            this.lblAuthTitle.TabIndex = 0;
            this.lblAuthTitle.Text = "XÁC THỰC THÔNG TIN NHÂN VIÊN";
            this.lblAuthTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.White;
            this.pnlContent.Controls.Add(this.btnAttachFile);
            this.pnlContent.Controls.Add(this.txtReportContent);
            this.pnlContent.Controls.Add(this.lblReportContent);
            this.pnlContent.Controls.Add(this.txtSubject);
            this.pnlContent.Controls.Add(this.lblSubject);
            this.pnlContent.Controls.Add(this.txtRelatedBillID);
            this.pnlContent.Controls.Add(this.lblRelatedBillID);
            this.pnlContent.Controls.Add(this.cbPriority);
            this.pnlContent.Controls.Add(this.lblPriority);
            this.pnlContent.Controls.Add(this.cbReportType);
            this.pnlContent.Controls.Add(this.lblcbReportType);
            this.pnlContent.Controls.Add(this.lblReportHeader);
            this.pnlContent.Location = new System.Drawing.Point(551, -3);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(732, 669);
            this.pnlContent.TabIndex = 2;
            // 
            // btnAttachFile
            // 
            this.btnAttachFile.BackColor = System.Drawing.Color.DarkGreen;
            this.btnAttachFile.FlatAppearance.BorderSize = 0;
            this.btnAttachFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttachFile.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttachFile.ForeColor = System.Drawing.Color.White;
            this.btnAttachFile.Location = new System.Drawing.Point(577, 537);
            this.btnAttachFile.Name = "btnAttachFile";
            this.btnAttachFile.Size = new System.Drawing.Size(141, 59);
            this.btnAttachFile.TabIndex = 11;
            this.btnAttachFile.Text = "Đính kèm";
            this.btnAttachFile.UseVisualStyleBackColor = false;
            // 
            // txtReportContent
            // 
            this.txtReportContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReportContent.Location = new System.Drawing.Point(145, 302);
            this.txtReportContent.Multiline = true;
            this.txtReportContent.Name = "txtReportContent";
            this.txtReportContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReportContent.Size = new System.Drawing.Size(573, 206);
            this.txtReportContent.TabIndex = 10;
            // 
            // lblReportContent
            // 
            this.lblReportContent.AutoSize = true;
            this.lblReportContent.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportContent.Location = new System.Drawing.Point(17, 334);
            this.lblReportContent.Name = "lblReportContent";
            this.lblReportContent.Size = new System.Drawing.Size(101, 25);
            this.lblReportContent.TabIndex = 9;
            this.lblReportContent.Text = "Nội dung :";
            // 
            // txtSubject
            // 
            this.txtSubject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubject.Location = new System.Drawing.Point(145, 211);
            this.txtSubject.Multiline = true;
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(506, 54);
            this.txtSubject.TabIndex = 8;
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.Location = new System.Drawing.Point(17, 211);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(81, 25);
            this.lblSubject.TabIndex = 7;
            this.lblSubject.Text = "Chủ đề :";
            // 
            // txtRelatedBillID
            // 
            this.txtRelatedBillID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRelatedBillID.Location = new System.Drawing.Point(145, 152);
            this.txtRelatedBillID.Multiline = true;
            this.txtRelatedBillID.Name = "txtRelatedBillID";
            this.txtRelatedBillID.Size = new System.Drawing.Size(322, 35);
            this.txtRelatedBillID.TabIndex = 6;
            // 
            // lblRelatedBillID
            // 
            this.lblRelatedBillID.AutoSize = true;
            this.lblRelatedBillID.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRelatedBillID.Location = new System.Drawing.Point(18, 162);
            this.lblRelatedBillID.Name = "lblRelatedBillID";
            this.lblRelatedBillID.Size = new System.Drawing.Size(81, 25);
            this.lblRelatedBillID.TabIndex = 5;
            this.lblRelatedBillID.Text = "Mã Bill :";
            // 
            // cbPriority
            // 
            this.cbPriority.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPriority.FormattingEnabled = true;
            this.cbPriority.Location = new System.Drawing.Point(483, 81);
            this.cbPriority.Name = "cbPriority";
            this.cbPriority.Size = new System.Drawing.Size(175, 33);
            this.cbPriority.TabIndex = 4;
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriority.Location = new System.Drawing.Point(355, 89);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(85, 25);
            this.lblPriority.TabIndex = 3;
            this.lblPriority.Text = "Ưu tiên :";
            // 
            // cbReportType
            // 
            this.cbReportType.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbReportType.FormattingEnabled = true;
            this.cbReportType.Location = new System.Drawing.Point(145, 81);
            this.cbReportType.Name = "cbReportType";
            this.cbReportType.Size = new System.Drawing.Size(175, 33);
            this.cbReportType.TabIndex = 2;
            // 
            // lblcbReportType
            // 
            this.lblcbReportType.AutoSize = true;
            this.lblcbReportType.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcbReportType.Location = new System.Drawing.Point(17, 89);
            this.lblcbReportType.Name = "lblcbReportType";
            this.lblcbReportType.Size = new System.Drawing.Size(101, 25);
            this.lblcbReportType.TabIndex = 1;
            this.lblcbReportType.Text = "Phân loại :";
            // 
            // lblReportHeader
            // 
            this.lblReportHeader.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblReportHeader.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportHeader.Location = new System.Drawing.Point(17, 14);
            this.lblReportHeader.Name = "lblReportHeader";
            this.lblReportHeader.Size = new System.Drawing.Size(704, 51);
            this.lblReportHeader.TabIndex = 0;
            this.lblReportHeader.Text = "NỘI DUNG BÁO CÁO GỬI CÔNG TY CHỦ";
            this.lblReportHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlSeparator2
            // 
            this.pnlSeparator2.BackColor = System.Drawing.Color.Black;
            this.pnlSeparator2.Location = new System.Drawing.Point(0, 537);
            this.pnlSeparator2.Name = "pnlSeparator2";
            this.pnlSeparator2.Size = new System.Drawing.Size(551, 3);
            this.pnlSeparator2.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DarkGreen;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(13, 573);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(141, 68);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnSaveDraft
            // 
            this.btnSaveDraft.BackColor = System.Drawing.Color.DarkGreen;
            this.btnSaveDraft.FlatAppearance.BorderSize = 0;
            this.btnSaveDraft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveDraft.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveDraft.ForeColor = System.Drawing.Color.White;
            this.btnSaveDraft.Location = new System.Drawing.Point(207, 573);
            this.btnSaveDraft.Name = "btnSaveDraft";
            this.btnSaveDraft.Size = new System.Drawing.Size(141, 68);
            this.btnSaveDraft.TabIndex = 5;
            this.btnSaveDraft.Text = "Lưu";
            this.btnSaveDraft.UseVisualStyleBackColor = false;
            // 
            // btnSendReport
            // 
            this.btnSendReport.BackColor = System.Drawing.Color.DarkGreen;
            this.btnSendReport.FlatAppearance.BorderSize = 0;
            this.btnSendReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendReport.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendReport.ForeColor = System.Drawing.Color.White;
            this.btnSendReport.Location = new System.Drawing.Point(394, 573);
            this.btnSendReport.Name = "btnSendReport";
            this.btnSendReport.Size = new System.Drawing.Size(141, 68);
            this.btnSendReport.TabIndex = 6;
            this.btnSendReport.Text = "Gửi";
            this.btnSendReport.UseVisualStyleBackColor = false;
            // 
            // pnlSeparator3
            // 
            this.pnlSeparator3.BackColor = System.Drawing.Color.Black;
            this.pnlSeparator3.Location = new System.Drawing.Point(551, 0);
            this.pnlSeparator3.Name = "pnlSeparator3";
            this.pnlSeparator3.Size = new System.Drawing.Size(3, 666);
            this.pnlSeparator3.TabIndex = 4;
            // 
            // frmReportToServer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1284, 668);
            this.Controls.Add(this.pnlSeparator3);
            this.Controls.Add(this.btnSendReport);
            this.Controls.Add(this.btnSaveDraft);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlAuth);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmReportToServer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GỬI BÁO CÁO LÊN SERVER";
            this.pnlAuth.ResumeLayout(false);
            this.pnlAuth.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlAuth;
        private System.Windows.Forms.Label lblAuthTitle;
        private System.Windows.Forms.Label lblAuthStatus;
        private System.Windows.Forms.Panel pnlSeparator1;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.TextBox txtStaffPass;
        private System.Windows.Forms.Label lblPassText;
        private System.Windows.Forms.TextBox txtStaffUser;
        private System.Windows.Forms.Label lblUserText;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.ComboBox cbReportType;
        private System.Windows.Forms.Label lblcbReportType;
        private System.Windows.Forms.Label lblReportHeader;
        private System.Windows.Forms.ComboBox cbPriority;
        private System.Windows.Forms.Label lblReportContent;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.TextBox txtRelatedBillID;
        private System.Windows.Forms.Label lblRelatedBillID;
        private System.Windows.Forms.Button btnAttachFile;
        private System.Windows.Forms.TextBox txtReportContent;
        private System.Windows.Forms.Panel pnlSeparator2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSaveDraft;
        private System.Windows.Forms.Button btnSendReport;
        private System.Windows.Forms.Panel pnlSeparator3;
    }
}