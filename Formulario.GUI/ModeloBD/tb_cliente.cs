//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Formulario.GUI.ModeloBD
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_cliente
    {
        public int id { get; set; }
        public string primer_nombre { get; set; }
        public string otros_nombres { get; set; }
        public string primer_apellido { get; set; }
        public string segundo_apellido { get; set; }
        public string documento { get; set; }
        public string celular { get; set; }
        public string correo { get; set; }
        public int creador { get; set; }
        public System.DateTime fecha_creacion { get; set; }
        public Nullable<int> editor { get; set; }
        public Nullable<System.DateTime> fecha_edicion { get; set; }
    
        public virtual tb_vendedor tb_vendedor { get; set; }
        public virtual tb_vendedor tb_vendedor1 { get; set; }
    }
}
