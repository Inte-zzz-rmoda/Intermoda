//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Intermoda.Produccion.Lavanderia
{
    using System;
    using System.Collections.Generic;
    
    public partial class Lavados
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Lavados()
        {
            this.ArchivosGlobales = new HashSet<ArchivosGlobales>();
            this.OpcionesLavados = new HashSet<OpcionesLavados>();
            this.OpcionLavadoOrden = new HashSet<OpcionLavadoOrden>();
        }
    
        public int LavadoId { get; set; }
        public string LavadoNombre { get; set; }
        public string LavadoDescripcion { get; set; }
        public int ColorIntermodaId { get; set; }
        public Nullable<int> IsActivo { get; set; }
        public Nullable<System.DateTime> LavadoFechaCreacion { get; set; }
        public Nullable<System.DateTime> LavadoFechaActualizacion { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ArchivosGlobales> ArchivosGlobales { get; set; }
        public virtual ColoresIntermoda ColoresIntermoda { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OpcionesLavados> OpcionesLavados { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OpcionLavadoOrden> OpcionLavadoOrden { get; set; }
    }
}