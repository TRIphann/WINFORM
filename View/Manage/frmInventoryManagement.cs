using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace JumpArena
{
    public partial class frmInventoryManagement : Form
    {
        private readonly string _cs;

        private readonly Image _warnIcon = SystemIcons.Warning.ToBitmap();

        private int _lowStockThreshold = 10;
        private void dgv_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Nuốt lỗi format, không hiện popup "DataGridView Default Error Dialog"
            e.ThrowException = false;
            e.Cancel = true;
        }

        public frmInventoryManagement()
        {
            InitializeComponent();

            _cs = System.Configuration.ConfigurationManager
                .ConnectionStrings["JumpArenaContextDB"].ConnectionString;

            // 100% tiếng Việt
            btnSearch.Text = "Tìm";
            btnRefreshInventory.Text = "Làm mới";
            btnCreateNewInput.Text = "Tạo";
            btnEditStock.Text = "Sửa";
            btnInputAll.Text = "Kết thúc";

            SetupCurrentInventoryGrid();
            SetupConfirmGrid();

            LoadCategoriesToCombo();
            LoadCurrentInventory();         // load lần đầu + tô đỏ + icon + header đỏ + popup

            // Events
            btnRefreshInventory.Click += (s, e) => LoadCurrentInventory(true);
            btnSearch.Click += (s, e) => LoadCurrentInventory(true);
            txtSearchProduct.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    e.SuppressKeyPress = true;
                    LoadCurrentInventory(true);
                }
            };
            cbProductGroup.SelectedIndexChanged += (s, e) => LoadCurrentInventory(true);

            btnCreateNewInput.Click += btnCreateNewInput_Click;
            btnInputAll.Click += btnInputAll_Click;

            // Format
            dgvCurrentInventory.CellFormatting += dgvCurrentInventory_CellFormatting;

            // FIX: bắt lỗi format để không bật popup mặc định
            dgvCurrentInventory.DataError += dgv_DataError;
            dgvConfirmedItemsry.DataError += dgv_DataError;
        }


        // =========================
        // 1) Load danh sách loại sản phẩm từ DB vào combobox
        // =========================
        private void LoadCategoriesToCombo()
        {
            using (var conn = new SqlConnection(_cs))
            using (var cmd = new SqlCommand(@"
SELECT CategoryID, CategoryName
FROM Category
ORDER BY CategoryName
", conn))
            using (var da = new SqlDataAdapter(cmd))
            {
                var dt = new DataTable();
                conn.Open();
                da.Fill(dt);

                // Nếu DB trả CategoryID kiểu string (bậy), ép về int để SelectedValue luôn là int
                if (dt.Columns["CategoryID"].DataType != typeof(int))
                {
                    var fixedDt = dt.Clone();
                    fixedDt.Columns["CategoryID"].DataType = typeof(int);

                    foreach (DataRow r in dt.Rows)
                    {
                        var nr = fixedDt.NewRow();
                        int cid = 0;
                        int.TryParse(r["CategoryID"]?.ToString(), out cid);
                        nr["CategoryID"] = cid;
                        nr["CategoryName"] = r["CategoryName"]?.ToString();
                        fixedDt.Rows.Add(nr);
                    }
                    dt = fixedDt;
                }

                var allRow = dt.NewRow();
                allRow["CategoryID"] = 0;
                allRow["CategoryName"] = "Tất cả";
                dt.Rows.InsertAt(allRow, 0);

                cbProductGroup.DisplayMember = "CategoryName";
                cbProductGroup.ValueMember = "CategoryID";
                cbProductGroup.DataSource = dt;
                cbProductGroup.SelectedIndex = 0;
            }
        }


        // =========================
        // 2) Setup grids
        // =========================
        private void SetupCurrentInventoryGrid()
        {
            dgvCurrentInventory.AutoGenerateColumns = false;
            dgvCurrentInventory.AllowUserToAddRows = false;
            dgvCurrentInventory.RowHeadersVisible = false;
            dgvCurrentInventory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCurrentInventory.MultiSelect = false;
            dgvCurrentInventory.ReadOnly = true;

            dgvCurrentInventory.Columns.Clear();
            dgvCurrentInventory.CellDoubleClick += (s, e) =>
            {
                if (e.RowIndex < 0) return;
                btnCreateNewInput_Click(btnCreateNewInput, EventArgs.Empty);
            };

            // Icon cảnh báo
            var colWarn = new DataGridViewImageColumn
            {
                Name = "Warn",
                HeaderText = "",
                Width = 30,
                ImageLayout = DataGridViewImageCellLayout.Zoom
            };
            dgvCurrentInventory.Columns.Add(colWarn);

            dgvCurrentInventory.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ProductID",
                HeaderText = "Mã",
                DataPropertyName = "ProductID",
                Width = 60,
                ValueType = typeof(int)
            });

            dgvCurrentInventory.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ProductName",
                HeaderText = "Sản phẩm",
                DataPropertyName = "ProductName",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                ValueType = typeof(string)
            });

            dgvCurrentInventory.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "CategoryName",
                HeaderText = "Loại",
                DataPropertyName = "CategoryName",
                Width = 160,
                ValueType = typeof(string)
            });

            dgvCurrentInventory.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "StockQuantity",
                HeaderText = "Tồn kho",
                DataPropertyName = "StockQuantity",
                Width = 90,
                ValueType = typeof(int),
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleRight }
            });
        }


        private void SetupConfirmGrid()
        {
            dgvConfirmedItemsry.AutoGenerateColumns = false;
            dgvConfirmedItemsry.AllowUserToAddRows = false;
            dgvConfirmedItemsry.RowHeadersVisible = false;
            dgvConfirmedItemsry.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvConfirmedItemsry.MultiSelect = true;

            dgvConfirmedItemsry.Columns.Clear();

            dgvConfirmedItemsry.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ProductID",
                HeaderText = "Mã",
                DataPropertyName = "ProductID",
                Width = 60,
                ReadOnly = true
            });

            dgvConfirmedItemsry.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ProductName",
                HeaderText = "Sản phẩm",
                DataPropertyName = "ProductName",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                ReadOnly = true
            });

            dgvConfirmedItemsry.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "CategoryName",
                HeaderText = "Loại",
                DataPropertyName = "CategoryName",
                Width = 160,
                ReadOnly = true
            });

            // Nhập số lượng thêm
            dgvConfirmedItemsry.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "AddQty",
                HeaderText = "Số lượng thêm",
                DataPropertyName = "AddQty",
                Width = 120,
                ReadOnly = false
            });

            // Nút xóa dòng (lỡ chọn sai)
            var colDel = new DataGridViewButtonColumn
            {
                Name = "DeleteRow",
                HeaderText = "",
                Text = "Xóa",
                UseColumnTextForButtonValue = true,
                Width = 60
            };
            dgvConfirmedItemsry.Columns.Add(colDel);

            dgvConfirmedItemsry.CellClick += dgvConfirmedItemsry_CellClick;
            dgvConfirmedItemsry.EditingControlShowing += dgvConfirmedItemsry_EditingControlShowing;
        }

        // Chỉ cho nhập số trong cột AddQty
        private void dgvConfirmedItemsry_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvConfirmedItemsry.CurrentCell == null) return;
            if (dgvConfirmedItemsry.CurrentCell.OwningColumn?.Name != "AddQty") return;

            if (e.Control is TextBox tb)
            {
                tb.KeyPress -= OnlyNumber_KeyPress;
                tb.KeyPress += OnlyNumber_KeyPress;
            }
        }

        private void OnlyNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) return;
            if (!char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void dgvConfirmedItemsry_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvConfirmedItemsry.Columns[e.ColumnIndex].Name == "DeleteRow")
            {
                dgvConfirmedItemsry.Rows.RemoveAt(e.RowIndex);
            }
        }

        // =========================
        // 3) Load “Tồn kho hiện tại” từ DB, đưa <10 lên đầu, tô đỏ dòng, icon cảnh báo
        // 4) Header “TỒN KHO HIỆN TẠI” tự đổi đỏ khi có bất kỳ <10
        // 5) Popup cảnh báo tồn kho thấp
        // 6) Ẩn StockQuantity cho vé (vé không quản tồn)
        // 7) Search theo tên + filter theo loại
        // =========================
        private bool IsStockManagedRow(DataRow row)
        {
            if (row == null) return true;
            object v = row["IsStockManaged"];
            if (v == null || v == DBNull.Value) return true;
            return Convert.ToBoolean(v);
        }
        private void LoadCurrentInventory(bool showPopupIfLow = false)
        {
            int cateId = 0;

            // Ép kiểu an toàn (tránh SelectedValue là string)
            if (cbProductGroup.SelectedValue != null)
                int.TryParse(cbProductGroup.SelectedValue.ToString(), out cateId);

            string kw = (txtSearchProduct.Text ?? "").Trim();

            using (var conn = new SqlConnection(_cs))
            using (var cmd = new SqlCommand(@"
SELECT p.ProductID, p.ProductName, c.CategoryName, p.StockQuantity, p.IsStockManaged

FROM Product p
JOIN Category c ON p.CategoryID = c.CategoryID
WHERE (@cateId = 0 OR p.CategoryID = @cateId)
  AND (@kw = N'' OR p.ProductName LIKE N'%' + @kw + N'%')
ORDER BY
    CASE
        WHEN c.CategoryName LIKE N'%Vé%' THEN 2
        WHEN ISNULL(p.StockQuantity, 0) < @low THEN 0
        ELSE 1
    END,
    CASE
        WHEN c.CategoryName LIKE N'%Vé%' THEN 999999
        ELSE ISNULL(p.StockQuantity, 0)
    END,
    p.ProductName
", conn))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.Parameters.Add("@cateId", SqlDbType.Int).Value = cateId;
                cmd.Parameters.Add("@kw", SqlDbType.NVarChar, 200).Value = kw;
                cmd.Parameters.Add("@low", SqlDbType.Int).Value = _lowStockThreshold;

                var dt = new DataTable();
                conn.Open();
                da.Fill(dt);

                dgvCurrentInventory.DataSource = dt;
                ApplyInventoryStylesAndHeader(dt, showPopupIfLow);
            }
        }


        private void ApplyInventoryStylesAndHeader(DataTable dt, bool showPopupIfLow)
        {
            // Tìm các hàng <10 nhưng KHÔNG phải vé
            var lowRows = dt.AsEnumerable()
                .Where(r => !IsTicket(r["CategoryName"]?.ToString()))
                .Where(r => SafeInt(r["StockQuantity"]) < _lowStockThreshold)
                .ToList();

            bool hasLow = lowRows.Any();

            // Header đỏ nếu có low
            lblCurrentTitle.BackColor = hasLow ? Color.Crimson : Color.DarkTurquoise;

            // Ẩn cột tồn kho nếu là vé -> làm bằng CellFormatting (ẩn từng cell)
            // Tô đỏ cả dòng, icon cảnh báo cho low
            if (showPopupIfLow && hasLow)
            {
                // Popup liệt kê hàng sắp hết
                var msg = string.Join(Environment.NewLine,
                    lowRows.Select(r => $"- {r["ProductName"]} (tồn: {SafeInt(r["StockQuantity"])})"));

                MessageBox.Show(
                    "CẢNH BÁO: Có sản phẩm tồn kho thấp (<10):\n\n" + msg,
                    "Tồn kho thấp",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        private void dgvCurrentInventory_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvCurrentInventory.Rows[e.RowIndex];
            var dtRow = (row.DataBoundItem as DataRowView)?.Row;
            if (dtRow == null) return;

            string cateName = dtRow["CategoryName"]?.ToString();
            bool isTicket = IsTicket(cateName);
            int stock = SafeInt(dtRow["StockQuantity"]);

            // Ẩn StockQuantity cho vé
            if (dgvCurrentInventory.Columns[e.ColumnIndex].Name == "StockQuantity")
            {
                if (isTicket)
                {
                    e.Value = ""; // trống
                    e.FormattingApplied = true;
                }
            }

            bool isLow = (!isTicket && stock < _lowStockThreshold);

            // Icon cảnh báo
            if (dgvCurrentInventory.Columns[e.ColumnIndex].Name == "Warn")
            {
                e.Value = isLow ? _warnIcon : null;
                e.FormattingApplied = true;
            }

            // Tô đỏ cả dòng nếu low
            if (isLow)
            {
                row.DefaultCellStyle.ForeColor = Color.Crimson;
                row.DefaultCellStyle.SelectionForeColor = Color.Crimson;
                row.DefaultCellStyle.Font = new Font(dgvCurrentInventory.Font, FontStyle.Bold);
            }
            else
            {
                row.DefaultCellStyle.ForeColor = dgvCurrentInventory.DefaultCellStyle.ForeColor;
                row.DefaultCellStyle.SelectionForeColor = dgvCurrentInventory.DefaultCellStyle.SelectionForeColor;
                row.DefaultCellStyle.Font = dgvCurrentInventory.Font;
            }
        }

        private bool IsTicket(string categoryName)
        {
            // Bạn có CategoryID vé riêng thì đổi sang check CategoryID là chuẩn nhất.
            return !string.IsNullOrWhiteSpace(categoryName) &&
                   categoryName.IndexOf("vé", StringComparison.OrdinalIgnoreCase) >= 0;
        }

        private int SafeInt(object v)
        {
            if (v == null || v == DBNull.Value) return 0;
            int.TryParse(v.ToString(), out int x);
            return x;
        }

        // =========================
        // 8) Bấm Tạo (Create) để đưa sản phẩm qua “Mặt hàng xác nhận”
        // =========================
        private void btnCreateNewInput_Click(object sender, EventArgs e)
        {
            if (!(dgvCurrentInventory.DataSource is DataTable dt) || dt.Rows.Count == 0)
            {
                MessageBox.Show("Không có sản phẩm để chọn.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Chọn dòng hiện tại ở tồn kho
            if (dgvCurrentInventory.CurrentRow == null)
            {
                MessageBox.Show("Chọn 1 sản phẩm ở bảng Tồn kho hiện tại trước.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var drv = dgvCurrentInventory.CurrentRow.DataBoundItem as DataRowView;
            if (drv == null) return;

            string cateName = drv["CategoryName"]?.ToString();
            if (IsTicket(cateName))
            {
                MessageBox.Show("Vé không quản tồn kho. Không đưa sang bảng xác nhận.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int pid = SafeInt(drv["ProductID"]);
            string pname = drv["ProductName"]?.ToString();

            // Nếu đã có trong bảng xác nhận thì vẫn cho thêm dòng mới (tùy bạn),
            // nhưng thường nên cộng dồn. Mình làm cộng dồn cho đỡ điên.
            foreach (DataGridViewRow r in dgvConfirmedItemsry.Rows)
            {
                if (r.Cells["ProductID"].Value != null &&
                    SafeInt(r.Cells["ProductID"].Value) == pid)
                {
                    // cộng dồn AddQty
                    int oldQty = SafeInt(r.Cells["AddQty"].Value);
                    r.Cells["AddQty"].Value = oldQty + 1;
                    dgvConfirmedItemsry.CurrentCell = r.Cells["AddQty"];
                    dgvConfirmedItemsry.BeginEdit(true);
                    return;
                }
            }

            dgvConfirmedItemsry.Rows.Add(pid, pname, cateName, 1);
            dgvConfirmedItemsry.CurrentCell = dgvConfirmedItemsry.Rows[dgvConfirmedItemsry.Rows.Count - 1].Cells["AddQty"];
            dgvConfirmedItemsry.BeginEdit(true);
        }

        // =========================
        // 9) Bấm Kết thúc (End) để cập nhật DB, refresh, hết đỏ
        // =========================
        private void btnInputAll_Click(object sender, EventArgs e)
        {
            if (dgvConfirmedItemsry.Rows.Count == 0)
            {
                MessageBox.Show("Chưa có sản phẩm nào trong 'Mặt hàng xác nhận'.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // validate
            var items = dgvConfirmedItemsry.Rows
                .Cast<DataGridViewRow>()
                .Where(r => !r.IsNewRow)
                .Select(r => new
                {
                    ProductID = SafeInt(r.Cells["ProductID"].Value),
                    ProductName = (r.Cells["ProductName"].Value ?? "").ToString(),
                    AddQty = SafeInt(r.Cells["AddQty"].Value)
                })
                .ToList();

            if (items.Any(x => x.ProductID <= 0 || x.AddQty <= 0))
            {
                MessageBox.Show("Có dòng bị sai (Số lượng thêm phải > 0).", "Lỗi dữ liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // confirm
            var confirm = MessageBox.Show(
                "Xác nhận cập nhật tồn kho cho các sản phẩm đã chọn?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            // update DB trong transaction
            using (var conn = new SqlConnection(_cs))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    try
                    {
                        foreach (var it in items)
                        {
                            using (var cmd = new SqlCommand(@"
UPDATE Product
SET StockQuantity = ISNULL(StockQuantity, 0) + @add
WHERE ProductID = @pid
", conn, tran))
                            {
                                cmd.Parameters.AddWithValue("@add", it.AddQty);
                                cmd.Parameters.AddWithValue("@pid", it.ProductID);
                                cmd.ExecuteNonQuery();
                            }
                        }

                        tran.Commit();
                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        MessageBox.Show("Lỗi cập nhật DB: " + ex.Message, "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            // clear confirm grid + refresh tồn kho
            dgvConfirmedItemsry.Rows.Clear();
            LoadCurrentInventory(true);

            MessageBox.Show("Đã cập nhật tồn kho.", "OK",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
