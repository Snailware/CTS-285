using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dataman_2Lib;

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
						default:
							Console.WriteLine("INVALID ENTRY.");
							break;
					}
				}
				while (input != "4");
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
				string input;

				do
				{
					Console.WriteLine();
					Console.WriteLine("1. ENTER PROBLEMS");
					Console.WriteLine("2. ANSWER PROBLEMS");
					Console.WriteLine("3. EXIT");
					Console.WriteLine("MAKE A SELECTION");
					input = Console.ReadLine();

					switch (input)
					{
						case "1":
							MemoryBankEnter();
							break;
						case "2":
							MemoryBankAnswer();
							break;
					}
				}
				while (input != "3");
			}

			void NumberGuesser()
			{
				string input;
				int intInput,
					randomNumber,
					tries = 0;

				Random random = new Random();
				randomNumber = random.Next(9, 101);

				do
				{
					Console.WriteLine($"{random.Next(9, randomNumber)}  ???  {random.Next(randomNumber, 101)}");

					input = Console.ReadLine();
					intInput = int.Parse(input);
					tries++;
				}
				while (intInput != randomNumber);
				LightShow();
				Console.WriteLine($"IT TOOK YOU {tries} TO GUESS THE NUMBER! PRESS [ENTER] TO CONTINUE.");
				Console.ReadLine();
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

			void MemoryBankAnswer()
			{
				string input;

				do
				{
					if (DataModel.MBSavedProblems.Count > 0)
					{
						Console.WriteLine(DataModel.MBSavedProblems[0]);
						Console.WriteLine("ENTER YOUR ANSWER OR PRESS [ENTER] TO EXIT");
						input = Console.ReadLine();
						if (GetAnswer(DataModel.MBSavedProblems[0]) == int.Parse(input))
						{
							LightShow();
							DataModel.MBSavedProblems.RemoveAt(0);
						}
						else
						{
							Incorrect();
						}
					}
					else
					{
						Console.WriteLine("NO PROBLEMS SAVED. PRESS [ENTER] TO RETURN.");
						Console.ReadLine();
						break;
					}

				} while (input != "");
			}

			void MemoryBankEnter()
			{
				string input;

				do
				{
					Console.WriteLine("ENTER A PROBLEM OR PRESS [ENTER] WHEN FINISHED.");
					input = Console.ReadLine();
					if (input != "")
					{
						DataModel.MBSavedProblems.Add(input);
					}
				}
				while (input != "");
			}

			int GetAnswer(string input)
			{
				int rightNumber,
					leftNumber,
					answer;
				string localOperator;

				string[] inputTokens = input.Split(null);
				rightNumber = int.Parse(inputTokens[0]);
				localOperator = inputTokens[1];
				leftNumber = int.Parse(inputTokens[2]);

				switch (localOperator)
				{
					case "+":
						answer = rightNumber + leftNumber;
						break;
					case "-":
						answer = rightNumber - leftNumber;
						break;
					case "*":
						answer = rightNumber * leftNumber;
						break;
					case "/":
						answer = rightNumber / leftNumber;
						break;
					default:
						answer = 0;
						break;
				}

				return answer;
			}

			MainMenu();
		}
	}
}
