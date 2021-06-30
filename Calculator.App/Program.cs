using System;

namespace Calculator.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the simple calculator");
            Console.WriteLine("Press Q to Exit or Any Key to Continue");
            string toContinue = Console.ReadLine();

            while (toContinue!="Q")
            {
                Console.WriteLine("Enter First Number:");
                string firstNumber = Console.ReadLine();

                Console.WriteLine("Enter Second Number:");
                string secondNumber = Console.ReadLine();

                Console.WriteLine("Enter The Operator:");
                string operatorSign = Console.ReadLine();

                var calculator = new CalculatorFactory();
                var outputNumber = calculator.Calculate(operatorSign, decimal.Parse(firstNumber), decimal.Parse(secondNumber));

                Console.WriteLine($"Output Number {outputNumber}");

                Console.WriteLine("Press Q to Exit or Any Key to Continue");
                toContinue = Console.ReadLine();
            }

        }
    }
}
