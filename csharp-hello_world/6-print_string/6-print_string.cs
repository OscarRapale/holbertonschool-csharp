using System;

class Program
{
	static void Main(string[] args)
	{
		string str = "Holberton School";
		Console.Write($"{str}");
        Console.Write($"{str}");
        Console.Write($"{str}");
        Console.WriteLine("");

        string firstNineChars = str.Substring(0, 9);
        Console.WriteLine($"{firstNineChars}");
    }
}