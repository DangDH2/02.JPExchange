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
    
    public partial class LOCATION
    {
        public LOCATION()
        {
            this.PostLocation = new HashSet<PostLocation>();
            this.UserDetail = new HashSet<UserDetail>();
        }
    
        public System.Guid LocationId { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public Nullable<byte> Index { get; set; }
    
        public virtual ICollection<PostLocation> PostLocation { get; set; }
        public virtual ICollection<UserDetail> UserDetail { get; set; }
    }
}
