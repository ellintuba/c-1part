using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTermLabAssignment2
{
    class Savings:Account
    {
        public Savings(string name, DateTime dob, string address, double balance, string type)
            : base(name, dob, address, balance, type)
        {
            Console.WriteLine("Savings Account Created");
        }
        public override void deposit(double amount)
        {
            this.balance = this.balance + amount;
            this.transactions = this.transactions + 1;
        }
        public override void withdraw(double amount)
        {
            if (this.balance - amount <= 0)
            {
                Console.WriteLine("Cannot make balance 0 of savings account");
                return;
            }

            this.balance = this.balance - amount;
        }
    }
}
