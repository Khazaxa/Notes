using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Pobierz wymiary trójkąta od użytkownika
            Console.Write("Podaj długość podstawy trójkąta: ");
            int baseLength = int.Parse(Console.ReadLine());

            Console.Write("Podaj wysokość trójkąta: ");
            int height = int.Parse(Console.ReadLine());

            // Narysuj trójkąt
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < baseLength; j++)
                {
                    if (i == 0 || i == height - 1 || j == 0 || j == baseLength - 1)
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
    }
}
