using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicTest1.Test_OOps                                  //1.Write Code to perform Constructor Chaining
{
    class ConstructorChaining
    {
        public int Age;
        string Name;
        public ConstructorChaining()
        {
            Console.WriteLine("Default Constructor");
        }
        public ConstructorChaining(int Age)
        {
            this.Age = Age;
            Console.WriteLine("Age:\t"+Age);
        }

        public ConstructorChaining(int Age, string Name)
        {
            this.Name = Name;
            Console.WriteLine("Age:\t" + Age + "\t Name:" + Name);
        }
        
        static void Main(string[] args)
        {
            ConstructorChaining obj = new ConstructorChaining();
           

            ConstructorChaining obj1 = new ConstructorChaining(20);

            ConstructorChaining obj2 = new ConstructorChaining(21,"\t veda");
        }
    }

}
