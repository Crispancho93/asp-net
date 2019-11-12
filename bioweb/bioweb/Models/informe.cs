//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace bioweb.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class informe
    {
        public int id_informe { get; set; }
        public string nombre { get; set; }
        public int usuario_sistema { get; set; }
        public int conductor { get; set; }
        public string ruta { get; set; }
        public string tipo_informe { get; set; }
        public System.DateTime fecha_hora { get; set; }
        public Nullable<decimal> kg_remisionado { get; set; }
        public Nullable<decimal> kg_planta { get; set; }
        public Nullable<decimal> diferencia { get; set; }
        public Nullable<decimal> producto_malo { get; set; }
        public Nullable<decimal> perdida_peso { get; set; }
        public Nullable<decimal> caneca { get; set; }
        public Nullable<decimal> galon { get; set; }
        public Nullable<decimal> peso_bruto { get; set; }
        public Nullable<decimal> tara { get; set; }
        public Nullable<decimal> peso_neto { get; set; }
        public Nullable<decimal> grados_brix { get; set; }
        public Nullable<decimal> cantidad_bulto { get; set; }
        public string observacion { get; set; }
    
        public virtual persona persona { get; set; }
        public virtual usuario usuario { get; set; }
    }
}
