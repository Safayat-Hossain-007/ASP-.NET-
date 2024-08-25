using System;
using System.Threading.Channels;

class Program
{
    public static void Main()
    {
        Console.WriteLine(printName("safayat"));
        Console.WriteLine();
        Console.WriteLine(sum(1,2));
        
    }

    static string printName(String name = default)
    {
        string name1 = $"My name is {name}";
        return name1;
    }

    static int sum(int a, int b = default)
    {
        return a + b;
    }
}