using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicTest1.Test_OOps
{
   /* 6.Write a program with Shopping class which has overloaded method ‘doTransaction’. If it has CreditCard type parameter it should display message 
    * ‘You got 15% discount on bill on credit card transaction’.
   If it has DebitCard type parameter it should display message ‘No discount on bill on debit card transaction’.
*/


    class Shopping
    { 
        public void DoTransaction(string s)
        {
            Console.WriteLine("You got 15 % discount on bill on credit card transaction");
        }
        public void DoTransaction(char a,string d)
        {
            Console.WriteLine("No discount on bill on debit card transaction");

            /*
            if(CreditCard)
            {
               Console.WriteLine("You got 15 % discount on bill on credit card transaction");
            }
            else
            {
                Console.WriteLine("No discount on bill on debit card transaction");
            }*/

        }

        static void Main(string[] args)
        {
            Shopping s = new Shopping();
            s.DoTransaction("credit card");
            s.DoTransaction('n', "debit card");

        }
    }
}
