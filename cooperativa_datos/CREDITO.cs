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
    
    public partial class CREDITO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CREDITO()
        {
            this.DETALLE_CREDITO = new HashSet<DETALLE_CREDITO>();
        }
    
        public int CreditoID { get; set; }
        public int CuentaID { get; set; }
        public int TipoCreditoID { get; set; }
        public decimal CreditoMonto { get; set; }
        public bool CreditoActivo { get; set; }
        public System.DateTime CreditoFechaEntrega { get; set; }
        public int CreditoPlazo { get; set; }
        public int CreditoGaranteID1 { get; set; }
        public Nullable<int> CreditoGaranteID2 { get; set; }
        public int UsuarioIDResponsable { get; set; }
    
        public virtual CUENTA CUENTA { get; set; }
        public virtual PERSONA PERSONA { get; set; }
        public virtual PERSONA PERSONA1 { get; set; }
        public virtual TIPO_CREDITO TIPO_CREDITO { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DETALLE_CREDITO> DETALLE_CREDITO { get; set; }
    }
}
