using Microsoft.AspNetCore.Mvc;
using MvcViews.Models;
using System.Diagnostics;

namespace MvcViews.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet] // Http get Methoduyla sayfayı getiriyuorum.
        public IActionResult Personel()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Personel(Personel personel)
        {
            if (ModelState.IsValid)
            {
                string personelBilgi = "";

                personelBilgi = "Personel bilgileri(Ad, Soyad, Yas): " + personel.Ad + personel.Soyad + personel.Yas;

                ViewBag.Mesaj=personelBilgi;
            }
            return View(personel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}