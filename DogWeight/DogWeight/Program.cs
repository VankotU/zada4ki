using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogWeight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double>listDogKg = Console.ReadLine().Split().Select(double.Parse).ToList();
            listDogKg.Where(k=>k>30).OrderBy(k=>k).ToList().ForEach(k=>Console.Write($" {k}"));
            Console.WriteLine();
            Console.WriteLine($"Min kg = {listDogKg.Min()}");
            Console.WriteLine($"Max kg = {listDogKg.Max()}");

            int count = listDogKg.Count(k=>k<30&&k>2);
            Console.WriteLine($"Dogs between 30 and 2 - {count}");

            List<double>listDogKg2 = new List<double>();
            listDogKg2=listDogKg.Select(k=>k+10).ToList();
            Console.WriteLine(string.Join(" ",listDogKg2));
            List<double>list3 = new List<double>();
            list3=listDogKg2.OrderByDescending(x=>x).Take(3).ToList();

            //listDogKg2.OrderByDescending(x => x).Take(3).ToList().ForEach(x=>Console.Write($"{x}"));
            Console.WriteLine($"Sum kg = {list3.Sum()}");
            listDogKg = listDogKg.Concat(listDogKg2).ToList();
            listDogKg.Distinct().ToList().ForEach(k => Console.Write($" {k}"));

            listDogKg2.Where(k=>k%2!=0).OrderBy(k=>k).Skip(3).ToList().ForEach(k => Console.Write($" {k}"));
        }
    }
}
