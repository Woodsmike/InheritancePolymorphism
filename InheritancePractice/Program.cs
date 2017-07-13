using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //inheritance and polymorphism
            //many forms of methods in a class can have different meanings
            //for different objects using inheritance
            //Inheritance
            Boat boat1 = new Boat(2,500,"white and yellow",70.0d,.78d);
            boat1.Move();
            boat1.Move();
            Console.WriteLine("Boat " + boat1.GetDistanceTraveled());

            Automobile car1 = new Automobile(4, 20, 4, 5, 5000, "red", 260);
            car1.Move();

            car1.Color = "gold";
            Console.WriteLine("Automobile " + car1.GetDistanceTraveled());

            Aircraft learJet = new Aircraft(20, 100000, "purple", 600);
            learJet.Move();
            learJet.Move();
            Console.WriteLine("Aircraft " + learJet.GetDistanceTraveled());

        }
    }
}
