using Microsoft.AspNetCore.Mvc;
using QLDuLichRBAC_Upgrade.Models;
using QLDuLichRBAC_Upgrade.Models.Entities;
using System.Security.Cryptography;
using System.Text;

namespace QLDuLichRBAC_Upgrade.Controllers
{
    public class AccountController : Controller
    {
        private readonly QLDuLichContext _context;
        public AccountController(QLDuLichContext context)
        {
            _context = context;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            string hashed = HashPassword(password);

            var user = _context.Users
                .FirstOrDefault(u => u.Username == username && u.PasswordHash == hashed);

            if (user == null)
            {
                ViewBag.Error = "Sai tên đăng nhập hoặc mật khẩu!";
                return View();
            }

            HttpContext.Session.SetString("Username", user.Username);
            HttpContext.Session.SetString("Role", user.Role);
            HttpContext.Session.SetString("FullName", user.FullName);

            return user.Role switch
            {
                "Admin" => RedirectToAction("Dashboard", "Admin"),
                "Guide" => RedirectToAction("Index", "Guide"),
                "Customer" => RedirectToAction("Index", "Customer"),
                _ => RedirectToAction("Index", "Home")
            };
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha = SHA256.Create())
            {
                var bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(bytes).Replace("-", "").ToUpperInvariant();
            }
        }
    }
}
