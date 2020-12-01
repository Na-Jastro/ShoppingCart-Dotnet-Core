using ShoppingCart.Mapped.ViewModels.ProductViewModel;
using System.Collections.Generic;

namespace ShoppingCart.Mapped.Infrastructure
{
    public interface IMappedProduct
    {
        IEnumerable<ProductViewModel> GetAllMappedProducts();
        ProductViewModel GetMappedProductById(int id);
        //void Insert(CreateCategoryViewModel vm);
        //void Update(EditCategoryViewModel vm);
        //void Delete(DeleteCategoryViewModel vm);
    }
}
