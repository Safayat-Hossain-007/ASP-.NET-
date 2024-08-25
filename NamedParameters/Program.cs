using System;

class NamedParameters
{
    public static void Main(String[] args)
    {
        string nameInput = "Safayat";
        int ageInput = 23;
        int incomeInput = 123323;
        
        printDetails(name : nameInput,
                     income : incomeInput,
                     age: ageInput);
        
    }

    static void printDetails(string name, int age,int income)
    {
        Console.WriteLine(name);
        Console.WriteLine(age);
        Console.WriteLine(income);
        
    }
}