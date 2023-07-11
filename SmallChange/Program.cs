using System.Collections.Generic;
using System.Threading; 
using System;

namespace SmallChange.Models
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
            Console.WriteLine(" ");
            Console.WriteLine("Welcome to Small-Change Exchange!");
            Console.WriteLine(" ");
            Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
            Console.WriteLine(" ");
            Console.WriteLine("Enter an Amount in Cents in Order To Find");
            Console.WriteLine("the Most Efficient Way to Break It");
            string userInput = Console.ReadLine();
            int userInputNumber = int.Parse(userInput);
            {
            ShowSimplePercentage();
            }
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            List<int> collection = Change.Break(userInputNumber);


            // Show result
            Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*");
            Console.WriteLine(" ");
            Console.WriteLine($"Your Change is: {collection[0]} quarters, {collection[1]} dimes, {collection[2]} nickles, {collection[3]} pennies");
            Console.WriteLine(" ");
            Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Thanks for Using Small-Change Exchange!");
            Console.WriteLine("Do You Need To Break More Change?(Y/N)");
            string userInput2 = Console.ReadLine();
            if (userInput2 == "Y")
            {
                Main();
            }
            else if (userInput2 == "N")
            {
                Console.WriteLine(" ");
                Console.WriteLine("Good Bye Bish");
                Console.WriteLine(" ");
            }
        }
        static void ShowSimplePercentage()
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.Write($"\rProgress: {i}%   ");
                Thread.Sleep(25);
            }

            Console.Write("\rDone!          ");
        }
    }
}