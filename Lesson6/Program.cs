using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Process[] proclist = Process.GetProcesses();
            foreach (Process process in proclist)
            {
                Console.WriteLine(process.ProcessName);
            }
            foreach (var item in Process.GetProcessesByName("WhatsApp"))
            {
               item.Kill();   
            }
            Console.ReadLine();

        }
    }
}
