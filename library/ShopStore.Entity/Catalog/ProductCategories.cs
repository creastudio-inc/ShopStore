﻿using ShopStore.Infrastructure.Models;

namespace ShopStore.Entity
{
    public class ProductCategories : EntityBase
    {
        public string Name { get; set; }
        public string MetaTitle { get; set; }
        public string MetaKeywords { get; set; }
        public string MetaDescription { get; set; }
        public string Description { get; set; }
        public int DisplayOrder { get; set; }
        public bool IsPublished { get; set; }
        public bool IncludeInMenu { get; set; }
        public bool IsDeleted { get; set; }
        public ProductCategories MainCategory { get; set; }
    }
}