using System;
using System.Linq;

namespace caMcsdPractice.ChapterOne
{
    public class Class1
    {

        public void print(object value)
        {
            System.Diagnostics.Debug.WriteLine(value);
        }

        public void valueTypes()
        {
            int myInt;
            print(new int());
            //print(myInt);
            //print(new int(default));

        }

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


        public void PatternMatching(object thisThing)
        {
            //C# 7
            if (thisThing is string name)
                System.Diagnostics.Debug.WriteLine(name);


            switch (thisThing)
            {
                case string t when t.StartsWith("mxo"):
                    System.Diagnostics.Debug.WriteLine($"Its a string and starts with 'mxo' {thisThing}");
                    break;
                case string s:
                    System.Diagnostics.Debug.WriteLine($"Its a string: {s}");
                    break;
                case int i:
                    System.Diagnostics.Debug.WriteLine("Its an int");
                    break;
                default:
                    System.Diagnostics.Debug.WriteLine("Nothing");
                    break;
            }


        }

        public bool GenericMethod<T>(T name,T lastName) where T:struct
        {
            T dude=name;
            T hi;

            //bool result= name == lastName; cannot do this because T & T are unknown types
            return name.Equals(lastName);//object class provides an equals method to compare values
        }
    }
}
