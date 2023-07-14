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
    List<int> numberList = new List<int>();

for (int i = 1; i <= bread; i++)
{
    numberList.Add(i);
}
    for (int i = 0; i<length; i++)
{
    if (i % 3 == 0)
    {
        // Index value is divisible by 3
        // Do something here
    }
}
}
    }

