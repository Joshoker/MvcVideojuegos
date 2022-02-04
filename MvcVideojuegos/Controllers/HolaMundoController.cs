using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcVideojuegos.Controllers
{
    public class HolaMundoController : Controller
    {

        //
        // GET: /HolaMundo/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Bienvenido(string nombre, int numVeces = 1)
        {
            ViewData["Mensaje"] = "Hola " + nombre;
            ViewData["NumeroDeVeces"] = numVeces;

            return View();

        }
    }
}
