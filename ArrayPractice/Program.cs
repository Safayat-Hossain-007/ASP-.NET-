using System;

public class Program
{
    public static void Main(String[] args)
    {
        // int[] numbers = new int[5];
        // //Entering values into the array 
        // Console.WriteLine("Enter values into the array: ");
        // for (int i = 0; i < numbers.Length; i++)
        // {
        //     Console.Write("Enter a number: ");
        //     numbers[i] = Convert.ToInt32(Console.ReadLine());
        // }
        //
        // //All the elements in the array
        // foreach (int num in numbers)
        // {
        //     Console.Write(num+" ");
        // }
        //
        // Console.ReadLine();
        
        
        //Triangle Example
        // int[] angles = new int[3];
        // for (int i = 0; i < angles.Length; i++)
        // {
        //     Console.Write("Enter angle: ");
        //     angles[i] = Convert.ToInt32(Console.ReadLine());
        // }
        //
        // int sum = 0;
        // foreach (int angle in angles)
        // {
        //     sum = sum + angle;
        // }
        //
        // Console.WriteLine( sum == 180 ? "valid" : "Invalid");
        
        
        //array sorting
        // int[] numbers = new int[]
        // {
        //     2, 2, 4, 5, 1, 6, 87, 5, 3
        // };
        // // Array.Sort(numbers);
        // // foreach (int number in numbers)
        // // {
        // //     Console.Write($"{number} ");
        // // }
        //
        //Array Reverse
        // Array.Sort(numbers);
        // Array.Reverse(numbers);
        // foreach (int item in numbers)
        // {
        //     Console.Write($"{item} ");
        // }
        
        
        //Array IndexOf
        int[] numbers = new int[]
        {
            5, 2, 33, 22, 66, 2
        };

        Console.Write("Enter the number that you want to search: ");
        int search = Convert.ToInt32(Console.ReadLine());
        int position = Array.IndexOf(numbers, search);
       
        if (position > -1)
        {
            Console.WriteLine($"Number {search} found at postion {position+1}");
        }
        else
        {
            Console.WriteLine("Not Found");
        }
    }
}