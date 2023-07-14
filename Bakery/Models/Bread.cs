using System.Collections.Generic;
using System;
using Bakery.Models;

//one loaf is $5
//two loaves costs $10
// three loaves cost $10
// four loaves costs $15
// five loaves cost $20
// six loaves costs $20
// seven loaves cost $25
// Can you see a pattern? Every 3rd loaf of bread is free.
//write loop, every time i % 3, add 0 to cost
namespace Bakery.Models
{
  public class Bread
  {
    public int breadInputNumber { get; set; }
    //need to create object to loop through up to bread input number
    public int breadTotal = 0;
    public static List<int> breadNumberList = new List<int>();
    public static List<int> ListOf(int breadInputNumber)
    {
      for (int i = 0; i <= breadInputNumber; i++)
      {
        // breadNumberList.Add(i);
      }
      return breadNumberList;
    }

    public static int CalcTotal(List<int> breadNumberList, int breadTotal)
    {
      for (int i = 0; i < breadNumberList.Count; i++)
      {
        if (i % 3 != 0)
        {
          // Index value is divisible by 3
          // add a add 5 to total value
          breadTotal += 5;
        }
      }
      return breadTotal;
    }

  }
}