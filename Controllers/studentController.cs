using Microsoft.AspNetCore.Mvc;
using MyfirstProyectWithLineCommand.Models;

namespace MyfirstProyectWithLineCommand.Controllers
{
    public class studentController : Controller
    {
        public studentController()
        {
        }
public IActionResult StudentAdd()
    {
       
        return View();
    }
    public IActionResult StudentSave()
    {
       
        return Redirect("StudentList");
    }
     public IActionResult StudentList()
    {
        StudentModel Alumno = new StudentModel();
        Alumno.Matricula = 2312;
        Alumno.Nombre = "Mario Loredo";
        Alumno.Carrera = "Ing en Desarrollo Software";
        Alumno.Edad = 20;
        Alumno.Sexo ="Masculino";
        Alumno.FechaCreacion = new DateTime(2024, 05, 17);
         StudentModel Alumno2 = new StudentModel();
       Alumno2.Matricula = 4312;
        Alumno2.Nombre = "Mario Loredo";
        Alumno2.Carrera = "Ing en Desarrollo Softe";
        Alumno2.Edad = 54;
        Alumno2.Sexo ="Mulino";
        Alumno2.FechaCreacion = new DateTime(2024, 05, 17);
         StudentModel Alumno3 = new StudentModel();
     Alumno3.Matricula = 43722;
        Alumno3.Nombre = "Mario Loredo";
        Alumno3.Carrera = "Ing enDesarrollo Software";
        Alumno3.Edad = 20;
        Alumno3.Sexo ="Masculino";
        Alumno3.FechaCreacion = new DateTime(2024, 05, 17);
       

        List<StudentModel> list = new List<StudentModel>();
        list.Add(Alumno);
         list.Add(Alumno2);
          list.Add(Alumno3);

          return View(list);
    }
     public IActionResult StudentShowAndEdit()
    {
        return View();
    }
  public IActionResult StudentEdit()
    {
        return Redirect("StudentList");
    }
    public IActionResult StudentShowAndDeleted()
    {
        return View();
    }
     public IActionResult StudentDeleted()
    {
        return Redirect("StudentList");
    }

    }
}