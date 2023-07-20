using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HomeWork2_4
{
	public class FruitVegetable : Vegetable
	{
		public FruitVegetable(string name, double weight, int caloriesPer100g) : base(name, weight, caloriesPer100g)
		{
		}

		public override void DisplayInfo()
		{
			Console.WriteLine($"Fruit Vegetable: {Name}, Weight: {Weight}g, Calories per 100g: {CaloriesPer100g}");
		}
	}
}
