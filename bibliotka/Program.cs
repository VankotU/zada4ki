using System;
using System.Collections.Generic;
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

            for(int i=0; i<n; i++)
            {
                Console.Write("vuvedi ime - ");
                ime[i] = Console.ReadLine();

                Console.Write("vuvedi nomer - ");
                nomer[i] = Console.ReadLine();

                Console.WriteLine((i + 1) + ". ime - " + ime[i]);
                Console.WriteLine((i + 1) + ". nomer - " + nomer[i]);
            }

            for (int i = 0; i < n; i++)
            {
                string a = nomer[i].Remove(1, 5);
                if(a == "2"|| a == "3")
                {
                    Console.WriteLine("posetil si ili ponedelnik ili vtornik");
                }

                if (a == "1")
                {
                    Console.WriteLine("posetil si ponedelnik");
                }

                if (a == "4" || a == "5")
                {
                    Console.WriteLine("posetil si ili vtornik ili srqda");
                }

                if (a == "0")
                {
                    Console.WriteLine("nqma takuv den");
                }

                if (a == "6" || a == "7")
                {
                    Console.WriteLine("posetil si ili chetvurtuk ili petuk");
                }

                if (a == "8" || a == "9")
                {
                    Console.WriteLine("posetil si ili subota ili nedelq");
                }

            }

           
           
        }
    }
}
