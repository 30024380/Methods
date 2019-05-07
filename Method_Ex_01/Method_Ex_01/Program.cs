//Name: Logan Tawhiri
//Purpose: Learning Methods
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Ex_01
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("------------------------Returning Method Example-------------------------");
            Console.WriteLine("-------------------------------------------------------------------------");

            //Declared variables.
            int num1 = 5;
            int num2 = 50;

            //Create a variable to hold what is being returned.
            int total = AddNumbers(num1, num2);
            Console.WriteLine("{0} + {1} = {2}", num1, num2, total);

            //Or we can use the returned result directly.
            Console.WriteLine("{0} + {1} = {2}", num1, num2, AddNumbers(num1, num2));
            Console.ReadLine();

            //These 2 blocks of code refer to the method twice
        }

        static int AddNumbers(int number1, int number2)
        {
            return number1 + number2;         
        }             
    }
}
