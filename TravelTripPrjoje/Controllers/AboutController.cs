using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripPrjoje.Models.Siniflar;

namespace TravelTripPrjoje.Controllers
{
    public class AboutController : Controller
    {
        // GET: About

        Context context_hakkimizda = new Context(); // bağlantı sınıfından nesne ürettik

        public ActionResult Index()
        {
            var hakkimizda_degerler = context_hakkimizda.Hakkimizdas.ToList(); // değişken tanımlayıp 
            return View(hakkimizda_degerler);
        }
    }
}