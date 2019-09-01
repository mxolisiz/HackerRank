using System.Diagnostics;

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

        enum mxolisi : byte
        {
            happy = 250,
            supperHappy,
            excited,
            superExcited,
            angry,
            veryAngry,
            //haibo value to huge for byte!
        }

        public void SwitchAndStuff()
        {
            mxolisi mxo = mxolisi.supperHappy;
            switch (mxo)
            {
                case mxolisi.happy:
                    break;
                case mxolisi.supperHappy:
                    break;
                case mxolisi.excited:
                    break;
                case mxolisi.superExcited:
                    break;
                case mxolisi.angry:
                    break;
                case mxolisi.veryAngry:
                    break;
                default:
                    break;
            }
            int theNUmbers = 254;
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
