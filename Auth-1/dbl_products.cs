//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Auth_1
{
    using System;
    using System.Collections.Generic;
    
    public partial class dbl_products
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Color { get; set; }
        public Nullable<int> CategoryId { get; set; }
    
        public virtual dbl_category dbl_category { get; set; }
    }
}
