using System;
using System.Collections.Generic;

class Dictionary {
    public static string BestScore(Dictionary<string, int> myList)
    {
        if (myList.Count == 0)
        {
            return "None";
        }

        string bestKey = null;
        int bestValue = -1;

        foreach (KeyValuePair<string, int> kvp in myList)
        {
            if (kvp.Value > bestValue)
            {
                bestKey = kvp.Key;
                bestValue = kvp.Value;
            }
        }
        return bestKey;
    }
}
