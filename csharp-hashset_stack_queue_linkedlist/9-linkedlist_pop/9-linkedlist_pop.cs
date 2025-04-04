﻿using System;
using System.Collections.Generic;

class LList
{
    public static int Pop(LinkedList<int> myLList)
    {
        if (myLList.Count == 0)
        {
            return 0;
        }

        int firstValue = myLList.First?.Value ?? 0;

        myLList.RemoveFirst();

        return firstValue;
    }
}
