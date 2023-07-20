using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2_5
{
	public class App
	{
		private Actions actions;
		private Random random;
		private FileService fileService;

		public App()
		{
			actions = new Actions();
			random = new Random();
			fileService = new FileService();
		}

		public void Run()
		{
			for (int i = 1; i <= 100; i++)
			{
				int actionNumber = random.Next(1, 4);
				try
				{
					switch (actionNumber)
					{
						case 1:
							actions.StartMethod();
							break;
						case 2:
							actions.SkippedLogicMethod();
							break;
						case 3:
							actions.BreakLogicMethod();
							break;
					}
				}
				catch (Exception ex)
				{
					if (ex is BusinessException)
					{
						Logger.Log($"Action got this custom Exception: {ex.Message}", LogType.Warning);
					}
					else
					{
						Logger.Log($"Action failed by reason: {ex}", LogType.Error);
					}

					fileService.WriteLogToFile($"Exception: {ex}");
				}
			}
		}
	}
}