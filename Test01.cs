using System;

namespace cSharp
{
    public class Test01
    {
        public void Run(int num)
        {

            int result = 1;
            for (int i = 1; i <= num; i++)
            {

                if (num >= i)
                {
                    result = result * i;
                }

                if (num <= i)
                {
                    Console.WriteLine(result);
                }
            }



        }
    }
}