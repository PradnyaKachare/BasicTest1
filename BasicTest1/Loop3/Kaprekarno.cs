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
            Console.WriteLine("Enter the Number:: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // check the number is kaprekar number or not
            if (IsKaprekar(number))
                
                Console.WriteLine(number + " is a kaprekar number");
            else
                Console.WriteLine(number + " is not a kaprekar number");

        }

        public static bool IsKaprekar(int number)
        {
            int count = 0;
            int temp = number;

            while (number > 0)
            {
                count++;
                number = number / 10;
            }
            Console.WriteLine(count);


            // calculate square value of the number, Step2
            number = temp;
            int square = number * number;
            int power = 1;

            //Divide square into two parts and 
            //Check it's sum is equal to the number? Step4
            for (int i=1; i<= count; i++)
            {
                power = power * 10;
            }
            Console.WriteLine(power);

            int quotient = square / power;
            int reminder = square % power;
            int sum = quotient + reminder;

                // compare sum and number, step 7
                if (sum == number)
                {
                    return true;
                }
                else
               {
                return false;
                }
           
            
        }
    }
}

