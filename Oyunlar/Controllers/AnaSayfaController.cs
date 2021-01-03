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
    public class AnaSayfaController : Controller
    {
        Context c = new Context();
        [Authorize]
        public IActionResult Index()
        {
            var degerler = c.Oyuns.Include(x => x.Kategori).ToList();
            return View(degerler);
        }

        public IActionResult Oyun()
        {
            var degerler = c.Oyuns.Include(x => x.Kategori).ToList();
            return View(degerler);
        }

        public IActionResult Kategori()
        {
            var degerler = c.Kategoris.ToList();
            return View(degerler);
        }
        public IActionResult Degerlendirme()
        {
            var degerler = c.Degerlendirmes.Include(x => x.Oyun).ToList();
            return View(degerler);
        }

        public IActionResult OyunListele(int id)
        {
            var degerler = c.Oyuns.Where(x => x.Kategori.KategoriID == id).ToList();
            var katAd = c.Kategoris.Where(x => x.KategoriID == id).Select(y => y.KategoriAd).FirstOrDefault();
            ViewBag.kat = katAd;
            return View(degerler);
        }

        public IActionResult DegerlendirmeListele(int id)
        {
            var degerler = c.Degerlendirmes.Where(x => x.oyunID == id).ToList();
            var katAd = c.Oyuns.Where(x => x.oyunID == id).Select(y => y.oyunAdi).FirstOrDefault();
            ViewBag.kat = katAd;
            return View(degerler);
        }


        [HttpGet]
        public IActionResult YeniDegerlendirme()
        {


            List<SelectListItem> degerler = (from x in c.Kullanicis.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = x.kullaniciAdi,
                                                 Value = x.kullaniciID.ToString()
                                             }).ToList();
            ViewBag.dgr = degerler;

            List<SelectListItem> degerler2 = (from x in c.Oyuns.ToList()
                                              select new SelectListItem
                                              {
                                                  Text = x.oyunAdi,
                                                  Value = x.oyunID.ToString()
                                              }).ToList();
            ViewBag.dgr2 = degerler2;

            return View();
        }
        [HttpPost]
        public IActionResult YeniDegerlendirme(Degerlendirme d,int kullaniciID)
        {
          //  var ic = c.Kullanicis.Where(x => x.kullaniciID == d.Kullanici.kullaniciID).FirstOrDefault();
            var ic2 = c.Oyuns.Where(x => x.oyunID == d.Oyun.oyunID).FirstOrDefault();

            d.kullaniciID = kullaniciID;
            d.Oyun = ic2;
            c.Degerlendirmes.Add(d);
            c.SaveChanges();
            return RedirectToAction("Degerlendirme");
        }

        [HttpGet]
        public IActionResult YeniKullanici()
        {
           
            return View();
        }
        [HttpPost]
        public IActionResult YeniKullanici(Admin a)
        {
            a.adminMi = false;
            c.Admins.Add(a);
            c.SaveChanges();
            return RedirectToAction("Degerlendirme");
        }
    }
}
