using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyfirstProyectWithLineCommand.Models;

namespace MyfirstProyectWithLineCommand.Controllers;

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

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
    public IActionResult StudentList()
    {
        StudentModel Alumno = new StudentModel();
        Alumno.Nombre = "Mario Loredo";
        Alumno.Carrera = "Ing en Desarrollo Software";
        Alumno.FechaCreacion = new DateTime(2024, 05, 17);
        return View(Alumno);
    }
    public IActionResult MaestroList()
    {
       MaestroModel Maestro = new MaestroModel();
       Maestro.Nombre = "Ricardo Arturo";
       Maestro.Carrera = "Ing en Desarrollo Software";
        return View(Maestro);
     
    }
 public IActionResult MateriasList()
    {
       MateriasModel Materia = new MateriasModel();
       Materia.Nombre = "Calculo Integral";
        return View(Materia);
     
    }
   
}
