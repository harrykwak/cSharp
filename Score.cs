using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workspace
{
    class Score
    {
        public void Run()
        {
            Console.WriteLine("국어 점수 입력하라.");
            String korT = Console.ReadLine();

            Console.WriteLine("수학 점수 입력하라.");
            String mathT = Console.ReadLine();

            Console.WriteLine("영어 점수 입력하라.");
            String engT = Console.ReadLine();
            
            Console.WriteLine("체육 점수 입력하라.");
            String pysT = Console.ReadLine();



            int kor = Convert.ToInt32(korT);
            int math = Convert.ToInt32(mathT);
            int eng = Convert.ToInt32(engT);
            int pys = Convert.ToInt32(pysT);


            int total = kor + math + eng + pys;
            int avg = total / 4;


            Console.WriteLine("국어 성적은 {0}, 수학 성적은 {1}, 영어 성적은 {2}, 체육 성적은 {3}", kor, math, eng, pys);
            Console.WriteLine("총점은 {0}, 평균은 {1}", total, avg);
        }
    }
}
