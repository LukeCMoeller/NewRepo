using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class BookModel
    {
        private string _title;
        private string _author;
        private int _totalPage;
        private int _currentPage;
        private List<int> _bookmarks = new List<int>();
        public BookModel(string title, string author, string tp)
        {
            _title = title;
            _author = author;
            _totalPage = Int32.Parse(tp);
        }
        public void addBookmark(int b)
        {
            _bookmarks.Add(b);
        }
        public void RemoveBookmark(int b)
        {
            _bookmarks.Remove(b);
        }
    }
}
