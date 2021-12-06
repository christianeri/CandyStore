using CandyStore.Models;
using CandyStore.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CandyStore.Controllers
{
    public class ShoppingCartController :Controller
    {
        private readonly ICandyRepository candyRepository;
        private readonly ShoppingCart shoppingCart;

        public ShoppingCartController(ICandyRepository candyRepository, ShoppingCart shoppingCart)
        {
            this.candyRepository = candyRepository;
            this.shoppingCart = shoppingCart;
        }




        //Added@6.9
        public ViewResult Index()
        {
            shoppingCart.ShoppingCartItemsDbSet = shoppingCart.GetShoppingCartItems();

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = shoppingCart,
                ShoppingCartTotal = shoppingCart.GetShoppingCartTotal()
            };

            return View(shoppingCartViewModel);
        }





        //Added@6.10
        public RedirectToActionResult AddToShoppingCart(int candyId)
        {
            var selectedCandy = candyRepository.GetAllCandy.FirstOrDefault(c => c.CandyId == candyId);

            if(selectedCandy != null)
            {
                shoppingCart.AddToCart(selectedCandy, 1);
            }

            return RedirectToAction("Index");
        }





        //Added@6.11
        public RedirectToActionResult RemoveFromShoppingCart(int candyId)
        {
            var selectedCandy = candyRepository.GetAllCandy.FirstOrDefault(
                x => x.CandyId == candyId);

            if (selectedCandy != null)
            {
                shoppingCart.RemoveFromCart(selectedCandy);
            }

            return RedirectToAction("Index");
        }
    }
}
