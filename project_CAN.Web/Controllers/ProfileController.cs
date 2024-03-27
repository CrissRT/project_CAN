using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using project_CAN.Web.Extension;
using project_CAN.Web.Models;

namespace project_CAN.Web.Controllers
{
    public class ProfileController : BaseController
    {
        // GET: Profile
        public ActionResult Index()
        {
            SessionStatus();
            if ((string)System.Web.HttpContext.Current.Session["LoginStatus"] != "login")
            {
                return RedirectToAction("Index", "Login");
            }
            return View();
        }
    }
}