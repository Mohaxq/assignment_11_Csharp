using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign11
{
    
    public class BookFunctions
    {
        public static string GetTitle(Book B)
        {
            return B.Title;
        }
        public static string GetAuthors(Book B)
        {
            return string.Join(", ", B.Authors);
        }
        public static string GetPrice(Book B)
        {
            return $"${B.Price}";
        }
        public static BookDelegate GetISBN = delegate (Book B)
        {
            return B.ISBN;
        };

        public static Func<Book, string> GetPublicationDate = B => B.PublicationDate.ToShortDateString();

    }
}
