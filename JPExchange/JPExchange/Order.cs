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
    
    public partial class Order
    {
        public System.Guid OrderId { get; set; }
        public Nullable<System.Guid> PostId { get; set; }
        public Nullable<System.Guid> OrderUserId { get; set; }
        public string OrderContent { get; set; }
        public string OrderName { get; set; }
        public string OrderAddress { get; set; }
        public string OrderPhone { get; set; }
        public string OrderEmail { get; set; }
        public string Status { get; set; }
        public Nullable<byte> ShipMethod { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.Guid> CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<System.Guid> ModifiedBy { get; set; }
    
        public virtual Post Post { get; set; }
        public virtual User User { get; set; }
        public virtual User CreatedUser { get; set; }
        public virtual User ModifiedUser { get; set; }
    }
}
