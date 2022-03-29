using System;

class Program
{
    static void Main(string[] args)
    {
        int i = 2;
        int j = 1;
        while (i < 7)
        {
            while (j < 10)
            {
                Console.WriteLine($"{i}*{j} = {i * j}");
                j++;
            }
            Console.WriteLine("\n");
            j = 1;
            i += 2;
        }
    }
}
