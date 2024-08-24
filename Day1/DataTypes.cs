namespace Module1;
using System;
using System.Threading;


public class DataTypes
{
    public static void Main(String[] args)
    {
        // string stringToNum = "12";
        // int number = Convert.ToInt32(stringToNum);
        // Console.WriteLine(number);
        // //range of the integer number
        // Console.WriteLine(int.MaxValue);
        // Console.WriteLine(int.MinValue);
        //
        //
        // string bigNumber = "1384623560858";
        // long longNumber = Convert.ToInt64(bigNumber);
        // Console.WriteLine("The big number is : "+longNumber);
        // //range of Long number
        // Console.WriteLine(long.MaxValue);
        // Console.WriteLine(long.MinValue);
        //
        //
        // //Double number --> which can be used for the more precison value
        // string decimalNumber = "-12.45";
        // double negative = Convert.ToDouble(decimalNumber);
        // Console.WriteLine(negative);
        // Console.WriteLine(double.MaxValue);
        // Console.WriteLine(double.MinValue);
        //
        //
        //
        // //float numbers are used for less amount of the precison
        // // Precision:
        // // Float:
        // //
        // // Uses 32 bits (4 bytes) of memory.
        // //     Provides about 6 to 7 decimal digits of precision.
        // //     Single precision floating-point.
        // //Double:
        // // Uses 64 bits (8 bytes) of memory.
        // //     Provides about 15 to 16 decimal digits of precision.
        // //     Double precision floating-point.
        //
        // string floatNumber = "-12.45";
        // float precison = Convert.ToSingle(floatNumber);
        // Console.WriteLine(precison);
        // Console.WriteLine(float.MaxValue);
        // Console.WriteLine(float.MinValue);
        //
        // // In C#, 5.2f and 5.2F are indeed the same in terms of functionality. Both represent a float 
        //
        // string moneyString = "12312413.23423";
        // decimal money = Convert.ToDecimal(moneyString);
        // Console.WriteLine(money);
        // Console.WriteLine(decimal.MaxValue);
        // Console.WriteLine(decimal.MinValue);
        //
        //
        // //Creat the  object of another class and acessing the data from that class
        // // TextBasedDataTypes textBased = new TextBasedDataTypes();
        // // Console.WriteLine(textBased.firstName+ " "+textBased.lastName);
        //
        //
        // //string Based Data Types
        // string name = "Safayat Hossain";
        // char letter = 'A';
        // Console.WriteLine("your name is : "+name);
        // Console.WriteLine("The given letter is : "+letter);
        //
        //
        // //boolean Datatype
        // bool isMale = true;
        // Console.WriteLine(isMale);
        // isMale = false;
        // Console.WriteLine(isMale);
        //
        //
        // //Exercise 1
        // string fullName = "Safayat Hossain";
        // string phoneNumber = "01816431849";
        // int age = 24;
        //
        // var fullNameWithVariable = "safayat";
        // var phoneNumberWithVariable = "01816431849";
        // var ageWithVariable = 24;
        //
        // Console.WriteLine(fullName);
        // Console.WriteLine();
        // Console.WriteLine(phoneNumber);
        // Console.WriteLine();
        // Console.WriteLine(age);
        //
        // //Exercise 2
        // int num1 = 10 ;
        // int num2 = 6;
        // int remainder = num1 % num2;
        // Console.WriteLine("The remainder is : "+remainder);
        //
        // num1 = 12;
        // num2 = 6;
        // remainder = num1 % num2;
        // Console.WriteLine(remainder);
        
        //simple input and output
        // Console.Write("Enter your Name : ");
        // string name = Console.ReadLine();
        // Console.Write("Enter your Age : ");
        // int age = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine("Your name is "+name+" and your age is : "+age);
        // Console.ReadLine();


        //Exercise -3
         // Console.Write("Enter first number: ");
         // int firstNumber = Convert.ToInt32(Console.ReadLine());
         //
         // Console.Write("Enter second number: ");
         // int secondNumber = Convert.ToInt32(Console.ReadLine());
         //
         // int result = firstNumber * secondNumber;
         //
         // Console.Write(firstNumber+" x "+secondNumber+" = ");
         // int userAns = Convert.ToInt32(Console.ReadLine());
         //
         // while (userAns != result)
         // { 
         //          Console.WriteLine("incorrect answer");
         //          Console.Write(firstNumber+" x "+secondNumber+" = ");
         //          userAns = Convert.ToInt32(Console.ReadLine());
         //      
         // }
         // Console.WriteLine("Correct");
         // Console.ReadLine();

        //swtich statement
        // Console.Write("Enter the day : ");
        // int day = Convert.ToInt32(Console.ReadLine());
        
        // if (day == 1)
        // {
        //     Console.WriteLine("Sat");
        // }else if (day == 2)
        // {
        //     Console.WriteLine("Sun");
        // }else if (day == 3)
        // {
        //     Console.WriteLine("Moon");
        // }
        // else if (day == 4)
        // {
        //     Console.WriteLine("Tues");
        // }else if (day == 5)
        // {
        //     Console.WriteLine("wed");
        // }else if (day == 6)
        // {
        //     Console.WriteLine("Thurs");
        // }else if (day == 7)
        // {
        //     Console.WriteLine("Fri");
        // }
        // else
        // {
        //     Console.WriteLine("day must be between 1-7");
        // }
        
        // switch(day)
        // {
        //     case 1: Console.WriteLine("Monday"); 
        //         break;
        //     case 2: Console.WriteLine("Tuesday"); 
        //         break;
        //     case 3: Console.WriteLine("wednesday");
        //         break;
        //     case 4:
        //         Console.WriteLine("Thursday");
        //         break;
        //     case 5: Console.WriteLine("Friday");
        //         break;
        //     case 6: Console.WriteLine("Saturday");
        //         break;
        //     case 7: Console.WriteLine("Sunday");
        //         break;
        //     default:
        //         Console.WriteLine("error");
        //         break;
        // }
        //
        // Console.ReadLine();
        
        //ternary operator
        // int age = 17;
        // string result1 = (age >= 18)? "yes" : "No";
        // Console.WriteLine(result1);


        // double format = 12D / 13.5D;
        // Console.WriteLine("{0:0.000}",format);
        //
        // double taka = -12D / 5D;
        // Console.WriteLine("${0:00}",taka);
        // Console.WriteLine(taka.ToString("c"));
        
        //tryParse function
        // bool sucess = true;
        // while (sucess)
        // {
        //     Console.Write("Enter a number: ");
        //     string number = Console.ReadLine();
        //     if (int.TryParse(number, out int num))
        //     {
        //         sucess = false;
        //         Console.WriteLine(num);
        //     }
        //     else
        //     {
        //         Console.WriteLine("failed to convert");
        //     }
        // }
        //
        // Console.ReadLine();

        //Exercise-4 {Times table print}
        // bool sucess = true;
        //
        // while (sucess)
        // {
        //     Console.Write("Which times table you want to print ? : ");
        //     string table = Console.ReadLine();
        //     if (int.TryParse(table, out int num))
        //     {
        //         sucess = false;
        //          for (int i = 1; i <= 10; i++) {
        //              Console.WriteLine(table+" x "+i+" = "+num*i );
        //          }
        //          break;
        //     }
        //     else
        //     {
        //         Console.WriteLine("Invalid input");
        //     }
        // }
        // Console.ReadLine();

        //Exercise-5 Fizz-buzz problem 
        // bool threeDiv = false;
        // bool fiveDiv = false;
        //
        // for (int i = 1; i <= 15; i++)
        // {
        //     threeDiv = i % 3 == 0;
        //     fiveDiv = i % 5 == 0;
        //     
        //     if (threeDiv && fiveDiv)
        //     {
        //         Console.WriteLine(i+" Fizz-Buzz");
        //     }else if (threeDiv)
        //     {
        //         Console.WriteLine(i+" Fizz");
        //     }else if (fiveDiv)
        //     {
        //         Console.WriteLine(i+" Buzz");
        //     }
        //     else
        //     {
        //         Console.WriteLine(i+ " number");
        //     }
        // }


        // string[] names = new string[] { "safayat ", "hossain ", "jake lokely " };
        // Console.WriteLine(string.Concat(names));
        // string name1 = "Safayat";
        // int age = 23;
        // Console.WriteLine(string.Concat("you name is ",name1," and age is ",age));
        //
        // Console.Write("Enter your name : ");
        // string name = Console.ReadLine();
        // // if (name != string.Empty)
        // if(!name.Equals(string.Empty))
        // {
        //     Console.WriteLine($"Your name is : {name}");
        // }
        // else
        // {
        //     Console.WriteLine("Your name field is empty");
        // }
        //
        // Console.ReadLine();

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
        // Console.Write("Enter your Name: ");
        // string name = Console.ReadLine();
        //
        // if (!string.IsNullOrEmpty(name))
        // {
        //     if (!name.Equals("safa"))
        //     {
        //         Console.WriteLine(name);
        //     }
        // }
        // else
        // {
        //     Console.WriteLine("incorrect");
        // }
        
        
        //print string in reverse
    }
}



