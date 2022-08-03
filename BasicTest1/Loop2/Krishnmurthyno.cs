using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicTest1.Loop2
{
   /* 8.	Write a code to check given number is Krishnamurthy number or not
                   e.g 145=  1!+4!+5!
	                         1+24+120
	            145  the original number get back is known as Krishnamurthy.*/


    class Krishnmurthyno
    {
        static int factorial(int n)
        {
            int fact = 1;

            while (n != 0)
            {
                fact = fact * n;
                n--;
            }

            return fact;
        }

        // function to Check if number is krishnamurthy

        static bool isKrishnamurthy(int n)
        {
            int sum = 0;

            int temp = n;
            while (temp != 0)
            {

                // calculate factorial of  last digit of temp and  add it to sum

                sum=sum + factorial(temp % 10);

                // replace value of temp by temp/10

                temp = temp / 10;
            }

            // Check if number is krishnamurthy
            return (sum == n);
        }

        // Driver code
        public static void Main()
        {
            int n = 145;
            if (isKrishnamurthy(n))
                Console.Write("YES");
            else
                Console.Write("NO");
        }
    }
}
