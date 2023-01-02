using System;

namespace array
{
    class Program
    {
        static void Main(String[] args)
        {
            SayHi();
            
            Console.WriteLine(GetMax(20, 10));
            Console.ReadLine();
        }
        static void SayHi()
        {
            bool IsMale = false;
            bool IsTall = true;
            if (IsMale && IsTall)
            {
                Console.WriteLine("You are male and tall");
            }
            else if (IsMale && !IsTall)
            {
                Console.WriteLine("You are male but short");
            }
            else if (!IsMale && IsTall)
            {
                Console.WriteLine("you are not male but tall");
            }
            else {
                Console.WriteLine("not male and short or both");
            }
           
        }
        static int GetMax(int num1, int num2)
        {
            int result;
            if (num1 > num2)
            {
                result = num1;
            }
            else
            {
                result = num2;
            }
            return result;
        }

    }
}