using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class LibraryController
    {
        private LibraryModel lModel;
        private LibraryView lView;
        private LibraryDelegate lDelegate; //i got no idea how to do these
        public LibraryController(LibraryModel LM, LibraryView LV)
        {
            lModel = LM;
            lView = LV;
        }

    }
}
