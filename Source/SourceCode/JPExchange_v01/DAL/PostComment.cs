//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class PostComment
    {
        public System.Guid PostCommentId { get; set; }
        public Nullable<System.Guid> PostId { get; set; }
        public string Comment { get; set; }
        public string Status { get; set; }
        public Nullable<byte> Pinned { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.Guid> CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<System.Guid> ModifiedBy { get; set; }
    
        public virtual Post Post { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
    }
}
