using System;

namespace excepting
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter a number : ");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter a second number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num / num2);

                Console.ReadLine();
            }
            catch (Exception e )
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
