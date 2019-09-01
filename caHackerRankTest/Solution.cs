using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caHackerRankTest
{
    class Solution
    {
        //fix 3 lines only for it to tell you location of valu in array
        public int solution(int[] myArray, int valu)
        {
            int N = myArray.Length;//5
            if (N == 0)
            {
                return (-1);
            }


            int position = 0;
            int length = N - 1;

            while (position < length)
            {
                int m = (position - length) / 2;

                if (myArray[m] > valu)
                {
                    length = m - 1;
                }
                else
                {
                    position = m;
                }
            }

            if (myArray[position] == valu)
            {
                return position;
            }
            return -1;
        }




        

        //move, replace remove

        //1
        public string TestRemove(string S, string T)
        {
            var lettersList = S.ToArray().ToList();

            for (int i = 0; i < lettersList.Count; i++)
            {
                if (S.Replace(S[i], '0').Replace("0", "").Equals(T))
                    return $"REMOVE {S[i]}";
            }

            return "0";
        }

        //2
        public string TestReplace(string S, string T)
        {
            var lettersList = new List<char> { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            var Schars = S.ToArray().ToList();

            //snett pnett


            for (int i = 0; i < Schars.Count; i++)
            {

                for (int j = 0; j < lettersList.Count; j++)
                {
                    var wordArray = Schars.ToArray();
                    wordArray[i] = lettersList[j];
                    if (string.Join("", wordArray).Equals(T))
                        return $"REPLACE {Schars[i]} {lettersList[j]}";
                }

            }

            return "0";
        }

        //3
        public void TestMove(string S, string T)
        {
            List<char> sList = S.ToList();
            for (int i = sList.Count - 1; i > 0; i--)
            {
                char currLetter = sList[i];
                var result = MoveLetterToLeft(i, currLetter, S, T);
                if (result.Equals(""))
                    continue;
                else
                {
                    Console.WriteLine(result);
                    break;
                }
            }

        }

        public string MoveLetterToLeft(int pos, char letter, string S, string T)
        {
            var lettersList = S.ToList();
            lettersList.RemoveAt(pos);

            for (int i = pos; i > 0; i--)
            {
                lettersList.Insert(i - 1, letter);
                if (string.Join("", lettersList).Equals(T))
                    return $"MOVED {letter}";

                lettersList.RemoveAt(i - 1);
            }

            return "";
        }
    }
}
