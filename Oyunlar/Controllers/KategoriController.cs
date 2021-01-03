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
    public class KategoriController : Controller
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
                var degerler = c.Kategoris.ToList();
                return View(degerler);
            }

            if (deger2 != 0)
            {
                
                return RedirectToAction("Index","Home");

            }

            return RedirectToAction("GirisYap", "Login");
        }

        [HttpGet]
        public IActionResult YeniKategori()
        {

            return View();
        }
        [HttpPost]
        public IActionResult YeniKategori(Kategori k)
        {
            c.Kategoris.Add(k);
            c.SaveChanges();
            return RedirectToAction("Index");
           
        }

        public IActionResult KategoriSil(int id)
        {
            var dep = c.Kategoris.Find(id);
            c.Kategoris.Remove(dep);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult KategoriGetir(int id)
        {
            var kat = c.Kategoris.Find(id);
            return View("KategoriGetir", kat);
        }

        public IActionResult KategoriGuncelle(Kategori k)
        {
            var kat = c.Kategoris.Find(k.KategoriID);
            kat.KategoriAd = k.KategoriAd;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult OyunListele(int id)
        {

            var degerler = c.Oyuns.Where(x => x.Kategori.KategoriID == id).ToList();
            var katAd = c.Kategoris.Where(x => x.KategoriID == id).Select(y => y.KategoriAd).FirstOrDefault();
            ViewBag.kat = katAd;
            return View(degerler);

        }
    }
}
