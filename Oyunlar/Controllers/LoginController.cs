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
    public class LoginController : Controller
    {
        Context c = new Context();
        [HttpGet]
        public IActionResult GirisYap()
        {
            return View();
        }

        public async Task<IActionResult> GirisYap(Admin A)
        {
            var bilgiler = c.Admins.FirstOrDefault(x => x.kullaniciAdi == A.kullaniciAdi && x.sifre == A.sifre);
            if (bilgiler != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,A.kullaniciAdi)
                };
                var useridentity = new ClaimsIdentity(claims, "Login");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index", "Kategori");
            }
            else
                return View();
        }


    }
}
