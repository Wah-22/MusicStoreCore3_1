using MusicStoreCore3_1.Models;
using System.Collections.Generic;

namespace MusicStoreCore3_1.ViewModel
{
    public class ShoppingCartViewModel
    {
        public List<Cart> CartItems { get; set; }
        public decimal CartTotal { get; set; }
    }
}
