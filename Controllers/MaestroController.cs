using Microsoft.AspNetCore.Mvc;
using MyfirstProyectWithLineCommand.Models;

namespace MyfirstProyectWithLineCommand.Controllers
{
    public class MaestroController : Controller
    {
        public MaestroController()
        {
        }
public IActionResult MaestroAdd()
{
    return View();
}

 public IActionResult MaestroList()
    {
       MaestroModel Maestro = new MaestroModel();
       Maestro.Nombre = "Ricardo Arturo";
       Maestro.Carrera = "Ing en Desarrollo Software";
        return View(Maestro);
     
    }
    }
}