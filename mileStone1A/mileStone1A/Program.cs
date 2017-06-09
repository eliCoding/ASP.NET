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

        static BankAccount b1 = new BankAccount();
        static Car c1 = new Car();
  


        static void Main(string[] args)
        {

            MainMenu();



        }

        public static void MainMenu()
        {
            Console.Clear();
            int choice = 0;

            while (true)
            {

                Console.WriteLine("=================================\n" + "Please Choose one of the Following:\n" +
                 "1: Bank Account\n" +
                 "2: Employee\n" +
                "3: Car\n" +
                 "0: Exit.\n" + "=====================\n");



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
                        BankMenu();

                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("*********** Employees ************");
                        Employee();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("*********** Car ***********");
                        Car();
                        break;

                    case 0:

                        Environment.Exit(0);

                        break;

                }
                Console.ReadLine();
            }

        }

        public static void BankTransaction(int i)
        {
            try
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
                    b1.Deposit(depositAmount);

                    Console.WriteLine("Your New balance is:" + b1.Balance);

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
                    b1.WithDraw(withDrawAmount);

                    Console.WriteLine("Your New balance is:" + b1.Balance);

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message, "");
            }


        }


        public static void BankMenu()
        {
            Console.Clear();

            int choice;

            while (true)
            {

                Console.WriteLine("Please Make Your Choice:\n" +

                    "1:Deposit\n" +
                    "2:WithDraw \n" +
                    "3:Bank Account balance \n"
                    +
                    "0: Main Menu");

                while (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine(" Error, Your Choice is not an integer. Please enter again");

                }
                Console.WriteLine("Your Choice is : " + choice);


                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        BankTransaction(1);
                        Console.WriteLine("Click on Enter To Continue.");


                        break;
                    case 2:


                        Console.Clear();
                        BankTransaction(2);
                        Console.WriteLine("Click on Enter To Continue.");

                        break;
                    case 3:

                        Console.Clear();
                        Console.WriteLine("Bank Acount Balance is:");
                        Console.WriteLine(b1.Balance);
                        Console.WriteLine("Click on Enter To Continue.");
                        break;

                    case 0:
                        MainMenu();


                        break;


                }
                Console.ReadLine();
            }


        }


        public static void Employee()
        {
            Console.Clear();
            Employee employee1 = new Employee();
            employee1.Name = "Susan Meyerr";
            employee1.IdNumber = 47899;
            employee1.Department = "Accounting";
            employee1.Position = "Vice President";
            Console.WriteLine(employee1.ToString());

            Employee employee2 = new Employee("Mark Jones", 39119, "IT", "Programmer");
            Console.WriteLine(employee2.ToString());

            Employee employee3 = new Employee("Joy Rogers", 81774);
            employee3.Department = "Manufacturing";
            employee3.Position = "Engineer";
            Console.WriteLine(employee3.ToString());
            Console.WriteLine("Click on Enter To Continue.");






        }

        public static void MakeCar()
        {
            int yearModel;
            string make;

            Console.WriteLine("Please Enter the Car Year Model: ");
            while (!int.TryParse(Console.ReadLine(), out yearModel))
            {
                Console.WriteLine(" Error, not a Integer number you entered . Please enter again");

            }


            Console.WriteLine("Please Enter the Car brand: ");
            make = Console.ReadLine();

            Console.WriteLine("Your Car  is : " + make + " " + yearModel);

        }
        public static void CarSpeed(int i)
        {

            try
            {
                if (i == 1)
                {
                    c1.Accelerate();
                    Console.WriteLine( "Your Speed:"+c1.Speed);
                }
                if (i == 2)
                {

                    c1.Brake();

                    Console.WriteLine( "Your Speed:"+c1.Speed);



                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message, "");
            }



        }


        private static void Car()
        {

            Console.Clear();

            int choice;

            while (true)
            {

                Console.WriteLine("Please Make Your Choice:\n" +
                     "1:Choose Your Car\n" +
                    "2:Accelerate\n" +
                    "3:Brake\n" +
                    "0: Main Menu");

                while (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine(" Error, Your Choice is not an integer. Please enter again");

                }
                Console.WriteLine("Your Choice is : " + choice);


                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        MakeCar();
                        break;
                    case 2:
                        Console.Clear();
                        CarSpeed(1);
                        Console.WriteLine("Click on Enter To Continue.");


                        break;
                    case 3:


                        Console.Clear();
                        CarSpeed(2);
                        Console.WriteLine("Click on Enter To Continue.");

                        break;

                    case 0:
                        MainMenu();


                        break;


                }
                Console.ReadLine();
            }

        }
    }
}
