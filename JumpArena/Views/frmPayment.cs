using System;
using System.Drawing;
using System.Windows.Forms;
using System.Globalization;

namespace JumpArena.Views
{
    public partial class frmPayment : Form
    {
        private Panel pnlLeft;
        private Panel pnlRight;
        private Label lblTitle;
        private Label lblCustomer;
        private Label lblPhone;
        private DataGridView dgvPayments;
        private Panel pnlSummary;
        private Label lblTotal;
        private Label lblCollected;
        private Label lblDue;
        private Label lblChange;
        private Label lblTotalValue;
        private Label lblCollectedValue;
        private Label lblDueValue;
        private Label lblChangeValue;
        private Button btnQuick1;
        private Button btnQuick2;
        private Button btnQuick3;
        private Button btnQuick4;
        private Button btnQuick5;
        private Button[] numPadButtons;
        private Button btnBankTransfer;
        private Button btnCash;
        private Button btnCreditCard;
        private Button btnOther;
        private Button btnSubmit;
        private Button btnClose;

        private decimal currentTotal = 68730.00m;
        private decimal currentCollected = 68730.00m;

        public frmPayment()
        {
            InitializeComponent();
            Load += FrmPayment_Load;
        }

        private void FrmPayment_Load(object sender, EventArgs e)
        {
            SetupForm();
            LoadSampleData();
            UpdateSummaryValues();
        }

        private void InitializeComponent()
        {
            SuspendLayout();
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1100, 750);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmPayment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Payment";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        private void SetupForm()
        {
            int formWidth = ClientSize.Width;
            int formHeight = ClientSize.Height;

            lblTitle = new Label
            {
                Text = "Payment",
                Location = new Point(15, 15),
                Size = new Size(250, 35),
                Font = new Font("Segoe UI", 16, FontStyle.Bold)
            };
            Controls.Add(lblTitle);

            btnClose = new Button
            {
                Text = "✕",
                Size = new Size(40, 40),
                BackColor = Color.FromArgb(220, 53, 69),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand,
                Location = new Point(formWidth - 50, 10)
            };
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.Click += (s, e) => Close();
            Controls.Add(btnClose);
            btnClose.BringToFront();


            int leftPanelWidth = (int)(formWidth * 0.60);
            int rightPanelWidth = formWidth - leftPanelWidth - 30;
            int panelY = 60;
            int panelHeight = formHeight - panelY - 10;

            pnlLeft = new Panel
            {
                Location = new Point(10, panelY),
                Size = new Size(leftPanelWidth, panelHeight),
                BackColor = Color.White
            };
            Controls.Add(pnlLeft);

            lblCustomer = new Label
            {
                Text = "👤 DEFAULT CUSTOMER",
                Location = new Point(15, 15),
                Size = new Size(300, 25),
                Font = new Font("Segoe UI", 11, FontStyle.Regular),
                ForeColor = Color.FromArgb(220, 53, 69)
            };
            pnlLeft.Controls.Add(lblCustomer);

            lblPhone = new Label
            {
                Text = "📞 84123456789",
                Location = new Point(pnlLeft.Width - 160, 15),
                Size = new Size(150, 25),
                Font = new Font("Segoe UI", 10),
                ForeColor = Color.Gray
            };
            pnlLeft.Controls.Add(lblPhone);

            int dgvY = 55;
            int dgvHeight = pnlLeft.Height - dgvY - 150;
            dgvPayments = new DataGridView
            {
                Location = new Point(15, dgvY),
                Size = new Size(pnlLeft.Width - 30, dgvHeight),
                BackgroundColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                GridColor = Color.FromArgb(230, 230, 230),
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                ReadOnly = false,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                RowHeadersVisible = false,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            };
            dgvPayments.CurrentCellDirtyStateChanged += DgvPayments_CurrentCellDirtyStateChanged;

            dgvPayments.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(220, 53, 69);
            dgvPayments.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvPayments.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvPayments.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPayments.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(220, 53, 69);
            dgvPayments.ColumnHeadersHeight = 35;
            dgvPayments.EnableHeadersVisualStyles = false;
            dgvPayments.Columns.Clear();

            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn
            {
                Name = "ColX",
                HeaderText = "",
                Text = "✕",
                UseColumnTextForButtonValue = false,
                Width = 40,
                FlatStyle = FlatStyle.Flat,
            };
            deleteButton.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPayments.Columns.Add(deleteButton);

            DataGridViewTextBoxColumn noColumn = new DataGridViewTextBoxColumn
            {
                Name = "ColNo",
                HeaderText = "No.",
                Width = 40,
                ReadOnly = true
            };
            noColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPayments.Columns.Add(noColumn);

            dgvPayments.Columns.Add("PaymentMethod", "Payment Method");
            dgvPayments.Columns.Add("Amount", "Amount");
            dgvPayments.Columns.Add("CollectedAmount", "Collected Amount");
            dgvPayments.Columns.Add("Remarks", "Remarks");
            dgvPayments.Columns.Add("Ref", "Ref");

            foreach (DataGridViewColumn col in dgvPayments.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }


            dgvPayments.Columns["ColX"].Width = 40;
            dgvPayments.Columns["ColNo"].Width = 40;
            dgvPayments.Columns["PaymentMethod"].Width = 220;
            dgvPayments.Columns["Amount"].Width = 120;
            dgvPayments.Columns["CollectedAmount"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvPayments.Columns["CollectedAmount"].FillWeight = 100;
            dgvPayments.Columns["Remarks"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvPayments.Columns["Remarks"].FillWeight = 100;
            dgvPayments.Columns["Ref"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvPayments.Columns["Ref"].FillWeight = 100;

            pnlLeft.Controls.Add(dgvPayments);

            int summaryY = dgvPayments.Bottom + 10;
            pnlSummary = new Panel
            {
                Location = new Point(15, summaryY),
                Size = new Size(pnlLeft.Width - 30, 80),
                BackColor = Color.FromArgb(245, 247, 250)
            };
            pnlLeft.Controls.Add(pnlSummary);

            int internalPadding = 10;
            int gap = 5;
            int numColumns = 4;
            int totalAvailableWidth = pnlSummary.Width - internalPadding * 2 - gap * (numColumns - 1);
            int itemWidth = totalAvailableWidth / numColumns;
            int lblY = 10;
            int valY = 35;
            int labelHeight = 20;
            int valueHeight = 30;

            int x1 = internalPadding + (itemWidth + gap) * 0;
            lblTotal = new Label { Text = "Total", Location = new Point(x1, lblY), Size = new Size(itemWidth, labelHeight), Font = new Font("Segoe UI", 10) };
            lblTotalValue = new Label { Text = "0", Location = new Point(x1, valY), Size = new Size(itemWidth, valueHeight), Font = new Font("Segoe UI", 14, FontStyle.Bold) };
            pnlSummary.Controls.Add(lblTotal);
            pnlSummary.Controls.Add(lblTotalValue);

            int x2 = internalPadding + (itemWidth + gap) * 1;
            lblCollected = new Label { Text = "Collected", Location = new Point(x2, lblY), Size = new Size(itemWidth, labelHeight), Font = new Font("Segoe UI", 10) };
            lblCollectedValue = new Label { Text = "0", Location = new Point(x2, valY), Size = new Size(itemWidth, valueHeight), Font = new Font("Segoe UI", 14, FontStyle.Bold), ForeColor = Color.FromArgb(243, 156, 18) }; // Màu cam đậm
            pnlSummary.Controls.Add(lblCollected);
            pnlSummary.Controls.Add(lblCollectedValue);

            int x3 = internalPadding + (itemWidth + gap) * 2;
            lblDue = new Label { Text = "Due", Location = new Point(x3, lblY), Size = new Size(itemWidth, labelHeight), Font = new Font("Segoe UI", 10) };
            lblDueValue = new Label { Text = "0", Location = new Point(x3, valY), Size = new Size(itemWidth, valueHeight), Font = new Font("Segoe UI", 14, FontStyle.Bold) };
            pnlSummary.Controls.Add(lblDue);
            pnlSummary.Controls.Add(lblDueValue);

            int x4 = internalPadding + (itemWidth + gap) * 3;
            lblChange = new Label { Text = "Change", Location = new Point(x4, lblY), Size = new Size(itemWidth, labelHeight + 5), Font = new Font("Segoe UI", 10) };
            lblChangeValue = new Label { Text = "0", Location = new Point(x4, valY), Size = new Size(itemWidth, valueHeight), Font = new Font("Segoe UI", 14, FontStyle.Bold), ForeColor = Color.FromArgb(220, 53, 69) }; // Màu đỏ
            pnlSummary.Controls.Add(lblChange);
            pnlSummary.Controls.Add(lblChangeValue);


            int quickY = pnlSummary.Bottom + 10;
            int[] quickAmounts = { 10000, 20000, 50000, 100000, 200000 };
            Button[] quickButtons = {
                btnQuick1 = new Button(),
                btnQuick2 = new Button(),
                btnQuick3 = new Button(),
                btnQuick4 = new Button(),
                btnQuick5 = new Button()
            };

            int quickBtnWidth = (pnlLeft.Width - 30 - 4 * 10) / 5;
            for (int i = 0; i < quickButtons.Length; i++)
            {
                quickButtons[i].Location = new Point(15 + i * (quickBtnWidth + 10), quickY);
                quickButtons[i].Size = new Size(quickBtnWidth, 50);
                quickButtons[i].Text = quickAmounts[i].ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
                quickButtons[i].BackColor = Color.White;
                quickButtons[i].FlatStyle = FlatStyle.Flat;
                quickButtons[i].FlatAppearance.BorderColor = Color.FromArgb(220, 220, 220);
                quickButtons[i].Font = new Font("Segoe UI", 10);
                quickButtons[i].Cursor = Cursors.Hand;
                int amount = quickAmounts[i];
                quickButtons[i].Click += (s, e) => AddQuickAmount(amount);
                pnlLeft.Controls.Add(quickButtons[i]);
            }

            pnlRight = new Panel
            {
                Location = new Point(leftPanelWidth + 20, panelY),
                Size = new Size(rightPanelWidth, panelHeight),
                BackColor = Color.FromArgb(52, 73, 94)
            };
            Controls.Add(pnlRight);

            int btnMargin = 8;
            int panelPadding = 10;

            int totalWidth = pnlRight.Width - panelPadding * 2;
            int totalHeight = pnlRight.Height - panelPadding * 2;

            int numBtnWidth = (totalWidth - 3 * btnMargin) / 4;
            int numBtnHeight = (totalHeight - 4 * btnMargin) / 5;

            int payBtnX = panelPadding + (numBtnWidth + btnMargin) * 3;
            int payBtnWidth = numBtnWidth;

            btnBankTransfer = CreatePaymentButton("Bank_Transfer\nSALECO", payBtnX, panelPadding, Color.FromArgb(26, 188, 156), payBtnWidth, numBtnHeight);
            btnCash = CreatePaymentButton("Cash_Q2", payBtnX, panelPadding + numBtnHeight + btnMargin, Color.FromArgb(26, 188, 156), payBtnWidth, numBtnHeight);
            btnCreditCard = CreatePaymentButton("Credit Card_\nQ2", payBtnX, panelPadding + (numBtnHeight + btnMargin) * 2, Color.FromArgb(26, 188, 156), payBtnWidth, numBtnHeight);
            btnOther = CreatePaymentButton("Other", payBtnX, panelPadding + (numBtnHeight + btnMargin) * 3, Color.FromArgb(26, 188, 156), payBtnWidth, numBtnHeight);

            pnlRight.Controls.Add(btnBankTransfer);
            pnlRight.Controls.Add(btnCash);
            pnlRight.Controls.Add(btnCreditCard);
            pnlRight.Controls.Add(btnOther);

            numPadButtons = new Button[12];
            string[] numLabels = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "000", "→" };

            for (int i = 0; i < 12; i++)
            {
                int row = i / 3;
                int col = i % 3;

                int x = panelPadding + col * (numBtnWidth + btnMargin);
                int y = panelPadding + row * (numBtnHeight + btnMargin);

                numPadButtons[i] = new Button
                {
                    Location = new Point(x, y),
                    Size = new Size(numBtnWidth, numBtnHeight),
                    Text = numLabels[i],
                    BackColor = Color.FromArgb(93, 109, 126),
                    ForeColor = Color.White,
                    Font = new Font("Segoe UI", 20, FontStyle.Bold),
                    FlatStyle = FlatStyle.Flat,
                    Cursor = Cursors.Hand
                };
                numPadButtons[i].FlatAppearance.BorderSize = 0;

                string btnText = numLabels[i];
                numPadButtons[i].Click += (s, e) => NumPad_Click(btnText);
                pnlRight.Controls.Add(numPadButtons[i]);
            }

            btnSubmit = new Button
            {
                Text = "Submit",
                Location = new Point(panelPadding, panelPadding + (numBtnHeight + btnMargin) * 4),
                Size = new Size(pnlRight.Width - panelPadding * 2, numBtnHeight),
                BackColor = Color.FromArgb(22, 160, 133),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 18, FontStyle.Bold),
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            btnSubmit.FlatAppearance.BorderSize = 0;
            btnSubmit.Click += BtnSubmit_Click;
            pnlRight.Controls.Add(btnSubmit);

            PerformLayout();
        }

        private void DgvPayments_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvPayments.IsCurrentCellDirty)
            {
                dgvPayments.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private Button CreatePaymentButton(string text, int x, int y, Color color, int width, int height)
        {
            Button btn = new Button
            {
                Location = new Point(x, y),
                Size = new Size(width, height),
                Text = text,
                BackColor = color,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand,
                TextAlign = ContentAlignment.MiddleCenter
            };
            btn.FlatAppearance.BorderSize = 0;
            btn.Click += (s, e) => PaymentMethod_Click(text);
            return btn;
        }

        private void LoadSampleData()
        {
            dgvPayments.Rows.Clear();

            int rowIndex = dgvPayments.Rows.Add(
                null,
                "1",
                "VND - ZaloPay\nZalaPay",
                "68,730",
                "68,730",
                "Ref Number",
                "bdfsdgsdfgses"
            );

            dgvPayments.Rows[rowIndex].DefaultCellStyle.BackColor = Color.FromArgb(230, 247, 255);
            dgvPayments.Rows[rowIndex].DefaultCellStyle.SelectionBackColor = Color.FromArgb(180, 220, 240);
            dgvPayments.Rows[rowIndex].DefaultCellStyle.SelectionForeColor = Color.Black;

            DataGridViewButtonCell buttonCell = (DataGridViewButtonCell)dgvPayments.Rows[rowIndex].Cells["ColX"];
            buttonCell.Value = "✕";
            buttonCell.Style.BackColor = Color.FromArgb(220, 53, 69);
            buttonCell.Style.ForeColor = Color.White;
            buttonCell.Style.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            buttonCell.Style.SelectionBackColor = buttonCell.Style.BackColor;
            buttonCell.Style.SelectionForeColor = buttonCell.Style.ForeColor;
        }

        private void UpdateSummaryValues()
        {
            lblTotalValue.Text = currentTotal.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
            lblCollectedValue.Text = currentCollected.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));

            decimal due = currentTotal - currentCollected;
            decimal change = 0m;

            if (due < 0)
            {
                change = Math.Abs(due);
                due = 0m;
            }

            lblDueValue.Text = due.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
            lblChangeValue.Text = change.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
        }

        private void NumPad_Click(string value)
        {
            MessageBox.Show($"Clicked: {value}");
        }

        private void AddQuickAmount(int amount)
        {
            MessageBox.Show($"Added quick amount: {amount:N0}");
        }

        private void PaymentMethod_Click(string method)
        {
            MessageBox.Show($"Selected payment method: {method}");
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Payment submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}