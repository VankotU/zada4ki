using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.Write("Въведи число 1:");
            double number1 = double.Parse(Console.ReadLine());

            Console.Write("Въведи число 2:");
            double number2 = double.Parse(Console.ReadLine());*/

            int number1 = 0;
            int number2 = 0;

            try 
            {
                number1 = int.Parse(Console.ReadLine());
                number2 = int.Parse(Console.ReadLine());
            }

            catch(FormatException e)
            {
                Console.WriteLine("Pishesh bukvi!! "+e.Message);
            }

            catch(Exception gosho)
            {
                Console.WriteLine("NESHTO DRUGO... "+gosho.Message);
            }

            Calculator elka11a = new Calculator();
            double result = 0;

            result = elka11a.Sum(number2, number1);
            Console.WriteLine($"{number1} + {number2} = {result}");

            result = elka11a.Subtract(number1, number2);
            Console.WriteLine($"{number1} - {number2} = {result}");

            result = elka11a.Multiply(number1, number2);
            Console.WriteLine($"{number1} * {number2} = {result}");

            result = elka11a.Divide(number1, number2);
            Console.WriteLine($"{number1} / {number2} = {result}");

            result = elka11a.Factorial((int)number1);
            Console.WriteLine($"{number1}! = {result}");

            result = elka11a.Power(number1, (int)number2);
            Console.WriteLine($"{number1} ^ {(int)number2} = {result}");

            try
            {
                result = elka11a.Divide(number1,number2);
            }

            catch(DivideByZeroException)
            {
                Console.WriteLine("Delene na 0 ot Program!!!");
            }

            result=elka11a.Power(number1,number2);
            Console.WriteLine($"{number1} na stepen {number2} = {result}");
        }
    }
}
