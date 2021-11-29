using System.Collections.Generic;
using System.Linq;

namespace CandyStore.Models
{
    public class CandyRepository : ICandyRepository
    {
        private readonly ICategoryRepository _categoryRepository = new CategoryRepository();



        public Candy GetCandyById(int candyId)
        {
            return GetAllCandy.FirstOrDefault(c => c.CandyId == candyId);
        }



        public IEnumerable<Candy> GetAllCandy => throw new System.NotImplementedException();

        public IEnumerable<Candy> GetCandyOnSale => throw new System.NotImplementedException();
    }
}
