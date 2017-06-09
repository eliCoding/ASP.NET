using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace milestone1A
{
    class BankAccount
    {
        private decimal _balance;

        //
        public const decimal MIN = 0;
        public const decimal MAX = 10000;

        //A: default constructor for the class starting with $0 balance
        public BankAccount()
        {
            _balance = 0;

        }

        //B: Add a non-default constructor
        public BankAccount(decimal balance_)
        {
            //D.4.Constructors should call Properties for added input validation. 
            _balance = 0;
            Deposit(balance_);
            //balance_ =_balance;
        }

        //C:Use Properties  
        public decimal Balance
        {

            get
            {

                return _balance;

            }




        }

        //D.1: Do not accept negative values.
        //D.2: User cannot deposit $10000 or more in one transaction

        public bool Deposit(decimal amount)
        {
          
            if (amount <= MIN || amount >= MAX)
            {
                throw new ArgumentOutOfRangeException("amount", "The amount is out of range.");
            }
            else
            {
                _balance += amount;
                return true;
            }
        }

        public decimal withDraw(decimal amount)
        {

            if (amount <= MIN || amount >= MAX || amount > _balance)
            {
                throw new ArgumentOutOfRangeException("amount", "The amount is out of range.");
            }
            else
            {
                _balance -= amount;
                return amount;
            }
        }








    }



}
