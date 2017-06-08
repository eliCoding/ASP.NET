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

            BankAccount b1 = new BankAccount();
      
            int choice = 0;

            while (true)
            {

                Console.WriteLine("Please Make Your Choice:\n"+
                    "1:Bank Account balance \n"+
                    "2:Deposit\n"+
                    "3:WithDraw \n"+
                    "4: Exit.");


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
                        decimal deposit = 0;


                        while (!decimal.TryParse(Console.ReadLine(), out deposit))
                        {
                            Console.WriteLine(" Error, not an Appro. Please enter again");

                        }
                        Console.WriteLine("Your Choice is : " + choice);
                        Console.WriteLine("Deposited Money is:");

                     //   Console.WriteLine(b1.Deposit(theAmount));
                        break;
                    case 3:
                        Console.WriteLine("WithDraw:");
                        break;

                    case 4:
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
