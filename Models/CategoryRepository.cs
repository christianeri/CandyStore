using System.Collections.Generic;

namespace CandyStore.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> GetAllCategories => throw new System.NotImplementedException();
    }
}
