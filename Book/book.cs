using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    public class Book
    {

        private int _pagecount;
        public static int count = 0;
        public string author {  get; set; }
        public string title { get; set; }
        public int pagecount { get { return _pagecount; } set { if (value < 0) { _pagecount = 0; } else { _pagecount = value; } /* pagecount = value < 0 ? 0 : value; */} }
        public bool isAvailable { get; set; }



        public Book(string Author,string Title, int Pagecount):this(this.author, this.title)
        { 
            author = Author;
            title = Title;
            pagecount = Pagecount;
            count++;
        }
        public Book(string Author, string Title)
        {
            author = Author;
            title = Title;
            pagecount = 0;
        }

        public override string ToString()
        {
            return $"Author: {author}, Title: {title}, Page Count: {pagecount}";
        }
        public void describe()
        {
            Console.WriteLine($"Author: {author}, Title: {title}, Page Count: {pagecount}");
        }
        public bool islong()
        {
            if (pagecount > 300) { return true; } else { return false; }     
        }
        public bool Borrow()
        {
            if (isAvailable)
            {
                isAvailable = false;
                return true;
            }
            else
            {
                return false;
            }
        }



    }
}
