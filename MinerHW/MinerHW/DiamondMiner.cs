using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerHW
{
    public class DiamondMiner
    {
        private string name;
        private string typeOfDiamond;
        private int totalNumber;

        public int TotalNumber
        {
            get { return totalNumber; }
            set
            {
                if (value < 100)
                {
                    throw new ArgumentOutOfRangeException("malko na broi");
                }
                totalNumber = value;
            }
        }


        public string TypeOfDiamond
        {
            get { return typeOfDiamond; }
            set { typeOfDiamond = value; }
        }


        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public DiamondMiner(string name, string typeOfDiamond, int totalNumber)
        {
            this.Name = name;
            this.TypeOfDiamond = typeOfDiamond;
            this.TotalNumber = totalNumber; 
        }

        public void Izhod()
        {
            Console.WriteLine($"ime - {this.name},tip - {this.typeOfDiamond},broika - {this.totalNumber}");
        }
    }
}
