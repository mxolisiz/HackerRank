using System.Diagnostics;

namespace caMcsdPractice.ChapterOne
{
    internal class Person
    {
        public string name { get; set; }
        public Person() => runTown();

        public virtual void runTown() => Debug.WriteLine("Im from the parent my... Person's constructor.");
    }
}