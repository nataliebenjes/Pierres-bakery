using System.Collections.Generic;
using System;

namespace SmallChange.Models
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*");
            Console.WriteLine("Welcome to Small-Change Exchange!");
            Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*");
            Console.WriteLine("Enter an Amount in Cents in Order To Find the Most Efficient Way to Break It");
            string userInput = Console.ReadLine();
            int userInputNumber = int.Parse(userInput);
            List<int> collection = Change.Break(userInputNumber);
        }
    }
}