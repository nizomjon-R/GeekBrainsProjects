using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
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
                        creatingMatrix(9, 9);
                        break;
                    case 2:
                        Contact();
                        break;
                    case 3:
                        strinngBackRead();
                        break;
                    case 4:
                        seaBattle();
                        break;
                    default:
                        Console.WriteLine("U are typing incorrect task number task number shuld be at 1 to 3");
                        //Console.ReadKey();
                        break;
                }


            }

        }
        // 1. Написать программу, выводящую элементы двумерного массива по диагонали.
        static void creatingMatrix(int a, int b)
        {
            int[,] matrix = new int[a, b];
            Random random = new Random();
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    matrix[i, j] = random.Next(1, 99);
                    Console.Write($"{matrix[i, j]} \t");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    if (i == j)
                    {
                        Console.Write($"{matrix[i, j]} \t");
                    }
                    else
                    {
                        Console.Write("\t");
                    }
                }
                Console.WriteLine();
            }
        }

        // 2. Написать программу «Телефонный справочник»: создать двумерный массив 5х2, хранящий
        // список телефонных контактов: первый элемент хранит имя контакта, второй — номер телефона/email.
        static void Contact()
        {
            string[,] matrix = new string[5, 2] { { "Oleg1", "11111" }, { "Oleg2", "22222" }, { "Oleg3", "33333" }, { "Oleg4", "44444" }, { "Oleg5", "55555" } };
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write($"{matrix[i, j]} \t");
                }
                Console.WriteLine();
            }
        }
        static void strinngBackRead()
        {
            Console.WriteLine("Please type any text");

            string anyText = Console.ReadLine().ToString();
            for (int i = anyText.Length - 1; i >= 0; i--)
            {
                Console.Write(anyText[i]);
            }
        }
        static void seaBattle()
        {
            int[,] matrix = new int[10, 10];
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    matrix[i, j] = random.Next(0, 2);
                    if (matrix[i, j] == 1)
                    {
                        Console.Write("X\t");
                    }
                    else
                    {
                        Console.Write($"{matrix[i, j]} \t");
                    }   
                }
                Console.WriteLine();
            }
        }

    }
}
