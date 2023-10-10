using System;

namespace CalculatorExample
{
    public class Calculator
    {
        /*public double Sum(double x, double y)
        {
            return x + y;
        }

        public double Subtract(double x, double number2)
        {
            return x - number2;
        }

        public double Multiply(double x, double y)
        {
            return x * y;
        }

        public double Divide(double x, double y)
        {
            //do not divide by 0!
            return x / y;
        }*/

        public double Sum(int x, int y)
        {
            return (x + y);
        }

        public double Subtract(int x, int y)
        {
            return (x - y);
        }

        public double Multiply(int x, int y)
        {
            return (x * y);
        }

        public double Divide(int x, int y)
        {
            if(y==0)
            {
                throw new DivideByZeroException("Delene na 0!!! ");
            }
            return (double)x / y; 
        }

        public long Factorial(int x)
        {
            long result = 1;
            for (int i = 2; i <= x; i++)
            {
                result = result * i; //result *= i;
            }

            return result; 
            
        }

        public double Power(int baseNumber, int power)
        {
            if(power==0)
            {
                return 1;
            }

            double result = baseNumber;
            if(power>0)
            {
                for (int i = 1; i < power; i++)
                {
                    result = result * baseNumber;
                }

                return result;
            }

            else 
            {
                power *= -1;
                for (int i = 1; i < power; i++)
                {
                    result = result * baseNumber;
                }
                return 1 / result;
            }
        }
        /*public double Power(double baseNumber, int power)
        {
            //!Степенуването с отрицателни числа не работи!
            double result = 1;
            for (int i = 1; i <= power; i++)
            {
                result = result * baseNumber; //result *= baseNumber;
            }

            return result;
        }*/
    }
}