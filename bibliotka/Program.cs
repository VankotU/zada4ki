using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliotka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("vuvedi broi - ");
            int n = int.Parse(Console.ReadLine());
            

            string[]ime=new string[n];

            string[]nomer=new string[n];

            double[]vreme=new double[n];

            for(int i=0; i<n; i++)
            {
                Console.Write("vuvedi ime - ");
                ime[i] = Console.ReadLine();

                Console.Write("vuvedi nomer - ");
                nomer[i] = Console.ReadLine();

                Console.Write("vuvedi vreme - ");
                vreme[i] = double.Parse(Console.ReadLine());

                Console.WriteLine((i + 1) + ". ime - " + ime[i]);
                Console.WriteLine((i + 1) + ". nomer - " + nomer[i]);
                Console.WriteLine((i + 1) + ". vreme - " + vreme[i]);
            }

            for (int i = 0; i < n; i++)
            {
                string a = nomer[i].Remove(1, 5);
                int b = int.Parse(a);

                if (b == 0)
                {
                    Console.WriteLine("nqma takuv den");
                }

                if (b == 1)
                {
                    Console.WriteLine("posetil si ponedelnik");

                    if (b < 1)
                    {
                        Console.WriteLine("Nqma takuv den");
                    }
                }

                if (b == 2 || b == 3)
                {
                    Console.WriteLine("posetil si ili vtornik ili srqda");

                    if (vreme[i] < 24.00)
                    {
                        Console.WriteLine("vtornik");
                    }

                    else
                    {
                        Console.WriteLine("srqda");
                    }
                }

                if (b == 4 || b == 5)
                {
                    Console.WriteLine("posetil si ili chetvurtuk ili petuk");

                    if (vreme[i] < 24.00)
                    {
                        Console.WriteLine("chetvurtuk");
                    }

                    else
                    {
                        Console.WriteLine("petuk");
                    }
                }

                if (b > 6)
                {
                    Console.WriteLine("bibliotkata ne raboti");
                }
                
              


            }

           
           
        }
    }
}
