using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicTest1.Loop2
{
    class Fibbo
    {
        //4.4.	WAP to print fibbo series upto 20 terms

        static void Main(string[] args)
        {
            int x, y = 0, z = 1;

            Console.WriteLine("Fibonaci Series: ");

            for (x = 0; x <= 20; x++)
            {
                Console.WriteLine(y);
                int temp = z + y;
                y = z;
                z = temp;
            }
        }
    }
}

