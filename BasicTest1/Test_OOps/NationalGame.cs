using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicTest1.Test_OOps
{
    /*  5) National game of India is Hockey, China is Table Tennis, Bangladesh is Kabaddi, Italy is Football,United States is baseball.
         Write a program to  read country name as user-input and to print the  country’s national game.Use switch case
  */


    class NationalGame
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Country Name:");

            string country_nm = (Console.ReadLine());


            switch (country_nm)
            {
                case "India":
                    Console.WriteLine("India National Game is Hockey");
                    break;

                case "China":
                    Console.WriteLine("China National Game is Table Tennis");
                    break;

                case "Bangladesh":
                    Console.WriteLine("Bangladesh National Game is Kabaddi");
                    break; ;

                case "Italy":
                    Console.WriteLine("Italy National Game is Football");
                    break;

                case "United States":
                    Console.WriteLine("United States National Game is baseball");
                    break;

                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }

        }
    }
}
         
    


