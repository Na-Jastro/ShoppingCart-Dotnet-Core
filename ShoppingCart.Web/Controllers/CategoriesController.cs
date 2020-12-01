using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ShoppingCart.Mapped.Infrastructure;
using ShoppingCart.Mapped.ViewModels.CategoryViewModels;

namespace ShoppingCart.Web.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly IMappedCategory _category;
        public CategoriesController(IMappedCategory category, IMapper mapper)
        {
            _category = category;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var AllCategories = _category.GetAllMappedCategories();
            return View(AllCategories);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var category = _category.GetMappedCategoryById(id);
            return View(category);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var category = _category.GetMappedCategoryById(id);
            return View(category);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var category = _category.GetMappedCategoryById(id);
            return View(category);
        }

        [HttpDelete]
        public IActionResult Delete(DeleteCategoryViewModel vm)
        {
            _category.Delete(vm);
            return RedirectToAction("Index", "Categories");
        }

        [HttpPost]

        public IActionResult Edit(EditCategoryViewModel vm)
        {
            _category.Update(vm);
            return RedirectToAction("Index", "Categories");
        }

        [HttpPost]
        public IActionResult Create(CreateCategoryViewModel vm)
        {
            _category.Insert(vm);
            return RedirectToAction("Index", "Categories");
        }
    }
}
