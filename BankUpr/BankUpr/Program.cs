using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankUpr
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Type a number - ");
                int n = int.Parse(Console.ReadLine());

                List<BankAccount> bankAccounts = new List<BankAccount>();

                for (int i = 0; i < n; i++)
                {
                    var data = Console.ReadLine().Split();
                    BankAccount b1 = new BankAccount(data[0], data[1], int.Parse(data[2]), data[3], data[4], double.Parse(data[5]), data[6]);
                    bankAccounts.Add(b1);
                }

                foreach (var accs in bankAccounts)
                {
                    accs.Print();
                }

                bankAccounts.OrderByDescending(x => x.Balance).ToList().ForEach(y => Console.WriteLine($"{y.Balance}"));
            }

            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
