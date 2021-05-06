using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workspace
{
    class Ex006
    {

        public void Run()
        {
            #region
            sbyte shortByNumber = 127;
            byte byteNumber = 0;
            short shortNumber = 32767;
            int intNumber = 20000;
            long longNumber = 50000;
            #endregion

            #region
            float floatNumber = 3.14f;
            double doubleNumber = 1.5;
            decimal decimalNumber = 5.5m;
            #endregion

            Console.WriteLine("정수 : {0}, {1}, {2}, {3}, {4} ", shortByNumber, byteNumber, shortNumber, intNumber, longNumber);
            Console.WriteLine("정수 : {0}, {1}, {2} ", floatNumber, doubleNumber, decimalNumber);
            
            #region
            char ch = 'A';
            String strMessage = "Hello Csharp";
            #endregion

            Console.WriteLine(ch);
            Console.WriteLine("{0}{1}{2}{3}{4} ", strMessage[0], strMessage[1], strMessage[2], strMessage[3], strMessage[4]);
            Console.WriteLine(strMessage);

            #region
            bool bCal = (1 + 2 == 3);
            bool bCal2 = ((12 > 8) && (8 < 20));
            bool isContainsWord = "Hello CSharp".Contains("Hello");
            #endregion
            Console.WriteLine("{0}", bCal);
            Console.WriteLine("{0}", bCal2);
            Console.WriteLine("{0}", isContainsWord);

            #region
            object objValue = 1;
            var vValue = "var";
            dynamic dValue = true;
            dynamic dValue2 = 1;
            dynamic dValue3 = "댕댕이";
            #endregion

            Console.WriteLine("object 변수 값은 {0}", objValue);
            Console.WriteLine("var 변수 값은 {0}", vValue);
            Console.WriteLine("dynamic 변수 값은 {0}, {1}, {2}", dValue, dValue2, dValue3);


        }
    }
}
