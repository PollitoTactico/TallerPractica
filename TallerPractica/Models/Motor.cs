using System.ComponentModel.DataAnnotations;

namespace TallerPractica.Models
{
    public class Motor
    {
        [Key]
        public int IdMotor { get; set; }
        public string TipoMotor { get; set; }
        public string CaballoFuerza { get; set; }
        public DateTime AnioFabricacion { get; set; }

    }
}
