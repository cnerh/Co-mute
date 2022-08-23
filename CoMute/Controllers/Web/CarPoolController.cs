using CoMute.Web.Models.Constants;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CoMute.Web.Controllers.Web
{
    public class CarPoolController : Controller
    {
        // GET: CarPool
        public ActionResult Index()
        {
            if (CoMuteConstants.UserId == null || CoMuteConstants.UserId == "")
            {
                return RedirectToAction("Index", "Home", new { area = "" });
            }

            return View();
        }
        public ActionResult CarPoolRegister()
        {

            if (CoMuteConstants.UserId == null || CoMuteConstants.UserId == "")
            {
                return RedirectToAction("Index", "Home", new { area = "" });

            }
            return View();
        }
        public ActionResult CarPoolView()
        {
            if (CoMuteConstants.UserId == null || CoMuteConstants.UserId == "")
            {
                return RedirectToAction("Index", "Home", new { area = "" });
            }

            return View();
        }
    }
}