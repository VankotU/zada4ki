using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseLambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            numbers.Where(n=>n>0).OrderBy(n=>n).ToList().ForEach(x => Console.Write(x));
            Console.WriteLine();    

            List<int> numbers2 = new List<int>();
            numbers2 = numbers.Where(n=>n%2!=0).Take(3).ToList();
            Console.WriteLine(String.Join(" ",numbers2));*/

            List<int> number1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            number1.Where(n => n % 3 == 0).OrderByDescending(n=>n).ToList().ForEach(x=>Console.WriteLine(x));

            /*List<int> number2 = new List<int>();
            int v = number1.Min();
            number2 = v;*/

            Console.WriteLine("Min: ",number1.Min());
            Console.WriteLine("Max: ",number1.Max());
            Console.WriteLine("Sum: ",number1.Sum());
        }
    }
}
