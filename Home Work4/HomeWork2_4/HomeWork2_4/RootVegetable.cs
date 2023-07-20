using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HomeWork2_4
{
	public class RootVegetable : Vegetable
	{
		public RootVegetable(string name, double weight, int caloriesPer100g) : base(name, weight, caloriesPer100g)
		{
		}

		public override void DisplayInfo()
		{
			Console.WriteLine($"Root Vegetable: {Name}, Weight: {Weight}g, Calories per 100g: {CaloriesPer100g}");
		}
	}
}
