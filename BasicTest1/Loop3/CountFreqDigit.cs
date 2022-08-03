using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicTest1.Loop3
{
    class CountFreqDigit
    {
        //1.	WAP to accept mobile number and count frequency of digit

        static void Main(string[] args)
        {
            int  f, count = 0;

            Console.WriteLine("Enter Mobile Number : ");
            long number = long.Parse(Console.ReadLine());

          Console.WriteLine("Digit\tFrequency");
           f = int.Parse(Console.ReadLine());
           
            
            while( number >0)
            {
                if (number % 10 == f)
                    count++;
                number = number / 10;

            }                   
             Console.WriteLine(number+ "\t" + f);

            
        }
    }
}

