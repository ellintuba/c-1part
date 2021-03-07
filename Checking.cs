using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTermLabAssignment2
{
    class Checking:Account
    {
        public Checking(string name, DateTime dob, string address, double balance, string type)
            : base(name, dob, address, balance, type)
        {
            Console.WriteLine("Checking Account Created");
        }
        public override void deposit(double amount)
        {
            this.balance = this.balance + amount;
            this.transactions = this.transactions + 1;
        }
        public override void withdraw(double amount)
        {
            if (this.balance - amount < 0)
            {
                Console.WriteLine("Cannot make balance less then 0 of checking account");
                return;
            }

            this.balance = this.balance - amount;

        }
    }
}