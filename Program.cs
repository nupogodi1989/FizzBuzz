using System;

namespace FizzBuzz
{
    class FizzBuzzInput
    {
        public void CustomerInput(int LowerBound, int UpperBound)
        {
            for (int i = LowerBound; i <= UpperBound; i++)
            {
                if (i % 3 ==0 && i % 5 == 0)
                {
                    System.Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    System.Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    System.Console.WriteLine("Buzz");
                }
                else
                {
                    System.Console.WriteLine(i);
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzzInput fizz = new FizzBuzzInput();
            fizz.CustomerInput(5, 16);
        }
    }
}
