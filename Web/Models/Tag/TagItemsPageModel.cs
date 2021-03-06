﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Mn.NewsCms.Common;

namespace Mn.NewsCms.Web.Models
{
    public class TagItemsPageModel
    {
        public TagItemsPageModel()
        {
            Posts = new List<Post>();
            VisualItems = new List<FeedItem>();
            Items = new List<FeedItem>();
        }
        public List<Post> Posts { get; set; }
        public List<FeedItem> VisualItems { get; set; }
        public List<FeedItem> Items { get; set; }
    }
}