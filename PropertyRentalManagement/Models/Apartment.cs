//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PropertyRentalManagement.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Apartment
    {
        public int ApartmentId { get; set; }
        public int BuildingId { get; set; }
        public int Number { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
    
        public virtual Building Building { get; set; }
    }
}
