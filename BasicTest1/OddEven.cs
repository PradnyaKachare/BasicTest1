using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicTest1
{
    class OddEven
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Enter a Number : ");
            i = int.Parse(Console.ReadLine());

            if (i % 2 == 0)
            {
                Console.WriteLine("Entered Number is an Even Number");
               
            }
            else
            {
                Console.WriteLine("Entered Number is an Odd Number");
                
            }
        }
    }
}
