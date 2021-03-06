﻿using ShopStore.Entity.ENUM;
using ShopStore.Infrastructure.Models;

namespace ShopStore.Entity
{
    public class Articles : EntityBase
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public byte[] Image { get; set; }
        public ArticlesType ArticlesType { get; set; }
    }
}