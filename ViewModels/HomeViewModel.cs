using CandyStore.Models;
using System.Collections;
using System.Collections.Generic;

namespace CandyStore.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Candy> CandyOnSale  { get; set; }
    }
}
