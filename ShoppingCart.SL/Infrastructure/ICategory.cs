﻿using ShoppingCart.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.SL.Infrastructure
{
    public interface ICategory
    {
        IEnumerable<Category> GetAllCategories();
        Category GetCategoryById(int id);
        void InsertCategory(Category category);
        void UpdateCategory(Category category);
        void DeleteCategory(Category category);
        void Save();
    }
}
