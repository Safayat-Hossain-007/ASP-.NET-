using System;

public class Program
{
    public static void Main (String []args)
    {
         // string[] names = new string[] { "safayat ", "hossain ", "jake lokely " };
         // Console.WriteLine(string.Concat(names));
         // string name1 = "Safayat";
         // int age = 23;
         // Console.WriteLine(string.Concat("you name is ",name1," and age is ",age));
         //
         // Console.Write("Enter your name : ");
         // string name2 = Console.ReadLine();
         // // if (name != string.Empty2
         // if(!name2.Equals(string.Empty))
         // {
         //     Console.WriteLine($"Your name is : {name2}");
         // }
         // else
         // {
         //     Console.WriteLine("Your name field is empty");
         // }
         //
         // Console.ReadLine();
         //
         // string message = "c# is awesome!";
         // for (int i = 0; i < message.Length; i++)
         // {
         //     Console.Write(message[i]);
         //     Thread.Sleep(50);
         // }
         // Console.WriteLine();
         //
         // //our own contains function
         // bool found = false;
         // for (int i = 0; i < message.Length; i++)
         // {
         //     if (message[i].Equals('a'))
         //     {   
         //         found = true;
         //         Console.WriteLine(found);
         //         break;
         //     }
         // }
         // Console.WriteLine(found);
         // Console.ReadLine();
        
        //isNullOrEmpty
         Console.Write("Enter your Name: ");
         string name = Console.ReadLine();
        
         if (!string.IsNullOrEmpty(name))
         {
             if (!name.Equals("safa"))
             {
                 Console.WriteLine(name);
             }
         }
         else
         {
             Console.WriteLine("incorrect");
         }
        
    }
}