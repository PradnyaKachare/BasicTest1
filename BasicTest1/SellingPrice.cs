using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicTest1
{
    class SellingPrice
    {
       
         float calculate_sellingprice(int cost_price,int no_of_items,int profit)
        {
            float selling_price = ((cost_price)* (100+profit) / 100);
            return selling_price;
            
        }
        static void Main(string[] args)
        {           
             // float selling_price = (float)s.calculate_sellingprice(20,10,20);
            // float selling_price = (float)s.calculate_sellingprice(14, 10, 15);

            int cost_price = int.Parse(Console.ReadLine());
            int no_of_items = int.Parse(Console.ReadLine());
            int profit = int.Parse(Console.ReadLine());
            SellingPrice s = new SellingPrice();
            //String str = selling_price.ToString();
            float result = s.calculate_sellingprice(cost_price, no_of_items, profit);
            Console.WriteLine(result + ".0");

            /*if (str.Contains("."))
            {
                Console.WriteLine(str);
            }
            else
            { 
                Console.WriteLine(str + ".0"); 
            }*/
       }
    }
}
