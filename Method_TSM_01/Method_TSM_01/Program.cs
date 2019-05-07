//Name: Logan Tawhiri
//Purpose: Changes the sign of the number from + to - or vice versa
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_TSM_01
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("---------------------------------------------------------------------------------------------------");
            Console.WriteLine("---------------------------------------Exercise 1--------------------------------------------------");
            Console.WriteLine("---------------------------------------------------------------------------------------------------");

            Console.WriteLine("This will return a number with the opposite sign i.e. (10 to -10)");
            Console.WriteLine("Enter a number");

            int num1 = int.Parse(Console.ReadLine());
            int total = ReturnNumber(num1);

            Console.WriteLine(total);
            Console.ReadLine();
        }
        static int ReturnNumber(int number1)
        {
            return number1 - number1 * 2;
        }        
    }
}
