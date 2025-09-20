using Microsoft.AspNetCore.Mvc;
using GarageMVC.Models;

namespace GarageMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly Garage miGaraje;

        public HomeController()
        {
            // Crear un garaje con capacidad de 10 autos
            miGaraje = new Garage(
                numeroGaraje: 1,
                descripcion: "Garaje de Dagoberto Fernández Valenzuela",
                capacidadEspacios: 10
            );

            // Crear y agregar 3 autos
            var auto1 = new Auto(1, "Toyota", "HAA-1234");
            var auto2 = new Auto(2, "Hyundai", "HBB-5678");
            var auto3 = new Auto(3, "Kia", "HCC-9012");

            miGaraje.ingresarAuto(auto1);
            miGaraje.ingresarAuto(auto2);
            miGaraje.ingresarAuto(auto3);
        }

        public IActionResult Index()
        {
            // Pasar el garaje con los autos a la vista
            return View(miGaraje);
        }
    }
}