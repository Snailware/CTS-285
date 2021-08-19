using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorClassLibrary;

namespace Calculator
{
	class Program
	{
		static void Main(string[] args)
		{
			const string Menu = @"Welcome to the Calculator program.
1. Add
2. Subtract
3. Divide
4. Multiply
5. Exit
Enter a number:";
			const string SubMenu = @"1. Repeat
2. Main Menu
Enter a number:";
			// menu consts.
			
			string result = "";
			// output formula. 

			bool continueMainLoop = true;
			// bool to control main loop.

			while (continueMainLoop)
			{
				bool continueSubLoop = true;
				// reset flag from previous iters. 

				int operation = GetInput(Menu);
				// display main menu and get operation choice input.

				if (operation < 1 || operation > 5)
				{
					continue;
				}
				// operation input validation.

				while (continueSubLoop)
				{
					if (operation == 1)
					{
						Console.WriteLine("Add");
					}
					else if (operation == 2)
					{
						Console.WriteLine("Subtract");
					}
					else if (operation == 3)
					{
						Console.WriteLine("Divide");
					}
					else if (operation == 4)
					{
						Console.WriteLine("Multiply");
					}
					else
					{
						Console.WriteLine("Goodbye.");
						Console.ReadLine();
						continueMainLoop = false;
						break;
					}
					// display selection header.

					int number1 = GetInput("enter a number:");
					int number2 = GetInput("enter a number:");
					// get inputs.

					if (operation == 3 && number2 == 0)
					{
						Console.WriteLine("Cannot divide by 0.");
						continue;
					}
					// prevent division by 0.

					switch (operation)
					{
						case 1:
							result = MathOps.Addition(number1, number2);
							break;
						case 2:
							result = MathOps.Subtraction(number1, number2);
							break;
						case 3:
							result = MathOps.Division(number1, number2);
							break;
						case 4:
							result = MathOps.Multiplication(number1, number2);
							break;
					}
					// perform desired math operation.

					Console.WriteLine(result);
					// show formula output. 

					if (GetInput(SubMenu) != 1)
					{
						continueSubLoop = false;
					}
					// prompt user for repeat & set flag.
				}
				// sub menu loop.
			}
			// main menu loop.
		}

		/// <summary>
		/// prompt user for int input. 
		/// </summary>
		/// <param name="prompt">prompt to give user before receiving input.</param>
		/// <returns>returns user input cast as int.</returns>
		static int GetInput(string prompt)
		{
			int output = 0;

			bool continueLoop = true;
			while (continueLoop)
			{
				Console.WriteLine(prompt);
				if (int.TryParse(Console.ReadLine(), out output))
				{
					continueLoop = false;
				}
				else
				{
					Console.WriteLine("invalid entry. entry must be an integer.");
				}
			}
			// input validation. 

			return output;
		}
	}
}
