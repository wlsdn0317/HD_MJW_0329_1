﻿using System;

class Program
{
    static void Main(string[] args)
    {
        for(int i = 3; i < 10; i+=3)
        {
            for(int j = 1; j < 10; j++)
            {
                Console.WriteLine($"{i}*{j} = {i * j}");
            }
            Console.WriteLine("\n");
        }
    }
}
