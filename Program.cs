using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountPriceExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalPrice = 0;
            int discountPrice = 0;

            Console.WriteLine("Please Enter total Price");

            totalPrice = Convert.ToInt32(Console.ReadLine());   

            if(totalPrice>=0 && totalPrice<=10000)
            {
                discountPrice = totalPrice * 5 / 100;
            }
            else if(totalPrice >10000 && totalPrice<=20000)
            {
                discountPrice = totalPrice * 10 / 100;

            }
            else if(totalPrice >20000)
            {
                discountPrice = totalPrice * 20 / 100;
            }
            else
            {
                Console.WriteLine("invalid output");
            }

            Console.WriteLine(discountPrice);
            Console.ReadKey();
        }
    }
}
