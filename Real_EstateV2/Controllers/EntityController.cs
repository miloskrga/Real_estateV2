using Microsoft.AspNetCore.Mvc;
using Real_EstateV2.Models;

namespace Real_EstateV2.Controllers
{
    public class EntityController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("GoToRegistration");
        }

        public IActionResult GoToRegistration()
        {
            return View("Registracija");
        }
        [HttpPost]
        public IActionResult Drugacije(string Input)
        {
            return View();
        }


        [HttpPost]
        public IActionResult Registracija(Korisnik korisnik)
        {
            return View();
        }
    }
}
