using System.Diagnostics;

namespace caMcsdPractice.ChapterOne
{
    internal class Person
    {
        protected int canBeAccessedOnlyByDerivedMembersObviously { get; set; }
        public string name { get; set; }
        public Person() => runTown();

        public virtual void runTown() => Debug.WriteLine("Im from the parent my... Person's constructor.");
    }

    interface MemberOfSociety
    {
        void PrintCatchPhrase();
        string FaveLanguage { get; set; }
    }

    abstract class CoderDude : MemberOfSociety
    {
        public abstract string FaveLanguage { get; set; }

        public abstract void PrintCatchPhrase();
    }

    
}