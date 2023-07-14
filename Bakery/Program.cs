using System.Collections.Generic;
using System.Threading;
using System;

namespace Bakery.Models;

class Program
{
  static void Main()
  {
    Console.WriteLine("Hello, welcome to Pierre's Bakery!");
    Console.WriteLine("Bread is Buy 2, get 1 free. A single loaf costs $5");
    Console.WriteLine("If you would like a pastry, the deal is if you Buy 3, get 1 free. A single pastry costs $2, then");
    Console.WriteLine("How many loaves of bread would you like? Please enter a number between 0 and 10, then press enter");
    string breadInput = Console.ReadLine();
    int breadInputNumber = int.Parse(breadInput);
    Console.WriteLine("How many pastries would you like? Please enter a number between 0 and 10, then press enter");
    string pastryInput = Console.ReadLine();
    int pastryNumber = int.Parse(pastryInput);
    //calculate bread cost
    //calculate pastry cost
    //Console.Writeline("your total cost is");
  }

}