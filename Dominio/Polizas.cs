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
    
    public partial class Polizas
    {
        public int polizaId { get; set; }
        public Nullable<int> vehiculoId { get; set; }
        public Nullable<int> clienteId { get; set; }
        public Nullable<System.DateTime> polizaFechaAlta { get; set; }
        public Nullable<System.DateTime> polizaFechaVigencia { get; set; }
        public Nullable<System.DateTime> polizaFechaBaja { get; set; }
        public Nullable<int> companiaId { get; set; }
        public Nullable<int> polizaEstado { get; set; }
    
        public virtual Clientes Clientes { get; set; }
        public virtual Companias Companias { get; set; }
        public virtual Vehiculos Vehiculos { get; set; }
    }
}