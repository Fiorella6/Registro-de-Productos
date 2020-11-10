using System.ComponentModel.DataAnnotations;

namespace Registro_de_productos.Models
{
    public class Contacto
    {
        [Required]
        public string nombre { get; set;}
        [Required]
        [EmailAddress]
        public string correo { get; set;}
    }
}