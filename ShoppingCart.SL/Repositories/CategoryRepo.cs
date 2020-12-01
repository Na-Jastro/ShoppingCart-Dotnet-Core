using ShoppingCart.DataAccess.Model;
using ShoppingCart.Repo.Infrastructure;
using ShoppingCart.SL.Infrastructure;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingCart.SL.Repositories
{
    public class CategoryRepo : ICategory
    {
        private readonly IRepository<Category> _repo;
        public CategoryRepo(IRepository<Category> Repo)
        {
            _repo = Repo;
        }
        public void DeleteCategory(Category category)
        {
            _repo.Delete(category);
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return _repo.GetAll().ToList();
        }

        public Category GetCategoryById(int id)
        {
            return _repo.GetById(id);
        }

        public void InsertCategory(Category category)
        {
            _repo.Insert(category);
        }

        public void Save()
        {
            _repo.Save();
        }

        public void UpdateCategory(Category category)
        {
            _repo.Update(category);
        }
    }
}
