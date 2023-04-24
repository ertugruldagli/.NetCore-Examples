using Microsoft.AspNetCore.Mvc;
using MVCLogin.Models;
using System.Diagnostics;

namespace MVCLogin.Controllers
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

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Login login )
        {
            if (login.UserID=="admin"&& login.Password=="1234")
            {
                ViewBag.Mesaj = "Tebrikler giriş başarılı";
            }
            else{
                ViewBag.Mesaj = "Kullanıcı adı veya şifre ynalış";
            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}