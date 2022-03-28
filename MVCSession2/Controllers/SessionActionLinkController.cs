using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCSession2.Models;


namespace MVCSession2.Controllers
{
    public class SessionActionLinkController : Controller
    {
        // GET: SessionActionLink
        public ActionResult Index()
        {
            MVCDBEntities db = new MVCDBEntities();
            List<CustomerMaster> lst = db.CustomerMaster.ToList();
            return View(lst);
        }

        public ActionResult ShowDetails(int id)
        {
            MVCDBEntities db = new MVCDBEntities();
            CustomerMaster obj = db.CustomerMaster.ToList().Where(p=>p.Customer_Id== id).FirstOrDefault();
            return View(obj);
        }


        [NonAction]
        public string GetEState(int id)
        {
            MVCDBEntities db = new MVCDBEntities();
            CustomerMaster obj = db.CustomerMaster.ToList().Where(p => p.Customer_Id == id).FirstOrDefault();
            return obj.State;
        }

        [ActionName("GetEmployeeState")]
        public string GetEmployeeState(int id)
        {
            return GetEState(id);
        }
    }
}