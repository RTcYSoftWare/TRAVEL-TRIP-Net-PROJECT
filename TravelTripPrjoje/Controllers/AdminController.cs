using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripPrjoje.Models.Siniflar;

namespace TravelTripPrjoje.Controllers
{

    public class AdminController : Controller
    {
        // GET: Admin

        Context c = new Context();


        /*--- BLOGLARI LİSTELEYEN ACTİON ---*/
        [Authorize] // GEREKLİ AUTHENTİCATİON İŞLEMİ YAPTIRDIK VE WEB CONFİG İÇERİSİNDE AYARLAMA YAPTIK.
        public ActionResult Index()
        {
            var degerler = c.Blogs.ToList();
            return View(degerler);
        }


        /*--- YENİ BLOG GETİREN ACTİON ---*/
        [HttpGet]
        public ActionResult YeniBlog()
        {
            return View();
        }


        /*--- YENİ BLOG EKLEYEN ACTİON ---*/
        [HttpPost]
        public ActionResult YeniBlog(Blog blog)
        {
            c.Blogs.Add(blog);
            c.SaveChanges();
            return RedirectToAction("Index");
        }


        /*--- BLOG SİLEN ACTİON ---*/
        public ActionResult BlogSil(int id)
        {
            var silinecek = c.Blogs.Find(id);
            c.Blogs.Remove(silinecek);
            c.SaveChanges();
            return RedirectToAction("Index");
        }


        /*--- BLOG BULAN ACTİON ---*/
        public ActionResult BlogGetir(int id )
        {
            var blog = c.Blogs.Find(id);
            return View("BlogGetir", blog);
        }


        /*--- GUNCELLEME YAPAN FONKSİYON ---*/
        public ActionResult BlogGuncelle(Blog guncelle) // formdan verileri aldık.
        {
            var guncellenecek_blog = c.Blogs.Find(guncelle.ID);
            guncellenecek_blog.Aciklama = guncelle.Aciklama;
            guncellenecek_blog.Baslik = guncelle.Baslik;
            guncellenecek_blog.BlogImage = guncelle.BlogImage;
            guncellenecek_blog.Tarih = guncelle.Tarih;
            c.SaveChanges();
            return RedirectToAction("Index");
        }


        /*--- YORUM LİSTELEME YAPAN ACTİON ---*/
        public ActionResult YorumListesi()
        {
            var yorumlar = c.Yorumlars.ToList();
            return View(yorumlar);
        }


        /*--- YORUM SİLME YAPAN ACTİON ---*/
        public ActionResult YorumSil(int id)
        {
            var silinecek_yorum = c.Yorumlars.Find(id);
            c.Yorumlars.Remove(silinecek_yorum);
            c.SaveChanges();
            return RedirectToAction("YorumListesi");

        }


        /*--- YORUM GETİREN ACTİON ---*/
        public ActionResult YorumGetir(int id)
        {
            var düzenlenecek_yorum = c.Yorumlars.Find(id);
            return View("YorumGetir", düzenlenecek_yorum);
        }


        /*--- YORUM GUNCELLEYEN ACTİON ---*/
        public ActionResult YorumGuncelle(Yorumlar guncelle) // formdan verileri aldık.
        {
            var guncellenecek_yorum = c.Yorumlars.Find(guncelle.ID);
            
            guncellenecek_yorum.Kullanici_Adi = guncelle.Kullanici_Adi;
            guncellenecek_yorum.Mail = guncelle.Mail;
            guncellenecek_yorum.Yorum = guncelle.Yorum;

            c.SaveChanges();
            return RedirectToAction("YorumListesi");
        }



    }
}