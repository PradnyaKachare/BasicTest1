using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicTest1
{
    class Studentmark
    {
        static void Main(string[] args)
        {
            double maths, phy, che, ca,marathi, total;
            double per, avg;
            
            Console.WriteLine("Calculate the total, percentage and division to take marks of Five subjects:\n");
            

            Console.WriteLine("Input  the marks of Maths : ");
            maths = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input  the marks of Marathi : ");
            marathi = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input  the marks of Physics : ");
            phy = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input  the marks of  Chemistry : ");
            che = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input  the marks of Computer Application : ");
            ca = Convert.ToInt32(Console.ReadLine());

            total = phy + che + ca + marathi + maths;

            avg = total / 5;

            per = (total / 500) * 100;       
            
            Console.WriteLine("Total Marks = "+total);
            Console.WriteLine("Percentage = " + per + "%");
            Console.WriteLine("Average = " + avg);

        }
    }
}
