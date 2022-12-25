using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoIfelseandSwithStatement.IfElseCondn
{   
    //IfElse statement And Conditional
    public class IfElseCondn
    {
        public static void GetHour()
        {
            int hour;
            Console.Write("Enter hour");
            hour = Convert.ToInt32(Console.ReadLine());
            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("It's Morning\n");
            }
            else if (hour >= 12 && hour < 18)
            {
                Console.WriteLine("It's Afternoon\n");
            }
            else
            {
                Console.WriteLine("It's Evening\n");
            }
        }
        public static void GetCustomer()
        {
            bool isGoldCustomer = true;
            float price = (isGoldCustomer) ? 19.95f: 29.95f ;
            Console.WriteLine(price);
        }
    }
}
