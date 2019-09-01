using System;
using System.Diagnostics;

namespace caMcsdPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            ChapterOne.chapterone ch1 = new ChapterOne.chapterone();

            ChapterOne.moreCode moreCode = new ChapterOne.moreCode();
            Debug.WriteLine(moreCode.ToString());

            Solution solution = new Solution();
            solution.TestMove("fares", "fears");
            solution.TestMove("mxolisi", "zondi");
            solution.TestMove("molisix", "mxolisi");
           
            
            //Console.WriteLine(solution.solution(new int[] { 5, 2, 6, 9, 7 }, 25));
            //Console.WriteLine(solution.TestReplace("test", "tent") == "REPLACE s n");
            Console.ReadLine();
            //0,1,2,3,4 answer should be 0
        }

        
    }
}
