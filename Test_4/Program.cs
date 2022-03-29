using System;

class Program
{
    static void Main(string[] args)
    {
        for(int i = 0; i < 5; i++)
        {
            for(int j = 0; j < 5; j++)
            {
                if (j > i)
                {

                }
                else
                {
                    Console.Write("*");
                }
            }
            Console.Write("\n");
        }
    }
}
