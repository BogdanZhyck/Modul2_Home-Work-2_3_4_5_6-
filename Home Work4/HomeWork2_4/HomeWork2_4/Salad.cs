using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2_4
{
	public class Salad
	{
		private Vegetable[] vegetables;
		private int count;

		public Salad(int capacity)
		{
			vegetables = new Vegetable[capacity];
			count = 0;
		}

		public void AddVegetable(Vegetable vegetable)
		{
			if (count < vegetables.Length)
			{
				vegetables[count] = vegetable;
				count++;
			}
			else
			{
				Console.WriteLine("The salad is full. Cannot add more vegetables.");
			}
		}

		public int CalculateTotalCalories()
		{
			int totalCalories = 0;
			foreach (var vegetable in vegetables)
			{
				if (vegetable != null)
					totalCalories += (int)(vegetable.CaloriesPer100g * vegetable.Weight / 100);
			}
			return totalCalories;
		}

		public void SortByCalories()
		{
			Array.Sort(vegetables, 0, count, new VegetableCaloriesComparer());
		}

		public Vegetable FindVegetableByCriteria(Func<Vegetable, bool> criteria)
		{
			foreach (var vegetable in vegetables)
			{
				if (vegetable != null && criteria(vegetable))
				{
					return vegetable;
				}
			}
			return null;
		}

		private class VegetableCaloriesComparer : IComparer<Vegetable>
		{
			public int Compare(Vegetable x, Vegetable y)
			{
				if (x == null && y == null)
					return 0;
				else if (x == null)
					return -1;
				else if (y == null)
					return 1;
				else
					return (x.CaloriesPer100g * x.Weight).CompareTo(y.CaloriesPer100g * y.Weight);
			}
		}
		public Vegetable[] GetVegetables()
		{
			var saladVegetables = new Vegetable[count];
			Array.Copy(vegetables, saladVegetables, count);
			return saladVegetables;
		}
	}

	public static class SaladExtensions
	{
		// Extension method to find vegetables with a given name in the salad
		public static Vegetable FindVegetableByName(this Salad salad, string name)
		{
			return salad.FindVegetableByCriteria(veg => veg.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
		}
	}
}

