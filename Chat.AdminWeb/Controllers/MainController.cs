using Chat.IService.Interface;
using Chat.Service;
using Chat.WebCommon;
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
        public IUserService userService { get; set; }
        public IExercisesService exercisesService { get; set; }        

        public ActionResult Index()
        {
            //long id = cityService.AddNew("南阳");
            //long id = adminService.AddAdminUser("32", "17779896652", "1234243", "123@qq.com");
            //long id = userService.AddNew("123", "34e", "qwewew", "34111132455", true, "34rretfsfd");
            //exercisesService.AddNew("这是什么鸟", 2, "乌鸦", "麻雀", "老鹰", "鹦鹉", 1);
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult JsonTest()
        {
            Person p = new Person();
            p.Name = "12321";
            p.Age = 12;

            return Json(new AjaxResult { Status="ok", ErrorMsg = "12321",Data=p});
        }

        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }
    }
}