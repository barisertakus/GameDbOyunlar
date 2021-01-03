using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Oyunlar.Models
{
    public class Degerlendirme
    {
        [Key]
        public int degerlendirmeID { get; set; }

        public int puan { get; set; }
        public string yorum { get; set; }
        public Oyun Oyun { get; set; }
        public int oyunID { get; set; }
        public Kullanici Kullanici { get; set; }
        public int kullaniciID { get; set; }
    }
}
