using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi GeekBrains it's my first home work!!!");
            Console.WriteLine("Please inter your first name");
            string userName = Console.ReadLine();
            DateTime myDateTame = DateTime.Now;
            Console.WriteLine($"Hello, {userName} today date time is {myDateTame}");
            //We can do this type of way
            Console.WriteLine("Hello, {0} today date time is {1}", userName, myDateTame);
            Console.WriteLine("Hello, " + userName + " today date time is " + myDateTame);
            Console.ReadLine();
        }
    }
}
