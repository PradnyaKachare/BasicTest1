using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

                       //2.WAP to calculate x y  where x is base and y is index without using readymade function.

namespace BasicTest1.Loop3
{
    class PowerOfNum
    {
        public static int CalcuOfPower(int x, int y)
        {
            if (y == 0)
                return 1;
            else
                return x * CalcuOfPower(x, y - 1);
        }

        static void Main(string[] args)
        {
            int bsnm, pwr;
            int result;
            Console.Write("\n\n Recursion : Calculate power of any number :\n");
           
            Console.Write(" Input the base  value : ");
            bsnm = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Input the exponent : ");
            pwr = Convert.ToInt32(Console.ReadLine());

            result = CalcuOfPower(bsnm, pwr);//called the function CalcuOfPower

            Console.Write(" The value of {0} to the power of {1} is : {2} \n\n", bsnm, pwr, result);
        }

       

    }
}
