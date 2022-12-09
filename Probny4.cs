using System;

class dupa
{
    public static void Main(string[] args)
    {
        int[,] tab = new int[,]
        {
            { 1,1,1,1,1,1 },
            { 2,2,2,2,2,2 },
            { 3,3,3,3,3,3 }
        };

        try
        {
            if (tab == null)
            {
                Console.WriteLine("0,0");
            }
            else if (tab.Length == 0)
            {
                Console.WriteLine("0,0");
            }
            else
            {
                double sum = 0;
                foreach (int i in tab)
                {
                    sum += i;
                }
                Console.WriteLine(sum / tab.Length);
            }
        }
        catch
        {
            Console.WriteLine("0.0");
        }

    }
}
