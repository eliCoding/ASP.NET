using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace milestone1
{
    class BankAcount
    {
        private decimal _balance;

        //
        public const decimal MIN = 0;
        public const decimal MAX = 10000;

        //A: default constructor for the class starting with $0 balance
        public BankAcount() {
            _balance = 0;

        }

        //B: Add a non-default constructor
        public BankAcount(decimal balance_)
        {
            //D.4.Constructors should call Properties for added input validation. 
            _balance = 0;
            Deposit(balance_);
            //balance_ =_balance;
        }

        //C:Use Properties  
        public decimal Balance{

            get
            {
                
                return _balance;

            }




        }

        //D.1: Do not accept negative values.
        //D.2: User cannot deposit $10000 or more in one transaction
        //D.3: User cannot withdraw more money than they have
        public bool Deposit(decimal amount)
        {
            //D.5:	Properties/method throw errors when input is invalid. 
            if (amount <= MIN || amount >= MAX || amount > Balance)
            {
                throw new ArgumentOutOfRangeException("amount", "The amount is out of range.");
            }
            else
            {
                _balance += amount;
                return true;
            }
        }


        //F: creates an instance of a BankAccount and interact with all its methods. 
     

       
          

    }
   


}
