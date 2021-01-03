using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using Oyunlar.Models;

namespace Oyunlar.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        Context c = new Context();
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var OyunList = c.Oyuns.ToList();
            return View(OyunList);
        }

        public IActionResult TumOyunlar()
        {
            var OyunList = c.Oyuns.ToList();
            return View(OyunList);
        }

        public IActionResult Iletisim()
        {
            return View();
        }


        OyunYorum oy = new OyunYorum();

        [HttpGet]
        public IActionResult OyunDetay(int id)
        {
            
            oy.Deger1 = c.Degerlendirmes.Where(x => x.oyunID == id).ToList();
            oy.Deger2 = c.Oyuns.Where(x => x.oyunID == id).ToList();

            return View(oy);
        }

        [Authorize]
        [HttpPost]
        public IActionResult OyunDetay(Degerlendirme d)
        {

            var ic = c.Kullanicis.Where(x => x.kullaniciID == d.Kullanici.kullaniciID).FirstOrDefault();
            var ic2 = c.Oyuns.Where(x => x.oyunID == d.Oyun.oyunID).FirstOrDefault();

            d.Kullanici = ic;
            d.Oyun = ic2;
            c.Degerlendirmes.Add(d);
            c.SaveChanges();
            return RedirectToAction("OyunDetay");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
