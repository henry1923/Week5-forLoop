﻿using System;
public class Exercise6
{
    public static void Main()
    {
        int j, n;

        Console.Write("\n\n");
        Console.Write(":\n");
        Console.Write("-----------------------------------");
        Console.Write("\n\n");

        Console.Write("Input the number (Table to be calculated) : ");
        n = Convert.ToInt32(Console.ReadLine());
        Console.Write("\n");
        for (j = 1; j <= 10; j++)
        {
            Console.Write("{0} X {1} = {2} \n", n, j, n * j);
        }
    }
}