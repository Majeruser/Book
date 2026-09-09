using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Book
{
    public class Libary
    {

        private List<Book> lista;
        public string name { get; set; }
        public int BookCount { get { return lista.Count; }  }

        public Libary(string Name)
        {
           name = Name;
           lista = new List<Book>();
        }

        public void addBook(Book book)
        {
            lista.Add(book);
        }

        public void PrintALll()
        {
            foreach (Book book in lista)
            {
                Console.WriteLine(book.describe);
            }
        }

        public Book FindbyTitle(string Title)
        {
            foreach (Book book in lista)
            {
                if (book.title == Title)
                {
                    return book;
                }
            }
            return null;
        }

        public List<Book> FindbyAuthor(string Author)
        {
            List<Book> foundBooks = new List<Book>();
            foreach (Book book in lista)
            {
                if (book.author == Author)
                {
                    foundBooks.Add(book);
                }
            }
            return foundBooks;
        }

        public int ALlPages() {
            int totalPages = 0;
            foreach (Book book in lista)
            {
                totalPages += book.pagecount;
            }
            return totalPages;
        }

        public double AvaragePages()
        {
            if (lista.Count == 0)
            {
                return 0;
            }
            return (double)ALlPages() / lista.Count;
        }
        public List<string> AvailabelBooks()
        {
            List<string> availableBooks = new List<string>();
            foreach (Book book in lista)
            {
                if (book.isAvailable == true)
                {
                    availableBooks.Add(book.title);
                }
            }
            return availableBooks;
        }


    }
}
