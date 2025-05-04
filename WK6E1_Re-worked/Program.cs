using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using WK6E1_Re_worked;

namespace WK6E1_Re_worked
{
    internal class Program
    {
        //create the parent class
        class Vehicle

        {
            //variables
            public string Make { get; set; }
            public string Model { get; set; }
            public int Year { get; set; }
            public int MaxSpeed { get; set; }


            //method
            public virtual void DisplayInfo()
            {
                //print details for user to view
                Console.WriteLine("Make: " + Make);
                Console.WriteLine("Model: " + Model);
                Console.WriteLine("Year: " + Year);
                Console.WriteLine("Max Speed: " + MaxSpeed + "km/h");

            }
        }
        //child class
        class Car : Vehicle
        {
            public int NumberOfDoors { get; set; }
            public override void DisplayInfo() //override to display attributes
            {
                base.DisplayInfo(); //call to display
                Console.WriteLine("Number of doors: " + NumberOfDoors); //output
            }
        }
        //child class
        class Motorcycle : Vehicle
        {
            public bool HasSideCar { get; set; }
            public override void DisplayInfo() //override to display attributes
            {
                base.DisplayInfo(); //call base to display
                Console.WriteLine("Has sidecar: " + HasSideCar); //ouput
            }
        }



           

        static void Main(string[] args)
        {
            //car object
            Car car = new Car
            {
                Make = "Toyota",
                Model = "Camry",
                Year = 2024,
                MaxSpeed = 170,
                NumberOfDoors = 4
            };

            //motorcycle object
            Motorcycle motorcycle = new Motorcycle
            {
                Make = "Honda",
                Model = "Dio",
                Year = 2025,
                MaxSpeed = 83,
                HasSideCar = false
            };

            //output

            Console.WriteLine("Car Info: ");
            car.DisplayInfo();
            Console.WriteLine("Motorcycle Info: ");
            motorcycle.DisplayInfo();
        }
    }
}

        
    



