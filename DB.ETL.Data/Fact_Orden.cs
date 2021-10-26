//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DB.ETL.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Fact_Orden
    {
        public int IdOrden { get; set; }
        public int Cliente_Key { get; set; }
        public Nullable<int> FechaOrden { get; set; }
        public int Empleado_Key { get; set; }
        public int Producto_Key { get; set; }
        public Nullable<int> FechaDespacho { get; set; }
        public int Fecha_Key { get; set; }
        public Nullable<int> EnvioMediante { get; set; }
        public Nullable<int> Carga { get; set; }
        public Nullable<decimal> PrecioUnitario { get; set; }
        public Nullable<int> Cantidad { get; set; }
        public Nullable<decimal> Descuento { get; set; }
        public Nullable<short> UnidadesDisponibles { get; set; }
        public Nullable<short> UnidadesEnOrden { get; set; }
        public Nullable<short> PuntoReorden { get; set; }
    
        public virtual Dim_Cliente Dim_Cliente { get; set; }
        public virtual Dim_Empleado Dim_Empleado { get; set; }
        public virtual Dim_Fecha Dim_Fecha { get; set; }
        public virtual Dim_Producto Dim_Producto { get; set; }
    }
}
