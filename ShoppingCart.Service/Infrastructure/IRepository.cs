using ShoppingCart.DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Repo.Infrastructure
{
    public interface IRepository<T> where T :BaseEntity
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Save();
    }
}
