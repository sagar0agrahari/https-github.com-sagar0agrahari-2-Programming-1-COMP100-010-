using System;

namespace Week_4_Assignment_COMP100
{
   class Program
   {
       static void Main(string[] args)
       {
           Console.WriteLine("Enter your hourly pay rate: ");
           double hourlyPayRate = Convert.ToDouble(Console.ReadLine());

           Console.WriteLine("Enter the number of hours worked: ");
           double hoursWorked = Convert.ToDouble(Console.ReadLine());

           double grossPay = hourlyPayRate * hoursWorked;
           double withholdingTax = 0;

           if (grossPay <= 300)
           {
               withholdingTax = grossPay * 0.1;
           }
           else
           {
               withholdingTax = grossPay * 0.12;
           }

           double netPay = grossPay - withholdingTax;

           Console.WriteLine("Gross Pay: $" + grossPay);
           Console.WriteLine("Withholding Tax: $" + withholdingTax);
           Console.WriteLine("Net Pay: $" + netPay);
           Console.ReadLine();
       }
   }
}
