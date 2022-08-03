using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicTest1.Loops
{
    class Seriescs
    {

     //11.Print the Series 2 12 36 80 150 252....upto 10 terms

         static void Main()
        {
            int n = 4;
           
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine((i * i) + (i * i * i));
            }
        }
    }
}
