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
            int id;
            bool didItWork = false;
             //returns bool                     //out: is a refrence , ID must have  a value that is being sent, you need to send the value
            didItWork = int.TryParse(Console.ReadLine(), out id);

            if (didItWork == true)
            {
                Console.WriteLine("Id is : " + id);
            }
            else

            {
                Console.WriteLine("Error, Id is not an integer.");

            }
            Console.ReadLine();
        }
        // if this == to false >>>> not an integer  or try parse worked but the id is less than 0
    }
}
