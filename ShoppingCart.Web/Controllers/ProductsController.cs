using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ShoppingCart.Mapped.Infrastructure;
using ShoppingCart.Mapped.ViewModels.ProductViewModel;
using System.Linq;
using FileUpload = ShoppingCart.Web.Helper.FileUpload;

namespace ShoppingCart.Web.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IMappedProduct _product;
        private readonly IMappedCategory _category;
        private readonly IWebHostEnvironment _webHostEnviroment;
        public ProductsController(IMappedProduct product, IMapper mapper,
            IMappedCategory category, IWebHostEnvironment webHostEnvironment)
        {
            _product = product;
            _category = category;
            _webHostEnviroment = webHostEnvironment;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var productList = _product.GetAllMappedProducts();
            return View(mappedProducts);
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            var singleProduct = _product.GetProductById(id);
            var mappedProduct = _mapper.Map<ProductDetailViewModel>(singleProduct);
            return View(mappedProduct);
        }

        [HttpGet]
        public IActionResult Create(int id)
        {
            CreateProductViewModel vm = new CreateProductViewModel();

            vm.Categories = _category.GetAllCategories().Select(p => new SelectListItem()
            {
                Text = p.Name,
                Value = p.Id.ToString(),
            }).ToList();

            return View(vm);
        }

        //[HttpPost]
        //public IActionResult Create(CreateProductViewModel vm)
        //{
        //    FileUpload fileUpload = new FileUpload(_webHostEnviroment);
        //    var selectedCategories = vm.Categories.Where(p => p.Selected).Select(p => p.Value).Select(int.Parse());
        //    var product = new ProductPostViewModel
        //    {
        //        Name = vm.Name,
        //        Price = vm.Price,
        //        Description = vm.Description,
        //        ProductImage = vm.ProductImage
        //    };

        //    var mappedProduct = _mapper.Map<Product>(product);
        //    _product.InsertProduct(mappedProduct, selectedCategories);
        //    _product.Save();
        //    return RedirectToAction("Index");
        //}
    }
}
