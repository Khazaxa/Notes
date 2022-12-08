using System;
namespace PatternTriangle
{
    internal class Program
    {
        public static void Wzorek(int n)
        {

            if (n % 2 == 0)
            {
                n--;
                if (n < 3)
                {
                    Console.WriteLine("Liczba n, nie może być mniejsza niż 3");
                }
                else if (n % 2 != 0)
                {
                    int i = 0;
                    int l = 0;
                    int k = n;
                    for (l = 0; l < n; l++)
                    {
                        for (i = 0; i < k; i++)
                        {
                            Console.Write("*");

                        }
                        Console.WriteLine();
                        for (int z = 0; z <= l; z++)
                        {
                            Console.Write(" ");
                        }

                        k = k - 2;

                    }
                    
                }
            }
            else if (n % 2 != 0)
            {
                if (n < 3)
                {
                    Console.WriteLine("Liczba n, nie może być mniejsza niż 3");
                }
                else if (n % 2 != 0)
                {
                    int i = 0;
                    int l = 0;
                    int k = n;
                    for (l = 0; l < n; l++)
                    {
                        for (i = 0; i < k; i++)
                        {
                            Console.Write("*");

                        }
                        Console.WriteLine();
                        for (int z = 0; z <= l; z++)
                        {
                            Console.Write(" ");
                        }

                        k = k - 2;

                    }
                    
                }
            }                                                         
        }
        static void Main(string[] args)
        {
            Wzorek(12);
        }
    }
}