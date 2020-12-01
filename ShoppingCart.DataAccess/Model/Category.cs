using ShoppingCart.DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.DataAccess.Model
{
    public class Category: BaseEntity
    { 
        public string Name { get; set; }
        public ICollection<ProductCategory> Products { get; set; } = new List<ProductCategory>();

    }
}
