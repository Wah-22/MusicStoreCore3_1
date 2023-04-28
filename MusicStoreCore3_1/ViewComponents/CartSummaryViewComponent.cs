using Microsoft.AspNetCore.Mvc;
using MusicStoreCore3_1.Models;

namespace MvcMusicStoreCore.ViewComponents
{
    public class CartSummaryViewComponent : ViewComponent
    {
        private readonly ShoppingCart shoppingCart;

        public CartSummaryViewComponent(ShoppingCart shoppingCart)
        {
            this.shoppingCart = shoppingCart;
        }

        public IViewComponentResult Invoke()
        {
            ViewData["CartCount"] = shoppingCart.GetCount();

            return View();
        }
    }
}