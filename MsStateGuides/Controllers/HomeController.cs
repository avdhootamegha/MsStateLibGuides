using LibGuides.Common;
using LibGuids.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading.Tasks;
using System.Configuration;
using MsStateGuides.Helpers;
using MsStateGuides.Models;

namespace MsStateGuides.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ActionResult> Index()
        {
            try
            {
                LibGuidesHelper libGuidesHelper = new LibGuidesHelper();

            var model = new LibGuidesModel()
                {
                    Filter = new LibGuidesFilter()
                };
                model.Subjects = await libGuidesHelper.GetLibGuidesSubjectsAsync(model.Filter);
                model.LibGuides = await libGuidesHelper.GetLibGuidesAsync(model.Filter);

                return View(model);
            }
            catch
            {
                return View("Error");
            }
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