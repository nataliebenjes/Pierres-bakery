using System.Collections.Generic;
using System;

namespace Bakery.Models
{
  //two pastries costs $4
  // three pastries costs $6
  // four pastries costs $6
  // five pastries costs $8
  // six pastries costs $10
  // seven pastries costs $12
  // eight pastries costs $12
  public class Pastry
  {
    public int pastryInputNumber { get; set; }
    //need to create object to loop through up to bread input number
    public int pastryTotal = 0;
    public static List<int> pastryNumberList = new List<int>();
    public static List<int> ListOf(int pastryInputNumber)
    {
      for (int i = 0; i <= pastryInputNumber; i++)
      {
        pastryNumberList.Add(i);
      }
      return pastryNumberList;
    }
    public static int CalcTotal(List<int> pastryNumberList, int pastryTotal)
    {
      for (int i = 0; i < pastryNumberList.Count; i++)
      {
        if (i % 4 != 0)
        {
          // Index value is divisible by 4
          // add a add 5 to total value
          pastryTotal += 2;

        }
      }
      return pastryTotal;
    }
  }
}