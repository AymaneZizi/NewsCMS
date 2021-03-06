using Mn.NewsCms.Common.BaseClass;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Script.Serialization;

namespace Mn.NewsCms.Common
{
    public class RecentKeyWord : BaseEntity
    {
        public RecentKeyWord()
        {

        }
        [Column("RecentKeyWordId")]
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

        [Display(Name = "مقدار")]
        public string Value { get; set; }
        [Display(Name = "تگ هست")]
        public bool IsTag { get; set; }
        [Display(Name = "عنوان")]
        public string Title { get; set; }
    }
}
