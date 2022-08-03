using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicTest1.Loop3
{
    class Kaprekarno
    {
        /*3.	A Kaprekar number is a number whose square when divided into two parts and such that sum of parts is equal to the 
            original number and none of the parts has value 0
             Input :  n = 45  Output : Yes Explanation : 452 = 2025 and 20 + 25 is 45
*/
        public static void Main()
        {
            //Read the input 
            Console.WriteLine("Enter an Positive Integer Number:: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // check the number is kaprekar number or not
            if (IsKaprekar(number))
                Console.WriteLine(number + " is a kaprekar number");
            else
                Console.WriteLine(number + " is not a kaprekar number");

            // wait for user confirmation to exit 
            Console.ReadLine();
        }

        public static bool IsKaprekar(int number)
        {
            
            int square = 0;
            int temp = 0;
            int countDigits = 0;
            int firstPart = 0;
            int secondPart = 0;
            int sum = 0;

            // calculate square value of the number, Step2
            square = number * number;

            // count number of digits in the square, step 3
            temp = square;
            while (temp != 0)
            {
                countDigits++;
                temp /= 10;
            }

            //Divide square into two parts and 
            //Check it's sum is equal to the number? Step4
            for (int i = countDigits - 1; i > 0; i--)
            {
                // find first part 
                // first time it will divide the square by 10 then 100 then 100 and so on.
                firstPart = square / (int)Math.Pow(10, i);

                //find second part
                secondPart = square % (int)Math.Pow(10, i);

                //heck have any part only 0, Step 5
                if (firstPart == 0 || secondPart == 0)
                    continue;

                // find sum value, step 6
                sum = firstPart + secondPart;

                // compare sum and number, step 7
                if (sum == number)
                {
                    return true;
                }
            }
            return false;
        }
    }
}

