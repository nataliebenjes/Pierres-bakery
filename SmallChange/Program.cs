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
            Console.WriteLine("  ___            _ _      ___ _                       ");
            Console.WriteLine(" / __|_ __  __ _| | |___ / __| |_  __ _ _ _  __ _ ___ ");
            Console.WriteLine(" \\__ \\ '  \\/ _` | | |___| (__| ' \\/ _` | ' \\/ _` / -_)");
            Console.WriteLine(" |___/_|_|_\\__,_|_|_|    \\___|_||_\\__,_|_||_\\__, \\___|");
            Console.WriteLine("         _____  _____ _  _   _   _  _  ___ _|___/     ");
            Console.WriteLine("        | __\\ \\/ / __| || | /_\\ | \\| |/ __| __|       ");
            Console.WriteLine("        | _| >  < (__| __ |/ _ \\| .` | (_ | _|        ");
            Console.WriteLine("        |___/_/\\_\\___|_||_/_/ \\_\\_|\\_|\\___|___|       ");

            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
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

            Console.WriteLine("Do You Want Your Money In a Different Change? (Y/N)");
            string userDifferentChange = Console.ReadLine();
            if (userDifferentChange == "Y")
            {
                collection = Change.DifferentChange(userInputNumber); // Note the removal of 'List<int>'

                // Show different change result
                Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*");
                Console.WriteLine(" ");
                Console.WriteLine($"Your Different Change is: {collection[0]} quarters, {collection[1]} dimes, {collection[2]} nickles, {collection[3]} pennies");
                Console.WriteLine(" ");
                Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*");
            }
            else
            {
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