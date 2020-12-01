using ShoppingCart.Mapped.ViewModels.CategoryViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Mapped.Infrastructure
{
    public interface IMappedCategory
    {
        IEnumerable<CategoryViewModel> GetAllMappedCategories();
        CategoryViewModel GetMappedCategoryById(int id);
        void Insert(CreateCategoryViewModel vm);
        void Update(EditCategoryViewModel vm);
        void Delete(DeleteCategoryViewModel vm);
    }
}
