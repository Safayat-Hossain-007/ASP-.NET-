using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        List<int> number = new List<int>();
        for (int i = 1; i <= 21; i++)
        {
            number.Add(i);
        }

        List<int> oddNumber = new List<int>();
        List<int> evenNumber = new List<int>();

        for (int i = 1; i <= 20; i++)
        {
            if (number[i] % 2 == 0)
            {
                evenNumber.Add(i);
            }
            else
            {
                oddNumber.Add(i);
            }
        }

        Console.Write("Even numbers: ");
        foreach (var even in evenNumber)
        {
            Console.Write($"{even} ");
        }
        Console.WriteLine();
        
        Console.Write("Odd numbers: ");
        foreach (var odd in oddNumber)
        {
            Console.Write($"{odd} ");
        }
    }
}