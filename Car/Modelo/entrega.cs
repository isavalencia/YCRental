//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Car.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class entrega
    {
        public int id_entrega { get; set; }
        public string estado_entrega { get; set; }
        public string kilometraje { get; set; }
        public int id_cliente { get; set; }
        public int id_contrato { get; set; }
        public int id_vehiculo { get; set; }
        public int id_alquiler { get; set; }
    
        public virtual alquilere alquilere { get; set; }
        public virtual cliente cliente { get; set; }
        public virtual contrato contrato { get; set; }
        public virtual vehiculo vehiculo { get; set; }
    }
}