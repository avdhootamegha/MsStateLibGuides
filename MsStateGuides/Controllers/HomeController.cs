using LibGuides.Common;
using LibGuids.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading.Tasks;
using System.Configuration;

namespace MsStateGuides.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ActionResult> Index()
        {
            LibGuidsClient client = new LibGuidsClient(ConfigurationManager.AppSettings["LibGuideApiEndPoint"].ToString());
            //var response = await client.Get();
            return View(await client.Get());
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
    }
}