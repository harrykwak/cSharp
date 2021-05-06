using System;

namespace cSharp
{
    public class fac
    {
        public void Run()
        {
            int result = 0;
            for (int i = 1; i <= 5; i++)
            {
                if (i < 6)
                {
                    result = result + i;
                }
                if (i >= 5)
                {
                    Console.WriteLine(result);
                }
            }
        }
    }
}