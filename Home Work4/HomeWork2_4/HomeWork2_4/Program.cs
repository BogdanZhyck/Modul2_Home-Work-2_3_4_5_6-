using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace HomeWork2_4
{
	public class Program
	{
		public static void Main()
		{
			var lettuce = new LeafyVegetable("Lettuce", 50, 15);
			var carrot = new RootVegetable("Carrot", 100, 41);
			var cucumber = new FruitVegetable("Cucumber", 70, 16);

			var salad = new Salad(capacity: 3);

			salad.AddVegetable(lettuce);
			salad.AddVegetable(carrot);
			salad.AddVegetable(cucumber);

			Console.WriteLine("Salad contents:");
			foreach (var vegetable in salad.GetVegetables())
			{
				if (vegetable != null)
					vegetable.DisplayInfo();
			}

			int totalCalories = salad.CalculateTotalCalories();
			Console.WriteLine($"Total salad calories: {totalCalories}");

			salad.SortByCalories();

			Console.WriteLine("Salad contents after sorting by calories:");
			foreach (var vegetable in salad.GetVegetables())
			{
				if (vegetable != null)
					vegetable.DisplayInfo();
			}

			var foundVegetable = salad.FindVegetableByCriteria(veg => veg.Name.Contains("Carrot"));
			if (foundVegetable != null)
			{
				Console.WriteLine("Found vegetable:");
				foundVegetable.DisplayInfo();
			}
			else
			{
				Console.WriteLine("No vegetable found.");
			}
		}
	}
}