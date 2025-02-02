﻿using System;
using System.Collections.Generic;

class List
{
    public static int Sum(List<int> myList)
    {
        HashSet<int> uniqueIntegers = new HashSet<int>();

        foreach (int num in myList)
        {
            uniqueIntegers.Add(num);
        }

        int sum = 0;
        foreach (int num in uniqueIntegers)
        {
            sum += num;
        }
        return sum;
    }
}
