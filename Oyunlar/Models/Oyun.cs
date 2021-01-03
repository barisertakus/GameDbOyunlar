using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Oyunlar.Models
{
    public class Oyun
    {
        [Key]
        public int oyunID { get; set; }
        public string oyunAdi { get; set; }
        public int boyut { get; set; }
        public int puan { get; set; }
        public int yayinlamaTarihi { get; set; }

        public string resim { get; set; }
        public int KategoriID { get; set; }
        public Kategori Kategori { get; set; }

        public IList<Degerlendirme> Degerlendirmes { get; set; }
    }
}
