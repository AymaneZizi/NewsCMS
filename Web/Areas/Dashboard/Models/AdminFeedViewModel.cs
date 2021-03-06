﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mn.NewsCms.Common;
using Mn.NewsCms.Web.WebLogic.BaseModel;

namespace Mn.NewsCms.Web.Areas.Dashboard.Models
{
    public class AdminFeedViewModel: PageGridModel
    {
        public long? SiteId { get; set; }
        public long? CatId { get; set; }
        public string Term { get; set; }
        public List<Feed> Feeds { get; set; }
        public List<SelectListItem> Cats { get; set; }
    }
}