using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workspace
{
    class Ex001
    {
        public void Run()
        {
            sbyte shortByteNumber = 127;
            byte byteNumber = 0;
            short shortNumber = 3232;
            int intNumber = 20000;

           Console.WriteLine("정수 : {0}, {0}, {1}, {2}, {3}", shortByteNumber, byteNumber, shortNumber, intNumber);
        }
    }
}
