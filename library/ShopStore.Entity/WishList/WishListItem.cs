using ShopStore.Infrastructure.Models;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopStore.Entity
{
    public class WishListItem : EntityBase
    {
        [ForeignKey("WishList")]
        public Guid WishListId { get; set; }

        public WishList WishList { get; set; }

        [ForeignKey("Product")]
        public Guid ProductId { get; set; }

        public Product Product { get; set; }

        public string Description { get; set; }

        public int Quantity { get; set; }
    }
}