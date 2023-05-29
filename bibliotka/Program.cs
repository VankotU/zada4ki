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
            //vuvedi broi chtateli
            //za tqh ime, nomer, br. posetiteli,

            /* Console.Write("Vuvedi broi - ");
             int a = int.Parse(Console.ReadLine());

             for(int i = 0; i < a; i++)
             {
                 Console.Write((i+1) + " ime - ");
                 string ime= Console.ReadLine();

                 Console.Write("nomer - ");
                 string nomer = Console.ReadLine();  

                 Console.Write((i+1)+". ime - "+ime);
                 Console.Write((i + 1) + ". nomer - "+nomer);
             }*/
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

                if (b < 1)
                {
                    Console.WriteLine("Nqma takuv den");
                }

                if (b == 2 || b == 3)
                {
                    Console.WriteLine("posetil si ili ponedelnik ili vtornik");

                    if (vreme[i] < 24.00)
                    {
                        Console.WriteLine("pnedelnik");
                    }

                    if (vreme[i] > 24.00)
                    {
                        Console.WriteLine("vtornik");
                    }
                }

                if (b == 1)
                {
                    Console.WriteLine("posetil si ponedelnik");
                }

                if (b == 4 || b == 5)
                {
                    Console.WriteLine("posetil si ili vtornik ili srqda");

                    if (vreme[i] < 24.00)
                    {
                        Console.WriteLine("vtornik");
                    }

                    if (vreme[i] > 24.00)
                    {
                        Console.WriteLine("srqda");
                    }
                }

                if (b == 0)
                {
                    Console.WriteLine("nqma takuv den");
                }

                if (b > 6)
                {
                    Console.WriteLine("bibliotkata ne raboti");
                }
                

            }

           
           
        }
    }
}
