using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2_3
{
	public class ChildrensGift
	{
		private Sweet[] sweets;
		private int count;

		public ChildrensGift(int capacity)
		{
			sweets = new Sweet[capacity];
			count = 0;
		}

		public void AddSweet(Sweet sweet)
		{
			if (count < sweets.Length)
			{
				sweets[count] = sweet;
				count++;
			}
			else
			{
				Console.WriteLine("The gift is full. Cannot add more sweets.");
			}
		}

		public double CalculateTotalWeight()
		{
			double totalWeight = 0;
			foreach (var sweet in sweets)
			{
				if (sweet != null)
					totalWeight += sweet.Weight;
			}
			return totalWeight;
		}

		public void SortByWeight()
		{
			Array.Sort(sweets, 0, count, new SweetWeightComparer());
		}

		public Sweet FindSweetByCriteria(Func<Sweet, bool> criteria)
		{
			foreach (var sweet in sweets)
			{
				if (sweet != null && criteria(sweet))
				{
					return sweet;
				}
			}
			return null;
		}

		// Custom comparer for sorting sweets by weight
		private class SweetWeightComparer : IComparer<Sweet>
		{
			public int Compare(Sweet x, Sweet y)
			{
				if (x == null && y == null)
					return 0;
				else if (x == null)
					return -1;
				else if (y == null)
					return 1;
				else
					return x.Weight.CompareTo(y.Weight);
			}
		}
		public Sweet[] GetSweets()
		{
			var giftSweets = new Sweet[count];
			Array.Copy(sweets, giftSweets, count);
			return giftSweets;
		}
	}
	public static class ChildrensGiftExtensions
	{
		// Extension method to find sweets with a given flavor in the gift
		public static Sweet FindSweetByFlavor(this ChildrensGift gift, string flavor)
		{
			return gift.FindSweetByCriteria(sweet => sweet is JellyBean jellyBean && jellyBean.Flavor == flavor);
		}
	}
}
