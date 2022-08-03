using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicTest1.Loops
{
    class PredictOP9
    {
        static void Main(string[] args)
        {
            for (int i = 5; i > 0; i--)
            {
                int mysteryInt = 100;
                mysteryInt -= i;
                Console.WriteLine(mysteryInt);
            }
        }
    }
}

//prints 95 96 97 98 99