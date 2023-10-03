﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class LibraryController
    {
        private List<BookModel> _books = new List<BookModel>();
        public BookModel currentBook;
        public LibraryController()
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
        public void addBookmark(int b)
        {
            _books[_books.IndexOf(currentBook)].addBookmark(b); //grabs teh current book and adds a bookmark to that
        }
        public void removeBookmark(int b)
        {
            _books[_books.IndexOf(currentBook)].RemoveBookmark(b); //grabs teh current book and removes a bookmark
 
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
