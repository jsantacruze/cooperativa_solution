//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace cooperativa_datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class PERSONA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PERSONA()
        {
            this.CREDITO = new HashSet<CREDITO>();
            this.CREDITO1 = new HashSet<CREDITO>();
        }
    
        public int PersonaID { get; set; }
        public string PersonaIdentificacion { get; set; }
        public string PersonaNombres { get; set; }
        public string PersonaApellidos { get; set; }
        public string PersonaRazonSocial { get; set; }
        public string PersonaDireccion { get; set; }
        public string PersonaTelefono { get; set; }
        public Nullable<bool> PersonaNatural { get; set; }
        public string TipoIdentificacionID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CREDITO> CREDITO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CREDITO> CREDITO1 { get; set; }
        public virtual EMPLEADO EMPLEADO { get; set; }
        public virtual TIPO_IDENTIFICACION TIPO_IDENTIFICACION { get; set; }
        public virtual SOCIO SOCIO { get; set; }
    }
}
