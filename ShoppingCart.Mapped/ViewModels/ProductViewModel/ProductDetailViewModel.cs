using ShoppingCart.Mapped.ViewModels.CategoryViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Mapped.ViewModels.ProductViewModel
{
    public class ProductDetailViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string ProductImage { get; set; }
        public ICollection<CategoryViewModel> CategoryNames { get; set; }
    }
}
