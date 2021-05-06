using System;

namespace cSharp
{
    public class forTest
    {
        public void Run()
        {
            int result = 0;
            for (int i = 1; i < 6; i++)
            {
                for (int y = 1; y < 6; y++)
                {
                    Console.Write(y+result + "\t");
                }
                    result=result+5;
                    Console.WriteLine();

            }
        }
    }
}