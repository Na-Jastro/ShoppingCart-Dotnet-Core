using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

using System.Web.Mvc;

namespace ShoppingCart.Mapped.ViewModels.ProductViewModel
{
    public class CreateProductViewModel
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public IFormFile ProductImage { get; set; }
        public List<SelectListItem> Categories { get; set; }
    }
}
