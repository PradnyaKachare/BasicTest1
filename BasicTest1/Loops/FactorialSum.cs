using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicTest1.Loops
{
    class FactorialSum
    {
        //15)1!+2!+3!+4!...n WAP a program to find sum

        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("Enter  number");
            int n1 = int.Parse(Console.ReadLine());
            for (int x = 1; x <= n1; x++)
            {
                int fact = 1;
             for(int i = x; i >= 1; i--)
                {
                    fact = fact * i;
                }
                sum = sum + fact;
            }
            Console.WriteLine("Sum of Factorial: "+sum);

        }
    }
}
