using Microsoft.AspNetCore.Mvc;
using MyfirstProyectWithLineCommand.Models;

namespace MyfirstProyectWithLineCommand.Controllers
{
    public class MaestroController : Controller
    {

        private readonly ILogger<MaestroController> _logger;
        public MaestroController(ILogger<MaestroController> logger)
        {
            _logger = logger;
        }

 public IActionResult MaestroAdd()
        {

            return View();
        }
[HttpPost]
public IActionResult MaestroAdd(MaestroModel maestro)
    {
       
        if (!ModelState.IsValid)
            {
                _logger.LogWarning("WattsonOO");
                return View();
            }

            _logger.LogInformation("HOLAAAAAAA");

            return Redirect("MaestroList");
    }


 public IActionResult MaestroList()
    {
        List<MaestroModel> list = new List<MaestroModel>();
       MaestroModel Maestro1 = new MaestroModel();
       Maestro1.Nombre = "Ricardo Arturo";
       Maestro1.Sexo = "Masculino";
         Maestro1.Edad = 25;
         Maestro1.Carrera = "Matematicas";
       MaestroModel Maestro2 = new MaestroModel();
      Maestro2.Nombre = "Ricardo Arturo";
       Maestro2.Sexo = "Masculino";
         Maestro2.Edad = 25;
             Maestro2.Carrera = "Matematicas";
       MaestroModel Maestro3 = new MaestroModel();
     Maestro3.Nombre = "Ricardo Arturo";
       Maestro3.Sexo = "Masculino";
         Maestro3.Edad = 25;
             Maestro3.Carrera = "Matematicas";
       list.Add(Maestro1);
        list.Add(Maestro2);
         list.Add(Maestro3);

        return View(list);
     
    }
   
      public IActionResult MaestroEdit(Guid Id)
        {
            MaestroModel teacher = new MaestroModel();
            teacher.id = Id;
            teacher.Nombre = " Profe";
            return View(teacher);
        }
        [HttpPost]
        public IActionResult MaestroEdit(StudentModel teacher)
        {

     if (!ModelState.IsValid)
            {
                _logger.LogWarning("WattsonOO");
                  teacher.Nombre = "Materia no validad";
                return View(teacher);
            }

            _logger.LogInformation("HOLAAAAAAA");

            return Redirect("MaestroList");

        }
    }
}