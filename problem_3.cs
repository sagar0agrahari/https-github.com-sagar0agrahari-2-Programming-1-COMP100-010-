using System;
namespace Week_4_Assignment_COMP100_3_7
{
	public class problem_3
	{
		static void Main(string[] args)
		{
			Console.WriteLine("The number of years that the money was left in the bank");
			int moneyLeftInBank = Convert.ToInt32(Console.ReadLine());
			double interestRate;

			if (moneyLeftInBank > 5)
			{
				interestRate = 7.5;
			}
			else
			{
				interestRate = 5.4;
			}
			Console.WriteLine("The interest rate for " + moneyLeftInBank + " years is " + interestRate + "%");

			Console.ReadLine();
		}
	}
}

