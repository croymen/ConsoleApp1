using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class1
    {
        public static void DoSomeHeavyLifting()
        {
            Console.WriteLine("I'm lifting a truck!!");
            Thread.Sleep(1000);
            Console.WriteLine("Tired! Need a 3 sec nap.");
            Thread.Sleep(1000);
            Console.WriteLine("1....");
            Thread.Sleep(1000);
            Console.WriteLine("2....");
            Thread.Sleep(1000);
            Console.WriteLine("3....");
            Console.WriteLine("I'm awake.");
        }
    }    
}
