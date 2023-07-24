using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2_6
{
	public abstract class ElectricalAppliance
	{
		public string Name { get; protected set; }
		public double PowerConsumption { get; protected set; }

		public ElectricalAppliance(string name, double powerConsumption)
		{
			Name = name;
			PowerConsumption = powerConsumption;
		}

		public abstract void DisplayInfo();
	}
}
