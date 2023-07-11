using System.Collections.Generic;
using System;

namespace SmallChange.Models
{
    public class Change
    {
        public static List <int> _changeKeys = new List <int> { 25, 10, 5, 1};

        // Business Logic goes here.

        public static List<int> Break(int userInputNumber)
    {
        List<int> changeValues = new List<int>(new int[4]);

        for (int i = 0; i <= 3; i++)
        {
            // Save a whole number into the result
            int coinsAmount = userInputNumber / _changeKeys[i];
            userInputNumber %= _changeKeys[i];

            // Set coins to the list
            changeValues[i] = coinsAmount;
        }
        return changeValues;
    }
    }
}