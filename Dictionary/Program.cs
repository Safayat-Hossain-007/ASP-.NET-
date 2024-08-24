using System;
using System.Collections.Generic;

class Program
{
    public static void Main(String[] args)
    {
        // Dictionary<int, string> name = new Dictionary<int, string>()
        // {
        //     {1,"Safayat" },
        //     {2,"Jake"},
        //     {3,"Ghost"},
        // };
        //
        // for (int i = 0; i < name.Count; i++)
        // {
        //     KeyValuePair<int, string> pair = name.ElementAt(i);
        //     Console.WriteLine(pair.Key + " - " + pair.Value);
        //     
        // }
        //
        // foreach (KeyValuePair<int,string> kvp in name)
        // {
        //     Console.WriteLine($"{kvp.Key} - {kvp.Value}");
        // }

        Dictionary<string, string> teacher = new Dictionary<string, string>()
        {
            { "Math", "Safayat" },
            { "Science", "Jake" }
        };

        if (teacher.TryGetValue("math", out string found))
        {
            Console.WriteLine(found);
        }
        else
        {
            Console.WriteLine("Not found");
        }
        
    }
}