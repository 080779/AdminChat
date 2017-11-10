using Chat.IService.Interface;
using Chat.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Chat.AdminWeb.Controllers
{   
    public class MainController : Controller
    {
        public ICityService cityService { get; set; }
        public IAdminUserService adminService { get; set; }

        public ActionResult Index()
        {
            //long id = cityService.AddNew("南阳");
            long id = adminService.AddAdminUser("32", "17779896652", "1234243", "123@qq.com", 1);
            return View(id);
        }
    }
}