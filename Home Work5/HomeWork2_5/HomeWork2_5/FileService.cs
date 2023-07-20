using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2_5
{

	public class FileService
	{
		private const string LogDirectory = "Logs";
		private const string LogFileFormat = "MM-dd-yyyy HH-mm-ss.fff tt.txt";
		private const int MaxLogFiles = 3;

		public void WriteLogToFile(string log)
		{
			if (!Directory.Exists(LogDirectory))
			{
				Directory.CreateDirectory(LogDirectory);
			}

			string logFileName = Path.Combine(LogDirectory, $"{DateTime.Now.ToString(LogFileFormat)}");
			File.WriteAllText(logFileName, log);

			DeleteOldLogs();
		}

		private void DeleteOldLogs()
		{
			string[] logFiles = Directory.GetFiles(LogDirectory, "*.txt");
			if (logFiles.Length > MaxLogFiles)
			{
				Array.Sort(logFiles);
				for (int i = 0; i < logFiles.Length - MaxLogFiles; i++)
				{
					File.Delete(logFiles[i]);
				}
			}
		}
	}
}
