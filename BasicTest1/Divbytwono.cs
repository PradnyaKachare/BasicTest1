using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicTest1
{
    class Divbytwono
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an number: ");

            int num=int.Parse(Console.ReadLine());

            
           
            if ((num % 5 == 0) && (num % 11 == 0))
            {
                Console.WriteLine ("%d is divisible by both 5 and 11");
            }
            else
            {
                Console.WriteLine("%d is Not divisible by both 5 and 11" );
            }
           
        }
    }
}
