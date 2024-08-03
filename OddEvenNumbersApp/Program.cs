using System;

namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            printNumbers("Numbers", Numbers);
            printNumbers("Even No", Numbers.Where(x=>IsEven(x)));
            printNumbers("Odd No", Numbers.Where(x => IsOdd(x)));

            Console.ReadKey();
        }
        static void printNumbers(string title,IEnumerable<int> Numbers)
        {
            Console.WriteLine();
            Console.Write($"{title} : [");
            foreach(var num in Numbers)
            {
                Console.Write($"{num},");
            }
            Console.WriteLine($" ]");
            Console.WriteLine();
        }

        static bool IsEven(int num) => num % 2 == 0;

        static bool IsOdd(int num) => !IsEven(num);
        
    }
}