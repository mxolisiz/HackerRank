using System;
using System.Diagnostics;
using System.Drawing;

namespace caMcsdPractice.ChapterOne
{
    public class chapterone
    {
        public chapterone()
        {
            Person[] people = new[] { new Employee { }, new Person { } };
            int num = 0;
            string type = num % 2 == 0 ? "even" : "odd";
            Debug.WriteLine(sizeof(int));
            Debug.WriteLine(people.GetType());


            var heitaDa = people[0] as Employee;
            heitaDa.ThisDudeWasAStudent();

            if (people is Employee[])
                Debug.WriteLine(people.ToString());

            var tryParseVal = people as Employee[];
            Debug.WriteLine(people.GetType());

            while (false)
                System.Console.WriteLine("Im  true");


        }

        public enum mxolisi : byte
        {
            happy = 250,
            supperHappy,
            excited,
            superExcited,
            angry,
            veryAngry,
            //haibo value to huge for byte!
        }

        public byte SwitchAndStuff(mxolisi val)
        {
            switch (val)
            {
                case mxolisi.happy:
                    return (byte)mxolisi.happy;
                case mxolisi.supperHappy:
                    return (byte)mxolisi.supperHappy;
                case mxolisi.excited:
                    return (byte)mxolisi.excited;
                case mxolisi.superExcited:
                    return (byte)mxolisi.superExcited;
                case mxolisi.angry:
                    return (byte)mxolisi.happy;
                case mxolisi.veryAngry:
                    return (byte)mxolisi.happy;
                default:
                    break;
            }
            byte theNUmbers = 254;
            switch (theNUmbers)
            {
                case 1:
                    Debug.WriteLine("im on one");
                    break;
                case 2:
                    Debug.WriteLine("nope");
                    break;
                case 7:
                case 8:
                case 9:
                case 10:
                    Debug.WriteLine("Supper cool with combos");
                    break;
                default:
                    Debug.WriteLine("Default hit!");
                    break;
            }
            return theNUmbers;
        }

        /// <summary>
        /// Error	CS8370	Feature 'recursive patterns' is not available in C# 7.3. Please use language version 8.0 or greater.
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        static string Display(object o) => o switch
        {
            Point { X: 0, Y: 0 } => "It's the center my guy!",
            Point { X: var x, Y: var y } => $"Its {x} and {y} !!!!",
            _ => "No!"
        };


        static string DisplayTest(object o)
        {

            switch (o)
            {

                default:
                    break;
            }

            var result= o switch
            {
                Point { X: 0, Y: 0 } => "It's the center my guy!",
                Point { X: var x, Y: var y } => $"Its {x} and {y} !!!!",
                _ => "Bricks, Andizi!"
            };

            return result;
        }

        class Employee : Person
        {
            public Employee() => Debug.WriteLine("Employee's constructor");

            public override void runTown() => Debug.WriteLine("Hey Im overriden - is that even a word - virtual vs abstract parent method.");

            public void ThisDudeWasAStudent()
            {
                Student student = new Student();
                Debug.WriteLine($"Default values {student.firstName}, {student.age}, {student.score1}");
            }
        }

        internal struct Student
        {
            public string firstName;
            public string lastname;
            public char initial;
            public double score1;
            public double score2;
            public double score3;
            public double score4;
            public double score5;
            public double average;
            public int age;
            /*public Student(int agez)
            {
                age = agez;
                average = 0;

            }*/
        }

        
    }
}
