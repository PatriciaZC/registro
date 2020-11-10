using System.ComponentModel.DataAnnotations;

namespace registro.Models
{
    public class Registro
    {
        [Required]
        [Display(Name="Nombre")]
        public string Nombre { get; set; }

        [Required]
        [Display(Name="Precio")]
        public string precio { get; set; }

        [Required]
        public string descripcion { get; set; }
    }
}