using Microsoft.AspNetCore.Mvc;
using MVCCoreEntregaContinua.Models;
using System.Diagnostics;

namespace MVCCoreEntregaContinua.Controllers
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
            ViewData["SALUDO"] = "Bienvenido a CI/CD GitHub";
            Random random = new Random();
            List<int> numeros = new List<int>();
            for (int i = 1; i <= 20; i++)
            {
                int num = random.Next(1, 20);
                numeros.Add(num);
            }
            return View(numeros);
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
