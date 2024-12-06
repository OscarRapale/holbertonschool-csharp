namespace _4_print_hexa;

class Program
{
    static void Main(string[] args)
    {
        for (int num = 0; num <= 98; num++)
        {
            Console.WriteLine($"{num} = 0x{num:X}");
        }
    }
}
