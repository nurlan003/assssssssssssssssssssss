using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Context;


namespace WpfApp1.Models
{
    public static class AddBookCS
    {

        public static void AddBookFC(Book book)
        {
            Book? newBook = book;
            LibraryDBContext newlibraryDBContext = new LibraryDBContext(); 
            newlibraryDBContext.Books.Add(newBook);
            newlibraryDBContext.SaveChanges();
        }
    }
}
