using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace milestone1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test");

            // bool didItWork = false;

            //  while (int.TryParse(Console.ReadLine(), out id) == false)
            int id;
            const int MIN = 0;
            const int MAX = 9999;

            Console.WriteLine("#1 Please enter an Integer:");
            while (!int.TryParse(Console.ReadLine(), out id) || id < MIN || id > MAX)
            {
                Console.WriteLine("#1 Error, Id is not an integer. Please enter again");

            }
            Console.WriteLine("#1 Id is : " + id);
            Console.ReadLine();


            Console.WriteLine("#2 Please enter an Integer:");
            while (!int.TryParse(Console.ReadLine(), out id) || id < MIN || id > MAX)
            {
                Console.WriteLine("#2 Error, Id is not an integer. Please enter again");

            }
            Console.WriteLine("#2 Id is : " + id);

            Console.ReadLine();
            //returns bool                     //out: is a refrence , ID must have  a value that is being sent, you need to send the value
            //    didItWork = int.TryParse(Console.ReadLine(), out id);

            //    if (didItWork == true)
            //    {
            //        Console.WriteLine("Id is : " + id);
            //    }
            //    else

            //    {
            //        Console.WriteLine("Error, Id is not an integer.");

            //    }
            //    Console.ReadLine();
            //}
            // if this == to false >>>> not an integer  or try parse worked but the id is less than 0
        }
    }
}
