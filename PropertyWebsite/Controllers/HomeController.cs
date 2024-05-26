using Microsoft.AspNetCore.Mvc;
using PropertyWebsite.Models;
using System.Diagnostics;

namespace PropertyWebsite.Controllers
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

        public IActionResult LoginUser()
        {
            return View();
        }

        public IActionResult LoginSeller()
        {
            return View();
        }

        public IActionResult UserDashboard()
        {
            return View();
        }

        public IActionResult Detail()
        {
            return View();
        }

        public IActionResult Buy() {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
