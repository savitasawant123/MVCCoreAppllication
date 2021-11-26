using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCoreAppllication.Controllers
{
    public class BookController : Controller
    {
        public string GetAllBooks()
        {
            return "List of all books";
        }
        public string GetBook(int id)
        {
            return $"Book with id={id}";
        }
        public string SearchBook(string bookname,string authorname)
        {
            return $"Book Name is {bookname} & Author Name is {authorname}";
        }
    }
}
