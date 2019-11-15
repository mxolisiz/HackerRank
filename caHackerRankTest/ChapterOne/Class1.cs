using System;
using System.Linq;

namespace caMcsdPractice.ChapterOne
{
    public class Class1
    {
        static bool IsPalindrome(string word)
        {
            string testWord = "";
            for (int i = word.Length - 1; i >= 0; i--)
                testWord += word[i];


            if (testWord.Equals(word))
                return true;

            return false;
        }

        static bool IsPalindromeFunc(string word)
        {
            string testWord = "";
            word.Split(new string[] {""}, StringSplitOptions.None).ToList().ForEach(l => {
                testWord += l;
            });

            if (testWord.Equals(word))
                return true;

            return false;
        }

        static bool IsPalindromeFunctional(string word)
        {
            string testWord = "";
            int counter = word.Length;

            while (word.Length != testWord.Length)
            {
                testWord += word[counter];
                counter--;
            }

            if (testWord.Equals(word))
                return true;

            return false;
        }

        public bool IsPalindromeSuperFunctional(string word)
        {
            string testWord = "";

            while (word.Length != testWord.Length)
            {
                testWord += word[GetIndex()];
                Console.WriteLine($"{testWord}: {GetIndex()}");
            }
            Console.WriteLine(testWord);
            return testWord == word;


            int GetIndex() => (word.Length - 1) - testWord.Length;
        }
    }
}
