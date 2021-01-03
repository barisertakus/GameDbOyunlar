using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Oyunlar.Models
{
    public class Kullanici
    {
        [Key]
        public int kullaniciID { get; set; }

        public string kullaniciAdi { get; set; }
        public string sifre { get; set; }

        public IList<Degerlendirme> Degerlendirmes { get; set; }
    }
}
