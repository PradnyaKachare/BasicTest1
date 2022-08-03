using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicTest1.Loop2
{
    //3.WAP to print number from 1 to 50 if number is even then print as it is and number is odd then print its square
    class SquareoFOdd
    {
        static void Main(string[] args)
        {
                  
            int j=2;// input number from user till which the //square and cube to find

           /* Console.WriteLine("Enter the Number ");
               i = int.Parse(Console.ReadLine());       */  
                       
            while(j <= 50)
                {
              if(j % 2 == 0)
                    {
                    Console.WriteLine("Even number: "+j);
                       }
                else
                {
                    Console.WriteLine("odd square: " + j * j);
                }
                j++;
           }                       
        }

    }
}

