using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelTripPrjoje.Models.Siniflar
{
    public class BlogYorum
    {
        public IEnumerable<Blog> Deger1 { get; set; }
        public IEnumerable<Yorumlar> Deger2 { get; set; }
        public IEnumerable<Blog> Deger3 { get; set; }
    }
}


/*BİR VİEW YANİ HTML SAYFASINA İKİ VEYA DAHA FAZLA TABLODAN VERİ ÇEKMEMİZE YARAR
 DERS ->https://www.youtube.com/watch?v=J2NivZZ4b_w&list=PLKnjBHu2xXNNhJQ6SyF7Wyhqza9mkMGSw&index=18
 */
