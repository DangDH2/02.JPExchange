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
    
    public partial class Post
    {
        public Post()
        {
            this.Bookmark = new HashSet<Bookmark>();
            this.ListMedia = new HashSet<Media>();
            this.ListOrder = new HashSet<Order>();
            this.ListComment = new HashSet<PostComment>();
            this.ListPostLocation = new HashSet<PostLocation>();
            this.ListPostTag = new HashSet<PostTag>();
            this.ListRating = new HashSet<Rating>();
        }
    
        public System.Guid PostId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Nullable<System.Guid> UserId { get; set; }
        public Nullable<System.Guid> CategoryId { get; set; }
        public Nullable<double> Price { get; set; }
        public Nullable<double> PriceSale { get; set; }
        public Nullable<System.DateTime> ValidDate { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.Guid> CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<System.Guid> ModifiedBy { get; set; }
        public Nullable<System.Guid> LevelId { get; set; }
    
        public virtual ICollection<Bookmark> Bookmark { get; set; }
        public virtual CATEGORY Category { get; set; }
        public virtual LEVEL Level { get; set; }
        public virtual ICollection<Media> ListMedia { get; set; }
        public virtual ICollection<Order> ListOrder { get; set; }
        public virtual User UserOwner { get; set; }
        public virtual User CreatedUser { get; set; }
        public virtual User ModifiedUser { get; set; }
        public virtual ICollection<PostComment> ListComment { get; set; }
        public virtual ICollection<PostLocation> ListPostLocation { get; set; }
        public virtual ICollection<PostTag> ListPostTag { get; set; }
        public virtual ICollection<Rating> ListRating { get; set; }
    }
}
