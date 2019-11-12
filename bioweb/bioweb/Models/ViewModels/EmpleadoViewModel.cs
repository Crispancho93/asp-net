using System.ComponentModel.DataAnnotations;


namespace bioweb.Models.ViewModels
{
    public class EmpleadoViewModel
    {
        [Display(Name = "* ID")]
        public int idPersona { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "* NOMBRE")]
        public string nombre { get; set; }

        // no llega por la vista, se asigna una vez se valida el ModelState.IsValid del controller
        public string tipoPersona { get; set; }

        [Required]
        [StringLength(10)]
        [Display(Name = "* TIPO DOCUMENTO")]
        public string tipoDocumento { get; set; }

        [Required]
        [StringLength(45)]
        [Display(Name = "* NÚMERO DOCUMENTO")]
        public string numeroDocumento { get; set; }

        [Required]
        [StringLength(75)]
        [Display(Name = "* DIRECCIÓN")]
        public string direccion { get; set; }

        [StringLength(75)]
        [Display(Name = "TELÉFONO")]
        public string telefono { get; set; }

        [StringLength(75)]
        [Display(Name = "CORREO")]
        public string correo { get; set; }

        [StringLength(75)]
        [Display(Name = "NOMBRE CONTACTO")]
        public string nombreContacto { get; set; }

        [StringLength(75)]
        [Display(Name = "NÚMERO CONTACTO")]
        public string telefonoContacto { get; set; }

        public string confirmacion { get; set; }

    }
}