using Microsoft.AspNetCore.Mvc;

namespace la_mia_pizzeria_static.Controllers
{
    public class ExRazorController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Esercizi bellissimi Razor";
            return View();
        }
    }
}
