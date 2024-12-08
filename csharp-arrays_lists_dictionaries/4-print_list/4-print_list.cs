﻿namespace _4_print_list;

class List
{
    public static List<int> CreatePrint(int size)
    {
        if (size < 0)
        {
           Console.WriteLine("Size cannot be negative");
           return null; 
        }

        List<int> list = new List<int>();

        for (int i = 0; i < size; i++)
        {
            list.Add(i);
        }
        for (int i = 0; i < size; i++)
        {
            Console.Write(list[i]);
            if (i < size - 1)
            {
                Console.Write(" ");
            }
        }
        Console.WriteLine();
        return list;
    }
}
