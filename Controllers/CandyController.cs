using CandyStore.Models;
using CandyStore.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CandyStore.Controllers
{
    public class CandyController : Controller
    {
        private readonly ICandyRepository candyRepository;
        private readonly ICategoryRepository categoryRepository;

        public CandyController(ICandyRepository candyRepository, ICategoryRepository categoryRepository)
        {
            this.candyRepository = candyRepository;
            this.categoryRepository = categoryRepository;
        }



        public IActionResult List()
        {
            var candyListViewModel = new CandyListViewModel();
            candyListViewModel.Candies = candyRepository.GetAllCandy;
            candyListViewModel.CurrentCategory = "Bestsellers";
            
            return View(candyListViewModel);
        }



        public IActionResult Details(int candyId)
        {
            var candyItem = candyRepository.GetCandyById(candyId);
            if(candyItem == null)
            {
                return NotFound();
            }
            return View(candyItem);
        }
    }
}
