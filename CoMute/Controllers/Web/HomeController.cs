using CoMute.Web.Models.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CoMute.Web.Controllers.Web
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

        public ActionResult Register()
        {
             
            return View();
        }
        public ActionResult Profile()
        {
            if (CoMuteConstants.UserId == null || CoMuteConstants.UserId == "")
            {
                return RedirectToAction("Index", "Home", new { area = "" });
            }
            return View();
        }

        public ActionResult JoinedView()
        {
            if (CoMuteConstants.UserId == null || CoMuteConstants.UserId == "")
            {
                return RedirectToAction("Index", "Home", new { area = "" });
            }
            return View();
        }

    }
}