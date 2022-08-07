using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicTest1.Test_OOps
{
    //2.Write to show uses of base keyword

    class Bird
    {
        public int leg = 2;

        public void Color()
        {
            Console.WriteLine("Birds are different color \t leg: " + leg);
        }
    }
    class Peacock : Bird
    {
        public Peacock() : base()
        {
            int leg = 4;
            base.Color();
            Console.WriteLine("Peacock is colorful \t  Leg \t" +leg);
          
        }
    }
    class Parrot : Bird
    {
      /*  public void Color()
        {
            Console.WriteLine("Parrot is Green\t " + base.leg);

        }*/
    }
    class BaseKeyword
    {
        static void Main(string[] args)
        {
            Peacock p = new Peacock();
            Parrot r = new Parrot();
            r.Color();
        }
    }

}
