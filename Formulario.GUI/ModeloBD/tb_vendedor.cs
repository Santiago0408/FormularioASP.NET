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
    
    public partial class tb_vendedor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_vendedor()
        {
            this.tb_cliente = new HashSet<tb_cliente>();
            this.tb_cliente1 = new HashSet<tb_cliente>();
            this.tb_usuario_vendedor = new HashSet<tb_usuario_vendedor>();
        }
    
        public int id { get; set; }
        public string primer_nombre { get; set; }
        public string otros_nombres { get; set; }
        public string primer_apellido { get; set; }
        public string segundo_apellido { get; set; }
        public string documento { get; set; }
        public string celular { get; set; }
        public string correo { get; set; }
        public string foto { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_cliente> tb_cliente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_cliente> tb_cliente1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_usuario_vendedor> tb_usuario_vendedor { get; set; }
    }
}
