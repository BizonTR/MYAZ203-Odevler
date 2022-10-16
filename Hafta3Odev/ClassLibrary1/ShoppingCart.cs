using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class ShoppingCart
    {
        private List<CartItem> cartItemList;
        
        public ShoppingCart()
        {
            cartItemList= new List<CartItem>();
        }
        public void Add(CartItem cartItem)
        {
            cartItemList.Add(cartItem);
        }
        public void GetList()
        {
            foreach (var cartItem in cartItemList)
            {
                Console.WriteLine($"Cart Id: {cartItem.CartId} - Product Name: {cartItem.Product.ProductName} - Product Quantity: {cartItem.Quantity}");
            }
        }
        public string GetBalance()
        {
            double balance = 0;
            foreach (var cartItem in cartItemList)
            {
                balance += (cartItem.Product.Price) * cartItem.Quantity;
            }
            return ($"Total Price: {balance}");
        }
        public void Remove(int id)
        {
            var deleted = cartItemList.FirstOrDefault(x => x.CartId == id);
            if (deleted == null)
            {
                Console.WriteLine("Cart not found");
                return;
            }
            cartItemList.Remove(deleted);
            Console.WriteLine("Cart deleted.");
        }
    }
}
