using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2_5
{
	public static class Logger
	{
		public static void Log(string message, LogType logType)
		{
			Console.WriteLine($"{DateTime.Now}: {logType}: {message}");
		}
	}

	public enum LogType
	{
		Error,
		Info,
		Warning
	}
}
