using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int vuosi;
            Console.Write("Anna vuosiluku: ");
            bool cs = int.TryParse(Console.ReadLine(), out vuosi);
            if (cs)
            {
                if (vuosi % 100 == 0)
                {
                    if (vuosi % 400 == 0)
                        Console.WriteLine("Vuosi " + vuosi + " on karkausvuosi. ");
                    else
                        Console.WriteLine("Vuosi " + vuosi + " ei ole karkausvuosi. ");
                }
                else if (vuosi % 4 == 0)
                    Console.WriteLine("Vuosi " + vuosi + " on karkausvuosi. ");
                else
                    Console.WriteLine("Vuosi " + vuosi + " ei ole karkausvuosi. ");
            }
        }
    }
}
