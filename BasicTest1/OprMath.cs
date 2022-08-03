using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicTest1
{
    class OprMath
    {
        static void Main(string[] args)
        {
            int a = 5;int b = 4; int c = 3;

            Console.WriteLine(a++ + b * ++c);
            Console.WriteLine("a = " + a + " b= " + b + " c = " + c);
            Console.WriteLine(b * 5 / a + b++ + b);
            Console.WriteLine("a = " + a + " b= " + b + " c = " + c);
        }

    }
}

