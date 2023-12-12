using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelMagicN
{
    public class Display
    {
        public static int GetMagicNumberFromUser()
        {
            Console.WriteLine("Въведете число - ");
            return int.Parse(Console.ReadLine());
        }

        public static void DisplayMagicNumbers(Something.CalculateMagicNumber())
        {
            Console.WriteLine("Магически числа: ");
            Console.WriteLine(string.Join(" ", ));
        }
    }
}
