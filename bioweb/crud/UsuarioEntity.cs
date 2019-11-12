using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud
{
    class UsuarioEntity
    {
        public int idUsuario { get; set; }
        public string nombre { get; set; }
        public string tipoUsuario { get; set; }
        public string tipoDocumento { get; set; }
        public string numeroDocumento { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string correo { get; set; }
        public string loguin { get; set; }
        public string clave { get; set; }
    }
}
