using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace JumpArena.View.Staff
{
    public partial class Checkin : Form
    {
        private readonly string _cs;

        public TicketItem SelectedTicket { get; private set; }
        public List<TicketItem> SelectedTickets { get; private set; } = new List<TicketItem>();

        public Checkin(string cs)
        {
            InitializeComponent();
            _cs = cs;
            StartPosition = FormStartPosition.CenterParent;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            ShowInTaskbar = false;
            LoadTicketsFromDb();

            // gắn click cho 4 nút
            btnCheck1.Click += (s, e) => PickTicket(0);
            btnCheck2.Click += (s, e) => PickTicket(1);
            btnCheck3.Click += (s, e) => PickTicket(2);
            btnCheck4.Click += (s, e) => PickTicket(3);
        }

        private List<TicketItem> _tickets = new List<TicketItem>();

        private void LoadTicketsFromDb()
        {
            // Chỉ lấy 4 vé vui chơi (CategoryID = 1) và loại vé Halloween (ProductID = 6)
            using (var conn = new SqlConnection(_cs))
            using (var cmd = new SqlCommand(@"
SELECT ProductID, ProductName, Price
FROM Product
WHERE CategoryID = 1
  AND ProductID <> 6
ORDER BY ProductID
", conn))
            {
                conn.Open();
                using (var rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        _tickets.Add(new TicketItem
                        {
                            ProductID = Convert.ToInt32(rd["ProductID"]),
                            ProductName = rd["ProductName"]?.ToString(),
                            Price = Convert.ToDecimal(rd["Price"])
                        });
                    }
                }
            }

            // đảm bảo đúng 4 vé
            _tickets = _tickets.Take(4).ToList();

            // đổ lên label của form Checkin (4 dòng)
            // Nếu DB đang có đúng thứ tự: 1,2,4,5 thì nó sẽ ra đúng như bạn cần.
            if (_tickets.Count > 0) lblVeTrongTuan.Text = _tickets[0].ProductName;
            if (_tickets.Count > 1) lblVeTreEmTT.Text = _tickets[1].ProductName;
            if (_tickets.Count > 2) lblVeTreEmCT.Text = _tickets[2].ProductName;
            if (_tickets.Count > 3) lblVeCuoiTuan.Text = _tickets[3].ProductName;

            // Nếu thiếu vé, disable nút tương ứng
            btnCheck1.Enabled = _tickets.Count > 0;
            btnCheck2.Enabled = _tickets.Count > 1;
            btnCheck3.Enabled = _tickets.Count > 2;
            btnCheck4.Enabled = _tickets.Count > 3;
        }

        private void PickTicket(int index)
        {
            if (index < 0 || index >= _tickets.Count) return;

            SelectedTicket = new TicketItem
            {
                ProductID = _tickets[index].ProductID,
                ProductName = _tickets[index].ProductName,
                Price = _tickets[index].Price,
                Unit = "Vé",
                Quantity = 1
            };

            DialogResult = DialogResult.OK;
            Close();
        }

    }
}
