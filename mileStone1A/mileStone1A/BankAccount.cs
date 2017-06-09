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

       
        public BankAccount()
        {
            _balance = 0;

        }

      
        public BankAccount(decimal balance_)
        {
            
            _balance = 0;
            Deposit(balance_);
            //balance_ =_balance;
        }

       
        public decimal Balance
        {

            get
            {

                return _balance;

            }




        }

        

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

        public bool WithDraw(decimal amount)
        {

            if (amount <= MIN)
            {
                throw new ArgumentOutOfRangeException("amount", "Withdraw amount is out of range");
            }

            if (amount >= _balance)
            {
                throw new ArgumentOutOfRangeException("amount", "Insufficient amount, the amount cannot be negative .");
            }

            else
            {
                _balance -= amount;
                return true;
            }
        }








    }



}
