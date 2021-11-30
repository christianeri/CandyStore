using CandyStore.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace CandyStore.Models
{
    public class CandyRepository : ICandyRepository
    {
        private readonly AppDBContext appDBContext;
        public CandyRepository(AppDBContext appDBContext)
        {
            this.appDBContext = appDBContext;
        }





        public IEnumerable<Candy> GetAllCandy
        {
            get {
                return appDBContext.Candies.Include(x => x.Category);
            }
        }





        public IEnumerable<Candy> GetCandyOnSale
        {
            get
            {
                return appDBContext.Candies.Include(x => x.Category).Where(y => y.IsOnSale);
            }
        }





        public Candy GetCandyById(int candyId)
        {
            return appDBContext.Candies.FirstOrDefault(x => x.CandyId == candyId);
        }
    }
}
