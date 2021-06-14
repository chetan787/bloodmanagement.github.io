using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BloodDonation.Models;
namespace BloodDonation.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult FAQ()
        {
            return View();
        }
        public ActionResult Signup()
        {
            return View();
        }
        public ActionResult Test()
        {
            return View();
        }
        [HttpPost]

        public ActionResult Signup(Tbl_Savelife tbl_Savelife)
        {
            using (SaveDonateEntities db = new SaveDonateEntities())
            {
               if (!db.Tbl_Savelife.Where(z => z.Email_Id == tbl_Savelife.Email_Id && z.Mobile_Number == tbl_Savelife.Mobile_Number).Any() || tbl_Savelife.Password == tbl_Savelife.Confirm_Password)
               {         //Tbl_Savelife.Token_number = Guid.NewGuid().ToString();
                    db.Tbl_Savelife.Add(tbl_Savelife);
                    db.SaveChanges();
                    return RedirectToAction("Home");
               }else
               return View(tbl_Savelife);
            }
        }
        public ActionResult Home()
        {
             return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}