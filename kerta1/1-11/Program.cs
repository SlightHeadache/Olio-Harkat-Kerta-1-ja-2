using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna luku: ");
            int r = int.Parse(Console.ReadLine());
            for (int i = r;i>0;i--)
            {
                for (int c = r - i;c >= 0;c--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
