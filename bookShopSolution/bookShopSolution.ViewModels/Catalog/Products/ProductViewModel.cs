﻿using bookShopSolution.ViewModels.Catalog.Categories;
using bookShopSolution.ViewModels.Catalog.ProductImages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookShopSolution.ViewModels.Catalog.Products
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public decimal OriginalPrice { get; set; }
        public int Stock { get; set; }
        public int ViewCount { get; set; }
        public DateTime DateCreated { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Details { get; set; }
        public string SeoDescription { get; set; }
        public string SeoTitle { get; set; }
        public string LanguageId { get; set; }
        public string SeoAlias { get; set; }
        public int LikeCount { get; set; }
        public bool IsFeatured { get; set; }
        public List<string> Categories { get; set; } = new List<string>();
        public string Thumbnail { get; set; }
        public double AverageStar { get; set; }
        public int ReviewCount { get; set; }
    }
}