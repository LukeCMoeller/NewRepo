using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public delegate void RequestBook(List<BookModel> Lbook); 
    public class LibraryView
    {
        private List<BookModel> _booksView = new List<BookModel>();
        public LibraryView()
        {
            Console.WriteLine("Welcome to the Mini-Kindle app.");
            Console.WriteLine("Type S to synchronize the book library with the cloud. Type L to see the books avaliable");
            string respone = Console.ReadLine();
            if(respone != "S" || respone != "L")
            {
                Console.WriteLine("Wront inputs stupid");
                System.Environment.Exit(1);
            }
            else
            {
                if(respone == "S")
                {
                    //something sycnronize
                }else if(respone == "L")
                {
                    displayLibrary();
                }
            }

        }
        public void UpdateBooks(List<BookModel> LBook)
        {
            _booksView = LBook;
        }

        public void displayLibrary()
        {
            //something delegates to get the model cus the view cant mess with the model
            //the TA said the view and the model shouldnt talk to eachother but in the teachers example the customverview has a vendingmodel in the constructor so idk
        }
        public void handleActions()
        {

        }
    }
}
