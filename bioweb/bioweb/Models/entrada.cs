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
    
    public partial class entrada
    {
        public int id_entrada { get; set; }
        public int usuario_sistema { get; set; }
        public int producto { get; set; }
        public int responsable { get; set; }
        public int proveedor { get; set; }
        public string ruta { get; set; }
        public int conductor { get; set; }
        public string numero_placa { get; set; }
        public string consecutivo { get; set; }
        public System.DateTime fecha_hora { get; set; }
        public Nullable<decimal> caneca { get; set; }
        public Nullable<decimal> galon { get; set; }
        public Nullable<decimal> kg_remisionado { get; set; }
        public Nullable<decimal> kg_planta { get; set; }
        public Nullable<decimal> diferencia { get; set; }
        public Nullable<decimal> producto_malo { get; set; }
        public Nullable<decimal> perdida_peso { get; set; }
        public Nullable<decimal> peso_neto { get; set; }
        public string observacion { get; set; }
    
        public virtual persona persona { get; set; }
        public virtual producto producto1 { get; set; }
        public virtual persona persona1 { get; set; }
        public virtual persona persona2 { get; set; }
        public virtual usuario usuario { get; set; }
    }
}
