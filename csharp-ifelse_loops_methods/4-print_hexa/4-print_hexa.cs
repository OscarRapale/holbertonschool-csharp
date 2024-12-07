using System;

class Program
{
    static void Main(string[] args)
    {
        for (int num = 0; num <= 98; num++)
        {
            Console.Write($"{num} = 0x{num:X}\n");
        }
    }
}
