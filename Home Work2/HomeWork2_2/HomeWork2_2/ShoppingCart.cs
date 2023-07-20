using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2_2
{


	public class ShoppingCart
	{
		private Product[] items;
		private int itemCount;

		public ShoppingCart()
		{
			items = new Product[10];
			itemCount = 0;
		}

		public void AddToCart(Product product)
		{
			if (itemCount >= 10)
			{
				Console.WriteLine("Кошик переповнений. Неможливо додати більше товарів.");
				return;
			}

			items[itemCount] = product;
			itemCount++;
		}

		public void PlaceOrder()
		{
			Console.WriteLine("Замовлення оформлено!");
		}

		public Product[] GetItems()
		{
			var cartItems = new Product[itemCount];
			Array.Copy(items, cartItems, itemCount);
			return cartItems;
		}
	}

}
