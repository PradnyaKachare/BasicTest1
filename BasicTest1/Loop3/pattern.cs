using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicTest1.Loop3
{                                        //6
    class pattern
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n ----------------------------------");

            //4.1

            for (int i = 1; i <= 5; i++)
            {

                for (int j = i; j >= 1; j--)
                {
                    Console.Write(j);
                }

                Console.WriteLine();
            }

            Console.WriteLine("\n ----------------------------------");

            //4.2


            for (int i = 1; i <= 5; i++)
            {
                for (int k = i; k < 5; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write (j % 2);
                }
                Console.WriteLine ();
            }

            Console.WriteLine("\n ----------------------------------");

        }
    }
}
