using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using System.Xml.Linq;

namespace ASPsec4_FormSubmission.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult FormGet()
        {
            ViewBag["name"] = Request.QueryString["name"].ToString();
            ViewBag["email"] = Request.QueryString["email"].ToString();
            ViewBag["class"] = Request.QueryString["class"].ToString();
            ViewBag["address"] = Request.QueryString["address"].ToString();

            return View();
        }
        public ActionResult FormPost(string name, string address, string email, string whichclass)
        {
            ViewData["name"] = name;
            ViewData["email"] = email;
            ViewData["class"] = whichclass;
            ViewData["address"] = address;

            return View();
        }
    }
}