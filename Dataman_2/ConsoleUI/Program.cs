using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
	class Program
	{
		static void Main(string[] args)
		{
			void MainMenu()
			{
				string input;
				do
				{
					Console.WriteLine("DATAMAN");
					Console.WriteLine();
					Console.WriteLine("1. Answer Checker");
					Console.WriteLine("2. Memory Bank");
					Console.WriteLine("3. Number Guesser");
					Console.WriteLine("4. Exit");
					Console.WriteLine();
					Console.WriteLine("ENTER A NUMBER:");
					Console.WriteLine();

					input = Console.ReadLine();
				}
				while (input != "1" &&
					   input != "2" &&
					   input != "3" &&
					   input != "4");

				switch (input)
				{
					case "1":
						AnswerChecker();
						break;
					case "2":
						MemoryBank();
						break;
					case "3":
						NumberGuesser();
						break;
					case "4":
						break;
				}
			}

			void AnswerChecker()
			{
				int score = 0;

				for (int index = 0; index < 10; index++)
				{
					int attempts = 0;

					Console.WriteLine("ANSWER CHECKER");
					Console.WriteLine();
					Console.WriteLine("Enter a math problem with spaces seperating operators: (example: '3 + 6 =')");
					Console.WriteLine();
					string problem = Console.ReadLine();

					do
					{
						Console.WriteLine($"{problem} ___");
						string roughUserAnswer = Console.ReadLine();
						string[] problemTokens = problem.Split(null);

						if (int.TryParse(problemTokens[0], out int leftNumber) &&
							int.TryParse(problemTokens[2], out int rightNumber) &&
							int.TryParse(roughUserAnswer, out int userAnswer))
						{
							if ((problemTokens[1] is "+" && leftNumber + rightNumber == userAnswer) ||
								(problemTokens[1] is "-" && leftNumber - rightNumber == userAnswer) ||
								(problemTokens[1] is "*" && leftNumber * rightNumber == userAnswer) ||
								(problemTokens[1] is "/" && leftNumber / rightNumber == userAnswer))
							{
								LightShow();
								score++;
								break;
							}
							else
							{
								Incorrect();
								attempts++;
							}
						}
					} 
					while (attempts < 2);
				}
				Console.WriteLine($"You scored {score} out of 10!");
			}
			
			void MemoryBank()
			{

			}

			void NumberGuesser()
			{

			}

			void LightShow()
			{
				Console.WriteLine("@&*#@@*$(($#@");
				Console.WriteLine("*# CORRECT *#");
				Console.WriteLine("*#&%*#*@#%@%%");
			}

			void Incorrect()
			{
				Console.WriteLine("EEE");
			}

			MainMenu();
		}
	}
}
