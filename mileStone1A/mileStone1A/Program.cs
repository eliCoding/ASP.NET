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

        static BankAccount b2 = new BankAccount();

        static void Main(string[] args)
        {
            int choice = 0;

            while (true)
            {

                Console.WriteLine("=================================\n" + "Please Choose one of the Following:\n" +
                 "1: Bank Account\n" +
                 "2: Employee\n" +
                "3: Car\n" +
                 "4: Exit.\n" + "================================\n");



                while (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine(" Error, Your Choice is not an integer. Please enter again");

                }
                Console.WriteLine("Your Choice is : (" + choice + ") Which is ===>");

                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("*********** Bank Acount ************");
                        bankMenu();

                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("*********** Employees ************");
                        employee();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("*********** Car ***********");
                        car();
                        break;

                    case 0:
                        Console.WriteLine("Exit");
                        break;

                }
                Console.ReadLine();
            }




        }

        public static void bankTransaction(int i)
        {

            if (i == 1)
            {
                decimal depositAmount;


                Console.WriteLine("Please Enter the Money that you want to deposit: ");
                while (!decimal.TryParse(Console.ReadLine(), out depositAmount))
                {
                    Console.WriteLine(" Error, not a decimal number you entered . Please enter again");

                }
                Console.WriteLine("Your Deposit amount is : " + depositAmount);
                b2.Deposit(depositAmount);

                Console.WriteLine("Your New balance is:" + b2.Balance);

            }
            if (i == 2)
            {
                decimal withDrawAmount;

                Console.WriteLine("Please Enter the Money that you want to withdraw: ");
                while (!decimal.TryParse(Console.ReadLine(), out withDrawAmount))
                {
                    Console.WriteLine(" Error, not a decimal number you entered . Please enter again");

                }
                Console.WriteLine("Your Withdraw amount is : " + withDrawAmount);
                b2.withDraw(withDrawAmount);

                Console.WriteLine("Your New balance is:" + b2.Balance);

            }


        }


        public static void bankMenu()
        {
            Console.Clear();

            int choice;

            while (true)
            {

                Console.WriteLine("Please Make Your Choice:\n" +
                    "1:Bank Account balance \n" +
                    "2:Deposit\n" +
                    "3:WithDraw \n" +
                    "0: Exit.");

                while (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine(" Error, Your Choice is not an integer. Please enter again");

                }
                Console.WriteLine("Your Choice is : " + choice);


                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Bank Acount Balance is:");
                        Console.WriteLine(b2.Balance);


                        break;
                    case 2:
                        Console.Clear();
                        bankTransaction(1);

                        break;
                    case 3:
                        Console.Clear();
                        bankTransaction(2);
                        break;

                    case 0:
                        Console.WriteLine("Exit");
                        break;


                }
                Console.ReadLine();
            }


        }

        public static void employee()
        {
            Employee employee1 = new Employee();
            employee1.Name = "Susan Meyerr";
            employee1.IdNumber = 47899;
            employee1.Department = "Accounting";
            employee1.Position = "Vice President";
            Console.WriteLine(employee1.ToString());

            Employee employee2 = new Employee("Mark Jones", 39119,"IT","Programmer");
            Console.WriteLine(employee2.ToString());






        }

        private static void car()
        {

        }
    }
}
