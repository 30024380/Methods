using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Name: Logan Tawhiri
//Purpose: Learning how to use classes
namespace Classes_Ex_01
{
    public class Program
    {
        public static void Main()
        {
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.WriteLine("-----------------------------------Exercise 1------------------------------------");
            Console.WriteLine("---------------------------------------------------------------------------------");

            Car car1 = new Car();
            car1.Make = "Toyota";
            car1.Model = "Corolla";
            car1.Colour = "Red";
            car1.Rego = "123qwe";

            Console.WriteLine("Car Make: {0}\nModel: {1}\nColour: {2}\nRego: {3}", car1.Make, car1.Model, car1.Colour, car1.Rego);
            Console.ReadLine();

            Car car2 = new Car();
            car2.Make = "Toyota";
            car2.Model = "Corolla";
            car2.Colour = "Red";
            car2.Rego = "123qwe";

            Console.WriteLine("Car Make: {0}\nModel: {1}\nColour: {2}\nRego: {3}", car2.Make, car2.Model, car2.Colour, car2.Rego);
            Console.ReadLine();

            Car car3 = new Car();
            car3.Make = "Toyota";
            car3.Model = "Corolla";
            car3.Colour = "Red";
            car3.Rego = "123qwe";

            Console.WriteLine("Car Make: {0}\nModel: {1}\nColour: {2}\nRego: {3}", car3.Make, car3.Model, car3.Colour, car1.Rego);
            Console.ReadLine();

            Car car4 = new Car();
            car4.Make = "Toyota";
            car4.Model = "Corolla";
            car4.Colour = "Red";
            car4.Rego = "123qwe";

            Console.WriteLine("Car Make: {0}\nModel: {1}\nColour: {2}\nRego: {3}", car4.Make, car4.Model, car4.Colour, car4.Rego);
            Console.ReadLine();

            Car car5 = new Car();
            car5.Make = "Toyota";
            car5.Model = "Corolla";
            car5.Colour = "Red";
            car5.Rego = "123qwe";

            Console.WriteLine("Car Make: {0}\nModel: {1}\nColour: {2}\nRego: {3}", car5.Make, car5.Model, car5.Colour, car5.Rego);
            Console.ReadLine();
        }
    }
    class Car
    {
        private string make;
        private string model;
        private string colour;
        private string rego;

        //Getters & Setters.
        public string Make {get { return make; } set { make = value; }}

        public string Model {get { return model; } set { model = value; }}

        public string Colour {get { return colour; } set { colour = value; }}

        public string Rego {get { return rego; } set { rego = value; }}
    }
}
