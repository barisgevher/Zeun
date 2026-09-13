using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using Zeun.Web.Data;
using Zeun.Web.Models;

namespace Zeun.Web.Controllers
{
    public class LoginController : Controller
    {
        private readonly OgrenciDbContext _context;

        public LoginController(OgrenciDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(Kullanici model)
        {
            if (string.IsNullOrWhiteSpace(model.KullaniciAdi) || string.IsNullOrWhiteSpace(model.Parola))
            {
                ViewBag.Error = "Kullanıcı Bilgileri Geçersiz";
                return View("Index");
            }

            // Kullanıcıyı sadece kullanıcı adıyla bul; şifre karşılaştırması hash üzerinden yapılır
            var kullanici = await _context.Kullanicis
                .FirstOrDefaultAsync(k => k.KullaniciAdi == model.KullaniciAdi);

            // Kullanıcı yoksa veya şifre hash ile eşleşmiyorsa: aynı genel hata (hangisinin yanlış olduğunu söylemiyoruz)
            if (kullanici is null || !BCrypt.Net.BCrypt.Verify(model.Parola, kullanici.Parola))
            {
                ViewBag.Error = "Kullanıcı Bilgileri Geçersiz";
                return View("Index");
            }

            var kullaniciTuru = await _context.KullaniciTurus
                .FirstOrDefaultAsync(kt => kt.KullaniciTurId == kullanici.KullaniciTuruId);

            if (kullaniciTuru is null)
            {
                ViewBag.Error = "Kullanıcı Bilgileri Geçersiz";
                return View("Index");
            }

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, kullanici.KullaniciAdi ?? string.Empty),
                new Claim(ClaimTypes.Role, kullaniciTuru.KullaniciTurAdi ?? string.Empty),
            };

            // Öğrenci girişi
            if (kullanici.KullaniciTuruId == 1)
            {
                var ogrenci = await _context.Ogrencis
                    .FirstOrDefaultAsync(o => o.KullaniciId == kullanici.KullaniciId);

                if (ogrenci is null)
                {
                    ViewBag.Error = "Kullanıcı Bilgileri Geçersiz";
                    return View("Index");
                }

                claims.Add(new Claim("OgrenciId", ogrenci.OgrenciId.ToString()));
                await SignInWithClaimsAsync(claims);
                HttpContext.Session.SetInt32("ogrenciId", ogrenci.OgrenciId);

                return RedirectToAction("Index", "Ogrenci");
            }

            // Öğretim elemanı girişi
            if (kullanici.KullaniciTuruId == 2)
            {
                var ogretimElemani = await _context.OgretimElemanis
                    .FirstOrDefaultAsync(o => o.KullaniciId == kullanici.KullaniciId);

                if (ogretimElemani is null)
                {
                    ViewBag.Error = "Kullanıcı Bilgileri Geçersiz";
                    return View("Index");
                }

                claims.Add(new Claim("OgretimElemaniId", ogretimElemani.OgretimElemaniId.ToString()));
                await SignInWithClaimsAsync(claims);
                HttpContext.Session.SetInt32("ogretimElemaniId", ogretimElemani.OgretimElemaniId);

                return RedirectToAction("Index", "OgretimElemani");
            }

            ViewBag.Error = "Kullanıcı Bilgileri Geçersiz";
            return View("Index");
        }

        private async Task SignInWithClaimsAsync(List<Claim> claims)
        {
            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            await HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                new ClaimsPrincipal(claimsIdentity),
                new AuthenticationProperties());
        }
    }
}