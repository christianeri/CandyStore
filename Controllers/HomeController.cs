using CandyStore.Models;
using CandyStore.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CandyStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICandyRepository candyRepository;
        private readonly ICategoryRepository categoryRepository;

        public HomeController(ICandyRepository candyRepository)
        {
            this.candyRepository = candyRepository;
        }




        public IActionResult Index()
        {
            var homeVievModel = new HomeViewModel
            {
                CandyOnSale = candyRepository.GetCandyOnSale
            };
            return View(homeVievModel);
        }
    }
}
