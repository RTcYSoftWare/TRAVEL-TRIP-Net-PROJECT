using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripPrjoje.Models.Siniflar
{
    public class Hakkimizda
    {
        [Key]
        public int ID { get; set; }
        public string Foto_Url { get; set; }
        public string Aciklama { get; set; }
    }
}