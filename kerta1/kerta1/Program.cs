using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kerta1
{
    class Program
    {
        static void Main(string[] args)
        {
            //7.02 l/100km
            //1.595 €/l
            //kysyy matkan
            Console.Write("Anna matka kilometreinä: ");
            float matka = float.Parse(Console.ReadLine());
            Console.Write("Bensaa kuluu " + (matka / 100) * 7.02 + " litraa, kustannus " + (matka / 100) * 7.02 * 1.595 + " euroa. ");
        }
    }
}
