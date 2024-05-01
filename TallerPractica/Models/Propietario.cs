using Microsoft.AspNetCore.Cors;
using System.ComponentModel.DataAnnotations;

namespace TallerPractica.Models
{
    public class Propietario
    {
        [Key]
        public int IdPropietario { get; set; }
        public char Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }

        [Display (Name= "Es Ecuatoriano")]
        public bool EsEcuatoriano { get; set; }   
    }
}
