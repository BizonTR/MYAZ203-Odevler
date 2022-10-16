using ClassLibrary1;

Product product1 = new Product() { Price=550,ProductId=3794,ProductName="Headphones"};
Product product2 = new Product() { Price = 7500, ProductId = 5473, ProductName = "Laptop" };

CartItem cartItem1 = new CartItem() { CartId = 1,Product = product1, Quantity = 5};
CartItem cartItem2 = new CartItem() { CartId = 2,Product = product2, Quantity = 22};
CartItem cartItem3 = new CartItem() { CartId = 3, Product = product1, Quantity = 30 };

ShoppingCart shoppingCart = new ShoppingCart();

shoppingCart.Add(cartItem1);
shoppingCart.Add(cartItem2);
shoppingCart.Add(cartItem3);

shoppingCart.Remove(3);

shoppingCart.GetList();

Console.WriteLine(shoppingCart.GetBalance());