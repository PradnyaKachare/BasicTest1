using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicTest1
{
    class Weirdno
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if(n %2==0 && n>20)
            {
                Console.WriteLine("Not Weird");
            }
            else if(n %2==0 && (2 <=n && n>=5))
            {
                Console.WriteLine("Not Weird");
            }
            else if(n % 2 == 0 && (6 <= n && n <=20))
            {
                Console.WriteLine(" Weird");
            }
            else
            {
                Console.WriteLine("Weird");
            }
        }
    }
}
