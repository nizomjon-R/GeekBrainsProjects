using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool any = true;

            while (any)
            {
                Console.WriteLine("1- Task1");
                Console.WriteLine("2- Task2");
                Console.WriteLine("3- Task3");
                Console.WriteLine("4- Task4");
                Console.WriteLine("Type task number!!!");
                Console.WriteLine("_________________________________________________________\n");

                int numberOfTask = Int32.Parse(Console.ReadLine());

                switch (numberOfTask)
                {
                    case 0:
                        Console.WriteLine("U are typing incorrect task number task number shuld be at 1 to 3");
                        break;
                    case 1:
                        Task1.PrintFullNames();
                        break;
                    case 2:
                        Task2.PrintSumm();
                        break;
                    case 3:
                        Console.WriteLine("Type number of month");
                        int a = Int32.Parse(Console.ReadLine());
                        Task3.Seasion(a);
                        break;
                    case 4:
                        Console.WriteLine("Type any number");
                        int b = Int32.Parse(Console.ReadLine());
                        Febonachi(b);
                        break;
                    default:
                        Console.WriteLine("U are typing incorrect task number task number shuld be at 1 to 3");
                        //Console.ReadKey();
                        break;
                }


            }
        }
        public class Task1
        {
            static string GetFullName(string firstName, string lastName, string patronymic)
            {
                return $" Your full name: {lastName} {firstName} {patronymic}";
            }
            public static void PrintFullNames()
            {
                Console.WriteLine(GetFullName("Test1", "Testev1", "Testovich1"));
                Console.WriteLine(GetFullName("Test2", "Testev2", "Testovich2"));
                Console.WriteLine(GetFullName("Test3", "Testev3", "Testovich3"));
                Console.WriteLine(GetFullName("Test4", "Testev4", "Testovich4"));
                Console.ReadLine();
            }
        }
        public class Task2
        {
            static int Summ(string anyText)
            {
                int summ = 0;
                for (int i = 0; i < anyText.Length; i++)
                {
                    if (char.IsNumber(anyText[i]))
                    {
                        summ += Convert.ToInt32(anyText[i].ToString());
                    }

                }
                return summ;
            }
            public static void PrintSumm()
            {
                Console.WriteLine("Please type any numbers");
                string anyText = Console.ReadLine();
                string result = String.Join(" ", anyText.AsEnumerable());
                Console.WriteLine($"Your typing string resul !!! {result}");
                Console.WriteLine($"Summ this humber of =  {Summ(result)}");
            }
        }
        public class Task3
        {
            public static string Seasion(int value)
            {
                if (value == 1 || value == 2 || value == 12)
                {
                    return NameOfSeasions.Winter.ToString();
                }
                else if (value == 3 || value == 4 || value == 5)
                {
                    return NameOfSeasions.Spring.ToString();
                }
                else if (value == 6 || value == 7 || value == 8)
                {
                    return NameOfSeasions.Summer.ToString();
                }
                else if (value == 9 || value == 10 || value == 11)
                {
                    return NameOfSeasions.Autumn.ToString();
                }
                else
                {
                    return "U should type numer at 1 to 12";
                }
            }
            public enum NameOfSeasions
            {
                Winter,
                Spring,
                Summer,
                Autumn,
                Error
            }
        }
        public static void Febonachi(int value)
        {
                int result = 0;
                int b = 1;
                int tmp;

                for (int i = 0; i < value; i++)
                {
                    tmp = result;
                    result = b;
                    b += tmp;
                Console.Write($"{b} \t");
                }
            Console.ReadLine();
        }
    }

}