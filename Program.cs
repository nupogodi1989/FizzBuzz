using System;

namespace FizzBuzz
{
    class FizzBuzz
    {
        public int lowerBound = 1;
        private string rawLowerBound;
        public int upperBound = 100;
        private string rawUpperBound;
        public int customFizz = 3;
        private string rawCustomFizz;
        public int customBuzz = 5;
        private string rawCustomBuzz;
        private void ParseArgs()
        {
            this.lowerBound = Int32.Parse(this.rawLowerBound);
            this.upperBound = Int32.Parse(this.rawUpperBound);
            this.customFizz = Int32.Parse(this.rawCustomFizz);
            this.customBuzz = Int32.Parse(this.rawCustomBuzz);
        }
        private void CustomBoundQuestions()
        {
            System.Console.WriteLine("Enter lower bound:");
            this.rawLowerBound = System.Console.ReadLine();
            System.Console.WriteLine("Enter upper bound:");
            this.rawUpperBound = System.Console.ReadLine();
        }

        private void CustomFizzBuzzQuestions()
        {
            System.Console.WriteLine("Enter Fizz:");
            this.rawCustomFizz = System.Console.ReadLine();
            System.Console.WriteLine("Enter Buzz:");
            this.rawCustomBuzz = System.Console.ReadLine();
        }

        public void PromptUser()
        {
            this.CustomBoundQuestions();
            this.CustomFizzBuzzQuestions();
        }

        private void OutputResults()
        {
            this.ParseArgs();
            for (int i = this.lowerBound; i <= this.upperBound; i++)
            {
                if (i % this.customFizz == 0 && i % this.customBuzz == 0)
                {
                    System.Console.WriteLine("FizzBuzz");
                }
                else if (i % this.customFizz == 0)
                {
                    System.Console.WriteLine("Fizz");
                }
                else if (i % this.customFizz == 0)
                {
                    System.Console.WriteLine("Buzz");
                }
                else
                {
                    System.Console.WriteLine(i);
                }
            }
        }
        public void PrintResults()
        {
            this.ParseArgs();
            this.OutputResults();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            fizzBuzz.PromptUser();
            fizzBuzz.PrintResults();
        }
    }
}
