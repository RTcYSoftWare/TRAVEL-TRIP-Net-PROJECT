using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TravelTripPrjoje.Models.Siniflar;

namespace TravelTripPrjoje.Controllers
{
    public class GirisYapController : Controller
    {

        Context giris_context = new Context();

        // GET: GirisYap
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]  
        public ActionResult Login(Admin admin)
        {
            var kontrol_et = giris_context.Admins.FirstOrDefault(x => x.Kullanici == admin.Kullanici && x.Sifre == admin.Sifre);

            if(kontrol_et != null)
            {
                FormsAuthentication.SetAuthCookie(kontrol_et.Kullanici, false);
                Session["Kullanici"] = kontrol_et.Kullanici.ToString();
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                return View();
            }
        }


        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "GirisYap");
        }




    }
}