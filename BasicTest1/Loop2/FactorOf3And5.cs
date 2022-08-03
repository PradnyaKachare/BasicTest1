using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicTest1.Loop2
{
	/*6.	Write a program to print number from 1 to 100 such that when a number is factor of 3 and 5 both print  “RedBlue” 
		and if given number is factor of only 3 the print “red” and if given number is factor of only 5 then “blue” otherwise
		the number itself*/


	class FactorOf3And5
    {
        static void Main(string[] args)
        {

			Console.WriteLine("\nDivided by 3: ");
				for (int i = 1; i < 100; i++)
				{
					if (i % 3 == 0)
					Console.Write( "Red " +i);
				}

			Console.WriteLine("\n\nDivided by 5: ");
				for (int i = 1; i < 100; i++)
				{
					if (i % 5 == 0) Console.Write(i + ", Blue");
				}

			Console.WriteLine("\n\nDivided by 3 & 5: ");
				for (int i = 1; i < 100; i++)
				{
					if (i % 3 == 0 && i % 5 == 0) Console.Write(i + ", RedBLue");
				}
			Console.WriteLine("\n");
			}
		}
    }

