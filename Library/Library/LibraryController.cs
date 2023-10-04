using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class LibraryController
    {
        private List<BookModel> _books = new List<BookModel>();
        public BookModel currentBook;
        public RequestBook RB;
        public updatebppl UB;
        public LibraryController(RequestBook rb, updatebook ub)
        {
            RB = rb;
            string filePath = Path.GetFullPath("Library.txt");
            if (File.Exists(filePath))
            {
                StreamReader sr = new StreamReader(filePath);
                while (!sr.EndOfStream)
                {
                    string[] Books = sr.ReadLine().Split(',');
                    _books.Add(new BookModel(Books[0], Books[1], Books[2]));
                }
                //63w6 
                sr.Close();
            }   
        }
        public void addBookmark(int b)
        {
            _books[_books.IndexOf(currentBook)].addBookmark(b); //grabs teh current book and adds a bookmark to that
        }
        public void removeBookmark(int b)
        {
            _books[_books.IndexOf(currentBook)].RemoveBookmark(b); //grabs teh current book and removes a bookmark
 
        }
        public void synchronize()
        {
            //grabs books from .txt file the update _books
            RB(_books);    
        }
        public void updateBook()
        {
            
        }

    }
}
