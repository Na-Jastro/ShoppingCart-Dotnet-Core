using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Mapped.ViewModels.ProductViewModel
{
    public class ProductPostViewModel
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public IFormFile ProductImage { get; set; }
    }
}
