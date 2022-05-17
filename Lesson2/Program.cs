using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  lesson2Task1();
            //   lesson2Task2();
            //  lesson2Task3();
            //  lesson2Task4();
            lesson2Task5();
        }
        public static void lesson2Task1()
        {
            //Запросить у пользователя минимальную и максимальную температуру за сутки и вывести среднесуточную температуру.

            Console.WriteLine("Type your max temperature for today");
            double maxTemp = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Type your min temperature for today");
            double minTemp = Int32.Parse(Console.ReadLine());

            // We are checking max and min temperature
            if (maxTemp < minTemp || maxTemp == minTemp)
            {
                Console.WriteLine("Please type your temperature corectly");
            }
            else
            {
                double midleTemp = (maxTemp + minTemp) / 2;
                Console.WriteLine($"Your midle temperature for today {midleTemp}");
            }
            Console.ReadLine();
        }
        public static void lesson2Task2()
        {
            //Запросить у пользователя порядковый номер текущего месяца и вывести его название.

            Console.WriteLine("Please!! inter current month number. Example: 1-January, 2-February.......");
            int nuberOfMonth = Int32.Parse(Console.ReadLine());
            switch (nuberOfMonth)
            {
                case 1:
                    Console.WriteLine("January");
                    break;
                case 2:
                    Console.WriteLine("February");
                    break;
                case 3:
                    Console.WriteLine("March");
                    break;
                case 4:
                    Console.WriteLine("April");
                    break;
                case 5:
                    Console.WriteLine("May");
                    break;
                case 6:
                    Console.WriteLine("June");
                    break;
                case 7:
                    Console.WriteLine("July");
                    break;
                case 8:
                    Console.WriteLine("August");
                    break;
                case 9:
                    Console.WriteLine("September");
                    break;
                case 10:
                    Console.WriteLine("October");
                    break;
                case 11:
                    Console.WriteLine("Novomber");
                    break;
                case 12:
                    Console.WriteLine("December");
                    break;
                default:
                    Console.WriteLine("You need type at 1 to 12");
                    break;
            }
            Console.ReadLine();
        }
        public static void lesson2Task3()
        {
            //Определить, является ли введённое пользователем число чётным.

            Console.WriteLine("Please type any numer");
            int anyNumber = Int32.Parse(Console.ReadLine());
            if (anyNumber / 2 == 0)
            {
                Console.WriteLine("Your number is even");
            }
            else
            {
                Console.WriteLine("Your number is not even");
            }
            Console.ReadLine();
        }
        public static void lesson2Task4()
        {
            string produktName = "Apple";
            double sumNDS = 377.10;
            double sumPolucheno = 377.10;
            string adress = "Test";
            string kassir = "Test";
            DateTime dataTame = DateTime.Now;
            int checkNumber = 0001;
            string nnn = "000000000001e";

            Console.WriteLine($"____________Dobro pojalovat____________ \n\n\n Summa s NDS -----{sumNDS} \nNazivaniya produkta ---------{produktName}\nItog---------- " +
                $"{sumPolucheno} \nKassir------------- {kassir} \nVremya-------------{dataTame} \nAdres---------- {adress}" +
                $"\nChek nomer----------------{checkNumber} \nNNN----------{nnn}\n\n____________Spasibo za pokupka_________ ");
            Console.ReadLine();


        }
        public static void lesson2Task5()
        {
            Console.WriteLine("Type month of winter (December, January, Febrary)");
            string monthOfWinter = Console.ReadLine();
            Console.WriteLine("Type temperature");
            int temperature = Int32.Parse(Console.ReadLine());
            if ((monthOfWinter == "December" || monthOfWinter == "January" || monthOfWinter == "Febrary") && temperature > 0)
            {
                Console.WriteLine($"Season is {monthOfWinter} temperature {temperature}  is raining");
            }
            else
            {
                Console.WriteLine("Wrong month or temperature");
            }
            Console.ReadLine();
        }
    }
}
