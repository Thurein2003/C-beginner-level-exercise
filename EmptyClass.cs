using System;

namespace calculator
{
    class Program
    {
        static int Main(string[]args)
            {
                Console.Write("enter a first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("enter a operator : ");
                string ope = Console.ReadLine();

                Console.Write("enter a second number : ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                if (ope == "+")
                {
                    Console.WriteLine(num1 + num2);
                }

                else if (ope == "-")
                {
                    Console.WriteLine(num1 - num2);
                }
                else if (ope == "*")
                {
                    Console.WriteLine(num1 * num2);
                }
                else
                {
                    Console.WriteLine("404 error");
                }
                Console.ReadLine();
            }
        }
    }
