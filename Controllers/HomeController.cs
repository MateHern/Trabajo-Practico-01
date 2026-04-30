// using System.Diagnostics;
// using Microsoft.AspNetCore.Mvc;
// using Tp01.Models;

// namespace Tp01.Controllers;

// public class HomeController : Controller
// {
//     private readonly ILogger<HomeController> _logger;

//     public HomeController(ILogger<HomeController> logger)
//     {
//         _logger = logger;
//     }

//     public IActionResult Index()
//     {
//         Grupo grupo = new Grupo ();
//         Dictionary<int,Integrante> pablo= grupo.mostrarIntegrantes();
//         ViewBag.Integrantes=pablo;

//         return View();
//     }

//     public IActionResult Privacy()
//     {
//         return View();
//     }

//     [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
//     public IActionResult Error()
//     {
//         return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
//     }
// }

using Microsoft.AspNetCore.Mvc;
using Tp01.Models;

namespace Tp01.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        Grupo grupo = new Grupo();
        ViewBag.Integrantes = grupo.mostrarIntegrantes();
        return View();
    }

    public IActionResult SelectIntegrante(int dni)
    {
        Grupo grupo = new Grupo();
        Integrante integrante = grupo.GetIntegrante(dni);
        ViewBag.Integrante = integrante;
        ViewBag.DNI = dni;
        return View("infoIntegrante");
    }
}