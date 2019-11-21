using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace BrainGames
{
    public sealed class WeekOne
    {
        
        // Complete the reverseArray function below.
        public int[] reverseArray(int[] a)
        {

            var testArray = new int[a.Length];
            int counter = 0;
            for (int i = a.Length - 1; i >= 0; i--)
            {
                testArray[i] = a[counter];
                counter++;
            }
            return testArray;

        }

        public int[] reverseArrayFunctional(int[] a)
        {

            var testArray = new int[a.Length];
            for (int i = a.Length; i > 0; i--)
                testArray[i - 1] = a[a.Length - i];

            return testArray;
        }


        
        public int[] reverseArraySuperFunctional(int[] a) => a.Reverse().ToArray();




        public int hourglassSum(int[][] arr)
        {


            List<int> results = new List<int>();
            int[,] hourGlass = new int[3, 3];

            for (int j = 0; j < 4; j++)
            {
                for (int i = 0; i < 4; i++)
                {

                    //top
                    hourGlass[0, 0] = arr[j][i];
                    hourGlass[0, 1] = arr[j][i + 1];
                    hourGlass[0, 2] = arr[j][i + 2];

                    //mid
                    hourGlass[1, 1] = arr[j + 1][i + 1];

                    //bottom
                    hourGlass[2, 0] = arr[j + 2][i];
                    hourGlass[2, 1] = arr[j + 2][i + 1];
                    hourGlass[2, 2] = arr[j + 2][i + 2];

                    //then sum the hour glass and empty it and save sum result
                    results.Add(hourGlass[0, 0] + hourGlass[0, 1] +
                        hourGlass[0, 2] + hourGlass[1, 1] + hourGlass[2, 0] + hourGlass[2, 1] + hourGlass[2, 2]);
                }

            }



            return results.Max();
        }


        public void Lehakoe()
        {
            int[] mxolisil;
            int[,] mxolisidl = new int[4, 4];
            mxolisil = new int[] { 1, 2 };
            print(mxolisidl.Rank);
        }


        public int TheHourGlassSum(int[][] arr)
        {
            List<int> results = new List<int>();
            int total = 0;
            for (int j = 0; j < 4; j++)
            {
                for (int i = 0; i < 4; i++)
                {
                    //top
                    total = arr[j][i] + arr[j][i + 1] + arr[j][i + 2]

                    //mid
                    + arr[j + 1][i + 1]

                    //bottom
                    + arr[j + 2][i] + arr[j + 2][i + 1] + arr[j + 2][i + 2];

                    results.Add(total);
                }
            }

            return results.Max();
        }

        public void ArrayShift()
        {
            string[] nd = Console.ReadLine().Split(' ');
            int count = Convert.ToInt32(nd[0]);
            int rotations = Convert.ToInt32(nd[1]);

            int[] array = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));

            Queue<int> queue = new Queue<int>();
            Queue<int> queue2 = new Queue<int>();

            for (int i = 0; i < count; i++)
                queue.Enqueue(array[i]);

            for (int i = 0; i < rotations; i++)
                queue2.Enqueue(queue.Dequeue());
            queue.ToList().ForEach(q => { Console.Write($"{q} "); });
            queue2.ToList().ForEach(q => { Console.Write($"{q} "); });



        }

        public string DecToHex(decimal number) => number.ToString("X");

        public List<int> gradingStudents(List<int> grades)
        {
            var rounded = new List<int>();

            grades.ForEach(g =>
            {
                if (g < 38)
                    rounded.Add(g);
                else
                {
                    int wholeNumber = g - (g % 5);
                    int nextMultiple = wholeNumber + 5;
                    int difference = nextMultiple - g;
                    if (difference < 3)
                        rounded.Add(nextMultiple);
                    else
                        rounded.Add(g);
                }
            });
            rounded = new List<int>();

            //new solution
            grades.ForEach(g =>
            {
                if (g < 38)
                    rounded.Add(g);
                else if ((5 - (g % 5)) < 3)
                    rounded.Add(g + (5 - (g % 5)));
                else
                    rounded.Add(g);
            });


            return rounded;
        }

        public void moveLeft()
        {
            string[] nd = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nd[0]);
            int d = Convert.ToInt32(nd[1]);

            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));
        }

        public bool isPrimeNumer(int input)
        {
            bool isPrime = true;
            for (int i = 2; i < 9; i++)
                if (input != i && input % i == 0)
                {
                    isPrime = false;
                    break;
                }

            List<int> divisors = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            bool isPrimeOneLine = divisors.Where(divisor => (input != divisor && input % divisor == 0) == true).FirstOrDefault() > 0 ? false : true;

            return isPrime && isPrimeOneLine;
        }

        public void print(object thing)
        {
            Console.WriteLine(thing.ToString());
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }
    }
}
