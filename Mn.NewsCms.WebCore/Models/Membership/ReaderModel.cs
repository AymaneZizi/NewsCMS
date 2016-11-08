﻿using System.Collections.Generic;
using Mn.NewsCms.Common;
using Mn.NewsCms.WebCore.Models.Cat;
using Mn.NewsCms.WebCore.Models.Tag;

namespace Mn.NewsCms.WebCore.Models.Membership
{
    public class ReaderModel
    {
        public ReaderModel()
        {
            Tags = new List<TagViewModel>();
            Categories = new List<CategoryViewModel>();
            Sites = new List<SiteOnlyTitle>();
            RecomendTags = new List<TagViewModel>();
            RecomendSites = new List<SiteOnlyTitle>();
            RecomendCats = new List<CategoryViewModel>();
        }
        public string UserTitle { get; set; }
        public List<TagViewModel> Tags { get; set; }
        public List<CategoryViewModel> Categories { get; set; }
        public List<SiteOnlyTitle> Sites { get; set; }
        public List<TagViewModel> RecomendTags { get; set; }
        public List<SiteOnlyTitle> RecomendSites { get; set; }
        public List<CategoryViewModel> RecomendCats { get; set; }
    }
}