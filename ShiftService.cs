using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace JumpArena
{
    public static class ShiftService
    {
        private static string ConnStr =>
            ConfigurationManager.ConnectionStrings["JumpArenaContextDB"].ConnectionString;

        // 1) Start ca nếu user chưa có ca đang mở (EndTime NULL)
        public static void StartShiftIfNotActive(int userId)
        {
            if (userId <= 0) return;

            using (var conn = new SqlConnection(ConnStr))
            {
                conn.Open();

                // Nếu đã có ca đang mở thì thôi, không tạo thêm (tránh leak ca)
                using (var check = new SqlCommand(@"
SELECT TOP 1 WorkShiftID
FROM WorkShift
WHERE UserID = @uid AND EndTime IS NULL
ORDER BY StartTime DESC;", conn))
                {
                    check.Parameters.AddWithValue("@uid", userId);
                    var existing = check.ExecuteScalar();
                    if (existing != null) return;
                }

                // Tạo ca mới
                using (var ins = new SqlCommand(@"
INSERT INTO WorkShift(UserID, StartTime, EndTime)
VALUES (@uid, GETDATE(), NULL);", conn))
                {
                    ins.Parameters.AddWithValue("@uid", userId);
                    ins.ExecuteNonQuery();
                }
            }
        }

        // 2) End ca đang mở (EndTime NULL)
        public static void EndShift(int userId)
        {
            if (userId <= 0) return;

            using (var conn = new SqlConnection(ConnStr))
            {
                conn.Open();

                using (var cmd = new SqlCommand(@"
UPDATE WorkShift
SET EndTime = GETDATE()
WHERE UserID = @uid AND EndTime IS NULL;", conn))
                {
                    cmd.Parameters.AddWithValue("@uid", userId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // 3) Lấy tổng phút làm theo khoảng ngày (cho màn quản lý)
        public static DataTable GetWorkSummary(DateTime from, DateTime to, string searchName = null)
        {
            using (var conn = new SqlConnection(ConnStr))
            using (var cmd = new SqlCommand(@"
SELECT
    u.UserID                         AS [Mã NV],
    u.FullName                       AS [Nhân viên],
    SUM(DATEDIFF(MINUTE,
        w.StartTime,
        CASE WHEN w.EndTime IS NULL THEN GETDATE() ELSE w.EndTime END
    ))                               AS [Tổng phút],
    CAST(SUM(DATEDIFF(MINUTE,
        w.StartTime,
        CASE WHEN w.EndTime IS NULL THEN GETDATE() ELSE w.EndTime END
    )) / 60.0 AS DECIMAL(10,2))      AS [Tổng giờ],
    MAX(w.StartTime)                 AS [Lần vào gần nhất],
    MAX(CASE WHEN w.EndTime IS NULL THEN 1 ELSE 0 END) AS [Đang làm]
FROM WorkShift w
LEFT JOIN [User] u ON u.UserID = w.UserID
WHERE w.StartTime >= @from AND w.StartTime < @to
  AND (@q IS NULL OR u.FullName LIKE '%' + @q + '%')
GROUP BY u.UserID, u.FullName
ORDER BY [Đang làm] DESC, [Tổng phút] DESC;", conn))
            {
                cmd.Parameters.AddWithValue("@from", from);
                cmd.Parameters.AddWithValue("@to", to);
                cmd.Parameters.AddWithValue("@q", (object)searchName ?? DBNull.Value);

                var dt = new DataTable();
                conn.Open();
                using (var da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
                return dt;
            }
        }
    }
}
