using System;

namespace inluppg2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skrivi in en multiplikation");
            string input = Console.ReadLine();

            int xIndex = input.IndexOf('*');
            int n1 = int.Parse(input[..xIndex]);
            int n2 = int.Parse(input[(xIndex + 1)..]);
            Console.WriteLine($"Svaret är {n1*n2}");
            Console.ReadKey();
        }
    }
}