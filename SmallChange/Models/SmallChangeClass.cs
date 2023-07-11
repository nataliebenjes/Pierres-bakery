using System.Collections.Generic;
using System;

namespace SmallChange.Models
{
    public class Change
    {
        public static List <int> _changeKeys = new List <int> { 25, 10, 5, 1};

        public static List<int> Break(int userInputNumber)
        {
            List<int> changeValues = new List<int>(new int[4]);

            for (int i = 0; i <= 3; i++)
            {
                int coinsAmount = userInputNumber / _changeKeys[i];
                userInputNumber %= _changeKeys[i];
                changeValues[i] = coinsAmount;
            }
            return changeValues;
        }

        public static List<int> DifferentChange(int userInputNumber)
        {
            List<int> changeValues1 = new List<int>(new int[4]);
            List<int> changeValues2 = new List<int>(new int[4]);

            int firstHalf = userInputNumber / 2;
            int secondHalf = userInputNumber - firstHalf;

            for (int i = 0; i <= 3; i++)
            {
                int coinsAmount1 = firstHalf / _changeKeys[i];
                firstHalf %= _changeKeys[i];
                changeValues1[i] = coinsAmount1;

                int coinsAmount2 = secondHalf / _changeKeys[i];
                secondHalf %= _changeKeys[i];
                changeValues2[i] = coinsAmount2;
            }

            List<int> totalChangeValues = new List<int>();
            for (int i = 0; i < changeValues1.Count; i++)
            {
                totalChangeValues.Add(changeValues1[i] + changeValues2[i]);
            }

            return totalChangeValues;
        }
    }
}
