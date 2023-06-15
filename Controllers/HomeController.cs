using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SalaEscape.Models;

namespace SalaEscape.Controllers;

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

    public IActionResult Tutorial()
    {
        return View();
    }

    public IActionResult Creditos()
    {
        return View();
    }

      public IActionResult Comenzar()
        {
            // Devuelve la view de la próxima Habitación a resolver (Según lo que indique EstadoJuego)
            int estadoJuego = Escape.GetEstadoJuego();

            switch (estadoJuego)
            {
                case 1:
                    return View("Habitacion1");
                    //Si no anda, probar con return RedirectToAction
                case 2:
                    return View("Habitacion2");
                case 3:
                    return View("Habitacion3");
                case 4:
                    return View("Habitacion4");
                default:
                    return View("Victoria");
            }
        }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]

      public IActionResult Habitacion1(int sala, string clave)
        {
            // Verifica que la sala que se está respondiendo coincida con EstadoJuego.
            if (sala != 1 || clave != "Incognita Sala 1")
            {
                ViewBag.Error = "La respuesta escrita fue incorrecta.";
                // En caso de estar resolviendo una sala incorrecta deberá devolver la view de la sala a resolver.
                return View("Habitacion1");
            }
           
            //Verifica si es correcta
            Escape.ResolverSala(sala, clave);

            // De ser así, retorna la View siguiente Habitacion.
            return View("Comenzar");
        }

         public IActionResult Habitacion2(int sala, string clave)
        {
            if (sala != 2 || clave != "Incognita Sala 2")
            {
                ViewBag.Error = "La respuesta escrita fue incorrecta.";
                return View("Habitacion2");
            }

            Escape.ResolverSala(sala, clave);

            return View("Comenzar");
        }

        public IActionResult Habitacion3(int sala, string clave)
        {
            if (sala != 3 || clave != "Incognita Sala 3")
            {
                ViewBag.Error = "La respuesta escrita fue incorrecta.";
                return View("Habitacion3");
            }

            Escape.ResolverSala(sala, clave);

            return View("Comenzar");
        }

        public IActionResult Habitacion4(int sala, string clave)
        {
            if (sala != 4 || clave != "Incognita Sala 4")
            {
                ViewBag.Error = "La respuesta escrita fue incorrecta.";
                return View("Habitacion4");
            }

            Escape.ResolverSala(sala, clave);

            return View("Comenzar");
        }

        public IActionResult Victoria()
        {
            // En caso de estar resolviendo la última sala de manera correcta deberá ir a la View Victoria.
            int estadoJuego = Escape.GetEstadoJuego();

            if (estadoJuego == 5)
            {
                return View();
            }
           
            // Si no se ha resuelto correctamente la última sala, redirige al usuario a la vista Comenzar.
            return View("Comenzar");
        }
    }
