using ShoppingCart.Repo.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;
using ShoppingCart.DataAccess.Entity;
using ShoppingCart.Repo.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ShoppingCart.Repo.Repositories
{
    class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<T> _entities;
        public Repository(ApplicationDbContext context)
        {
            _context = context;
            _entities = _context.Set<T>();
        }
        public void Delete(T entity)
        {
            _entities.Remove(entity);
        }

        public IEnumerable<T> GetAll()
        {
            return _entities.AsEnumerable();
        }

        public T GetById(int id)
        {
            return _entities.FirstOrDefault(p => p.Id == p.Id);
        }

        public void Insert(T entity)
        {
            _entities.Add(entity);
        }
        public void Save()
        {
            //_entities.SaveChanges();
        }

        public void Update(T entity)
        {
            _entities.Update(entity);
        }
    }
}
