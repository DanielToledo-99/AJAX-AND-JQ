//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CodeFirstDemo.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class InvoiceDetails
    {
        public int InvoiceDetailID { get; set; }
        public int CustomerID { get; set; }
        public int SellerID { get; set; }
    
        public virtual Customers Customers { get; set; }
        public virtual Sellers Sellers { get; set; }
    }
}
