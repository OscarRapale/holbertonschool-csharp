using System;
using System.Collections.Generic;
using System.Linq;

class Dictionary {
    public static void PrintSorted(Dictionary<string, string> myDict) {
        List<string> sortedKeys = new List<string>(myDict.Keys);
        sortedKeys.Sort();

        foreach (string key in sortedKeys)
        {
            Console.WriteLine($"{key}: {myDict[key]}");
        }
    }
}