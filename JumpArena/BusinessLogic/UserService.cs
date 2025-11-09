using JumpArena.DataAccess;
using JumpArena.Models;
using Microsoft.EntityFrameworkCore; // Cần cho .Include()
using System.Linq;

namespace JumpArena.BusinessLogic
{
    public class UserService
    {
        // Hàm đăng nhập
        public User Login(string username, string password)
        {
            using (var context = new AppDbContext())
            {
                // Lấy user VÀ thông tin Role đi kèm (giống JOIN)
                var user = context.Users
                                  .Include(u => u.Role)
                                  .FirstOrDefault(u => u.Username == username);

                if (user == null)
                {
                    return null; // Không tìm thấy tên đăng nhập
                }

                // CẢNH BÁO BẢO MẬT: Đây là so sánh mật khẩu gốc.
                // Khi làm thật, bạn phải HASH mật khẩu nhập vào và so sánh với
                // mật khẩu đã HASH trong database.
                if (user.Password == password)
                {
                    return user; // Đăng nhập thành công
                }

                return null; // Sai mật khẩu
            }
        }
    }
}