using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo03
{
    class Program
    {
        static void Main(string[] args)
        {
            //create one Car instance
            Car car = new Car();
            car.Model = "Audi";
            car.Engine = 2.0;
            car.Color = "Silver";
            car.FuzzyDice = false;
            car.Speed = 150;
            car.PrintData();
            //Console.WriteLine("FuzzyDice = " + car.FuzzyDice);
            //Console.WriteLine("Model = " + car.Model);

            Car nascar = new Car("Dogecar");
            //Console.WriteLine("FuzzyDice = " + nascar.FuzzyDice);
            //Console.WriteLine("Model = " + nascar.Model);
            nascar.Speed = 200;
            nascar.Color = "Red";
            nascar.Engine = 6.1;
            nascar.FuzzyDice = true;
            nascar.PrintData();
            nascar.Accelerate(50);
            nascar.PrintData();

            Console.ReadLine();
        }
    }
}
