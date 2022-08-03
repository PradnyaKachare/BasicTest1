using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern
{
    class SpyNum
    {
       /* 4)write a  program to check given number is spy number or not
            e.g 123 if sum of digit is equals to product of digit the number is spy number
               i.e 123=1+2+3=6 and 1*2*3=6 so the number is spy number
*/
        static void Main(string[] args)
        {
            int n, sum = 0, mul = 1, r;
            Console.WriteLine("Enter the Number");
            n = int.Parse(Console.ReadLine());
                      
            while (n !=0)
            {
                r = n % 10;
                sum=sum+ r;
                mul =mul*r;
                n=n/10;

            }
            if (sum == mul)
                Console.WriteLine("This is Spy number");
            else
                Console.WriteLine("This is Not Spy number");
        }
    }
}
