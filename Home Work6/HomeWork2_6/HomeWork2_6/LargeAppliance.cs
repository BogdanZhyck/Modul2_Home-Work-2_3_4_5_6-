using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HomeWork2_6
{
	public class LargeAppliance : ElectricalAppliance
	{
		public LargeAppliance(string name, double powerConsumption) : base(name, powerConsumption)
		{
		}

		public override void DisplayInfo()
		{
			Console.WriteLine($"Large Appliance: {Name}, Power Consumption: {PowerConsumption} Watts");
		}
	}
}
