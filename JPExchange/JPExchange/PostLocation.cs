//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JPExchange
{
    using System;
    using System.Collections.Generic;
    
    public partial class PostLocation
    {
        public System.Guid PostId { get; set; }
        public System.Guid LocationId { get; set; }
        public System.Guid PostLocationId { get; set; }
    
        public virtual LOCATION Location { get; set; }
        public virtual Post Post { get; set; }
    }
}