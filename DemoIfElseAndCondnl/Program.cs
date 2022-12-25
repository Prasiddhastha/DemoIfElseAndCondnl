using DemoIfelseandSwithStatement.IfElseCondn;
using System;
namespace DemoIfandSwitchStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            int choose;
        A: Console.WriteLine("**************Enter Your Choice**************\n\n");
            Console.WriteLine("1.Check Hour\t\t\t 2. Conditonal Statement");
            choose = Convert.ToInt32(Console.ReadLine());
            switch (choose)
            {
                case 1:
                    IfElseCondn.GetHour();
                    goto A;

                case 2:
                    IfElseCondn.GetCustomer();
                    goto A;
                default:
                    Console.WriteLine("\t\t!!!!!!!!!!!!!!Wrong Input!!!!!!!!!!!!!!\n");
                    goto A;

            }


        }


    }
}