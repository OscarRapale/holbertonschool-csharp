using System;
using System.Collections.Generic;

class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)

    {
        HashSet<int> set1 = new HashSet<int>(list1);
        HashSet<int> set2 = new HashSet<int>(list2);
        HashSet<int> differenceSet = new HashSet<int>();

        foreach (int num in list1)
        {
            if (!set2.Contains(num))
            {
                differenceSet.Add(num);
            }
            else
            {
                differenceSet.Remove(num);
            }
        }

        foreach (int num in list2)
        {
            if (!set1.Contains(num))
            {
                differenceSet.Add(num);
            }
            else
            {
                differenceSet.Remove(num);
            }
        }

        List<int> differenceList = new List<int>(differenceSet);
        differenceList.Sort();

        return differenceList;
    }
}
