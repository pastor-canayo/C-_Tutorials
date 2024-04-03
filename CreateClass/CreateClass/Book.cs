using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    public class Book
    {
        string _name;
        string _author;
        int _pagecount;

        public Book(string name, string author, int pagecount) 
        {
            _name = name;
            _author = author;
            _pagecount = pagecount;
        }
        public string GetDescription()
        {
            return $"{_name} by {_author} and the book is {_pagecount} pages";
        }
    }
}
