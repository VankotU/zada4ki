using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizationExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvedi broi hora - ");
            int count = int.Parse(Console.ReadLine());

            Console.WriteLine("Vuvedi danni za choveka - ");
            List<Person> list = new List<Person>();

            for (int i = 0; i < count; i++)
            {
                var data = Console.ReadLine().Split();
                Person persons = new Person(data[0], data[1], data[2], int.Parse(data[3]), data[4], data[5], data[6], data[7]);
                list.Add(persons);
            }

            foreach (var person in list) 
            {
                person.Print();
            }
        }
    }
}
