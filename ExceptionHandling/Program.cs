using System;

public class ExceptionHandling
{
    public static void Main(String [] args)
    {
        bool sucess = true;
        while (sucess)
        {
            try
            {
                Console.Write("Enter a number:");
                int number = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Your number is " + number);
                sucess = false;
            }
            catch (InvalidDataException)
            {
                Console.WriteLine("Please enter a valid number");
            }
            catch (FormatException)
            {
                Console.WriteLine("please enter numner only");
            }
            catch (Exception)
            {
                Console.WriteLine("something went wrong");
            }
        }
    }
}