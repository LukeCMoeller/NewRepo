using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Library
{
    
    public class LibraryModel
    {
        private List<BookModel> _books = new List<BookModel>();
        public LibraryModel()
        {
            string filePath = Path.GetFullPath("Library.txt");
            if (File.Exists(filePath))
            {
                StreamReader sr = new StreamReader(filePath);
                while (!sr.EndOfStream)
                {
                    string[] Books = sr.ReadLine().Split(' ');
                    _books.Add(new BookModel(Books[0], Books[1], Books[2]));
                }
                sr.Close();
            }
        }
        public void addBook(BookModel Book)
        {
            _books.Add(Book);
        }
        public void removeBook(BookModel Book)
        {
            _books.Remove(Book);
        }
        public void synchronize()
        {
            //doing know what this does
        }
    }
}
