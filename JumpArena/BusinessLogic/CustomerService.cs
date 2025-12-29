using JumpArena.DataAccess;
using JumpArena.Models;
using System.Linq;
using System;

namespace JumpArena.BusinessLogic
{
    public class CustomerService
    {
        public Customer FindOrCreateCustomer(string phoneNumber, string lastName, string middleName, string firstName, DateTime? birthDate, string address)
        {
            using (var context = new AppDbContext())
            {
                // 1. Tìm khách hàng
                var customer = context.Customers.FirstOrDefault(c => c.PhoneNumber == phoneNumber);

                // 2. Nếu không tìm thấy, tạo mới
                if (customer == null)
                {
                    customer = new Customer
                    {
                        PhoneNumber = phoneNumber,
                        LastName = lastName,
                        MiddleName = middleName,
                        FirstName = firstName,
                        BirthDate = birthDate,
                        Address = address
                        // Thêm các trường khác nếu cần
                    };
                    context.Customers.Add(customer);
                    context.SaveChanges(); // Lưu vào DB và lấy ID
                }

                // 3. Trả về khách hàng (dù là mới tạo hay vừa tìm thấy)
                return customer;
            }
        }
    }
}