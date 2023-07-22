using System.ComponentModel.DataAnnotations;

namespace ExamenUnidadII.Models
{
    public class Test
    {

        [Required(ErrorMessage = "Debe Ingresar su Nombre")]
        [Display(Name = "Nombre")]
        public string Name { get; set; }

        [Required(ErrorMessage = "El Correo Electrónico es obligatorio")]
        [EmailAddress(ErrorMessage = "Ingrese una dirección de correo válida")]
        [Display(Name = "Correo Electrónico")]
        public string Email { get; set; }

        public int Result { get; set; }
    }
}
