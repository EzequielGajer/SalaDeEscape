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
            Escape.IncrementarIntentosExtra();
            Escape.IncrementarPistasExtra();
            Escape.DecrementarVida();

            int vidasRestantesDespuesDeRestar = Escape.GetVidasRestantes();

            if (vidasRestantesDespuesDeRestar == 0)
            {
                return View("Derrota");
            }

            ViewBag.VidasRestantes = vidasRestantesDespuesDeRestar;
            ViewBag.PistasExtrasUtilizadas = Escape.GetPistasExtrasUtilizadas();
            ViewBag.IntentosExtraUtilizados = Escape.GetIntentosExtraUtilizados();

            return View("Habitacion1");

        }

        Escape.ResolverSala(sala, clave);
        int vidasRestantesDespuesDeResolver = Escape.GetVidasRestantes();

        if (vidasRestantesDespuesDeResolver == 0)
        {
            return View("Derrota");
        }

        ViewBag.VidasRestantes = vidasRestantesDespuesDeResolver;
        ViewBag.PistasExtrasUtilizadas = Escape.GetPistasExtrasUtilizadas();
        ViewBag.IntentosExtraUtilizados = Escape.GetIntentosExtraUtilizados();

        return View("Habitacion2");
    }

    public IActionResult Habitacion2(int sala, string clave)
    {
        int estadoJuego = Escape.GetEstadoJuego();
        int vidasRestantes = Escape.GetVidasRestantes();

        if (sala != 2 || clave != "LUNA")
        {
            ViewBag.Error = "La respuesta escrita fue incorrecta.";
            Escape.IncrementarIntentosExtra();
            Escape.IncrementarPistasExtra();
            Escape.DecrementarVida();

            int vidasRestantesDespuesDeRestar = Escape.GetVidasRestantes();

            if (vidasRestantesDespuesDeRestar == 0)
            {
                return View("Derrota");
            }

            ViewBag.VidasRestantes = vidasRestantesDespuesDeRestar;
            ViewBag.PistasExtrasUtilizadas = Escape.GetPistasExtrasUtilizadas();
            ViewBag.IntentosExtraUtilizados = Escape.GetIntentosExtraUtilizados();

            return View("Habitacion2");
        }

        Escape.ResolverSala(sala, clave);
        int vidasRestantesDespuesDeResolver = Escape.GetVidasRestantes();

        if (vidasRestantesDespuesDeResolver == 0)
        {
            return View("Derrota");
        }

        ViewBag.VidasRestantes = vidasRestantesDespuesDeResolver;
        ViewBag.PistasExtrasUtilizadas = Escape.GetPistasExtrasUtilizadas();
        ViewBag.IntentosExtraUtilizados = Escape.GetIntentosExtraUtilizados();

        return View("Habitacion3");
    }

    public IActionResult Habitacion3(int sala, string clave)
    {
        int estadoJuego = Escape.GetEstadoJuego();
        int vidasRestantes = Escape.GetVidasRestantes();

        if (sala != 3 || clave != "AZUL")
        {
            ViewBag.Error = "La respuesta escrita fue incorrecta.";
            Escape.IncrementarIntentosExtra();
            Escape.IncrementarPistasExtra();
            Escape.DecrementarVida();
            int vidasRestantesDespuesDeRestar = Escape.GetVidasRestantes();

            if (vidasRestantesDespuesDeRestar == 0)
            {
                return View("Derrota");
            }

            ViewBag.VidasRestantes = vidasRestantesDespuesDeRestar;
            ViewBag.PistasExtrasUtilizadas = Escape.GetPistasExtrasUtilizadas();
            ViewBag.IntentosExtraUtilizados = Escape.GetIntentosExtraUtilizados();

            return View("Habitacion3");
        }

        Escape.ResolverSala(sala, clave);
        int vidasRestantesDespuesDeResolver = Escape.GetVidasRestantes();

        if (vidasRestantesDespuesDeResolver == 0)
        {
            return View("Derrota");
        }

        ViewBag.VidasRestantes = vidasRestantesDespuesDeResolver;
        ViewBag.PistasExtrasUtilizadas = Escape.GetPistasExtrasUtilizadas();
        ViewBag.IntentosExtraUtilizados = Escape.GetIntentosExtraUtilizados();

        return View("Habitacion4");
    }

    public IActionResult Habitacion4(int sala, string clave)
    {
        int estadoJuego = Escape.GetEstadoJuego();
        int vidasRestantes = Escape.GetVidasRestantes();

        if (sala != 4 || clave != "EUROPA")
        {
            ViewBag.Error = "La respuesta escrita fue incorrecta.";
            Escape.IncrementarIntentosExtra();
            Escape.IncrementarPistasExtra();
            Escape.DecrementarVida();

            int vidasRestantesDespuesDeRestar = Escape.GetVidasRestantes();

            if (vidasRestantesDespuesDeRestar == 0)
            {
                return View("Derrota");
            }

            ViewBag.VidasRestantes = vidasRestantesDespuesDeRestar;
            ViewBag.PistasExtrasUtilizadas = Escape.GetPistasExtrasUtilizadas();
            ViewBag.IntentosExtraUtilizados = Escape.GetIntentosExtraUtilizados();

            return View("Habitacion4");
        }

        Escape.ResolverSala(sala, clave);
        int vidasRestantesDespuesDeResolver = Escape.GetVidasRestantes();

        if (vidasRestantesDespuesDeResolver == 0)
        {
            return View("Derrota");
        }

        ViewBag.VidasRestantes = vidasRestantesDespuesDeResolver;
        ViewBag.PistasExtrasUtilizadas = Escape.GetPistasExtrasUtilizadas();
        ViewBag.IntentosExtraUtilizados = Escape.GetIntentosExtraUtilizados();

        return View("Victoria");
    }

    public IActionResult Victoria()
    {
        int estadoJuego = Escape.GetEstadoJuego();

        if (estadoJuego == 5)
        {
            int intentosExtraUtilizados = Escape.GetIntentosExtraUtilizados();
            int pistasExtrasUtilizadas = Escape.GetPistasExtrasUtilizadas();

            ViewBag.IntentosExtraUtilizados = intentosExtraUtilizados;
            ViewBag.PistasExtrasUtilizadas = pistasExtrasUtilizadas;

            return View();
        }

        return View("Comenzar");
    }

    public IActionResult Derrota()
    {
        return View("Derrota");
    }

    public IActionResult NuevoJuego()
    {
        Escape.ResetearVidas();
        
        Escape.ResetearPistasYIntentosExtra();
        int vidasRestantes = Escape.GetVidasRestantes();
        ViewBag.VidasRestantes = vidasRestantes;

        return View("Habitacion1");
    }
}