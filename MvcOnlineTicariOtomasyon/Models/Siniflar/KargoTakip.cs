using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcOnlineTicariOtomasyon.Models.Siniflar
{
    public class KargoTakip
    {
        [Key]
        public int KargoTakipID { get; set; }

        [Display(Name = "Takip Kodu")]
        [Column(TypeName = "Varchar")]
        [StringLength(11)]
        public string TakipKodu { get; set; }

        [Display(Name = "Açıklama")]
        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string Aciklama { get; set; }
        [Display(Name = "Tarih Zaman")]
        public DateTime TarihZaman { get; set; }
    }
}