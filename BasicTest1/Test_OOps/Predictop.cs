using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicTest1.Test_OOps
{                                                                                                                                   
    class Predictop
    {            //   7) Predict the output

          static void main(String[] args)
          {
             /* Car c1 = new Car();
              c1.color = "Blue";
              Car c2 = new Car();
              c2.changeColor(c1);
              c2.color = "Pink";
              Console.WriteLine(c1.color);
              Console.WriteLine(c2.color);*/
          }
    }
        class Car
        {
            String color;
            public void changeColor(Car c2)
            {
                c2.color = color;
                color = "Red";
            }
        }

    }
//op:Error  color is inacceccible due to protection level
