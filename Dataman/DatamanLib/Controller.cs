using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatamanLib
{
	/// <summary>
	/// class for controlling dataman functions.
	/// </summary>
	public static class Controller
	{
		/// <summary>
		/// turn device on.
		/// </summary>
		public static void PowerOn()
		{
			DataModel.PoweredOn = true;
		}

		/// <summary>
		/// turn device off. also resets data model.
		/// </summary>
		public static void PowerOff()
		{
			DataModel.PoweredOn = false;
			DataModel.Input = "";
		}

		/// <summary>
		/// add a number to input.
		/// </summary>
		/// <param name="number"></param>
		public static void AddNumber(int number)
		{
			if (DataModel.PoweredOn)
			{
				DataModel.Input = $"{DataModel.Input}{number}";
			}
		}

		/// <summary>
		/// add an operator to input.
		/// </summary>
		/// <param name="oper"></param>
		public static void AddOperator(char oper)
		{
			if (DataModel.PoweredOn)
			{
				DataModel.Input = $"{DataModel.Input} {oper} ";
			}
		}

		public static bool ExecuteAnswerChecker()
		{
			string[] inputTokens = DataModel.Input.Split(null);
			// tokenize input string.

			if (inputTokens[inputTokens.GetUpperBound(0)] is "=")

			if (int.TryParse(inputTokens[0], out int leftNumber) &&
				int.TryParse(inputTokens[2], out int rightNumber) &&
				int.TryParse(inputTokens[4], out int userAnswer))
				// if all numbers can be parsed, proceed.
			{
				if (inputTokens[1] is "+" &&
					leftNumber + rightNumber == userAnswer)
				{
					return true;
				}
				// check for addition accuracy.

				if (inputTokens[1] is "-" &&
					leftNumber - rightNumber == userAnswer)
				{
					return true;
				}
				
			}
		}
	}

	/// <summary>
	/// Mode enum for setting device mode.
	/// </summary>
	public enum Mode
	{
		AnswerChecker,
		MemoryBank,
		NumberGuesser
	}
}
