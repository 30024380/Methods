//Name: Logan Tawhiri
//Purpose: Learning to use parameters
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Ex_02
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("------------------------Method Parameters Example------------------------");
            Console.WriteLine("-------------------------------------------------------------------------");

            //Asks user for name
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine(Greeting(name));

            Console.WriteLine("\n***** User Input Variables *****");
            Console.Write("Please enter a number: ");
            int number3 = int.Parse(Console.ReadLine());
            Console.Write("Please enter another number: ");
            int number4 = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} + {1} = {2}", number3, number4, Calculate(number3, number4));
            Console.ReadLine();
        }
        //Returns the users name with hello
        static string Greeting(string name)
        {
            return "Hello " + name + ", this apps demo's the use of parameters. ";
        }               
        
        //Calculates the user input numbers
        static int Calculate(int num1, int num2)
        {
            int total = num1 + num2;
            return total;
        }
    }
}
