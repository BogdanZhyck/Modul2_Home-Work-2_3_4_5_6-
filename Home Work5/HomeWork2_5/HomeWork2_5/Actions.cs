using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2_5
{
	public class Actions
	{
		public void StartMethod()
		{
			Logger.Log($"Start method: {nameof(StartMethod)}", LogType.Info);
		}

		public void SkippedLogicMethod()
		{
			try
			{
				throw new BusinessException("Skipped logic in method");
			}
			catch (BusinessException ex)
			{
				Logger.Log($"Action got this custom Exception: {ex.Message}", LogType.Warning);
			}
		}

		public void BreakLogicMethod()
		{
			try
			{
				throw new Exception("I broke a logic");
			}
			catch (Exception ex)
			{
				Logger.Log($"Action failed by reason: {ex}", LogType.Error);
			}
		}
	}

	public class BusinessException : Exception
	{
		public BusinessException(string message) : base(message)
		{
		}
	}
}
