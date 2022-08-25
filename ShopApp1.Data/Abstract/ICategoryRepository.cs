using ShopApp1.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopApp1.Data.Abstract
{
    public interface ICategoryRepository : IRepository<Category>
    {
        Category GetByIdWithProducts(int categoryId);
        void DeleteFromCategory(int productId, int categoryId);
    }
}
