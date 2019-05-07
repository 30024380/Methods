using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_TSM_02
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("---------------------------------------------------------------------------------------------------");
            Console.WriteLine("---------------------------------------Exercise 2--------------------------------------------------");
            Console.WriteLine("---------------------------------------------------------------------------------------------------");

            Console.WriteLine("Converts the distance in miles to kilometers and shows the original value");
            Console.WriteLine("Enter the distance");

            int num1 = int.Parse(Console.ReadLine());
            double total = Conversion(num1);

            Console.WriteLine("Original Value (In Miles): " + num1);
            Console.WriteLine("Result (In Kilometers) " + total);
            Console.ReadLine();
        }
        static double Conversion(int number1)
        {
            return number1 * 1.609;
        }        
    }
}
