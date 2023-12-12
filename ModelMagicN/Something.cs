using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelMagicN
{
    public class Something
    {
        private int num1;
        private int num2;
        private int num3;
        private int num4;
        private int num5;
        private int num6;

        public int Num1
        {
            get { return num1; }
            set
            {
                if (value < 1 && value > 9)
                {
                    throw new ArgumentException("nope");
                }
                num1 = value;
            }
        }


        public int Num2
        {
            get { return num2; }
            set
            {
                if (value < 0 && value > 9)
                {
                    throw new ArgumentException("nope");
                }

                num2 = value;
            }
        }


        public int Num3
        {
            get { return num3; }
            set
            {
                if (value < 0 && value > 9)
                {
                    throw new ArgumentException("nope");
                }

                num3 = value;
            }
        }


        public int Num4
        {
            get { return num4; }
            set
            {
                if (value < 0 && value > 9)
                {
                    throw new ArgumentException("nope");
                }

                num4 = value;
            }
        }


        public int Num5
        {
            get { return num5; }
            set
            {
                if (value < 0 && value > 9)
                {
                    throw new ArgumentException("nope");
                }

                num5 = value;
            }
        }


        public int Num6
        {
            get { return num6; }
            set
            {
                if (value < 0 && value > 9)
                {
                    throw new ArgumentException("nope");
                }

                num6 = value;
            }
        }

        public Something(int num1, int num2, int num3, int num4, int num5, int num6)
        {
            this.Num1 = num1;
            this.Num2 = num2;
            this.Num3 = num3;
            this.Num4 = num4;
            this.Num5 = num5;
            this.Num6 = num6;
        }

        public static int MagicNumber(int num1, int num2, int num3, int num4, int num5, int num6)
        {
            return num1 * num2 * num3 * num4 * num5 * num6;
        }

        public static int CalculateMagicNumber(int num1, int num2, int num3, int num4, int num5, int num6)
        {
            return num1 * 100000 + num2 * 10000 + num3 * 1000 + num4 * 100 + num5 * 10 + num6;
        }
    }
}
    

		
	

	

