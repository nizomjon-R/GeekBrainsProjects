using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\nizom\source\repos\nizomjon-R\GeekBrainsProjects\myTxt.txt";
            Task1 task1 = new Task1(path);
            task1.CreateTxtFile();
            task1.SaveTextToTxt();
            Task2 task2 = new Task2(path);
            task2.DateTimeCreatedFile();
            Task3 task3 = new Task3();
            Console.WriteLine(task3.AnyInt());
            task3.CreateAndSaveBin();
            Task4 task4 = new Task4();
            task4.CreateTxtFile();
            task4.SaveDirToTxt(new DirectoryInfo(@"C:\Users\nizom\source\repos\nizomjon-R\GeekBrainsProjects"), "", true);
            Console.ReadKey();
        }




        public class Task1
        {

            string path;

            public Task1(string path) { this.path = path; }


            public void CreateTxtFile()
            {
                using (StreamWriter sw = File.CreateText(path))
                    Console.WriteLine("New txt file is created");
                Console.WriteLine($"it is in this link.... {path}");
                Console.WriteLine("Type any text it will be save to txt file");
            }
            public void SaveTextToTxt()
            {
                string anyText = Console.ReadLine().ToString();
                using (StreamWriter streamWriter = new StreamWriter(path))
                {
                    streamWriter.WriteLine(anyText);
                }

            }
        }
        public class Task2
        {
            string path;
            public Task2(string path) { this.path = path; }
            public void DateTimeCreatedFile()
            {
                FileInfo fileInfo = new FileInfo(path);
                DateTime date = fileInfo.CreationTime;
                Console.WriteLine($"Your file created {date}");
            }
        }
        public class Task3
        {
            public int AnyInt()
            {
                Random random = new Random();
                return random.Next(0, 255);
            }
            public void CreateAndSaveBin()
            {
                string path = @"C:\Users\nizom\source\repos\nizomjon-R\GeekBrainsProjects\myTxt.bin";
                using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(path, FileMode.Create)))
                {
                    binaryWriter.Write(AnyInt());
                }
                Console.WriteLine($"Created bin file....  {path}");
            }

        }
        public class Task4
        {
            string path = @"C:\Users\nizom\source\repos\nizomjon-R\GeekBrainsProjects\myDirTxt.txt";
            public void CreateTxtFile()
            {

                using (StreamWriter sw = File.CreateText(path))
                    Console.WriteLine("New txt file is created");
                Console.WriteLine($"it is in this link.... {path}");
                Console.WriteLine("Type any text it will be save to txt file");
            }
            public void SaveDirToTxt(DirectoryInfo directoryInfo, string indent, bool lastDirectory)
            {

                using (StreamWriter streamWriter = new StreamWriter(@"C:\Users\nizom\source\repos\nizomjon-R\GeekBrainsProjects\myDirTxt.txt"))
                {
                    streamWriter.Write(indent);
                    streamWriter.Write(lastDirectory ? "|__" : "|--");
                    indent += lastDirectory ? " " : "| ";
                    streamWriter.WriteLine(directoryInfo.Name);
                    DirectoryInfo[] directoryInfos = directoryInfo.GetDirectories();
                    for (int i = 0; i < directoryInfos.Length; i++)
                    {
                        SaveDirToTxt(directoryInfos[i], indent, i == directoryInfos.Length - 1);
                    }
                    streamWriter.Write(path);
                }
            }
            //public void PrintDir(DirectoryInfo directoryInfo, string indent, bool lastDirectory)

            //{
            //    Console.Write(indent);
            //    Console.Write(lastDirectory ? "|__" : "|--");
            //    indent += lastDirectory ? " " : "| ";
            //    Console.WriteLine(directoryInfo.Name);
            //    DirectoryInfo[] directoryInfos = directoryInfo.GetDirectories();
            //    for (int i = 0; i < directoryInfos.Length; i++)
            //    {
            //        PrintDir(directoryInfos[i], indent, i == directoryInfos.Length - 1);
            //    }
            //}
        }
    }
}
