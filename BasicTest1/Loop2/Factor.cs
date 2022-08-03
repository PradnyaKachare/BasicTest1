using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicTest1.Loop2
{
    //2.	Write a program to print all factors of given numbers
    class Factor
    {
        static void Main(string[] args)
        {
            int num, x;
            Console.WriteLine("Enter the Number ");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("The Factors are : ");
            for (x = 1; x <= num; x++)
            {
                if (num % x == 0)
                {
                    Console.WriteLine(x);
                }
            }
            Console.ReadLine();

        }
    }
}
