using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTermLabAssignment2
{
    abstract class Account
    {
        public int accountNo = 10000;
        public string accountName;
        public DateTime dob;
        public string address;
        public double balance;
        public int transactions;
        public string type;

        public Account(string accountName, DateTime dob, string address,double balance,string type)
        {
            this.accountNo = ++accountNo;
            this.accountName = accountName;
            this.dob = dob;
            this.address = address;
            this.balance = balance;
            this.transactions = 0;
            this.type = type;
        }

        public abstract void deposit(double amount);

        public abstract void withdraw(double amount);

        public void showDetails()
        {
            Console.WriteLine("Account No: " + this.accountNo);
            Console.WriteLine("Account Name: " + this.accountName);
            Console.WriteLine("Date of Birth: " + this.dob.ToShortDateString());
            Console.WriteLine("Address: " + this.address);
            Console.WriteLine("Starting Balance: " + this.balance);
            Console.WriteLine("Transactions: " + this.transactions);
            Console.WriteLine("Type: " + this.type);
        }
    }
}
