using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Oyunlar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Oyunlar.Controllers
{
    public class AdminHome : Controller
    {
        Context c = new Context();
        [Authorize]
        public IActionResult Index()
        {
            var admin = User.Identity.Name;
            var deger = c.Admins.Where(x => x.kullaniciAdi == admin).Where(x => x.adminMi == true).Count();
            var deger2 = c.Admins.Where(x => x.kullaniciAdi == admin).Where(x => x.adminMi == false).Count();


            if (deger != 0)
            {
                var degerler = c.Admins.ToList();
                return View(degerler);
            }

            return RedirectToAction("GirisYap", "Login");

        }
    }
}