using System;
namespace Week_4_Assignment_COMP100
{
   public class problem_9
   {
       static void Main(string[] args)
       {
           int iqScore;
           Console.WriteLine("Enter a iqScore = ");
           iqScore = Convert.ToInt32(Console.ReadLine());

           if ((iqScore < 0) || (iqScore > 200))
           {
               Console.WriteLine("Error: IQ score must be between 0 and 200.");
           }
           else if (iqScore > 100)
           {
               Console.WriteLine("Above average IQ score.");
           }
           else if (iqScore == 100)
           {
               Console.WriteLine("Average IQ score.");
           }
           else
           {
               Console.WriteLine("Below average IQ score.");
           }
           Console.ReadLine();

       }
   }
}