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
    
    public partial class tb_usuario_vendedor
    {
        public int id { get; set; }
        public string usuario { get; set; }
        public string clave { get; set; }
        public int id_vendedor { get; set; }
    
        public virtual tb_vendedor tb_vendedor { get; set; }
    }
}
