using milestone1A;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mileStone1A
{
    class Program
    {



        static void Main(string[] args)
        {
            int choice = 0;
         
            while (true)
            {

                Console.WriteLine("=================================\n"+"Please Choose one of the Following:\n"+
                 "1: Bank Account\n"+
                 "2: Employee\n"+
                "3: Car\n"+
                 "4: Exit.\n" + "================================\n");



                while (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine(" Error, Your Choice is not an integer. Please enter again");

                }
                Console.WriteLine("Your Choice is : ("+ choice +") Which is ===>");

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("*********** Bank Acount ************" );
                        q1();
                      
                        break;
                    case 2:

                        Console.WriteLine("Emlpyees");                    
                        break;
                    case 3:
                        Console.WriteLine("Car");
                        break;

                    case 0:
                        Console.WriteLine("Exit");
                        break;



                        //    default:
                        //  Console.WriteLine("");

                }
                Console.ReadLine();
            }




        }
        public static void q1()
        {

           
      
            int choice = 0;
            decimal deposit = 0;
            decimal withDraw = 0;

            BankAccount b1 = new BankAccount();

            BankAccount b2 = new BankAccount(deposit);

            while (true)
            {

                Console.WriteLine("Please Make Your Choice:\n"+
                    "1:Bank Account balance \n"+
                    "2:Deposit\n"+
                    "3:WithDraw \n"+
                    "0: Exit.");


                while (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine(" Error, Your Choice is not an integer. Please enter again");

                }
                Console.WriteLine("Your Choice is : " + choice);


                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Bank Acount Balance is:");

                        Console.WriteLine(b1.Balance);



                        break;
                    case 2:
                      

                        Console.WriteLine("Please Enter the Money that you want to deposit: ");
                        while (!decimal.TryParse(Console.ReadLine(), out deposit))
                        {
                            Console.WriteLine(" Error, not a decimal number you entered . Please enter again");

                        }
                        Console.WriteLine("Your Deposit amount is : " + deposit);

                      
                        Console.WriteLine("Your New balance is:" + b2.Balance);
                        break;
                    case 3:
                       

                        Console.WriteLine("Please Enter the Money that you want to withdraw: ");
                        while (!decimal.TryParse(Console.ReadLine(), out withDraw))
                        {
                            Console.WriteLine(" Error, not a decimal number you entered . Please enter again");

                        }
                        Console.WriteLine("Your Withdraw amount is : " + withDraw);

                       
                        Console.WriteLine("Your New balance is:" + b2.Balance);

                        break;

                    case 0:
                        Console.WriteLine("Exit");
                        break;



                        //    default:
                        //  Console.WriteLine("");

                }
                Console.ReadLine();
            }


        }
    }
}
