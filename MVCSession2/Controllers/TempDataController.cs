using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSession2.Controllers
{
    public class TempDataController : Controller
    {
        // GET: TempData
        public ActionResult Index()
        {

            TempData["Name"] = "Ajay";
            TempData["Code"] = "1001";
            return View();
        }

        public ActionResult Details()
        {
            if (TempData.ContainsKey("Name"))
            {
                var _name= TempData["Name"] as string;
                ViewBag.FullName = _name + "Dev";

            }
            if (TempData.ContainsKey("Code"))
            {
                ViewBag.Code = TempData["Code"] as string;

            }
             
           
            return View();
        }
    }
};