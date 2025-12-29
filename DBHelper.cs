using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms; // Dùng cho MessageBox trong trường hợp lỗi

// Class này KHÔNG kế thừa từ Form và không nằm trong namespace BTLLTTQ 
// để dễ dàng sử dụng từ mọi nơi trong project.
public class DBHelper
{
    // Chuỗi kết nối đã được xác nhận hoạt động trên máy của bạn
    private const string ConnectionString = "Data Source=LAPTOP-0KAUS2R2; Initial Catalog=JumpArenaDB; Integrated Security=True; TrustServerCertificate=True;";

    // Hàm kiểm tra kết nối (Dùng để test)
    public bool KiemTraKetNoi()
    {
        using (SqlConnection connection = new SqlConnection(ConnectionString))
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Lỗi kết nối SQL Server:\n" + ex.Message, "Lỗi Kết Nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
    public bool UpdatePassword(string tenDangNhap, string matKhauMoi)
    {
        // Cập nhật mật khẩu bằng Stored Procedure hoặc câu lệnh SQL trực tiếp
        string query = "UPDATE NguoiDung SET MatKhau = @MatKhauMoi WHERE TenDangNhap = @TenDangNhap";

        // Đảm bảo ConnectionString đã được khai báo và đúng trong DBHelper
        using (SqlConnection connection = new SqlConnection(ConnectionString))
        {
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                // Thêm các tham số để tránh lỗi SQL Injection
                command.Parameters.AddWithValue("@MatKhauMoi", matKhauMoi);
                command.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);

                try
                {
                    connection.Open();
                    // ExecuteNonQuery trả về số hàng bị ảnh hưởng. Nếu > 0 là thành công.
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi cập nhật mật khẩu DB: " + ex.Message, "Lỗi DB", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }
    }
    // Hàm Đăng nhập (Sử dụng sp_DangNhapNguoiDung)
    public DataTable DangNhap(string tenDangNhap, string matKhau)
    {
        DataTable dtKetQua = new DataTable();

        using (SqlConnection connection = new SqlConnection(ConnectionString))
        {
            try
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("sp_DangNhapNguoiDung", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
                    command.Parameters.AddWithValue("@MatKhau", matKhau);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dtKetQua);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi truy vấn Đăng nhập: " + ex.Message, "Lỗi Database");
            }
        }

        return dtKetQua;
    }
}