using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int vnro, unro;
            Console.Write("Anna luku ");
            vnro = int.Parse(Console.ReadLine());
            for (int i = 0; i <= 1; i++)
            {
                Console.Write("Anna luku ");
                unro = int.Parse(Console.ReadLine());
                if (unro > vnro)
                    vnro = unro;
            }
            Console.WriteLine(vnro);
        }
    }
}