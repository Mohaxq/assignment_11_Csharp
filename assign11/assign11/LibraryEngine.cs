using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign11
{
    public static class LibraryEngine
    {
        public static void ProcessBooks(List<Book> blist, Func<Book, string> bookFunction)
        {
            foreach (Book B in blist)
            {
                Console.WriteLine(bookFunction(B));
            }
        }
    }
}
