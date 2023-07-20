namespace HomeWork2_6
{
	public class Program
	{
		public static void Main()
		{
			var smallAppliance1 = new SmallAppliance("Toaster", 800);
			var smallAppliance2 = new SmallAppliance("Blender", 400);
			var mediumAppliance1 = new MediumAppliance("Washing Machine", 1500);
			var mediumAppliance2 = new MediumAppliance("Microwave", 1000);
			var largeAppliance1 = new LargeAppliance("Refrigerator", 2000);
			var largeAppliance2 = new LargeAppliance("Air Conditioner", 2500);

			var apartment = new Apartment(capacity: 6);

			apartment.PlugInAppliance(smallAppliance1);
			apartment.PlugInAppliance(smallAppliance2);
			apartment.PlugInAppliance(mediumAppliance1);
			apartment.PlugInAppliance(mediumAppliance2);
			apartment.PlugInAppliance(largeAppliance1);
			apartment.PlugInAppliance(largeAppliance2);

			Console.WriteLine("Apartment contents:");
			foreach (var appliance in apartment.GetAppliances())
			{
				if (appliance != null)
					appliance.DisplayInfo();
			}

			double totalPowerConsumption = apartment.CalculateTotalPowerConsumption();
			Console.WriteLine($"Total power consumption: {totalPowerConsumption} Watts");

			apartment.SortByPowerConsumption();

			Console.WriteLine("Apartment contents after sorting by power consumption:");
			foreach (var appliance in apartment.GetAppliances())
			{
				if (appliance != null)
					appliance.DisplayInfo();
			}

			double minPower = 800;
			double maxPower = 1500;
			var matchingAppliances = apartment.FindAppliancesByPowerRange(minPower, maxPower);
			Console.WriteLine($"Appliances with power consumption between {minPower} Watts and {maxPower} Watts:");
			foreach (var appliance in matchingAppliances)
			{
				appliance.DisplayInfo();
			}
		}
	}
}