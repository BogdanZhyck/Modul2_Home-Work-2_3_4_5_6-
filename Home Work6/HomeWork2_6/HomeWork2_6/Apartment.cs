using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2_6
{
	public class Apartment
	{
		private ElectricalAppliance[] appliances;
		private int count;

		public Apartment(int capacity)
		{
			appliances = new ElectricalAppliance[capacity];
			count = 0;
		}

		public void PlugInAppliance(ElectricalAppliance appliance)
		{
			if (count < appliances.Length)
			{
				appliances[count] = appliance;
				count++;
			}
			else
			{
				Console.WriteLine("The apartment is full. Cannot plug in more appliances.");
			}
		}

		public double CalculateTotalPowerConsumption()
		{
			double totalPowerConsumption = 0;
			foreach (var appliance in appliances)
			{
				if (appliance != null)
					totalPowerConsumption += appliance.PowerConsumption;
			}
			return totalPowerConsumption;
		}

		public void SortByPowerConsumption()
		{
			Array.Sort(appliances, 0, count, new AppliancePowerConsumptionComparer());
		}

		public ElectricalAppliance[] FindAppliancesByRange(Func<ElectricalAppliance, bool> criteria)
		{
			var matchingAppliances = new List<ElectricalAppliance>();
			foreach (var appliance in appliances)
			{
				if (appliance != null && criteria(appliance))
				{
					matchingAppliances.Add(appliance);
				}
			}
			return matchingAppliances.ToArray();
		}

		public ElectricalAppliance[] GetAppliances()
		{
			var apartmentAppliances = new ElectricalAppliance[count];
			Array.Copy(appliances, apartmentAppliances, count);
			return apartmentAppliances;
		}

		private class AppliancePowerConsumptionComparer : IComparer<ElectricalAppliance>
		{
			public int Compare(ElectricalAppliance x, ElectricalAppliance y)
			{
				if (x == null && y == null)
					return 0;
				else if (x == null)
					return -1;
				else if (y == null)
					return 1;
				else
					return x.PowerConsumption.CompareTo(y.PowerConsumption);
			}
		}
	}

	public static class ApartmentExtensions
	{
		// Extension method to find appliances with power consumption within a given range in the apartment
		public static ElectricalAppliance[] FindAppliancesByPowerRange(this Apartment apartment, double minPower, double maxPower)
		{
			return apartment.FindAppliancesByRange(appliance => appliance.PowerConsumption >= minPower && appliance.PowerConsumption <= maxPower);
		}
	}
}
