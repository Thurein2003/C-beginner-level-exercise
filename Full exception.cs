using System;

namespace exception
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter a number : ");
                int num = Convert.ToInt32(Console.ReadLine());

                Console.Write( "Enter a second number : ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num / num2);
                
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}