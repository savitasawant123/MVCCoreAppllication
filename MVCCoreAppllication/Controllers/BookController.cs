using Microsoft.AspNetCore.Mvc;
using MVCCoreAppllication.Models;
using MVCCoreAppllication.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCoreAppllication.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository = null;
        public BookController()
        {
            _bookRepository = new BookRepository();
        }
        public ViewResult GetAllBooks()
        {
           var data=_bookRepository.GetAllBooks();
            return View();
        }
        public BookModel GetBook(int id)
        {
            return _bookRepository.GetBookById(id);
        }
        public List<BookModel> SearchBook(string title,string authorname)
        {
            return _bookRepository.SearchBook(title,authorname);
        }
    }
}
