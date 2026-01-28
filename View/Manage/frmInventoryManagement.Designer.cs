namespace JumpArena
{
    partial class frmInventoryManagement
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
            this.btnCreateNewInput = new System.Windows.Forms.Button();
            this.btnRefreshInventory = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbProductGroup = new System.Windows.Forms.ComboBox();
            this.lblProductGroup = new System.Windows.Forms.Label();
            this.txtSearchProduct = new System.Windows.Forms.TextBox();
            this.lblSearchProduct = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCurrentTitle = new System.Windows.Forms.Label();
            this.dgvCurrentInventory = new System.Windows.Forms.DataGridView();
            this.btnEditStock = new System.Windows.Forms.Button();
            this.pnlPendingInputg = new System.Windows.Forms.Panel();
            this.btnInputAll = new System.Windows.Forms.Button();
            this.lblInputNote = new System.Windows.Forms.Label();
            this.dgvConfirmedItemsry = new System.Windows.Forms.DataGridView();
            this.lblPendingTitle = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentInventory)).BeginInit();
            this.pnlPendingInputg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConfirmedItemsry)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.btnCreateNewInput);
            this.pnlHeader.Controls.Add(this.btnRefreshInventory);
            this.pnlHeader.Controls.Add(this.btnSearch);
            this.pnlHeader.Controls.Add(this.cbProductGroup);
            this.pnlHeader.Controls.Add(this.lblProductGroup);
            this.pnlHeader.Controls.Add(this.txtSearchProduct);
            this.pnlHeader.Controls.Add(this.lblSearchProduct);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1257, 130);
            this.pnlHeader.TabIndex = 0;
            // 
            // btnCreateNewInput
            // 
            this.btnCreateNewInput.BackColor = System.Drawing.Color.Aqua;
            this.btnCreateNewInput.FlatAppearance.BorderSize = 0;
            this.btnCreateNewInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateNewInput.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateNewInput.Location = new System.Drawing.Point(1121, 60);
            this.btnCreateNewInput.Name = "btnCreateNewInput";
            this.btnCreateNewInput.Size = new System.Drawing.Size(118, 57);
            this.btnCreateNewInput.TabIndex = 7;
            this.btnCreateNewInput.Text = "Tạo\r\n";
            this.btnCreateNewInput.UseVisualStyleBackColor = false;
            // 
            // btnRefreshInventory
            // 
            this.btnRefreshInventory.BackColor = System.Drawing.Color.Aqua;
            this.btnRefreshInventory.FlatAppearance.BorderSize = 0;
            this.btnRefreshInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshInventory.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshInventory.Location = new System.Drawing.Point(987, 60);
            this.btnRefreshInventory.Name = "btnRefreshInventory";
            this.btnRefreshInventory.Size = new System.Drawing.Size(118, 57);
            this.btnRefreshInventory.TabIndex = 6;
            this.btnRefreshInventory.Text = "Làm mới\r\n";
            this.btnRefreshInventory.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Aqua;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(843, 60);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(118, 57);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // cbProductGroup
            // 
            this.cbProductGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProductGroup.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProductGroup.FormattingEnabled = true;
            this.cbProductGroup.Location = new System.Drawing.Point(553, 76);
            this.cbProductGroup.Name = "cbProductGroup";
            this.cbProductGroup.Size = new System.Drawing.Size(265, 33);
            this.cbProductGroup.TabIndex = 4;
            // 
            // lblProductGroup
            // 
            this.lblProductGroup.AutoSize = true;
            this.lblProductGroup.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductGroup.Location = new System.Drawing.Point(460, 76);
            this.lblProductGroup.Name = "lblProductGroup";
            this.lblProductGroup.Size = new System.Drawing.Size(57, 25);
            this.lblProductGroup.TabIndex = 3;
            this.lblProductGroup.Text = "Loại :";
            // 
            // txtSearchProduct
            // 
            this.txtSearchProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchProduct.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchProduct.Location = new System.Drawing.Point(135, 76);
            this.txtSearchProduct.Multiline = true;
            this.txtSearchProduct.Name = "txtSearchProduct";
            this.txtSearchProduct.Size = new System.Drawing.Size(292, 33);
            this.txtSearchProduct.TabIndex = 2;
            // 
            // lblSearchProduct
            // 
            this.lblSearchProduct.AutoSize = true;
            this.lblSearchProduct.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchProduct.Location = new System.Drawing.Point(29, 76);
            this.lblSearchProduct.Name = "lblSearchProduct";
            this.lblSearchProduct.Size = new System.Drawing.Size(100, 25);
            this.lblSearchProduct.TabIndex = 1;
            this.lblSearchProduct.Text = "Tìm kiếm :";
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Crimson;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1257, 38);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "QUẢN LÝ NHẬP KHO VÀ TỒN KHO";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCurrentTitle
            // 
            this.lblCurrentTitle.BackColor = System.Drawing.Color.DarkTurquoise;
            this.lblCurrentTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCurrentTitle.Location = new System.Drawing.Point(0, 142);
            this.lblCurrentTitle.Name = "lblCurrentTitle";
            this.lblCurrentTitle.Size = new System.Drawing.Size(641, 53);
            this.lblCurrentTitle.TabIndex = 1;
            this.lblCurrentTitle.Text = "TỒN KHO HIỆN TẠI";
            this.lblCurrentTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvCurrentInventory
            // 
            this.dgvCurrentInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCurrentInventory.Location = new System.Drawing.Point(0, 210);
            this.dgvCurrentInventory.Name = "dgvCurrentInventory";
            this.dgvCurrentInventory.RowHeadersWidth = 51;
            this.dgvCurrentInventory.RowTemplate.Height = 24;
            this.dgvCurrentInventory.Size = new System.Drawing.Size(641, 256);
            this.dgvCurrentInventory.TabIndex = 2;
            // 
            // btnEditStock
            // 
            this.btnEditStock.BackColor = System.Drawing.Color.Aqua;
            this.btnEditStock.FlatAppearance.BorderSize = 0;
            this.btnEditStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditStock.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditStock.Location = new System.Drawing.Point(523, 472);
            this.btnEditStock.Name = "btnEditStock";
            this.btnEditStock.Size = new System.Drawing.Size(118, 57);
            this.btnEditStock.TabIndex = 3;
            this.btnEditStock.Text = "Sửa";
            this.btnEditStock.UseVisualStyleBackColor = false;
            // 
            // pnlPendingInputg
            // 
            this.pnlPendingInputg.BackColor = System.Drawing.Color.PeachPuff;
            this.pnlPendingInputg.Controls.Add(this.btnInputAll);
            this.pnlPendingInputg.Controls.Add(this.lblInputNote);
            this.pnlPendingInputg.Controls.Add(this.dgvConfirmedItemsry);
            this.pnlPendingInputg.Controls.Add(this.lblPendingTitle);
            this.pnlPendingInputg.Location = new System.Drawing.Point(647, 135);
            this.pnlPendingInputg.Name = "pnlPendingInputg";
            this.pnlPendingInputg.Size = new System.Drawing.Size(610, 402);
            this.pnlPendingInputg.TabIndex = 4;
            // 
            // btnInputAll
            // 
            this.btnInputAll.BackColor = System.Drawing.Color.Aqua;
            this.btnInputAll.FlatAppearance.BorderSize = 0;
            this.btnInputAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInputAll.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInputAll.Location = new System.Drawing.Point(453, 337);
            this.btnInputAll.Name = "btnInputAll";
            this.btnInputAll.Size = new System.Drawing.Size(118, 57);
            this.btnInputAll.TabIndex = 3;
            this.btnInputAll.Text = "Kết thúc\r\n";
            this.btnInputAll.UseVisualStyleBackColor = false;
            // 
            // lblInputNote
            // 
            this.lblInputNote.AutoSize = true;
            this.lblInputNote.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputNote.Location = new System.Drawing.Point(51, 349);
            this.lblInputNote.Name = "lblInputNote";
            this.lblInputNote.Size = new System.Drawing.Size(87, 25);
            this.lblInputNote.TabIndex = 2;
            this.lblInputNote.Text = "Ghi chú :";
            // 
            // dgvConfirmedItemsry
            // 
            this.dgvConfirmedItemsry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConfirmedItemsry.Location = new System.Drawing.Point(51, 75);
            this.dgvConfirmedItemsry.Name = "dgvConfirmedItemsry";
            this.dgvConfirmedItemsry.RowHeadersWidth = 51;
            this.dgvConfirmedItemsry.RowTemplate.Height = 24;
            this.dgvConfirmedItemsry.Size = new System.Drawing.Size(520, 256);
            this.dgvConfirmedItemsry.TabIndex = 1;
            // 
            // lblPendingTitle
            // 
            this.lblPendingTitle.BackColor = System.Drawing.Color.ForestGreen;
            this.lblPendingTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPendingTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPendingTitle.Location = new System.Drawing.Point(45, 7);
            this.lblPendingTitle.Name = "lblPendingTitle";
            this.lblPendingTitle.Size = new System.Drawing.Size(526, 53);
            this.lblPendingTitle.TabIndex = 0;
            this.lblPendingTitle.Text = "MẶT HÀNG XÁC NHẬN";
            this.lblPendingTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmInventoryManagement
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1258, 538);
            this.Controls.Add(this.pnlPendingInputg);
            this.Controls.Add(this.btnEditStock);
            this.Controls.Add(this.dgvCurrentInventory);
            this.Controls.Add(this.lblCurrentTitle);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmInventoryManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ TỒN KHO";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentInventory)).EndInit();
            this.pnlPendingInputg.ResumeLayout(false);
            this.pnlPendingInputg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConfirmedItemsry)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSearchProduct;
        private System.Windows.Forms.Button btnCreateNewInput;
        private System.Windows.Forms.Button btnRefreshInventory;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cbProductGroup;
        private System.Windows.Forms.Label lblProductGroup;
        private System.Windows.Forms.TextBox txtSearchProduct;
        private System.Windows.Forms.Label lblCurrentTitle;
        private System.Windows.Forms.DataGridView dgvCurrentInventory;
        private System.Windows.Forms.Button btnEditStock;
        private System.Windows.Forms.Panel pnlPendingInputg;
        private System.Windows.Forms.Button btnInputAll;
        private System.Windows.Forms.Label lblInputNote;
        private System.Windows.Forms.DataGridView dgvConfirmedItemsry;
        private System.Windows.Forms.Label lblPendingTitle;
    }
}