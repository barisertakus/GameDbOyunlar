using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Oyunlar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Oyunlar.Controllers
{
    public class KullaniciLoginController : Controller
    {
        Context c = new Context();
        [HttpGet]
        public IActionResult GirisYap()
        {
            return View();
        }

        public async Task<IActionResult> GirisYap(Kullanici k)
        {
            var bilgiler = c.Kullanicis.FirstOrDefault(x => x.kullaniciAdi == k.kullaniciAdi && x.sifre == k.sifre);
            if (bilgiler != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,k.kullaniciAdi)
                };
                var useridentity = new ClaimsIdentity(claims, "KullaniciLogin");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Anasayfa", "Index");
            }
            else
                return View();
        }
    }
}
