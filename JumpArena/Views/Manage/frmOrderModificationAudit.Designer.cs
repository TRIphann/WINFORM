namespace JumpArena
{
    partial class frmOrderModificationAudit
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblBillID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCreationTime = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblReasonTitle = new System.Windows.Forms.Label();
            this.lblModificationType = new System.Windows.Forms.Label();
            this.cbModificationType = new System.Windows.Forms.ComboBox();
            this.lblPresetReason = new System.Windows.Forms.Label();
            this.cbPresetReason = new System.Windows.Forms.ComboBox();
            this.lblReasonDetail = new System.Windows.Forms.Label();
            this.txtReasonDetail = new System.Windows.Forms.TextBox();
            this.pnlAuthDetails = new System.Windows.Forms.Panel();
            this.lblAuthTitle = new System.Windows.Forms.Label();
            this.lblManagerUser = new System.Windows.Forms.Label();
            this.lblManagerPass = new System.Windows.Forms.Label();
            this.lblAuthStatus = new System.Windows.Forms.Label();
            this.txtManagerUser = new System.Windows.Forms.TextBox();
            this.txtManagerPass = new System.Windows.Forms.TextBox();
            this.btnVerifyManager = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlActions = new System.Windows.Forms.Panel();
            this.btnProceedToModify = new System.Windows.Forms.Button();
            this.btnDeleteBill = new System.Windows.Forms.Button();
            this.btnViewPreviousLogs = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlAuthDetails.SuspendLayout();
            this.pnlActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.lblCreationTime);
            this.pnlHeader.Controls.Add(this.label3);
            this.pnlHeader.Controls.Add(this.label2);
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Controls.Add(this.lblBillID);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1266, 130);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Crimson;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1266, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "XÁC NHẬN/KHAI BÁO SỬA ĐỔI ĐƠN HÀNG";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBillID
            // 
            this.lblBillID.AutoSize = true;
            this.lblBillID.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillID.Location = new System.Drawing.Point(22, 57);
            this.lblBillID.Name = "lblBillID";
            this.lblBillID.Size = new System.Drawing.Size(81, 25);
            this.lblBillID.TabIndex = 1;
            this.lblBillID.Text = "Mã Bill :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(346, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Thời gian Tối đa :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(710, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nhân viên bán hàng :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tổng tiền Bill Cũ :";
            // 
            // lblCreationTime
            // 
            this.lblCreationTime.AutoSize = true;
            this.lblCreationTime.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreationTime.Location = new System.Drawing.Point(339, 95);
            this.lblCreationTime.Name = "lblCreationTime";
            this.lblCreationTime.Size = new System.Drawing.Size(167, 25);
            this.lblCreationTime.TabIndex = 5;
            this.lblCreationTime.Text = "Thời gian tạo Bill :\n";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtReasonDetail);
            this.panel2.Controls.Add(this.lblReasonDetail);
            this.panel2.Controls.Add(this.cbPresetReason);
            this.panel2.Controls.Add(this.lblPresetReason);
            this.panel2.Controls.Add(this.cbModificationType);
            this.panel2.Controls.Add(this.lblModificationType);
            this.panel2.Controls.Add(this.lblReasonTitle);
            this.panel2.Location = new System.Drawing.Point(3, 136);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(634, 358);
            this.panel2.TabIndex = 1;
            // 
            // lblReasonTitle
            // 
            this.lblReasonTitle.BackColor = System.Drawing.Color.HotPink;
            this.lblReasonTitle.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReasonTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblReasonTitle.Location = new System.Drawing.Point(26, 10);
            this.lblReasonTitle.Name = "lblReasonTitle";
            this.lblReasonTitle.Size = new System.Drawing.Size(561, 45);
            this.lblReasonTitle.TabIndex = 0;
            this.lblReasonTitle.Text = "LÝ DO THAY ĐỔI / XÓA BILL";
            this.lblReasonTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblModificationType
            // 
            this.lblModificationType.AutoSize = true;
            this.lblModificationType.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificationType.Location = new System.Drawing.Point(26, 74);
            this.lblModificationType.Name = "lblModificationType";
            this.lblModificationType.Size = new System.Drawing.Size(57, 25);
            this.lblModificationType.TabIndex = 1;
            this.lblModificationType.Text = "Loại :";
            // 
            // cbModificationType
            // 
            this.cbModificationType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModificationType.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbModificationType.FormattingEnabled = true;
            this.cbModificationType.Location = new System.Drawing.Point(129, 63);
            this.cbModificationType.Name = "cbModificationType";
            this.cbModificationType.Size = new System.Drawing.Size(361, 33);
            this.cbModificationType.TabIndex = 2;
            // 
            // lblPresetReason
            // 
            this.lblPresetReason.AutoSize = true;
            this.lblPresetReason.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresetReason.Location = new System.Drawing.Point(26, 123);
            this.lblPresetReason.Name = "lblPresetReason";
            this.lblPresetReason.Size = new System.Drawing.Size(67, 25);
            this.lblPresetReason.TabIndex = 3;
            this.lblPresetReason.Text = "Lý do :";
            // 
            // cbPresetReason
            // 
            this.cbPresetReason.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPresetReason.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPresetReason.FormattingEnabled = true;
            this.cbPresetReason.Location = new System.Drawing.Point(129, 115);
            this.cbPresetReason.Name = "cbPresetReason";
            this.cbPresetReason.Size = new System.Drawing.Size(361, 33);
            this.cbPresetReason.TabIndex = 4;
            // 
            // lblReasonDetail
            // 
            this.lblReasonDetail.AutoSize = true;
            this.lblReasonDetail.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReasonDetail.Location = new System.Drawing.Point(26, 167);
            this.lblReasonDetail.Name = "lblReasonDetail";
            this.lblReasonDetail.Size = new System.Drawing.Size(83, 25);
            this.lblReasonDetail.TabIndex = 5;
            this.lblReasonDetail.Text = "Chi tiết :";
            // 
            // txtReasonDetail
            // 
            this.txtReasonDetail.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReasonDetail.Location = new System.Drawing.Point(129, 167);
            this.txtReasonDetail.Multiline = true;
            this.txtReasonDetail.Name = "txtReasonDetail";
            this.txtReasonDetail.Size = new System.Drawing.Size(361, 166);
            this.txtReasonDetail.TabIndex = 6;
            // 
            // pnlAuthDetails
            // 
            this.pnlAuthDetails.Controls.Add(this.btnVerifyManager);
            this.pnlAuthDetails.Controls.Add(this.txtManagerPass);
            this.pnlAuthDetails.Controls.Add(this.txtManagerUser);
            this.pnlAuthDetails.Controls.Add(this.lblAuthStatus);
            this.pnlAuthDetails.Controls.Add(this.lblManagerPass);
            this.pnlAuthDetails.Controls.Add(this.lblManagerUser);
            this.pnlAuthDetails.Controls.Add(this.lblAuthTitle);
            this.pnlAuthDetails.Location = new System.Drawing.Point(652, 136);
            this.pnlAuthDetails.Name = "pnlAuthDetails";
            this.pnlAuthDetails.Size = new System.Drawing.Size(614, 244);
            this.pnlAuthDetails.TabIndex = 2;
            // 
            // lblAuthTitle
            // 
            this.lblAuthTitle.BackColor = System.Drawing.Color.HotPink;
            this.lblAuthTitle.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAuthTitle.Location = new System.Drawing.Point(23, 10);
            this.lblAuthTitle.Name = "lblAuthTitle";
            this.lblAuthTitle.Size = new System.Drawing.Size(515, 45);
            this.lblAuthTitle.TabIndex = 0;
            this.lblAuthTitle.Text = "THÔNG TIN XÁC THỰC QUẢN LÝ";
            this.lblAuthTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblManagerUser
            // 
            this.lblManagerUser.AutoSize = true;
            this.lblManagerUser.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManagerUser.Location = new System.Drawing.Point(23, 71);
            this.lblManagerUser.Name = "lblManagerUser";
            this.lblManagerUser.Size = new System.Drawing.Size(150, 25);
            this.lblManagerUser.TabIndex = 1;
            this.lblManagerUser.Text = "Tên Đăng nhập :";
            // 
            // lblManagerPass
            // 
            this.lblManagerPass.AutoSize = true;
            this.lblManagerPass.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManagerPass.Location = new System.Drawing.Point(23, 132);
            this.lblManagerPass.Name = "lblManagerPass";
            this.lblManagerPass.Size = new System.Drawing.Size(103, 25);
            this.lblManagerPass.TabIndex = 2;
            this.lblManagerPass.Text = "Mật khẩu :";
            // 
            // lblAuthStatus
            // 
            this.lblAuthStatus.AutoSize = true;
            this.lblAuthStatus.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthStatus.Location = new System.Drawing.Point(23, 192);
            this.lblAuthStatus.Name = "lblAuthStatus";
            this.lblAuthStatus.Size = new System.Drawing.Size(109, 25);
            this.lblAuthStatus.TabIndex = 3;
            this.lblAuthStatus.Text = "Trạng thái :";
            // 
            // txtManagerUser
            // 
            this.txtManagerUser.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManagerUser.Location = new System.Drawing.Point(179, 71);
            this.txtManagerUser.Multiline = true;
            this.txtManagerUser.Name = "txtManagerUser";
            this.txtManagerUser.Size = new System.Drawing.Size(359, 34);
            this.txtManagerUser.TabIndex = 4;
            // 
            // txtManagerPass
            // 
            this.txtManagerPass.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManagerPass.Location = new System.Drawing.Point(179, 123);
            this.txtManagerPass.Multiline = true;
            this.txtManagerPass.Name = "txtManagerPass";
            this.txtManagerPass.Size = new System.Drawing.Size(359, 34);
            this.txtManagerPass.TabIndex = 5;
            // 
            // btnVerifyManager
            // 
            this.btnVerifyManager.BackColor = System.Drawing.Color.Aqua;
            this.btnVerifyManager.FlatAppearance.BorderSize = 0;
            this.btnVerifyManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerifyManager.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerifyManager.Location = new System.Drawing.Point(420, 176);
            this.btnVerifyManager.Name = "btnVerifyManager";
            this.btnVerifyManager.Size = new System.Drawing.Size(118, 57);
            this.btnVerifyManager.TabIndex = 6;
            this.btnVerifyManager.Text = "LOGIN";
            this.btnVerifyManager.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(680, 386);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(614, 3);
            this.panel1.TabIndex = 3;
            // 
            // pnlActions
            // 
            this.pnlActions.Controls.Add(this.btnCancel);
            this.pnlActions.Controls.Add(this.btnViewPreviousLogs);
            this.pnlActions.Controls.Add(this.btnDeleteBill);
            this.pnlActions.Controls.Add(this.btnProceedToModify);
            this.pnlActions.Location = new System.Drawing.Point(667, 395);
            this.pnlActions.Name = "pnlActions";
            this.pnlActions.Size = new System.Drawing.Size(605, 109);
            this.pnlActions.TabIndex = 4;
            // 
            // btnProceedToModify
            // 
            this.btnProceedToModify.BackColor = System.Drawing.Color.Aqua;
            this.btnProceedToModify.FlatAppearance.BorderSize = 0;
            this.btnProceedToModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProceedToModify.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProceedToModify.Location = new System.Drawing.Point(18, 32);
            this.btnProceedToModify.Name = "btnProceedToModify";
            this.btnProceedToModify.Size = new System.Drawing.Size(118, 57);
            this.btnProceedToModify.TabIndex = 0;
            this.btnProceedToModify.Text = "Fix";
            this.btnProceedToModify.UseVisualStyleBackColor = false;
            // 
            // btnDeleteBill
            // 
            this.btnDeleteBill.BackColor = System.Drawing.Color.Aqua;
            this.btnDeleteBill.FlatAppearance.BorderSize = 0;
            this.btnDeleteBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteBill.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteBill.Location = new System.Drawing.Point(170, 32);
            this.btnDeleteBill.Name = "btnDeleteBill";
            this.btnDeleteBill.Size = new System.Drawing.Size(118, 57);
            this.btnDeleteBill.TabIndex = 1;
            this.btnDeleteBill.Text = "Delete";
            this.btnDeleteBill.UseVisualStyleBackColor = false;
            // 
            // btnViewPreviousLogs
            // 
            this.btnViewPreviousLogs.BackColor = System.Drawing.Color.Aqua;
            this.btnViewPreviousLogs.FlatAppearance.BorderSize = 0;
            this.btnViewPreviousLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewPreviousLogs.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewPreviousLogs.Location = new System.Drawing.Point(327, 32);
            this.btnViewPreviousLogs.Name = "btnViewPreviousLogs";
            this.btnViewPreviousLogs.Size = new System.Drawing.Size(118, 57);
            this.btnViewPreviousLogs.TabIndex = 2;
            this.btnViewPreviousLogs.Text = "View";
            this.btnViewPreviousLogs.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Aqua;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(463, 32);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(118, 57);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // frmOrderModificationAudit
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1266, 526);
            this.Controls.Add(this.pnlActions);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlAuthDetails);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmOrderModificationAudit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NHẬT KÝ CHỈNH SỬA ĐƠN HÀNG";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlAuthDetails.ResumeLayout(false);
            this.pnlAuthDetails.PerformLayout();
            this.pnlActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCreationTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBillID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblReasonTitle;
        private System.Windows.Forms.TextBox txtReasonDetail;
        private System.Windows.Forms.Label lblReasonDetail;
        private System.Windows.Forms.ComboBox cbPresetReason;
        private System.Windows.Forms.Label lblPresetReason;
        private System.Windows.Forms.ComboBox cbModificationType;
        private System.Windows.Forms.Label lblModificationType;
        private System.Windows.Forms.Panel pnlAuthDetails;
        private System.Windows.Forms.Button btnVerifyManager;
        private System.Windows.Forms.TextBox txtManagerPass;
        private System.Windows.Forms.TextBox txtManagerUser;
        private System.Windows.Forms.Label lblAuthStatus;
        private System.Windows.Forms.Label lblManagerPass;
        private System.Windows.Forms.Label lblManagerUser;
        private System.Windows.Forms.Label lblAuthTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlActions;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnViewPreviousLogs;
        private System.Windows.Forms.Button btnDeleteBill;
        private System.Windows.Forms.Button btnProceedToModify;
    }
}