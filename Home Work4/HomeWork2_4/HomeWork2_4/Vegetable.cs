using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2_4
{
	public abstract class Vegetable
	{
		public string Name { get; protected set; }
		public double Weight { get; protected set; }
		public int CaloriesPer100g { get; protected set; }

		public Vegetable(string name, double weight, int caloriesPer100g)
		{
			Name = name;
			Weight = weight;
			CaloriesPer100g = caloriesPer100g;
		}

		public abstract void DisplayInfo();
	}
}
