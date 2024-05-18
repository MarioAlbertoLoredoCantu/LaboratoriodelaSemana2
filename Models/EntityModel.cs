namespace MyfirstProyectWithLineCommand.Models
{
    public class EntityModel : BaseModel
    {
        public EntityModel()
        {

        }
     
        public int Clase { get; set; }

        public int  Matricula { get; set; }

        public string Nombre { get; set; }

        public string Carrera { get; set; }
    
        public int Edad {get; set;} 

        public string Sexo { get; set; }
        
       
    }

 }
