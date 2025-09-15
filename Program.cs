using System.Numerics;

namespace CalculatorMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Calculator!");
            Console.WriteLine("Press 1 for Addition");
            Console.WriteLine("Press 2 for Subtraction");
            Console.WriteLine("Press 3 for Multiplication");
            Console.WriteLine("Press 4 for Division");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter first number:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Addition(num1, num2);
                    break;
                case 2:
                    Subtraction(num1, num2);
                    break;
                case 3:
                    Multiplication(num1, num2);
                    break;
                case 4:
                    Division(num1, num2);
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }

                    private static void Division(double num1, double num2)
        {
                      var sum = num1 / num2;
                      Console.WriteLine($"Division result: {sum} ");
        }
        

        private static void Multiplication(double num1, double num2)
        {
            var sum = num1 * num2;
            Console.WriteLine($"Multiplication result: {sum} ");
        }

        private static void Subtraction(double num1, double num2)
        {
            var sum = num1 - num2;
            Console.WriteLine($"Subtraction result: {sum} ");
        }

        private static void Addition(double num1, double num2)
        {
            var sum = num1 + num2;
            Console.WriteLine($"Addition sum: {sum} ");
        }
        }
    }

