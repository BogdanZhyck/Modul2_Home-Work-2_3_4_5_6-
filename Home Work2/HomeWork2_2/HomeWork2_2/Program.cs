namespace HomeWork2_2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var products = new Product[3];
			products[0] = new Product { Id = 1, Name = "Товар 1", Price = 10.99m };
			products[1] = new Product { Id = 2, Name = "Товар 2", Price = 19.99m };
			products[2] = new Product { Id = 3, Name = "Товар 3", Price = 5.99m };

			var cart = new ShoppingCart();

			for (int i = 0; i < Math.Min(10, products.Length); i++)
			{
				cart.AddToCart(products[i]);
			}

			cart.PlaceOrder();

			var orderService = new OrderService();
			orderService.RegisterOrder(cart);
		}
	}
}