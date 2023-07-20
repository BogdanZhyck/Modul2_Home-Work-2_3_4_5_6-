using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace HomeWork2_3
{
	public class Program
	{
		public static void Main()
		{
			// Creating candies
			var chocolate1 = new Chocolate("Dark Chocolate", 50, "Dark");
			var chocolate2 = new Chocolate("Milk Chocolate", 40, "Milk");
			var jellyBean1 = new JellyBean("Fruit Jelly", 20, "Fruit Flavor");
			var jellyBean2 = new JellyBean("Cola Jelly", 15, "Cola Flavor");

			// Creating a children's gift
			var childrensGift = new ChildrensGift(capacity: 4);

			// Adding candies to the gift
			childrensGift.AddSweet(chocolate1);
			childrensGift.AddSweet(chocolate2);
			childrensGift.AddSweet(jellyBean1);
			childrensGift.AddSweet(jellyBean2);

			// Displaying information about candies in the gift
			Console.WriteLine("Gift contents:");
			foreach (var sweet in childrensGift.GetSweets())
			{
				if (sweet != null)
					sweet.DisplayInfo();
			}

			// Calculating the total weight of the gift
			double totalWeight = childrensGift.CalculateTotalWeight();
			Console.WriteLine($"Total gift weight: {totalWeight}g");

			// Sorting candies in the gift by weight
			childrensGift.SortByWeight();

			Console.WriteLine("Gift contents after sorting by weight:");
			foreach (var sweet in childrensGift.GetSweets())
			{
				if (sweet != null)
					sweet.DisplayInfo();
			}

			// Finding a specific candy in the gift based on a criteria
			var foundSweet = childrensGift.FindSweetByCriteria(s => s.Name.Contains("Cola"));
			if (foundSweet != null)
			{
				Console.WriteLine("Found candy:");
				foundSweet.DisplayInfo();
			}
			else
			{
				Console.WriteLine("No candy found.");
			}
		}
	}
}