using System;

namespace Pattern_Diamond
{
    internal class Program
    {
        public static void Wzorek(int n)
        {
            if (n % 2 != 0)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int j = i; j <= n / 2; j++)
                    {
                        Console.Write("*");
                    }
                    for (int j = i + 1; j <= n / 2; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                n = n - 1;
                for (int i = 0; i < n; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int j = i; j <= n / 2; j++)
                    {
                        Console.Write("*");
                    }
                    for (int j = i + 1; j <= n / 2; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
        }
        static void Main(string[] args)
        {
            Wzorek(12);
            Wzorek(12);
        }
    }
}