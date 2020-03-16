using System;

namespace FizzBuzz
{
    class FizzBuzzInput
    {
        public void CustomerInput(int LowerBound, int UpperBound, int Fizz, int Buzz)
        {
            for (int i = LowerBound; i <= UpperBound; i++)
            {
                if (i % Fizz == 0 && i % Buzz == 0)
                {
                    System.Console.WriteLine("FizzBuzz");
                }
                else if (i % Fizz == 0)
                {
                    System.Console.WriteLine("Fizz");
                }
                else if (i % Buzz == 0)
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
            FizzBuzzInput input = new FizzBuzzInput();
            System.Console.WriteLine("Enter lower bound:");
            var lowerBound = System.Console.ReadLine();
            System.Console.WriteLine("Enter upper bound:");
            var upperBound = System.Console.ReadLine();
            System.Console.WriteLine("Enter Fizz:");
            var fizz = System.Console.ReadLine();
            System.Console.WriteLine("Enter Buzz:");
            var buzz = System.Console.ReadLine();
            input.CustomerInput(Int32.Parse(lowerBound), Int32.Parse(upperBound),
                                Int32.Parse(fizz), Int32.Parse(buzz));
        }
    }
}
