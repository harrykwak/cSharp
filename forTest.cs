using System;

namespace cSharp
{
    public class forTest
    {
        public void Run()
        {
            int result = 0;
            for (int i = 1; i < 11; i++)
            {
                for (int y = 1; y < 11; y++)
                {
                    Console.Write(y+result + "\t");
                }
                    result=result+10;
                    Console.WriteLine();

            }
        }
    }
}