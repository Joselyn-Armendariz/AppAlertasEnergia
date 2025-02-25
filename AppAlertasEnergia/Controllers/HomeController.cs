using System.Diagnostics;
using AppAlertasEnergia.Models;
using Microsoft.AspNetCore.Mvc;

namespace AppAlertasEnergia.Controllers
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

        public IActionResult Sesion()
        {
            return RedirectToAction("Login", "Sesion");
        }

        public IActionResult Mantenimiento()
        {
            return View();
        }
        public IActionResult Registro()
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
