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
    
    public partial class tb_empresa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_empresa()
        {
            this.tb_formulario = new HashSet<tb_formulario>();
        }
    
        public int id { get; set; }
        public string nombre { get; set; }
        public string nit { get; set; }
        public string correo { get; set; }
        public string direccion { get; set; }
        public string celular { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_formulario> tb_formulario { get; set; }
    }
}
