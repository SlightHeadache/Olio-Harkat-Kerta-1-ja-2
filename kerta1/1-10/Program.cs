using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] taulu = new int[9];
            taulu[0] = 1;
            taulu[1] = 2;
            taulu[2] = 33;
            taulu[3] = 44;
            taulu[4] = 55;
            taulu[5] = 68;
            taulu[6] = 77;
            taulu[7] = 96;
            taulu[8] = 100;
            for (int i = 0; i <= 8; i++)
            {
                if (taulu[i] % 2 == 0)
                    Console.WriteLine("HEP");
                else
                    Console.WriteLine();
            }
        }
    }
}
