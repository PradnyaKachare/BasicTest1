using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//     1.Write a program to print all numbers between 1 and 100 except the numbers which are divisible by 5or 10


namespace BasicTest1.Loop2
{
    class Divby5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Divided by 5 & 10: ");
            for (int i = 1; i <= 100; i++)
            {
                if (i % 5 == 0 && i % 10 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }



    }
}
