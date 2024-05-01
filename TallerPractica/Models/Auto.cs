using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TallerPractica.Models
{
    public class Auto 
    {
        [Key]
        public int IdAuto { get; set; }
        [Required]
        public string? Matricula { get; set; }
        public int NumPuertas { get; set; }
        public string? Color { get; set; }
        public DateTime Anio { get; set; }
        [Required]
        public string? Propietario { get; set; }


        [ForeignKey("MotorIdMotor")]
        public int? MotorIdMotor{ get; set; }
        public Motor? Motor { get; set; }

    }
}
