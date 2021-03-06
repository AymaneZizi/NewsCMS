using Mn.NewsCms.Common.BaseClass;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Mn.NewsCms.Common.Membership;
using Mn.NewsCms.Common.Models;

namespace Mn.NewsCms.Common
{
    public partial class Tag : BaseEntity
    {
        public Tag()
        {            
            this.SearchHistories = new List<SearchHistory>();
            this.Categories = new List<Category>();
            this.Users = new List<User>();
        }

        [Column("TagId")]
        public override long Id
        {
            get
            {
                return base.Id;
            }
            set
            {
                base.Id = value;
            }
        }

        public string Title { get; set; }
        public string Value { get; set; }
        public int Rate { get; set; }
        public int RepeatCount { get; set; }
        public string EnValue { get; set; }
        public int? ParentTagId { get; set; }
        public bool InIndex { get; set; }
        public DateTime? CreationDate { get; set; }
        public string Color { get; set; }
        public string ImageThumbnail { get; set; }
        public bool HasBackgroundImage { get; set; }
        public string BackgroundColor { get; set; }       
        public virtual ICollection<SearchHistory> SearchHistories { get; set; }
        public virtual ICollection<Category> Categories { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
        public virtual ICollection<Ad> Ads { get; set; }
        public virtual ICollection<Feed> Feeds { get; set; }
    }
}
