using System;

class Program
{
    static void Main(string[] args)
    {
        int sum = 0;
        int i = 1;
        while (i < 21)
        {
            if(i %2 != 0)
            {
                sum += i;
            }
            i++;
        }
        Console.WriteLine($"홀수의 합은 = {sum}");
    }
}
