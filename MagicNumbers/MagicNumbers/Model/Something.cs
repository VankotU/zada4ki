using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicNumbers.Model
{
    public class Something
    {
        public static List<int> FindMagicNumbers(int magicNumber)
        {
            List<int> result = new List<int>();

            for (int number1 = 1; number1 <= 9; number1++)
            {
                for (int number2 = 0; number2 <= 9; number2++)
                {
                    for (int number3 = 0; number3 <= 9; number3++)
                    {
                        for (int number4 = 0; number4 <= 9; number4++)
                        {
                            for (int number5 = 0; number5 <= 9; number5++)
                            {
                                for (int number6 = 0; number6 <= 9; number6++)
                                {
                                    if (number1 * number2 * number3 * number4 * number5 * number6 == magicNumber)
                                    {
                                        int resultNumber = number1 * 100000 + number2 * 10000 + number3 * 1000 + number4 * 100 + number5 * 10 + number6;
                                        result.Add(resultNumber);
                                    }
                                }
                            }
                        }
                    }
                }
            }

            return result;

        }
    }
}
