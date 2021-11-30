using CandyStore.Data;
using System.Collections.Generic;

namespace CandyStore.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDBContext appDBContext;
        public CategoryRepository(AppDBContext appDBContext)
        {
            this.appDBContext = appDBContext;
        }





        public IEnumerable<Category> GetAllCategories => appDBContext.Categories;
    }
}
