using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripPrjoje.Models.Siniflar;

namespace TravelTripPrjoje.Controllers
{
    public class DenemeController : Controller
    {
        // GET: Deneme
        Context c = new Context();
        public ActionResult Index()
        {
            var b = c.Blogs.Take(10).ToList();

            return View(b);
        }
    
        public ActionResult About()
        {
            return View();
        }

        public PartialViewResult Partial1()
        {
            var degerler = c.Blogs.OrderByDescending(x => x.ID).Take(2).ToList();
            return PartialView(degerler);
        }

        public PartialViewResult Partial2()
        {
            var degerler = c.Blogs.Where(x => x.ID == 2).ToList();
            return PartialView(degerler);
        }

        public PartialViewResult Partial3()
        {
            var degerler = c.Blogs.Take(10).ToList();
            return PartialView(degerler);
        }

        public PartialViewResult Partial4()
        {
            var degerler = c.Blogs.Take(3).ToList();
            return PartialView(degerler);
        }
    
    }
}