using System;
public class Program{
    public static void Main(String[] args)
    {
        Console.Write("Enter your password: ");
        string password = Console.ReadLine();

        Console.Write("Enter your password again:");
        String passwordAgain = Console.ReadLine();

        bool sucess = true;
        while (sucess)
        {
            if (!string.IsNullOrEmpty(password) && !string.IsNullOrEmpty(passwordAgain))
            {
                if (password.Length > 6 && passwordAgain.Length > 6)
                {
                    if (password.Equals(passwordAgain))
                    {   
                        sucess = false;
                        Console.WriteLine("Passwords match!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Passwords do not match! Try again!");
                    
                        Console.Write("Enter your password : ");
                        password = Console.ReadLine();

                        Console.Write("Enter your password again:");
                        passwordAgain = Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("Password is too short ! enter more than 6 characters!");
                    Console.Write("Enter your password : ");
                    password = Console.ReadLine();

                    Console.Write("Enter your password again:");
                    passwordAgain = Console.ReadLine();
                }
                
            }
            else
            {
                Console.WriteLine("Passwords can't be empty! Try again!");
                Console.Write("Enter your password : ");
                password = Console.ReadLine();

                Console.Write("Enter your password again:");
                passwordAgain = Console.ReadLine();
                
            }
        }
    }
}

