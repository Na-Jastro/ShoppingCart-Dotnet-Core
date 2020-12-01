using ShoppingCart.DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.DataAccess.Model
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string ProductImage { get; set; }
        public ICollection<ProductCategory> Categories { get; set; } = new List<ProductCategory>();
    }
}
