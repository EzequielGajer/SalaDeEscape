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

    public IActionResult Personajes()
    {
        return View();
    }

    public IActionResult Comenzar()
    {
    int estadoJuego = Escape.GetEstadoJuego();
    int vidasRestantes = Escape.GetVidasRestantes();

    ViewBag.VidasRestantes = vidasRestantes;

    return View("Comenzar");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]

 public IActionResult Habitacion1(int sala, string clave)
    {
        int estadoJuego = Escape.GetEstadoJuego();
        int vidasRestantes = Escape.GetVidasRestantes();

        if (sala != 1 || clave != "ESPACIO")
        {
            ViewBag.Error = "La respuesta escrita fue incorrecta.";
            vidasRestantes = vidasRestantes-1;
            ViewBag.VidasRestantes = vidasRestantes;
            return View("Habitacion1");
        }

        Escape.ResolverSala(sala, clave);

        ViewBag.VidasRestantes = vidasRestantes;

        return View("Habitacion2");
    }

    public IActionResult Habitacion2(int sala, string clave)
    {
        int estadoJuego = Escape.GetEstadoJuego();
        int vidasRestantes = Escape.GetVidasRestantes();
        
        if (sala != 2 || clave != "TALL")
        {
            ViewBag.Error = "La respuesta escrita fue incorrecta.";
            vidasRestantes = vidasRestantes-1;
            ViewBag.VidasRestantes = vidasRestantes;
            return View("Habitacion2");
        }

        Escape.ResolverSala(sala, clave);

        ViewBag.VidasRestantes = vidasRestantes;

        return View("Habitacion3");
    }

    public IActionResult Habitacion3(int sala, string clave)
    {
        if (sala != 3 || clave != "Incognita Sala 3")
        {
            ViewBag.Error = "La respuesta escrita fue incorrecta.";
            return View("Habitacion3");
        }

        Escape.ResolverSala(sala, clave);

        int estadoJuego = Escape.GetEstadoJuego();
        int vidasRestantes = Escape.GetVidasRestantes();

        ViewBag.VidasRestantes = vidasRestantes;

        return View("Habitacion4");
    }

    public IActionResult Habitacion4(int sala, string clave)
    {
        if (sala != 4 || clave != "Incognita Sala 4")
        {
            ViewBag.Error = "La respuesta escrita fue incorrecta.";
            return View("Habitacion4");
        }

        Escape.ResolverSala(sala, clave);

        int estadoJuego = Escape.GetEstadoJuego();
        int vidasRestantes = Escape.GetVidasRestantes();

        ViewBag.VidasRestantes = vidasRestantes;

        return View("Victoria");
    }

    public IActionResult Victoria()
    {
        int estadoJuego = Escape.GetEstadoJuego();

        if (estadoJuego == 5)
        {
            return View();
        }

        return View("Comenzar");
    }
}