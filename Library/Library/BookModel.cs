using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class BookModel
    {
        public string Title
        {
            get;
            private set;
        }
        public string Author
        {
            get;
            private set;
        }
        public int TotalPage
        {
            get;
            private set;
        }
        public int CurrentPage
        {
            get;
            private set;
        }
        public List<int> Bookmarks {
            get;
            private set;
        } = new List<int>();
    public BookModel(string title, string author, string tp)
        {
            Title = title;
            Author = author;
            TotalPage = Int32.Parse(tp);
        }
        public void addBookmark(int b)
        {
            Bookmarks.Add(b);
        }
        public void RemoveBookmark(int b)
        {
            Bookmarks.Remove(b);
        }
    }
}
