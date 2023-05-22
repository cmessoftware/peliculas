using Microsoft.AspNetCore.Mvc;

namespace Peliculas.Web.Controllers
{
    public class HistorialController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

    }
}
