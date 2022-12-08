using System;

namespace Hourglass
{
    internal class Program
    {
        public static void PrintHourglass(int n)
        {
            if (n % 2 == 0)
            {
                n--;
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j || i + j == n - 1 || i == n / 2 || j == n / 2)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            PrintHourglass(25);
        }
    }
}
