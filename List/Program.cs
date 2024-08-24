using System;
using System.Collections.Generic;
public class Program
{
    public static void Main(String[] args)
    {
        List<int> listNumbers = new List<int>();
        for (int i = 0; i < 3; i++)
        {
            Console.Write("Enter Number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            listNumbers.Add(num);
        }
        // foreach (int num in numbers)
        // {
        //     Console.WriteLine(num);
        // }

        for (int i = 0; i < listNumbers.Count; i++)
        {
            Console.WriteLine(listNumbers[i]);
        }
    }
}

