using Microsoft.AspNetCore.Mvc;
using Tp01.Models;

namespace Tp01.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        Grupo grupo = new Grupo();
        ViewBag.Integrantes = grupo.DevolverIntegrantes();
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