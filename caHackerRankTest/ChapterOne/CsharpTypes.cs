using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caMcsdPractice.ChapterOne
{
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
                System.Diagnostics.Debug.WriteLine("Book is currently on page 0!.");
        }
    }

    public class CsharpTypes
    {
        Book book = new Book();
        public CsharpTypes()
        {
            book.Pages = 3;
            book.PreviousPage();
            book.NextPage();
        }
    }
}
