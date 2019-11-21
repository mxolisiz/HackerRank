using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caMcsdPractice.ChapterOne
{
    public class InstanceAndStaticVariables
    {
        public static int Counter { get; set; }
        public string Name { get; set; }
    }
    struct Book
    {
        public string Title { get; set; }
        public string Category { get; set; }
        public int Pages { get; set; }
        public int CurrentPage { get; set; }
        public int ISBN { get; set; }
        public int CoverStyle { get; set; }

        public void NextPage()
        {
            if (CurrentPage < Pages)
            {
                CurrentPage++;
                System.Diagnostics.Debug.WriteLine($"Current page: {CurrentPage}");
            }
            else
                System.Diagnostics.Debug.WriteLine($"You are on the last page ({Pages})");
        }
        public void PreviousPage()
        {
            if (CurrentPage != 0)
            {
                CurrentPage--;
                System.Diagnostics.Debug.WriteLine($"Current page: {CurrentPage}");
            }
            else
                Debug.WriteLine("Book is currently on page 0!.");
        }
    }

    public partial class CsharpTypes
    {
        Book book = new Book();
        public void PageTheBook()
        {
            book.Pages = 3;
            book.PreviousPage();
            book.NextPage();
        }

        public void ToggleInstanceAndStaticValues()
        {
            InstanceAndStaticVariables instanceAndStaticVariables = new InstanceAndStaticVariables();
            instanceAndStaticVariables.Name = "Instance1";
            InstanceAndStaticVariables.Counter++;
            InstanceAndStaticVariables instanceAndStaticVariables2 = new InstanceAndStaticVariables();
            instanceAndStaticVariables2.Name = "Instance2";
            InstanceAndStaticVariables.Counter++;
            Debug.WriteLine($"InstanceAndStaticVariables.Counter:{InstanceAndStaticVariables.Counter}");
            Debug.WriteLine($"instanceAndStaticVariables2.Counter:Cannot be accessed with an instance variable");
        }
    }
}
