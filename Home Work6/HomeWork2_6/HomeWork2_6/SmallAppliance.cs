﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HomeWork2_6
{
	public class SmallAppliance : ElectricalAppliance
	{
		public SmallAppliance(string name, double powerConsumption) : base(name, powerConsumption)
		{
		}

		public override void DisplayInfo()
		{
			Console.WriteLine($"Small Appliance: {Name}, Power Consumption: {PowerConsumption} Watts");
		}
	}
}
