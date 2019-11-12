using System.ComponentModel.DataAnnotations;

namespace bioweb.Models.ViewModels
{
    public class UsuarioViewModel
    {
        [Display(Name = "* ID")]
        public int idUsuario { get; set; }
        
        [Required]
        [StringLength(100)]
        [Display(Name = "* NOMBRE")]
        public string nombre { get; set; }

        [Required]
        [StringLength(10)]
        [Display(Name = "* TIPO USUARIO")]
        public string tipoUsuario { get; set; }

        [Required]
        [StringLength(10)]
        [Display(Name = "* TIPO DOCUMENTO")]
        public string tipoDocumento { get; set; }

        [Required]
        [StringLength(45)]
        [Display(Name = "* NÚMERO DOCUMENTO")]
        public string numeroDocumento { get; set; }

        [StringLength(75)]
        [Display(Name = "DIRECCIÓN")]
        public string direccion { get; set; }
        
        [StringLength(75)]
        [Display(Name = "TELÉFONO")]
        public string telefono { get; set; }

        [StringLength(75)]
        [Display(Name = "CORREO")]
        public string correo { get; set; }
        
        [Required]
        [StringLength(75)]
        [Display(Name = "* LOGUIN")]
        public string loguin { get; set; }

        [Required]
        [StringLength(75)]
        [Display(Name = "* CLAVE")]
        public string clave { get; set; }

    }
}