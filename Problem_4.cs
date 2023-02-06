using System;
namespace Week_4_Assignment_COMP100_3_7
{
	public class Problem4
	{
       static void Main(string[] args)
       {
           Console.WriteLine("Enter your message: ");
           string message = Console.ReadLine();

           if (message.Length <= 140)
           {
               Console.WriteLine("message accepted.");
           }
           else
           {
               Console.WriteLine("message rejected.");
           }
           Console.ReadLine();
       }
   }
}

