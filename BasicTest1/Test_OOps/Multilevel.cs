using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicTest1.Test_OOps
{
    // 3. Define Inheritance.WAP to give example of multilevel inheritance (real life example)


    class School
    {
        internal string stud_nm = "Pradnya";

        public void ShowSchool()
        {
            Console.WriteLine("Name:" + stud_nm);
        }
    }

    class ClassRoom : School
    {

        internal int id = 101;

        public void ShowClassRoom()
        {
            Console.WriteLine("Student Name:"+stud_nm + "\tStudent Id:\t"  + id);
        }
    }

    class Liabrary : ClassRoom
    {
        string book = "Computer science";

        public void ShowLiabrary()
        {
            Console.WriteLine("Student Name:"+stud_nm + "\tStudent Id:\t" + id + "\tBook name:\t" + book);
        }

    }

    class Multilevel
    {
        static void Main(string[] args)
        {
            Liabrary l = new Liabrary();
            l.ShowSchool();
            l.ShowClassRoom();
            l.ShowLiabrary();
        }
    }

}
