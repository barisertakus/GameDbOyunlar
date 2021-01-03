using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Oyunlar.Models
{
    public class Admin
    {
        [Key]
        public int adminID { get; set; }

        public string kullaniciAdi { get; set; }
        public string sifre { get; set; }
        public bool adminMi { get; set; }

        public string mail { get; set; }
    }
}
