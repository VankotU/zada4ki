using MVC_Type.Model;
using MVC_Type.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Type.Controller
{
    class TipController
    {
        private Tip tip = new Tip();
        private Display display = new Display();

        public TipController()
        {
            display.Input();
            tip.Amount=display.Amount;
            tip.Percent=display.Percent;
            display.TipAmount= tip.CalculateTip();
            display.TipAmount=tip.CalculateTotal();
            display.Output();
        }
    }
}
