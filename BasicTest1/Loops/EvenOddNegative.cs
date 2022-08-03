using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicTest1.Loops
{
    class EvenOddNegative
    {
        //12) WAP to print number from 1 to 50 if number is even then print as it is and
        //number is odd then print negative number with its square

        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int n1 = int.Parse(Console.ReadLine());

            for (int x = 1; x <= n1; x++)
            {
                if(x %2 == 0)
                {
                    Console.WriteLine(x);
                }
                else
                {
                    Console.WriteLine("negative odd number: "+-x+" saqure: "+(x)*(x));
                }
            }
        }
    }
}
