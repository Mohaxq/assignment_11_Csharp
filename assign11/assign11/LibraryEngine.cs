using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign11
{
    public delegate string BookDelegate(Book B);
    public static class LibraryEngine
    {
        public static void ProcessBooks(List<Book> blist,BookDelegate bookFunction)
        {
            foreach (Book B in blist)
            {
                Console.WriteLine(bookFunction(B));
            }
        }
    }
}
