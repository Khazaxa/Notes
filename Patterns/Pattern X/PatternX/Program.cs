using System;

namespace PatternX
{
        class Program
        {
            public static void PrintX(int n)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (i == j || i + j == n - 1)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }
            }
            static void Main(string[] args)
            {
                PrintX(5);
            }
        }    
}