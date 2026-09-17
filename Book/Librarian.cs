using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    public class Librarian
    {
        public string Name { get; set; }
        private Libary libary;
        public Librarian(string Name,Libary libary)
        {
            this.Name = Name;
            this.libary = libary;
        }
        public string introduce()
        {
            return $"nev:{Name} libary{libary.name}";
        }
        public
    }
}
