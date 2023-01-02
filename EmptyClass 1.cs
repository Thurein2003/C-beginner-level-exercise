using System;

namespace Method
{
    class Program
    {
        static void Main(string[]args)
        {
            SayHi("name", 34);
            SayHi("Mike",23);
            SayHi("john",34);
            SayHi("thurein",20);

            Console.ReadLine();
        }
        static void SayHi(string name,int age)
        {
            Console.WriteLine("Hello" + name + "You are "+ age);
        }
    }
}

