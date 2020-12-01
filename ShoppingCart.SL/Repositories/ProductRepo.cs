using Microsoft.EntityFrameworkCore;
using ShoppingCart.DataAccess.Model;
using ShoppingCart.Repo.Data;
using ShoppingCart.Repo.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingCart.SL.Repositories
{
    public class ProductRepo : IProduct
    {
        private readonly IRepository<Product> _repo;

        public ProductRepo(IRepository<Product> Repo)
        {
            _repo = Repo;
        }
        public void DeleteProduct(Product product)
        {
            _repo.Delete(product);
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _repo.GetAll().ToList();
        }

        public Product GetProductById(int id)
        {
            return _repo.GetById(id);
        }

        public IEnumerable<Category> GetProductCategories(int id)
        {
            var product = GetProductById(id);
            var productCategories = product.Categories.Select(p => p.Category);
            return productCategories;
        }

        public void InsertProduct(Product product, List<int> categories)
        {
            foreach (var category in categories)
            {
                product.Categories.Add(new ProductCategory()
                {
                    Product = product,
                    CategoryId = category
                });
            }
            _repo.Insert(product);
        }

        public void Save()
        {
            _repo.Save();
        }

        public void UpdateProduct(Product product)
        {
            _repo.Update(product);
        }
    }
}
