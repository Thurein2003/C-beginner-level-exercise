using System;

namespace user
{
    class Program
    {
        static void Main(string [] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("enter your age: ");
            string age = Console.ReadLine();
            Console.WriteLine("Hello" + name + "enter your age" + age);

            Console.ReadLine();
        }
    }
}
