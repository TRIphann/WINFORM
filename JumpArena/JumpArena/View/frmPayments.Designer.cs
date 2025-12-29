using System;
using System.Windows.Forms;
using System.Drawing;

namespace JumpArena
{
    partial class frmPayments
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.tlpQuick = new System.Windows.Forms.TableLayoutPanel();
            this.btnQuick1 = new System.Windows.Forms.Button();
            this.btnQuick2 = new System.Windows.Forms.Button();
            this.btnQuick3 = new System.Windows.Forms.Button();
            this.btnQuick4 = new System.Windows.Forms.Button();
            this.btnQuick5 = new System.Windows.Forms.Button();
            this.pnlSummary = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.lblCollected = new System.Windows.Forms.Label();
            this.lblCollectedValue = new System.Windows.Forms.Label();
            this.lblDue = new System.Windows.Forms.Label();
            this.lblChange = new System.Windows.Forms.Label();
            this.lblDueValue = new System.Windows.Forms.Label();
            this.lblChangeValue = new System.Windows.Forms.Label();
            this.dgvPayments = new System.Windows.Forms.DataGridView();
            this.ColX = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CollectedAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ref = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.tlpRight = new System.Windows.Forms.TableLayoutPanel();
            this.btnOther = new System.Windows.Forms.Button();
            this.numPadButtons12 = new System.Windows.Forms.Button();
            this.numPadButtons11 = new System.Windows.Forms.Button();
            this.numPadButtons10 = new System.Windows.Forms.Button();
            this.btnCreditCard_Q2 = new System.Windows.Forms.Button();
            this.numPadButtons9 = new System.Windows.Forms.Button();
            this.numPadButtons8 = new System.Windows.Forms.Button();
            this.numPadButtons7 = new System.Windows.Forms.Button();
            this.btnCashQ2 = new System.Windows.Forms.Button();
            this.numPadButtons6 = new System.Windows.Forms.Button();
            this.numPadButtons5 = new System.Windows.Forms.Button();
            this.numPadButtons4 = new System.Windows.Forms.Button();
            this.btnBankTransfer = new System.Windows.Forms.Button();
            this.numPadButtons3 = new System.Windows.Forms.Button();
            this.numPadButtons2 = new System.Windows.Forms.Button();
            this.numPadButtons1 = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.pnlLeft.SuspendLayout();
            this.tlpQuick.SuspendLayout();
            this.pnlSummary.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).BeginInit();
            this.pnlRight.SuspendLayout();
            this.tlpRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlLeft.BackColor = System.Drawing.Color.White;
            this.pnlLeft.Controls.Add(this.tlpQuick);
            this.pnlLeft.Controls.Add(this.pnlSummary);
            this.pnlLeft.Controls.Add(this.dgvPayments);
            this.pnlLeft.Controls.Add(this.lblPhone);
            this.pnlLeft.Controls.Add(this.lblCustomer);
            this.pnlLeft.Location = new System.Drawing.Point(10, 48);
            this.pnlLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(650, 544);
            this.pnlLeft.TabIndex = 0;
            // 
            // tlpQuick
            // 
            this.tlpQuick.ColumnCount = 5;
            this.tlpQuick.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpQuick.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpQuick.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpQuick.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpQuick.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpQuick.Controls.Add(this.btnQuick1, 0, 0);
            this.tlpQuick.Controls.Add(this.btnQuick2, 1, 0);
            this.tlpQuick.Controls.Add(this.btnQuick3, 2, 0);
            this.tlpQuick.Controls.Add(this.btnQuick4, 3, 0);
            this.tlpQuick.Controls.Add(this.btnQuick5, 4, 0);
            this.tlpQuick.Location = new System.Drawing.Point(15, 492);
            this.tlpQuick.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlpQuick.Name = "tlpQuick";
            this.tlpQuick.RowCount = 1;
            this.tlpQuick.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpQuick.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpQuick.Size = new System.Drawing.Size(620, 44);
            this.tlpQuick.TabIndex = 4;
            // 
            // btnQuick1
            // 
            this.btnQuick1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnQuick1.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnQuick1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuick1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuick1.Location = new System.Drawing.Point(3, 2);
            this.btnQuick1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQuick1.Name = "btnQuick1";
            this.btnQuick1.Size = new System.Drawing.Size(118, 40);
            this.btnQuick1.TabIndex = 0;
            this.btnQuick1.Text = "10.000";
            this.btnQuick1.UseVisualStyleBackColor = true;
            // 
            // btnQuick2
            // 
            this.btnQuick2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnQuick2.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnQuick2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuick2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuick2.Location = new System.Drawing.Point(127, 2);
            this.btnQuick2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQuick2.Name = "btnQuick2";
            this.btnQuick2.Size = new System.Drawing.Size(118, 40);
            this.btnQuick2.TabIndex = 1;
            this.btnQuick2.Text = "20.000";
            this.btnQuick2.UseVisualStyleBackColor = true;
            // 
            // btnQuick3
            // 
            this.btnQuick3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnQuick3.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnQuick3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuick3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuick3.Location = new System.Drawing.Point(251, 2);
            this.btnQuick3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQuick3.Name = "btnQuick3";
            this.btnQuick3.Size = new System.Drawing.Size(118, 40);
            this.btnQuick3.TabIndex = 2;
            this.btnQuick3.Text = "50.000";
            this.btnQuick3.UseVisualStyleBackColor = true;
            // 
            // btnQuick4
            // 
            this.btnQuick4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnQuick4.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnQuick4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuick4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuick4.Location = new System.Drawing.Point(375, 2);
            this.btnQuick4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQuick4.Name = "btnQuick4";
            this.btnQuick4.Size = new System.Drawing.Size(118, 40);
            this.btnQuick4.TabIndex = 3;
            this.btnQuick4.Text = "100.000";
            this.btnQuick4.UseVisualStyleBackColor = true;
            // 
            // btnQuick5
            // 
            this.btnQuick5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnQuick5.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnQuick5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuick5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuick5.Location = new System.Drawing.Point(499, 2);
            this.btnQuick5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQuick5.Name = "btnQuick5";
            this.btnQuick5.Size = new System.Drawing.Size(118, 40);
            this.btnQuick5.TabIndex = 4;
            this.btnQuick5.Text = "200.000";
            this.btnQuick5.UseVisualStyleBackColor = true;
            // 
            // pnlSummary
            // 
            this.pnlSummary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.pnlSummary.Controls.Add(this.tableLayoutPanel1);
            this.pnlSummary.Location = new System.Drawing.Point(15, 420);
            this.pnlSummary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlSummary.Name = "pnlSummary";
            this.pnlSummary.Size = new System.Drawing.Size(620, 64);
            this.pnlSummary.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.lblTotal, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTotalValue, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblCollected, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCollectedValue, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblDue, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblChange, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblDueValue, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblChangeValue, 3, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(620, 64);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Black;
            this.lblTotal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTotal.Location = new System.Drawing.Point(3, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(46, 23);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Total";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.AutoSize = true;
            this.lblTotalValue.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalValue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTotalValue.Location = new System.Drawing.Point(3, 32);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(27, 31);
            this.lblTotalValue.TabIndex = 1;
            this.lblTotalValue.Text = "0";
            this.lblTotalValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCollected
            // 
            this.lblCollected.AutoSize = true;
            this.lblCollected.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCollected.ForeColor = System.Drawing.Color.Black;
            this.lblCollected.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCollected.Location = new System.Drawing.Point(158, 0);
            this.lblCollected.Name = "lblCollected";
            this.lblCollected.Size = new System.Drawing.Size(81, 23);
            this.lblCollected.TabIndex = 2;
            this.lblCollected.Text = "Collected";
            this.lblCollected.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCollectedValue
            // 
            this.lblCollectedValue.AutoSize = true;
            this.lblCollectedValue.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCollectedValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.lblCollectedValue.Location = new System.Drawing.Point(158, 32);
            this.lblCollectedValue.Name = "lblCollectedValue";
            this.lblCollectedValue.Size = new System.Drawing.Size(27, 31);
            this.lblCollectedValue.TabIndex = 3;
            this.lblCollectedValue.Text = "0";
            this.lblCollectedValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDue
            // 
            this.lblDue.AutoSize = true;
            this.lblDue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDue.Location = new System.Drawing.Point(313, 0);
            this.lblDue.Name = "lblDue";
            this.lblDue.Size = new System.Drawing.Size(32, 16);
            this.lblDue.TabIndex = 4;
            this.lblDue.Text = "Due";
            this.lblDue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChange.ForeColor = System.Drawing.Color.Black;
            this.lblChange.Location = new System.Drawing.Point(468, 0);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(69, 23);
            this.lblChange.TabIndex = 5;
            this.lblChange.Text = "Change";
            this.lblChange.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDueValue
            // 
            this.lblDueValue.AutoSize = true;
            this.lblDueValue.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDueValue.ForeColor = System.Drawing.Color.Black;
            this.lblDueValue.Location = new System.Drawing.Point(313, 32);
            this.lblDueValue.Name = "lblDueValue";
            this.lblDueValue.Size = new System.Drawing.Size(27, 31);
            this.lblDueValue.TabIndex = 6;
            this.lblDueValue.Text = "0";
            this.lblDueValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblChangeValue
            // 
            this.lblChangeValue.AutoSize = true;
            this.lblChangeValue.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangeValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.lblChangeValue.Location = new System.Drawing.Point(468, 32);
            this.lblChangeValue.Name = "lblChangeValue";
            this.lblChangeValue.Size = new System.Drawing.Size(27, 31);
            this.lblChangeValue.TabIndex = 7;
            this.lblChangeValue.Text = "0";
            this.lblChangeValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvPayments
            // 
            this.dgvPayments.AllowUserToAddRows = false;
            this.dgvPayments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPayments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPayments.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPayments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColX,
            this.ColNo,
            this.PaymentMethod,
            this.Amount,
            this.CollectedAmount,
            this.Remarks,
            this.Ref});
            this.dgvPayments.EnableHeadersVisualStyles = false;
            this.dgvPayments.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dgvPayments.Location = new System.Drawing.Point(15, 44);
            this.dgvPayments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPayments.Name = "dgvPayments";
            this.dgvPayments.RowHeadersVisible = false;
            this.dgvPayments.RowHeadersWidth = 51;
            this.dgvPayments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPayments.Size = new System.Drawing.Size(620, 368);
            this.dgvPayments.TabIndex = 2;
            // 
            // ColX
            // 
            this.ColX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColX.FillWeight = 35F;
            this.ColX.HeaderText = "";
            this.ColX.MinimumWidth = 6;
            this.ColX.Name = "ColX";
            this.ColX.Text = "✕";
            this.ColX.Width = 40;
            // 
            // ColNo
            // 
            this.ColNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColNo.FillWeight = 35F;
            this.ColNo.HeaderText = "No.";
            this.ColNo.MinimumWidth = 6;
            this.ColNo.Name = "ColNo";
            this.ColNo.ReadOnly = true;
            this.ColNo.Width = 50;
            // 
            // PaymentMethod
            // 
            this.PaymentMethod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.PaymentMethod.FillWeight = 35F;
            this.PaymentMethod.HeaderText = "Payment Method";
            this.PaymentMethod.MinimumWidth = 6;
            this.PaymentMethod.Name = "PaymentMethod";
            this.PaymentMethod.Width = 220;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.MinimumWidth = 6;
            this.Amount.Name = "Amount";
            // 
            // CollectedAmount
            // 
            this.CollectedAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CollectedAmount.HeaderText = "Collected Amount";
            this.CollectedAmount.MinimumWidth = 6;
            this.CollectedAmount.Name = "CollectedAmount";
            // 
            // Remarks
            // 
            this.Remarks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Remarks.HeaderText = "Remarks";
            this.Remarks.MinimumWidth = 6;
            this.Remarks.Name = "Remarks";
            // 
            // Ref
            // 
            this.Ref.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ref.HeaderText = "Ref";
            this.Ref.MinimumWidth = 6;
            this.Ref.Name = "Ref";
            // 
            // pnlRight
            // 
            this.pnlRight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.pnlRight.Controls.Add(this.tlpRight);
            this.pnlRight.Location = new System.Drawing.Point(670, 48);
            this.pnlRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(420, 544);
            this.pnlRight.TabIndex = 1;
            // 
            // tlpRight
            // 
            this.tlpRight.ColumnCount = 4;
            this.tlpRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpRight.Controls.Add(this.btnOther, 3, 3);
            this.tlpRight.Controls.Add(this.numPadButtons12, 2, 3);
            this.tlpRight.Controls.Add(this.numPadButtons11, 1, 3);
            this.tlpRight.Controls.Add(this.numPadButtons10, 0, 3);
            this.tlpRight.Controls.Add(this.btnCreditCard_Q2, 3, 2);
            this.tlpRight.Controls.Add(this.numPadButtons9, 2, 2);
            this.tlpRight.Controls.Add(this.numPadButtons8, 1, 2);
            this.tlpRight.Controls.Add(this.numPadButtons7, 0, 2);
            this.tlpRight.Controls.Add(this.btnCashQ2, 3, 1);
            this.tlpRight.Controls.Add(this.numPadButtons6, 2, 1);
            this.tlpRight.Controls.Add(this.numPadButtons5, 1, 1);
            this.tlpRight.Controls.Add(this.numPadButtons4, 0, 1);
            this.tlpRight.Controls.Add(this.btnBankTransfer, 3, 0);
            this.tlpRight.Controls.Add(this.numPadButtons3, 2, 0);
            this.tlpRight.Controls.Add(this.numPadButtons2, 1, 0);
            this.tlpRight.Controls.Add(this.numPadButtons1, 0, 0);
            this.tlpRight.Controls.Add(this.btnSubmit, 0, 4);
            this.tlpRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRight.Location = new System.Drawing.Point(0, 0);
            this.tlpRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlpRight.Name = "tlpRight";
            this.tlpRight.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.tlpRight.RowCount = 5;
            this.tlpRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpRight.Size = new System.Drawing.Size(420, 544);
            this.tlpRight.TabIndex = 0;
            // 
            // btnOther
            // 
            this.btnOther.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.btnOther.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOther.FlatAppearance.BorderSize = 0;
            this.btnOther.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOther.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOther.ForeColor = System.Drawing.Color.White;
            this.btnOther.Location = new System.Drawing.Point(313, 325);
            this.btnOther.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOther.Name = "btnOther";
            this.btnOther.Size = new System.Drawing.Size(94, 101);
            this.btnOther.TabIndex = 15;
            this.btnOther.Text = "Other";
            this.btnOther.UseVisualStyleBackColor = false;
            // 
            // numPadButtons12
            // 
            this.numPadButtons12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(109)))), ((int)(((byte)(126)))));
            this.numPadButtons12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numPadButtons12.FlatAppearance.BorderSize = 0;
            this.numPadButtons12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numPadButtons12.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPadButtons12.ForeColor = System.Drawing.Color.White;
            this.numPadButtons12.Location = new System.Drawing.Point(213, 325);
            this.numPadButtons12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numPadButtons12.Name = "numPadButtons12";
            this.numPadButtons12.Size = new System.Drawing.Size(94, 101);
            this.numPadButtons12.TabIndex = 14;
            this.numPadButtons12.Text = "→";
            this.numPadButtons12.UseVisualStyleBackColor = false;
            // 
            // numPadButtons11
            // 
            this.numPadButtons11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(109)))), ((int)(((byte)(126)))));
            this.numPadButtons11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numPadButtons11.FlatAppearance.BorderSize = 0;
            this.numPadButtons11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numPadButtons11.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPadButtons11.ForeColor = System.Drawing.Color.White;
            this.numPadButtons11.Location = new System.Drawing.Point(113, 325);
            this.numPadButtons11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numPadButtons11.Name = "numPadButtons11";
            this.numPadButtons11.Size = new System.Drawing.Size(94, 101);
            this.numPadButtons11.TabIndex = 13;
            this.numPadButtons11.Text = "000";
            this.numPadButtons11.UseVisualStyleBackColor = false;
            // 
            // numPadButtons10
            // 
            this.numPadButtons10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(109)))), ((int)(((byte)(126)))));
            this.numPadButtons10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numPadButtons10.FlatAppearance.BorderSize = 0;
            this.numPadButtons10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numPadButtons10.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPadButtons10.ForeColor = System.Drawing.Color.White;
            this.numPadButtons10.Location = new System.Drawing.Point(13, 325);
            this.numPadButtons10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numPadButtons10.Name = "numPadButtons10";
            this.numPadButtons10.Size = new System.Drawing.Size(94, 101);
            this.numPadButtons10.TabIndex = 12;
            this.numPadButtons10.Text = "0";
            this.numPadButtons10.UseVisualStyleBackColor = false;
            // 
            // btnCreditCard_Q2
            // 
            this.btnCreditCard_Q2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.btnCreditCard_Q2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCreditCard_Q2.FlatAppearance.BorderSize = 0;
            this.btnCreditCard_Q2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreditCard_Q2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreditCard_Q2.ForeColor = System.Drawing.Color.White;
            this.btnCreditCard_Q2.Location = new System.Drawing.Point(313, 220);
            this.btnCreditCard_Q2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreditCard_Q2.Name = "btnCreditCard_Q2";
            this.btnCreditCard_Q2.Size = new System.Drawing.Size(94, 101);
            this.btnCreditCard_Q2.TabIndex = 11;
            this.btnCreditCard_Q2.Text = "Credit Card_Q2";
            this.btnCreditCard_Q2.UseVisualStyleBackColor = false;
            // 
            // numPadButtons9
            // 
            this.numPadButtons9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(109)))), ((int)(((byte)(126)))));
            this.numPadButtons9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numPadButtons9.FlatAppearance.BorderSize = 0;
            this.numPadButtons9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numPadButtons9.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPadButtons9.ForeColor = System.Drawing.Color.White;
            this.numPadButtons9.Location = new System.Drawing.Point(213, 220);
            this.numPadButtons9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numPadButtons9.Name = "numPadButtons9";
            this.numPadButtons9.Size = new System.Drawing.Size(94, 101);
            this.numPadButtons9.TabIndex = 10;
            this.numPadButtons9.Text = "9";
            this.numPadButtons9.UseVisualStyleBackColor = false;
            // 
            // numPadButtons8
            // 
            this.numPadButtons8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(109)))), ((int)(((byte)(126)))));
            this.numPadButtons8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numPadButtons8.FlatAppearance.BorderSize = 0;
            this.numPadButtons8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numPadButtons8.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPadButtons8.ForeColor = System.Drawing.Color.White;
            this.numPadButtons8.Location = new System.Drawing.Point(113, 220);
            this.numPadButtons8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numPadButtons8.Name = "numPadButtons8";
            this.numPadButtons8.Size = new System.Drawing.Size(94, 101);
            this.numPadButtons8.TabIndex = 9;
            this.numPadButtons8.Text = "8";
            this.numPadButtons8.UseVisualStyleBackColor = false;
            // 
            // numPadButtons7
            // 
            this.numPadButtons7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(109)))), ((int)(((byte)(126)))));
            this.numPadButtons7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numPadButtons7.FlatAppearance.BorderSize = 0;
            this.numPadButtons7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numPadButtons7.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPadButtons7.ForeColor = System.Drawing.Color.White;
            this.numPadButtons7.Location = new System.Drawing.Point(13, 220);
            this.numPadButtons7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numPadButtons7.Name = "numPadButtons7";
            this.numPadButtons7.Size = new System.Drawing.Size(94, 101);
            this.numPadButtons7.TabIndex = 8;
            this.numPadButtons7.Text = "7";
            this.numPadButtons7.UseVisualStyleBackColor = false;
            // 
            // btnCashQ2
            // 
            this.btnCashQ2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.btnCashQ2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCashQ2.FlatAppearance.BorderSize = 0;
            this.btnCashQ2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCashQ2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCashQ2.ForeColor = System.Drawing.Color.White;
            this.btnCashQ2.Location = new System.Drawing.Point(313, 115);
            this.btnCashQ2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCashQ2.Name = "btnCashQ2";
            this.btnCashQ2.Size = new System.Drawing.Size(94, 101);
            this.btnCashQ2.TabIndex = 7;
            this.btnCashQ2.Text = "Cash_Q2";
            this.btnCashQ2.UseVisualStyleBackColor = false;
            // 
            // numPadButtons6
            // 
            this.numPadButtons6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(109)))), ((int)(((byte)(126)))));
            this.numPadButtons6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numPadButtons6.FlatAppearance.BorderSize = 0;
            this.numPadButtons6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numPadButtons6.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPadButtons6.ForeColor = System.Drawing.Color.White;
            this.numPadButtons6.Location = new System.Drawing.Point(213, 115);
            this.numPadButtons6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numPadButtons6.Name = "numPadButtons6";
            this.numPadButtons6.Size = new System.Drawing.Size(94, 101);
            this.numPadButtons6.TabIndex = 6;
            this.numPadButtons6.Text = "6";
            this.numPadButtons6.UseVisualStyleBackColor = false;
            // 
            // numPadButtons5
            // 
            this.numPadButtons5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(109)))), ((int)(((byte)(126)))));
            this.numPadButtons5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numPadButtons5.FlatAppearance.BorderSize = 0;
            this.numPadButtons5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numPadButtons5.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPadButtons5.ForeColor = System.Drawing.Color.White;
            this.numPadButtons5.Location = new System.Drawing.Point(113, 115);
            this.numPadButtons5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numPadButtons5.Name = "numPadButtons5";
            this.numPadButtons5.Size = new System.Drawing.Size(94, 101);
            this.numPadButtons5.TabIndex = 5;
            this.numPadButtons5.Text = "5";
            this.numPadButtons5.UseVisualStyleBackColor = false;
            // 
            // numPadButtons4
            // 
            this.numPadButtons4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(109)))), ((int)(((byte)(126)))));
            this.numPadButtons4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numPadButtons4.FlatAppearance.BorderSize = 0;
            this.numPadButtons4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numPadButtons4.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPadButtons4.ForeColor = System.Drawing.Color.White;
            this.numPadButtons4.Location = new System.Drawing.Point(13, 115);
            this.numPadButtons4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numPadButtons4.Name = "numPadButtons4";
            this.numPadButtons4.Size = new System.Drawing.Size(94, 101);
            this.numPadButtons4.TabIndex = 4;
            this.numPadButtons4.Text = "4";
            this.numPadButtons4.UseVisualStyleBackColor = false;
            // 
            // btnBankTransfer
            // 
            this.btnBankTransfer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.btnBankTransfer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBankTransfer.FlatAppearance.BorderSize = 0;
            this.btnBankTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBankTransfer.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBankTransfer.ForeColor = System.Drawing.Color.White;
            this.btnBankTransfer.Location = new System.Drawing.Point(313, 10);
            this.btnBankTransfer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBankTransfer.Name = "btnBankTransfer";
            this.btnBankTransfer.Size = new System.Drawing.Size(94, 101);
            this.btnBankTransfer.TabIndex = 3;
            this.btnBankTransfer.Text = "Bank_Transfer\r\nSALECO";
            this.btnBankTransfer.UseVisualStyleBackColor = false;
            // 
            // numPadButtons3
            // 
            this.numPadButtons3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(109)))), ((int)(((byte)(126)))));
            this.numPadButtons3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numPadButtons3.FlatAppearance.BorderSize = 0;
            this.numPadButtons3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numPadButtons3.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPadButtons3.ForeColor = System.Drawing.Color.White;
            this.numPadButtons3.Location = new System.Drawing.Point(213, 10);
            this.numPadButtons3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numPadButtons3.Name = "numPadButtons3";
            this.numPadButtons3.Size = new System.Drawing.Size(94, 101);
            this.numPadButtons3.TabIndex = 2;
            this.numPadButtons3.Text = "3";
            this.numPadButtons3.UseVisualStyleBackColor = false;
            // 
            // numPadButtons2
            // 
            this.numPadButtons2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(109)))), ((int)(((byte)(126)))));
            this.numPadButtons2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numPadButtons2.FlatAppearance.BorderSize = 0;
            this.numPadButtons2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numPadButtons2.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPadButtons2.ForeColor = System.Drawing.Color.White;
            this.numPadButtons2.Location = new System.Drawing.Point(113, 10);
            this.numPadButtons2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numPadButtons2.Name = "numPadButtons2";
            this.numPadButtons2.Size = new System.Drawing.Size(94, 101);
            this.numPadButtons2.TabIndex = 1;
            this.numPadButtons2.Text = "2";
            this.numPadButtons2.UseVisualStyleBackColor = false;
            // 
            // numPadButtons1
            // 
            this.numPadButtons1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(109)))), ((int)(((byte)(126)))));
            this.numPadButtons1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numPadButtons1.FlatAppearance.BorderSize = 0;
            this.numPadButtons1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numPadButtons1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPadButtons1.ForeColor = System.Drawing.Color.White;
            this.numPadButtons1.Location = new System.Drawing.Point(13, 10);
            this.numPadButtons1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numPadButtons1.Name = "numPadButtons1";
            this.numPadButtons1.Size = new System.Drawing.Size(94, 101);
            this.numPadButtons1.TabIndex = 0;
            this.numPadButtons1.Text = "1";
            this.numPadButtons1.UseVisualStyleBackColor = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.tlpRight.SetColumnSpan(this.btnSubmit, 4);
            this.btnSubmit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(13, 430);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(394, 104);
            this.btnSubmit.TabIndex = 16;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(15, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(132, 38);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Payment";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1050, 8);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 32);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "✕";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblPhone
            // 
            this.lblPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.ForeColor = System.Drawing.Color.Gray;
            this.lblPhone.Image = global::JumpArena.Properties.Resources.icons8_phone_20;
            this.lblPhone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPhone.Location = new System.Drawing.Point(490, 12);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(131, 20);
            this.lblPhone.TabIndex = 1;
            this.lblPhone.Text = "84123456789";
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCustomer
            // 
            this.lblCustomer.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.lblCustomer.Image = global::JumpArena.Properties.Resources.icons8_customer_20;
            this.lblCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCustomer.Location = new System.Drawing.Point(15, 12);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(200, 20);
            this.lblCustomer.TabIndex = 0;
            this.lblCustomer.Text = "DEFAULT CUSTOMER";
            this.lblCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmPayments
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1100, 600);
            this.MinimumSize = new System.Drawing.Size(1100, 600);
            this.Name = "frmPayments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment";
            this.pnlLeft.ResumeLayout(false);
            this.tlpQuick.ResumeLayout(false);
            this.pnlSummary.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).EndInit();
            this.pnlRight.ResumeLayout(false);
            this.tlpRight.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel pnlLeft;
        private Label lblCustomer;
        private Panel pnlRight;
        private Label lblTitle;
        private Button btnClose;
        private Label lblPhone;
        private DataGridView dgvPayments;
        private Panel pnlSummary;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridViewButtonColumn ColX;
        private DataGridViewTextBoxColumn ColNo;
        private DataGridViewTextBoxColumn PaymentMethod;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn CollectedAmount;
        private DataGridViewTextBoxColumn Remarks;
        private DataGridViewTextBoxColumn Ref;
        private Label lblTotal;
        private Label lblTotalValue;
        private Label lblCollected;
        private Label lblCollectedValue;
        private Label lblDue;
        private Label lblChange;
        private Label lblDueValue;
        private Label lblChangeValue;
        private TableLayoutPanel tlpQuick;
        private Button btnQuick1;
        private Button btnQuick2;
        private Button btnQuick3;
        private Button btnQuick4;
        private Button btnQuick5;
        private TableLayoutPanel tlpRight;
        private Button btnOther;
        private Button numPadButtons12;
        private Button numPadButtons11;
        private Button numPadButtons10;
        private Button btnCreditCard_Q2;
        private Button numPadButtons9;
        private Button numPadButtons8;
        private Button numPadButtons7;
        private Button btnCashQ2;
        private Button numPadButtons6;
        private Button numPadButtons5;
        private Button numPadButtons4;
        private Button btnBankTransfer;
        private Button numPadButtons3;
        private Button numPadButtons2;
        private Button numPadButtons1;
        private Button btnSubmit;
    }
}