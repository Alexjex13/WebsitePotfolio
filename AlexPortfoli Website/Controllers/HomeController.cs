using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AlexPortfoli_Website.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "What can I do for you ?";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact me.";

            return View();
        }

        public ActionResult Cpage()
        {
            return View("/views/skills/cpage.cshtml");
        }
        public ActionResult AzurePage()
        {
            return View("/views/skills/AzurePage.cshtml");
        }
        public ActionResult HtmlPage()
        {
            return View("/views/skills/htmlpage.cshtml");
        }
        public ActionResult JavascriptPage()
        {
            return View("/views/skills/javascriptpage.cshtml");
        }
        public ActionResult NetCorePage()
        {
            return View("/views/skills/NetCorepage.cshtml");
        }
        public ActionResult SqlPage()
        {
            return View("/views/skills/sqlpage.cshtml");
        }


        public ActionResult CustomWebsites()
        {
            return View("/views/Services/CustomWebsites.cshtml");
        }
        public ActionResult CustomCmsDevelopment()
        {
            return View("/views/Services/CustomCmsDevelopment.cshtml");
        }
        public ActionResult MobileAppDevelopment()
        {
            return View("/views/Services/MobileAppDevelopment.cshtml");
        }

    }
}