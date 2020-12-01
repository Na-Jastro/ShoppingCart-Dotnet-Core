using AutoMapper;
using ShoppingCart.DataAccess.Model;
using ShoppingCart.Mapped.Infrastructure;
using ShoppingCart.Mapped.ViewModels.CategoryViewModels;
using ShoppingCart.SL.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Mapped.Repositories
{
    public class MappedCategory : IMappedCategory
    {
        private readonly ICategory _categoryRepo;
        private readonly IMapper _mapper;

        public MappedCategory(ICategory categoryRepo)
        {
            _categoryRepo = categoryRepo;
        }

        public void Delete(DeleteCategoryViewModel vm)
        {
            var mappedCategoryInModel = _mapper.Map<Category>(vm);
            _categoryRepo.DeleteCategory(mappedCategoryInModel);
            _categoryRepo.Save();
        }

        public IEnumerable<CategoryViewModel> GetAllMappedCategories()
        {
            var AllCategories = _categoryRepo.GetAllCategories();
            var vm = _mapper.Map<List<CategoryViewModel>>(AllCategories);
            return vm;
        }

        public CategoryViewModel GetMappedCategoryById(int id)
        {
            var category = _categoryRepo.GetCategoryById(id);
            var vm = _mapper.Map<CategoryViewModel>(category);
            return vm;
        }

        public void Insert(CreateCategoryViewModel vm)
        {
            var mappedCategoryInModel = _mapper.Map<Category>(vm);
            _categoryRepo.InsertCategory(mappedCategoryInModel);
            _categoryRepo.Save();
        }

        public void Update(EditCategoryViewModel vm)
        {
            var mappedCategoryInModel = _mapper.Map<Category>(vm);
            _categoryRepo.UpdateCategory(mappedCategoryInModel);
            _categoryRepo.Save();
        }
    }
}
