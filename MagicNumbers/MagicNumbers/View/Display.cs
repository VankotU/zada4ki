using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicNumbers.View
{
    public class Display
    {
        public static int GetMagicNumberFromUser()
        {
            Console.WriteLine("Въведете число - ");
            return int.Parse(Console.ReadLine());
        }

        public static void DisplayMagicNumbers(List<int> magicNumbers)
        {
            Console.WriteLine("Магически числа: ");
            Console.WriteLine(string.Join(" ",magicNumbers));
        }
    }
}
