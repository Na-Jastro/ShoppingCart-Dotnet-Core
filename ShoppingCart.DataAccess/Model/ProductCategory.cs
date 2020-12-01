using ShoppingCart.DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.DataAccess.Model
{
    public class ProductCategory :BaseEntity
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public Product Product { get; set; }
        public Category Category { get; set; }
        public ICollection<ProductCategory> Categories { get; set; }


    }
}
