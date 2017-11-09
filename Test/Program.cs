using Chat.IService.Interface;
using Chat.Service.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            IAdminUserService adminService = new AdminUserService();
            long id= adminService.AddAdminUser("aaa", "15615615656", "123456", "edfe@qq.com", 1);
            Console.WriteLine(id);
            Console.ReadKey();
        }
    }
}
