using Microsoft.AspNetCore.Mvc;
using SingletonASP.Models;
using System.Diagnostics;

namespace SingletonASP.Controllers
{
    public class HomeController : Controller
    {
        

        public HomeController()
        {

        }

        public IActionResult Index()
        {
            Tools.Log.GetInstance("log.txt").Save("Entro a index");
            return View();
        }

        public IActionResult Privacy()
        {
            Tools.Log.GetInstance("log.txt").Save("Entro a Privacy");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
