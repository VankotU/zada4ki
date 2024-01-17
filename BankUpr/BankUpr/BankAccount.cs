using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankUpr
{
    public class BankAccount:BankDetails
    {
        protected int number;
        protected string nameUser;
        protected string addressUser;
        protected double balance;
        protected string dateOfLastUsing;



        public int Number
        {
            get { return number; }
            set 
            {
                if (value > 9999)
                {
                    throw new ArgumentOutOfRangeException("Invalid code!");
                }
                number = value; 
            }
        }

        public string NameUser
        {
            get { return nameUser; }
            set { nameUser = value; }
        }

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public BankAccount(string name, string address, int number, string nameUser, string addressUser, double balance, string dateOfLastUsing) : base(name, address)
        {
            this.number = number;
            this.nameUser = nameUser;
            this.addressUser = addressUser;
            this.balance = balance;
            this.dateOfLastUsing = dateOfLastUsing;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Number of the bank account - {number}, Name of the user - {nameUser}, Address of the user - {addressUser}, Balance of the user - {balance}, Last time user checked out - {dateOfLastUsing}");
        }
    }
}
