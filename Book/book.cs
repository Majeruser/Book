using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    internal class Book
    {
        public string author {  get; set; }
        public string title { get; set; }
        private int pagecount { get; set; }

        public Book(string Author,string Title, int Pagecount)
        { 
            author = Author;
            title = Title;
            pagecount = Pagecount;
        }
        public override string ToString()
        {
            return $"Author: {author}, Title: {title}, Page Count: {pagecount}";
        }

    }
}
