﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookShopSolution.ViewModels.Catalog.Categories
{
    public class CategoryUpdateRequest
    {
        public string Name { get; set; }
        public string? SeoDescription { get; set; }
        public string? SeoTitle { get; set; }
        public string LanguageId { get; set; }
        public string? SeoAlias { get; set; }
        public bool IsShowOnHome { get; set; }
    }
}