using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HomeWork2_6
{
	public class MediumAppliance : ElectricalAppliance
	{
		public MediumAppliance(string name, double powerConsumption) : base(name, powerConsumption)
		{
		}

		public override void DisplayInfo()
		{
			Console.WriteLine($"Medium Appliance: {Name}, Power Consumption: {PowerConsumption} Watts");
		}
	}
}
