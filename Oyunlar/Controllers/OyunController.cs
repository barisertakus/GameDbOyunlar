using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Oyunlar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Oyunlar.Controllers
{
    public class OyunController : Controller
    {
      
        Context c = new Context();

        [Authorize]
        public IActionResult Index()
        {
            var admin = User.Identity.Name;
            var deger = c.Admins.Where(x => x.kullaniciAdi == admin).Where(x => x.adminMi == true).Count();

            if (deger != 0)
            {
                var degerler = c.Oyuns.ToList();
                return View(degerler);
            }

            return RedirectToAction("GirisYap", "Login");
        }

        [HttpGet]
        public IActionResult YeniOyun()
        {
            List<SelectListItem> degerler = (from x in c.Kategoris.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = x.KategoriAd,
                                                 Value = x.KategoriID.ToString()
                                             }).ToList();
            ViewBag.dgr = degerler;

            return View();
        }
        [HttpPost]
        public IActionResult YeniOyun(Oyun o)
        {
            var ic = c.Kategoris.Where(x => x.KategoriID == o.Kategori.KategoriID).FirstOrDefault();
            o.Kategori = ic;
            c.Oyuns.Add(o);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult OyunSil(int id)
        {
            var oy = c.Oyuns.Find(id);
            c.Oyuns.Remove(oy);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult OyunGetir(int id)
        {
            var ic = c.Oyuns.Find(id);
            return View("OyunGetir", ic);
        }


        public IActionResult OyunGuncelle(Oyun k)
        {
            var kat = c.Oyuns.Where(x => x.oyunID == k.oyunID).FirstOrDefault();
            kat.oyunAdi = k.oyunAdi;
            kat.boyut = k.boyut;
            kat.yayinlamaTarihi = k.yayinlamaTarihi;
            kat.puan = k.puan;
            kat.resim = k.resim;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
