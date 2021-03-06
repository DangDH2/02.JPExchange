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
    
    public partial class UserDetail
    {
        public UserDetail()
        {
            this.ListUser = new HashSet<User>();
        }
    
        public int UserDetailId { get; set; }
        public string SecondEmail { get; set; }
        public string SecondPhone { get; set; }
        public string Bio { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public string Instagram { get; set; }
        public string LocationX { get; set; }
        public string LocationY { get; set; }
        public string Country { get; set; }
        public Nullable<int> LocationId { get; set; }
        public string Ward { get; set; }
        public string Street { get; set; }
        public string Address { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<int> ModifiedDate { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
    
        public virtual LOCATION Location { get; set; }
        public virtual User CreatedUser { get; set; }
        public virtual User ModifiedUser { get; set; }
        public virtual ICollection<User> ListUser { get; set; }
    }
}
