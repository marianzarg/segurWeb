//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dominio
{
    using System;
    using System.Collections.Generic;
    
    public partial class Modelos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Modelos()
        {
            this.Vehiculos = new HashSet<Vehiculos>();
        }
    
        public int modeloId { get; set; }
        public string modeloDescripcion { get; set; }
        public Nullable<int> marcaId { get; set; }
        public Nullable<int> tipoVehiculoId { get; set; }
        public Nullable<int> modeloEstado { get; set; }
    
        public virtual Marcas Marcas { get; set; }
        public virtual TipoVehiculos TipoVehiculos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vehiculos> Vehiculos { get; set; }
    }
}