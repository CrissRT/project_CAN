using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace project_CAN.Web.Controllers
{
    public class SignUpController : Controller
    {
        // GET: SignUp
        public ActionResult SignUp()
        {
            ViewBag.Title = "Sign Up";
            return View(ViewBag);
        }
    }
}