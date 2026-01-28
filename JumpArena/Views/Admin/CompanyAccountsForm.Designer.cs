namespace YourProjectNamespace
{
    partial class CompanyAccountsForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.tblCenter = new System.Windows.Forms.TableLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblRoleFilter = new System.Windows.Forms.Label();
            this.cmbRoles = new System.Windows.Forms.ComboBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.pnlAction = new System.Windows.Forms.Panel();
            this.lblActionTitle = new System.Windows.Forms.Label();
            this.lblListTitle = new System.Windows.Forms.Label();
            this.pnlList = new System.Windows.Forms.Panel();
            this.dgvAccounts = new System.Windows.Forms.DataGridView();
            this.tblCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.pnlAction.SuspendLayout();
            this.pnlList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).BeginInit();
            this.SuspendLayout();
            // 
            // tblCenter
            // 
            this.tblCenter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblCenter.ColumnCount = 1;
            this.tblCenter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblCenter.Controls.Add(this.btnAdd, 0, 1);
            this.tblCenter.Controls.Add(this.btnEdit, 0, 2);
            this.tblCenter.Controls.Add(this.btnDelete, 0, 3);
            this.tblCenter.Controls.Add(this.lblRoleFilter, 0, 4);
            this.tblCenter.Controls.Add(this.cmbRoles, 0, 5);
            this.tblCenter.Location = new System.Drawing.Point(13, 61);
            this.tblCenter.Margin = new System.Windows.Forms.Padding(4);
            this.tblCenter.Name = "tblCenter";
            this.tblCenter.RowCount = 6;
            this.tblCenter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6F));
            this.tblCenter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tblCenter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tblCenter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tblCenter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblCenter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tblCenter.Size = new System.Drawing.Size(372, 279);
            this.tblCenter.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(12, 10);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(347, 59);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm Tài Khoản";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEdit.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(12, 77);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(347, 60);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Sửa Tài Khoản";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(12, 147);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(347, 64);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Xóa Tài Khoản";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblRoleFilter
            // 
            this.lblRoleFilter.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblRoleFilter.AutoSize = true;
            this.lblRoleFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoleFilter.Location = new System.Drawing.Point(4, 219);
            this.lblRoleFilter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoleFilter.Name = "lblRoleFilter";
            this.lblRoleFilter.Size = new System.Drawing.Size(76, 20);
            this.lblRoleFilter.TabIndex = 3;
            this.lblRoleFilter.Text = "Vai Trò:";
            // 
            // cmbRoles
            // 
            this.cmbRoles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbRoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRoles.Location = new System.Drawing.Point(4, 246);
            this.cmbRoles.Margin = new System.Windows.Forms.Padding(4);
            this.cmbRoles.Name = "cmbRoles";
            this.cmbRoles.Size = new System.Drawing.Size(364, 33);
            this.cmbRoles.TabIndex = 4;
            this.cmbRoles.SelectedIndexChanged += new System.EventHandler(this.cmbRoles_SelectedIndexChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Red;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1333, 62);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "TÀI KHOẢN CÔNG TY";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 62);
            this.splitContainerMain.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.pnlAction);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.lblListTitle);
            this.splitContainerMain.Panel2.Controls.Add(this.pnlList);
            this.splitContainerMain.Panel2.SizeChanged += new System.EventHandler(this.splitContainerMain_Panel2_SizeChanged);
            this.splitContainerMain.Size = new System.Drawing.Size(1333, 676);
            this.splitContainerMain.SplitterDistance = 399;
            this.splitContainerMain.SplitterWidth = 5;
            this.splitContainerMain.TabIndex = 1;
            // 
            // pnlAction
            // 
            this.pnlAction.Controls.Add(this.lblActionTitle);
            this.pnlAction.Controls.Add(this.tblCenter);
            this.pnlAction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAction.Location = new System.Drawing.Point(0, 0);
            this.pnlAction.Margin = new System.Windows.Forms.Padding(4);
            this.pnlAction.Name = "pnlAction";
            this.pnlAction.Size = new System.Drawing.Size(399, 676);
            this.pnlAction.TabIndex = 0;
            // 
            // lblActionTitle
            // 
            this.lblActionTitle.AutoSize = true;
            this.lblActionTitle.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActionTitle.Location = new System.Drawing.Point(13, 12);
            this.lblActionTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActionTitle.Name = "lblActionTitle";
            this.lblActionTitle.Size = new System.Drawing.Size(215, 29);
            this.lblActionTitle.TabIndex = 5;
            this.lblActionTitle.Text = "QUẢN LÝ TÁC VỤ";
            // 
            // lblListTitle
            // 
            this.lblListTitle.BackColor = System.Drawing.Color.PowderBlue;
            this.lblListTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblListTitle.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListTitle.ForeColor = System.Drawing.Color.Black;
            this.lblListTitle.Location = new System.Drawing.Point(0, 0);
            this.lblListTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblListTitle.Name = "lblListTitle";
            this.lblListTitle.Size = new System.Drawing.Size(929, 49);
            this.lblListTitle.TabIndex = 1;
            this.lblListTitle.Text = "DANH SÁCH TÀI KHOẢN";
            this.lblListTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlList
            // 
            this.pnlList.Controls.Add(this.dgvAccounts);
            this.pnlList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlList.Location = new System.Drawing.Point(0, 48);
            this.pnlList.Margin = new System.Windows.Forms.Padding(4);
            this.pnlList.Name = "pnlList";
            this.pnlList.Size = new System.Drawing.Size(929, 628);
            this.pnlList.TabIndex = 0;
            // 
            // dgvAccounts
            // 
            this.dgvAccounts.AllowUserToAddRows = false;
            this.dgvAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAccounts.Location = new System.Drawing.Point(0, 0);
            this.dgvAccounts.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAccounts.Name = "dgvAccounts";
            this.dgvAccounts.ReadOnly = true;
            this.dgvAccounts.RowHeadersWidth = 51;
            this.dgvAccounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccounts.Size = new System.Drawing.Size(929, 628);
            this.dgvAccounts.TabIndex = 0;
            // 
            // CompanyAccountsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 738);
            this.Controls.Add(this.splitContainerMain);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1061, 605);
            this.Name = "CompanyAccountsForm";
            this.Text = "Quản lý Tài Khoản Công ty";
            this.tblCenter.ResumeLayout(false);
            this.tblCenter.PerformLayout();
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.pnlAction.ResumeLayout(false);
            this.pnlAction.PerformLayout();
            this.pnlList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        // Khai báo các biến
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.Panel pnlAction;
        private System.Windows.Forms.Label lblActionTitle;
        private System.Windows.Forms.TableLayoutPanel tblCenter;
        private System.Windows.Forms.Panel pnlList;
        private System.Windows.Forms.Label lblListTitle;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvAccounts;
        private System.Windows.Forms.ComboBox cmbRoles;
        private System.Windows.Forms.Label lblRoleFilter;
    }
}