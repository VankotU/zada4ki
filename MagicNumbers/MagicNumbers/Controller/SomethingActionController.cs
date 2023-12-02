using MagicNumbers.Model;
using MagicNumbers.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicNumbers.Controller
{
    public class SomethingActionController
    {
        public void Run()
        {
            int magicNumber = Display.GetMagicNumberFromUser();
            List<int> magicNumbers = Something.FindMagicNumbers(magicNumber);

            Display.DisplayMagicNumbers(magicNumbers);
        }
    }
}
