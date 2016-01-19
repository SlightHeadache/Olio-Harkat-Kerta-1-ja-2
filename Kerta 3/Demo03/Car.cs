using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo03
{
    class Car
    {
        //field member

        //properties
        public string Model { get; set; }
        public string Color { get; set; }
        public double Engine { get; set; }
        public int Speed { get; set; }
        public bool FuzzyDice { get; set; }

        //constructor
        public Car()
        {
            FuzzyDice = true;
        }

        //parametric constructor
        public Car(string model)
        {
            Model = model;
        }

        //method displays car data
        public void PrintData()
        {
            Console.WriteLine("Car data: ");
            Console.WriteLine("- model: " + Model);
            Console.WriteLine("- color: " + Color);
            Console.WriteLine("- engine: " + Engine);
            Console.WriteLine("- speed: " + Speed);
            Console.WriteLine("- fuzzy dice: " + FuzzyDice);
        }

        // method increases speed
        public void Accelerate(int newSpeed)
        {
            Speed += newSpeed;
        }
    }
}
