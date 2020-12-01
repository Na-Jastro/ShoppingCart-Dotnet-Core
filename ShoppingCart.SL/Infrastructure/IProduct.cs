using ShoppingCart.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Repo.Infrastructure
{
    public interface IProduct
    {
        IEnumerable<Product> GetAllProducts();
        IEnumerable<Category> GetProductCategories(int id);
        Product GetProductById(int id);
        void InsertProduct(Product product, List<int> categories) ;
        void UpdateProduct(Product product);
        void DeleteProduct(Product product);
        void Save();
    }
}
