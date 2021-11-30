﻿using MVCCoreAppllication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCoreAppllication.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }

        public BookModel GetBookById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }

        public List<BookModel> SearchBook(string title,string author)
        {
                return DataSource().Where(x => x.Title.Contains(title) || x.Author.Contains(author)).ToList();
        }

        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel(){Id=1,Title="DotNet",Author="Nita"},
                new BookModel() { Id = 2, Title = "Java", Author = "Prasad" },
                new BookModel(){Id=3,Title="SQL",Author="Javed" },
                new BookModel(){Id=4,Title="Computer Network",Author="Nitin"},
                new BookModel(){Id=5,Title="Software Engineering",Author="Jorge"},
            };
        }
    }
}
