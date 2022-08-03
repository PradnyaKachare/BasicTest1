using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicTest1.Loop3
{
    class KboatSeries
    {
        //  5.	Series 0,3,8,15,24,35,48.....nterms

               /*  to check whether the product of two numbers is a buzz number or not. 
                   [A number that ends with 7 or is divisible by 7, is called a buzz number].
                     */


            public static void Main(String[] args)
            {
                for (int i = 1; i <= 10; i++)
                {
                    int t = i * i - 1;

                Console.WriteLine (t + " ");
                }
            }
        
    }
}
