using System.ComponentModel.DataAnnotations;
namespace TareaSem7.Models
{
    public class Formulario
    {
        [Required]
        [Display(Name="Nombre del Producto")]
        public string Nombre { get; set; }
        
        [Required]
        [Display(Name="Precio del Producto")]
        public string Precio { get; set; }

        [Required]
        [Display(Name="Descripcion del Producto")]
        public string Descripcion { get; set; }
    }
}