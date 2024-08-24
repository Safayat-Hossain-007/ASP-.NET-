using System;
public class Program
{
    public static void Main(String[] args)
    {
        //Printing a  String 
        Console.Write("Enter Your name: ");
        string name = Console.ReadLine();

        for (int i = 0; i < name.Length; i++)
        {
            Console.Write(name[i]);
        }

        Console.WriteLine();
        Console.ReadLine();
        
        //printing a String in reverse
        for (int i = name.Length - 1; i >= 0; i--)
        {
            Console.Write(name[i]);
        }
        Console.WriteLine();
        Console.ReadLine();
    }
}