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
    public class DegerlendirmeController : Controller
    {

        Context c = new Context();

        [Authorize]

        public IActionResult Index()
        {
            var admin = User.Identity.Name;
            var deger = c.Admins.Where(x => x.kullaniciAdi == admin).Where(x => x.adminMi == true).Count();

            if (deger != 0)
            {
                var degerler = c.Degerlendirmes.ToList();
                return View(degerler);
            }

            return RedirectToAction("GirisYap", "Login");
        }

        public IActionResult DegerlendirmeSil(int id)
        {
            var dep = c.Degerlendirmes.Find(id);
            c.Degerlendirmes.Remove(dep);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DegerlendirmeGetir(int id)
        {
            var ic = c.Degerlendirmes.Find(id);
            return View("DegerlendirmeGetir", ic);
        }


        public IActionResult DegerlendirmeGuncelle(Degerlendirme k)
        {
            var kat = c.Degerlendirmes.Where(x => x.degerlendirmeID == k.degerlendirmeID).FirstOrDefault();
            kat.puan = k.puan;
            kat.yorum = k.yorum;
            c.SaveChanges();
            return RedirectToAction("Index");
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
        public IActionResult YeniDegerlendirme(Degerlendirme d)
        {
            var ic = c.Kullanicis.Where(x => x.kullaniciID == d.Kullanici.kullaniciID).FirstOrDefault();
            var ic2 = c.Oyuns.Where(x => x.oyunID == d.Oyun.oyunID).FirstOrDefault();
            
            d.Kullanici = ic;
            d.Oyun = ic2;
            c.Degerlendirmes.Add(d);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
