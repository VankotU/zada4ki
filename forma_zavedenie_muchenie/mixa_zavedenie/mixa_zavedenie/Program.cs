using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace mixa_zavedenie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("kolko choveka ste?");
            int chovkea = int.Parse(Console.ReadLine());
            Console.WriteLine("masa za nepushachi ili pushachi?");
            string masa = Console.ReadLine();
            for (int i = 0; i < chovkea; i++)
            {
                Console.WriteLine("Poruchka na chovek: " + (i + 1));
                Console.WriteLine("Shte qdesh li salata?(da/ne)");
                string dane = Console.ReadLine();
                if (dane == "da")
                {
                    Console.WriteLine("shopska, turshiq ili mlechna?");
                    string salata = Console.ReadLine();
                    Console.WriteLine("kolko broq?");
                    int broi = int.Parse(Console.ReadLine());
                }


                Console.WriteLine("shte qdesh li osnovno?(da/ne)");
                string dane2 = Console.ReadLine();
                if (dane2 == "da")
                {
                    Console.WriteLine("agneshko, purjen kartof ili kebapche");
                    string osnovno = Console.ReadLine();
                    Console.WriteLine("kolko na broi?");
                    int broi2 = int.Parse(Console.ReadLine());

                }

                Console.WriteLine("shte qdesh li desert?(da/ne)");
                string deaznaa = Console.ReadLine();
                if (deaznaa == "da")
                {
                    Console.WriteLine("torta, sladoled ili krem karamel?");
                    string desert = Console.ReadLine();
                    Console.WriteLine("kolko na broi");
                    int broi3 = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Shte piesh li neshto?(da/ne)");
                string piinie = Console.ReadLine();
                if (piinie == "da")
                {
                    Console.WriteLine("alkohol, bezalkoholno ili toplo?");
                    string piinie2 = Console.ReadLine();
                    if (piinie2 == "alkohol")
                    {
                        Console.WriteLine("uiski, vodka ili menta?");
                        string alkohol = Console.ReadLine();
                        Console.WriteLine("kolko na broi?");
                        int broi4 = int.Parse(Console.ReadLine());


                    }
                    if (piinie2 == "bezalkohlno")
                    {
                        Console.WriteLine("fesh ili gazirana voda?");
                        string bezalkoholno = Console.ReadLine();
                        Console.WriteLine("kolko na broi?");
                        int broi5 = int.Parse(Console.ReadLine());

                    }
                    if (piinie2 == "toplo")
                    {
                        Console.WriteLine("kafe, chai ili greqna rakiq?");
                        string toplo = Console.ReadLine();
                        Console.WriteLine("kolko na broi?");
                        int broi6 = int.Parse(Console.ReadLine());

                    }
                }

            }




            Console.WriteLine("shte ima li drugo?(da/ne) ");
            string otgovor = Console.ReadLine();
            if (otgovor == "da")
            {
                Console.WriteLine("Shte qdesh li salata?(da/ne)");
                string dane = Console.ReadLine();
                if (dane == "da")
                {
                    Console.WriteLine("shopska, turshiq ili mlechna?");
                    string salata = Console.ReadLine();
                    Console.WriteLine("kolko broq?");
                    int broi = int.Parse(Console.ReadLine());
                }


                Console.WriteLine("shte qdesh li osnovno?(da/ne)");
                string dane2 = Console.ReadLine();
                if (dane2 == "da")
                {
                    Console.WriteLine("agneshko, purjen kartof ili kebapche");
                    string osnovno = Console.ReadLine();
                    Console.WriteLine("kolko na broi?");
                    int broi2 = int.Parse(Console.ReadLine());

                }

                Console.WriteLine("shte qdesh li desert?(da/ne)");
                string deaznaa = Console.ReadLine();
                if (deaznaa == "da")
                {
                    Console.WriteLine("torta, sladoled ili krem karamel?");
                    string desert = Console.ReadLine();
                    Console.WriteLine("kolko na broi");
                    int broi3 = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Shte piesh li neshto?(da/ne)");
                string piinie = Console.ReadLine();
                if (piinie == "da")
                {
                    Console.WriteLine("alkohol, bezalkoholno ili toplo?");
                    string piinie2 = Console.ReadLine();
                    if (piinie2 == "alkohol")
                    {
                        Console.WriteLine("uiski, vodka ili menta?");
                        string alkohol = Console.ReadLine();
                        Console.WriteLine("kolko na broi?");
                        int broi4 = int.Parse(Console.ReadLine());


                    }
                    if (piinie2 == "bezalkohlno")
                    {
                        Console.WriteLine("fesh ili gazirana voda?");
                        string bezalkoholno = Console.ReadLine();
                        Console.WriteLine("kolko na broi?");
                        int broi5 = int.Parse(Console.ReadLine());

                    }
                    if (piinie2 == "toplo")
                    {
                        Console.WriteLine("kafe, chai ili greqna rakiq?");
                        string toplo = Console.ReadLine();
                        Console.WriteLine("kolko na broi?");
                        int broi6 = int.Parse(Console.ReadLine());

                    }
                }

                Console.WriteLine("s kakvo shte platite?(cash/karta)");
                string plashtane = (Console.ReadLine());
                if (plashtane == "karta")
                {
                    Console.WriteLine("nomer na kartata: ");
                    decimal nomer = decimal.Parse(Console.ReadLine());
                    Console.WriteLine("validnost: ");
                    string validnost = Console.ReadLine();
                    Console.WriteLine("CVV: ");
                    int cvv = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}
