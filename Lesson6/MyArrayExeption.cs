using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    public class MyArrayExeption : Exception
    {
        public MyArrayExeption(string message): base(message)
        {

        }
    }
}
