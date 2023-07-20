using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2_2
{
	public class OrderService
	{
		private static int orderNumber = 1;

		public void RegisterOrder(ShoppingCart cart)
		{
			Console.WriteLine("Зареєстровано замовлення з номером: " + orderNumber);
			orderNumber++;
		}
	}
}
