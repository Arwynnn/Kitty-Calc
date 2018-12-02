// Telling the program what part of the library you want to use
using System;

namespace Calculator_Kitty

{   //An object that can stor methods such as static void main
    class Program

    {   //This is a method
        static void Main(string[] args)
        {   
            //This is a loop (It'll loop forever until the program is closed)
            while (true)
            {

                string function = String.Empty;
                float num1 = 0; float num2 = 0;
                bool check = false;

                //say name of program
                Console.WriteLine("Kitty Calc 2.0");

                while (!check)
                {
                    Console.WriteLine("What is your first number?");
                    var validate = Calcfunction.IsValidNumber(Console.ReadLine());
                    if(validate.Check)
                    {
                        num1 = validate.Num;
                        check = validate.Check;
                    }
                    else { Console.WriteLine("That was not a valid number.");}
                }
                check = false;

                while (!check)
                {
                    Console.WriteLine("What is your second number?");
                    var validate = Calcfunction.IsValidNumber(Console.ReadLine());
                    if (validate.Check)
                    {
                        num2 = validate.Num;
                        check = validate.Check;
                    }
                    else { Console.WriteLine("That was not a valid number."); }
                }

                check = false;

                while (!check)
                {
                    Console.WriteLine("Would you like to add(+), subtract(-), multiply(*) or division(/)?");
                    function = Console.ReadLine();
                    if (Calcfunction.IsValidFunction(function))
                    {
                        check = Calcfunction.IsValidFunction(function);
                    } else { Console.WriteLine("That is not a valid function.");
                    }
                       
                }

                switch (function)
                {
                    case "+":
                        Console.WriteLine(Calcfunction.Add(num1, num2));
                        break;
                    case "-":
                        Console.WriteLine(Calcfunction.Subtract(num1, num2));
                        break;
                    case "*":
                        Console.WriteLine(Calcfunction.Multiply(num1, num2));
                        break;
                    case "/":
                        Console.WriteLine(Calcfunction.Divide(num1, num2));
                        break;
                    default:
                        Console.WriteLine("There seems to be an error.");
                        break;
                }
                Console.WriteLine("Press any key to use again.\nOr type (quit/q) to quit the application.");
                if (Console.ReadLine().ToLower() == "q" || Console.ReadLine().ToLower() == "quit")
                {
                    Environment.Exit(exitCode: 2);
                }
            }



        }
    }
}