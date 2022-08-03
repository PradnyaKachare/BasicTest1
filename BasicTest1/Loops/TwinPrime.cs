using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicTest1.Loops
{
    class TwinPrime
    {
        //10 Write a program to find twin prime number. (Accept two no from user and check,
        //if both are prime and their difference is 2 then they
          //are twin prime). 

        static void Main(string[] args)
        {
            int i, n1,n2, prime = 0;

            Console.WriteLine("Enter first number");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number");
            n2 = int.Parse(Console.ReadLine());

            for (i = 1; i <= n1; i++)
            {
                if (n1 % i == 0)
                {
                    prime++;
                }
            }

            for (i = 1; i <= n2; i++)
            {
                if (n2 % i == 0)
                {
                    prime++;
                }
            }

            if (prime==4 && (n2-n1)==2)
                {
                Console.WriteLine("Entered number is twin prime");
                }
            else 
            {
                Console.WriteLine("Entered number is Not prime");
            }
            
        }
    }
}
