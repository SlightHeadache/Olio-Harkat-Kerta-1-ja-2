using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int dump = 0;
            int buffer;
            for (;;)
            {
                Console.Write("Anna luku: ");
                buffer = int.Parse(Console.ReadLine());
                if (buffer == 0)
                    break;
                else
                    dump += buffer;
            }
            Console.WriteLine(dump);
        }
    }
}
