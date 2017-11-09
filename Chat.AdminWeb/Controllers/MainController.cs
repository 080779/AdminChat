using Chat.IService.Interface;
using Chat.Service.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Chat.AdminWeb.Controllers
{
    public class MainController : Controller
    {
        // GET: Main
        public ActionResult Index()
        {
            ICityService cityService = new CityService();
            long id = cityService.AddNew("南京");
            return View(id);
        }
    }
}