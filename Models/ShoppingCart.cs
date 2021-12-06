using CandyStore.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CandyStore.Models
{
    public class ShoppingCart
    {
        public string ShoppingCartId { get; set; }
        public List<ShoppingCartItem> ShoppingCartItemsDbSet { get; set; }


        private readonly AppDBContext db;
        public ShoppingCart(AppDBContext db)
        {
            this.db = db;
        }





        // Accessing #Session# @6.3 ----------------------------------------------------------------------------------
        public static ShoppingCart GetCart(IServiceProvider services)
        {
            // Instantiation of #Session#
            ISession session = services.GetRequiredService<IHttpContextAccessor>
                ()?.HttpContext.Session;

            // Getting current DbContext from #services#
            var context = services.GetService<AppDBContext>();
            
// 1) Find if #session# exists. 2) If so set cartId to cartId of that session. 3) If not create new #cartId#.             
/* 1 & 2 */ string cartId = session.GetString("CartId") /* 3 */ ?? Guid.NewGuid().ToString(); // ??: Ternary operator with null check
         
            // Set new or retrived #cartId# to current #session#.
            session.SetString("CartId", cartId);

            // Return new instance of ShoppinCart with retrieved or created #cartId#
            return new ShoppingCart(context) {ShoppingCartId = cartId };
        }
        // ---------------------------------------------------------------------------------------------------------




        // Added@6.4
        public void AddToCart(Candy candy, int amount)
        {
            // 1) Check if item is already in the cart *Oklart
            var shoppingCartItem = db.ShoppingCartItemsDbSet.SingleOrDefault(
                s => s.Candy.CandyId == candy.CandyId
                && s.ShoppingCartId == ShoppingCartId);

            // 2a) If item is not i cart, add it
            if (shoppingCartItem == null)
            {
                shoppingCartItem = new ShoppingCartItem
                {
                    ShoppingCartId = ShoppingCartId,
                    Candy = candy,
                    Amount = amount
                };
                // 3a) Add item to database
                db.ShoppingCartItemsDbSet.Add(shoppingCartItem);
            }
            // 2b) If item is already in database, increase the amount
            else
            {
                shoppingCartItem.Amount++;
            }
            // 3ab Save changes
            db.SaveChanges();
        }




        // Added@6.5
        public int RemoveFromCart(Candy candy)
        {
            var shoppingCartItem = db.ShoppingCartItemsDbSet.SingleOrDefault(
                s => s.Candy.CandyId == candy.CandyId
                && s.ShoppingCartId == ShoppingCartId);

            var localAmount = 0;

            if(shoppingCartItem != null)
            {
                if(shoppingCartItem.Amount > 1)
                {
                    shoppingCartItem.Amount--;
                    localAmount = shoppingCartItem.Amount;
                }
                else {
                    db.ShoppingCartItemsDbSet.Remove(shoppingCartItem);
                }
            }
            db.SaveChanges();

            return localAmount;
        }



        //Added@6.6
        public List<ShoppingCartItem> GetShoppingCartItems()
        {
            //*Oklart
            return ShoppingCartItemsDbSet ?? (
                ShoppingCartItemsDbSet = db.ShoppingCartItemsDbSet
                .Where(cart => cart.ShoppingCartId == ShoppingCartId)
                .Include(x => x.Candy)
                .ToList());
        }




        //Added@6.7
        public void ClearCart()
        {
            var cartItems = db.ShoppingCartItemsDbSet.Where(
                x => x.ShoppingCartId == ShoppingCartId);

            db.ShoppingCartItemsDbSet.RemoveRange();
            db.SaveChanges();
        }




        //Added@6.8
        public decimal GetShoppingCartTotal()
        {
            var total = db.ShoppingCartItemsDbSet.Where(
                x => x.ShoppingCartId == ShoppingCartId)
                .Select(x => x.Candy.Price * x.Amount).Sum();

            return total;
        }
    }
}
