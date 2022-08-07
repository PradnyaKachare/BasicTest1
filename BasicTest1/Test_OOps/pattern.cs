using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicTest1.Test_OOps
{
    /*   4. Print the pattern 
      1 
    1 2 3
  1 2 3 4 5
1 2 3 4 5 6 7
*/

    class pattern
    {
        public static void Main()
        {
            int temp = 0;
            for (int i = 1; i <= 4; i++)
            {                
                for (int k = i; k < 5; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i + temp; j++)
                {
                    Console.Write(j);
                }
                temp++;
                Console.WriteLine();

            }
        }
    }
}
