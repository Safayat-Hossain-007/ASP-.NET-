using System;
using System.Collections.Generic;

class New
{
    //if we put public static void dou(){} --> then we don't have create instance/object 
     public void dou()
    {
        Console.WriteLine("Hello from another class");
    }
}

public class Program
{
    public static void Main(String[] args)
    {
        PrintMessage();
        New n = new New();
        n.dou();
        Console.ReadLine();
    }

    static void PrintMessage()
    {
        Console.WriteLine("Hello from another function");
    }
    
}