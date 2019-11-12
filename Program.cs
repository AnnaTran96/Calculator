using System;

namespace ExceptionHandlingCal
{
    class Program
    {
        static void Main(string[] args)
        {
            bool useAgain = true;

            while (useAgain)
            {

                try
                {
                    Console.Write("Enter a number:\t");
                    decimal num1 = Convert.ToDecimal(Console.ReadLine());
                    Console.Write("Choose an operator /nThis can either be '+', '-', '/' or '*'\n");
                    string operation = Console.ReadLine();
                    Console.Write("Enter a second number:\t");
                    decimal num2 = Convert.ToDecimal(Console.ReadLine());

                    if (operation == "+")
                    {
                        Console.WriteLine(num1 + num2);
                    }
                    else if (operation == "-")
                    {
                        Console.WriteLine(num1 - num2);
                    }
                    else if (operation == "*")
                    {
                        Console.WriteLine(num1 * num2);
                    }
                    else if (operation == "/")
                    {
                        Console.WriteLine(num1 / num2);
                    }
                    else
                    {
                        Console.WriteLine("Invalid Operator");
                    }

                }

                catch (DivideByZeroException e)
                {
                    Console.WriteLine(e.Message);
                }

                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {

                }


                Console.WriteLine("Do you want to use the calculator again? Yes or No? \t");
                string contUse;
                contUse = Console.ReadLine();
                contUse = contUse.ToLower();

                if (contUse == "yes")
                {
                    useAgain = true;
                    Console.Clear();
                }
                else if (contUse == "no")
                {
                    useAgain = false;
                }
                else
                {

                }


            }
        }
    }
}
