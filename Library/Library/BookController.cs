using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class BookController
    {
        private BookModel _bModel;
        private BookView _bView;
        private BookDelegate _bDelegate; //i got no idea how to do these
        public BookController(BookModel BM, BookView BV)
        {
            _bModel = BM;
            _bView = BV;
        }
        public void flipPage()
        {

        }
        public void setBookmark(int i)
        {
            _bModel.addBookmark(i);
        }
        public void removeBookmark(int i)
        {
            _bModel.RemoveBookmark(i);
        }
        public void goToPage()
        {
            //probably make a method to access private parameters from _bmodel
        }
    }
}
