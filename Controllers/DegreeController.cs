using Microsoft.AspNetCore.Mvc;
using MyfirstProyectWithLineCommand.Models;

namespace MyfirstProyectWithLineCommand.Controllers
{
    public class DegreeController : Controller
    {
        private readonly ILogger<DegreeController> _logger;
        public DegreeController(ILogger<DegreeController> logger)
        {
            _logger = logger;
        }

        public IActionResult DegreeAdd()
        {

            return View();
        }

        [HttpPost]
        public IActionResult DegreeAdd(MateriasModel degree)
        {

            if (!ModelState.IsValid)
            {
                _logger.LogWarning("WattsonOO");
                return View();
            }

            _logger.LogInformation("HOLAAAAAAA");

            return Redirect("MateriasList");

        }
        public IActionResult MateriasList()
        {

            MateriasModel Materia = new MateriasModel();
            Materia.Nombre = "Calculo Integral";
            MateriasModel Materia2 = new MateriasModel();
            Materia2.Nombre = "Matematicas II";
            MateriasModel Materia3 = new MateriasModel();
            Materia3.Nombre = "Fisica I";


            List<MateriasModel> list = new List<MateriasModel>();
            list.Add(Materia);
            list.Add(Materia2);
            list.Add(Materia3);
            return View(list);


        }
        
        public IActionResult DegreeEdit(Guid Id)
        {
            MateriasModel carrera = new MateriasModel();
            carrera.id = Id;
            carrera.Nombre = "Materia cargada";
            return View(carrera);
        }
        [HttpPost]
        public IActionResult DegreeEdit(MateriasModel carrera)
        {

     if (!ModelState.IsValid)
            {
                _logger.LogWarning("WattsonOO");
                  carrera.Nombre = "Materia no validad";
                return View(carrera);
            }

            _logger.LogInformation("HOLAAAAAAA");

            return Redirect("MateriasList");

        }
        public IActionResult DegreeShowAndDeleted(Guid Id)
        {
            MateriasModel carrera = new MateriasModel();
            carrera.id = Id;
            carrera.Nombre = "Materia cargada";
            return View(carrera);

        }
        public IActionResult DegreeDeleted()
        {
            return Redirect("MateriaList");
        }


    }
}