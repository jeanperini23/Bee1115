using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Bee1115
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] C = Console.ReadLine().Split(' ');
            int c1 = int.Parse(C[0]);
            int c2 = int.Parse(C[1]);

            if (c1 > 0 && c2 > 0)
            {
                Console.WriteLine("primeiro");
            }
            else if (c1 < 0 && c2 > 0)
            {
                Console.WriteLine("segundo");
            }
            else if (c1 < 0 && c2 < 0)
            {
                Console.WriteLine("terceiro");
            }
            else if (c1 > 0 && c2 < 0)
            {
                Console.WriteLine("quarto");
            }

            while (c1 != 0 && c2 != 0){
                C = Console.ReadLine().Split(' ');
                c1 = int.Parse(C[0]);
                c2 = int.Parse(C[1]);

                if (c1 > 0 && c2 > 0)
                {
                    Console.WriteLine("primeiro");
                }
                else if (c1 < 0 && c2 > 0)
                {
                    Console.WriteLine("segundo");
                }
                else if (c1 < 0 && c2 < 0)
                {
                    Console.WriteLine("terceiro");
                }
                else if (c1 > 0 && c2 < 0)
                {
                    Console.WriteLine("quarto");
                }
            }


                
        }
    }
}
