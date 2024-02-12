using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurePoliMorph
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Type in number - 1 for Rectangle, number - 2 for Circle and number - 3 for Trapezium");
                int number = int.Parse(Console.ReadLine());
                switch (number)
                {
                    case 1:
                        {
                            Shape rectangle = new Rectangle(5, 7);
                            Console.WriteLine($"P={rectangle.CalculatePerimeter():f2}");
                            Console.WriteLine($"S={rectangle.CalculateArea():f2}");
                            Console.WriteLine(rectangle.Draw());
                        }
                        break;
                    case 2:
                        {
                            Shape circle = new Circle(2);
                            Console.WriteLine($"P={circle.CalculatePerimeter():f2}");
                            Console.WriteLine($"S={circle.CalculateArea():f2}");
                            Console.WriteLine(circle.Draw());
                        }
                        break;
                    case 3:
                        {
                            Shape trapezium = new Trapezium(4,5,6);
                            Console.WriteLine($"P={trapezium.CalculatePerimeter():f2}");
                            Console.WriteLine($"S={trapezium.CalculateArea():f2}");
                            Console.WriteLine(trapezium.Draw());
                        }
                        break;
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
