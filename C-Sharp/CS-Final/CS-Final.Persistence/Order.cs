//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CS_Final.Persistence
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public System.Guid Id { get; set; }
        public string Size { get; set; }
        public string Crust { get; set; }
        public string Toppings { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Zip { get; set; }
        public string Phone { get; set; }
        public string Payment { get; set; }
    }
}