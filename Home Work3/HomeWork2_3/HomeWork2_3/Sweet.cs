using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2_3
{
	// Base class for sweets
	public abstract class Sweet
	{
		public string Name { get; protected set; }
		public double Weight { get; protected set; }

		public Sweet(string name, double weight)
		{
			Name = name;
			Weight = weight;
		}

		public abstract void DisplayInfo();
	}

	// Inheritance hierarchy for different types of candies
	public class Chocolate : Sweet
	{
		public string ChocolateType { get; private set; }

		public Chocolate(string name, double weight, string chocolateType) : base(name, weight)
		{
			ChocolateType = chocolateType;
		}

		public override void DisplayInfo()
		{
			Console.WriteLine($"Chocolate: {Name}, Weight: {Weight}g, Type: {ChocolateType}");
		}
	}

	public class JellyBean : Sweet
	{
		public string Flavor { get; private set; }

		public JellyBean(string name, double weight, string flavor) : base(name, weight)
		{
			Flavor = flavor;
		}

		public override void DisplayInfo()
		{
			Console.WriteLine($"Jelly Bean: {Name}, Weight: {Weight}g, Flavor: {Flavor}");
		}
	}

}
