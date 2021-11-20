using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripPrjoje.Models.Siniflar;
namespace TravelTripPrjoje.Controllers
{
    public class BlogController : Controller
    {

        BlogYorum by = new BlogYorum();// sınıftan nesne blog detay için
        // GET: Blog
        Context c = new Context();
        public ActionResult Index()
        {
            //var bloglar = c.Blogs.ToList();

            by.Deger1 = c.Blogs.ToList();
            by.Deger3 = c.Blogs.Take(3);
            // by.Deger3 = c.Blogs.OrderByDescending(x=>x.ID).Take(3).ToList(); tersten çekme

            return View(by);
        }

        public ActionResult BlogDetay(int id)
        {
           // var blog_bul = c.Blogs.Where(x => x.ID == id).ToList(); gelen id ile veritabanında bulunan bloglardan id eşleştirmesi yaparak blogu bulduk
            
            by.Deger1 = c.Blogs.Where(x => x.ID == id).ToList();
            by.Deger2 = c.Yorumlars.Where(x => x.Blogid == id).ToList();
            
            return View(by); // blogu döndürdük
        }

        [HttpGet]
        public PartialViewResult YorumYap(int id)
        {
            ViewBag.deger = id;
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult YorumYap(Yorumlar gelen_yorum)
        {
            c.Yorumlars.Add(gelen_yorum);
            c.SaveChanges();
            return PartialView();
        }




    }
}