using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicTest1.Loop2
{
    /*5.	To find whether the given number is a Harshad number or not, calculate the sum of the digit of the number then,
           check whether the given number is divisible by the sum of its digit.If yes, then given number is a Harshad number.
           A number is said to be the Harshad number if it is divisible by the sum of  its digit
            For example, if number is 156, then sum of its digit will be 1 + 5 + 6 = . Since 156 is divisible by 12. 
             So, 156 is a Harshad number.
    		Some of the other examples of Harshad number are 8, 54, 120, etc.*/

    class Harshadno
    {
        static void Main(string[] args)
        {
            int num = 156;
            int rem = 0, sum = 0, n;

            //Make a copy of num and store it in variable n  
            n = num;

            //Calculates sum of digits  
            while (num > 0)
            {
                rem = num % 10;
                sum = sum + rem;
                num = num / 10;
            }

            //Checks whether number is divisible by sum of digits  
            if (n % sum == 0)
                Console.WriteLine(n + " is a harshad number");
            else
                Console.WriteLine(n + " is not a harshad number");
        }

    }
}
