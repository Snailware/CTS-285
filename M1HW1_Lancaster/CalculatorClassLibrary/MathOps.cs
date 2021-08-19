using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorClassLibrary
{
	/// <summary>
	/// class for performing math operations. 
	/// </summary>
	public static class MathOps
	{
		/// <summary>
		/// perform addition.
		/// </summary>
		/// <param name="number1">starting number.</param>
		/// <param name="number2">number to add.</param>
		/// <returns>sum of numbers as formula.</returns>
		public static string Addition(int number1, int number2)
		{
			return $"{number1} + {number2} = {number1 + number2}";
		}

		/// <summary>
		/// perform subtraction.
		/// </summary>
		/// <param name="number1">starting number.</param>
		/// <param name="number2">number to subtract.</param>
		/// <returns>difference between numbers as formula.</returns>
		public static string Subtraction(int number1, int number2)
		{
			return $"{number1} - {number2} = {number1 - number2}";
		}

		/// <summary>
		/// perform multiplication. 
		/// </summary>
		/// <param name="number1">starting number.</param>
		/// <param name="number2">number to multiply by.</param>
		/// <returns>product of numbers as formula.</returns>
		public static string Multiplication(int number1, int number2)
		{
			return $"{number1} * {number2} = {number1 * number2}";
		}

		/// <summary>
		/// perform division.
		/// </summary>
		/// <param name="number1">first number.</param>
		/// <param name="number2">number to divide by. cannot be 0.</param>
		/// <returns>dividend of numbers as formula.</returns>
		public static string Division(int number1, int number2)
		{
			return $"{number1} / {number2} = {number1 / number2}";
		}
	}
}
