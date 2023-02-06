using System;

namespace Week_4_Assignment_COMP100
{
   class Program
   {
       static void Main(string[] args)
       {
           const double textbookAverageCost = 125;
           const double premiumForHardcover = 0.2;
           const double doscountOnTextbook = 0.05;
           const int numberOfTextbookOnDiscount = 4;

           Console.WriteLine("Enter the number of hardcover textbooks: ");
           int numHardcover = Convert.ToInt32(Console.ReadLine());

           Console.WriteLine("Enter the number of softcover textbooks: ");
           int numSoftcover = Convert.ToInt32(Console.ReadLine());

           double hardcoverCost = numHardcover * textbookAverageCost * (1 + premiumForHardcover);
           double softcoverCost = numSoftcover * textbookAverageCost;

           if (numHardcover + numSoftcover > numberOfTextbookOnDiscount)
           {
               hardcoverCost = hardcoverCost * (1 - doscountOnTextbook);
               softcoverCost = softcoverCost * (1 - doscountOnTextbook);
           }

           double totalCost = hardcoverCost + softcoverCost;

           Console.WriteLine("Cost of hardcover textbooks: $" + hardcoverCost);
           Console.WriteLine("Cost of softcover textbooks: $" + softcoverCost);
           Console.WriteLine("Total cost of textbooks: $" + totalCost);
           Console.ReadLine();
       }
   }
}
