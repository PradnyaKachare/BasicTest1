using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicTest1.Loops
{
    class Triomorphic
    {
        /*5) write a program to check given number is trimorphic number or not
               4 is trimorphic number as its cube(64) contains 4  at the end.
              5 is trimorphic number as its cube(625)contains 5 at the end.
*/

        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number:");
            int n = int.Parse(Console.ReadLine());

            int rem = n % 10;
            int cube = n * n * n;
            int cubeRem = cube % 10;
            if (rem == cubeRem)
            {
                Console.WriteLine("Entered number trimorphic ");
            }
            else
            {
                Console.WriteLine("Entered number not trimorphic ");
            }
        }
    }
}

