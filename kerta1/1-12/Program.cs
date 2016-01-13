using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] taul = new int[5];
            for(int i = 4;i >= 0; i--)
            {
                Console.Write("Anna luku: ");
                taul[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Luvut ovat ");
            for (int i = 0; i <= 4; i++)
            {
                Console.Write(taul[i]);
                if (i == 4)
                {
                    Console.Write(".");
                    Console.WriteLine();
                }
                else
                    Console.Write(", ");
            }
        }
    }
}
