using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicTest1.Loops
{
    class Pattern
    {        
       // 6) WAP to print following pattern.
        /*      1
	          2 2 2
            3 3 3 3 3
          4 4 4 4 4 4 4*/


        static void Main(string[] args)
        {
            int temp = 0;
          
            for (int i = 1; i <= 4; i++)
            {
                for (int k = i; k <= 5; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i+temp; j++)
                    {
                        Console.Write(i);
                    }
                temp++;
                    Console.WriteLine();
                
            }

            Console.WriteLine("\n ----------------------------------");


            /*7.WAP to print following pattern.



                    *****
                    ****
                     ***
                     **
                      *
*/


            for (int i = 5; i >= 1; i--)
            {
                for (int k = i; k <= 5; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n ----------------------------------");

        /*    8) WAP to print following pattern.
      1 2 3 4 5
         1 2 3 4
             1 2 3
                1 2
                    1
*/



            for (int i = 5; i >= 1; i--)
            {
                for (int k = i; k < 5; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            

        }
    }
}
