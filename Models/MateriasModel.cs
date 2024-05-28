using System.ComponentModel.DataAnnotations;

namespace MyfirstProyectWithLineCommand.Models
{
    public class MateriasModel :BaseModel
    {
        public MateriasModel()
        {

        }

        [Required(ErrorMessage = "El {0} es un campo requerido")]
      
        public string Nombre { get; set; }
    }

    
}