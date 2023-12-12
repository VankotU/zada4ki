using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Type.View
{
    class Display
    {
        public double Amount { get; set; }
        public double Percent { get; set; }
        public object TipAmount { get; set; }
        public double Total { get; set; }

        public void Input()
        {
            Console.Write("Enter amount `");
            this.Amount = double.Parse(Console.ReadLine());

            Console.Write("Enter percent ");
            this.Percent = double.Parse(Console.ReadLine());
        }

        public void Output() 
        {
            Console.WriteLine($"Your tip is {TipAmount:C}");
            Console.WriteLine("____________________________");
            Console.WriteLine("The total will be : {0:C}",Total);
            Console.WriteLine("____________________________");
        }
    }
}
