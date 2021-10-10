﻿using my_books.Data.Models;
using my_books.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_books.Data.Services
{
    public class AuthorsService
    {
        private readonly AppDbContext _context;
        public AuthorsService(AppDbContext context)
        {
            _context = context;
        }

        public void AddAuthor(AuthorVM author)
        {
            var _author = new Author()
            {
                FullName = author.FullName
            };
            _context.Authors.Add(_author);
            _context.SaveChanges();
        }

        public AuthorWithBooksVM GetAuthorWithBooks(int authorId)
        {
            var _author = _context.Authors.Where(a => a.Id == authorId).Select(a => new AuthorWithBooksVM
            {
                FullName = a.FullName,
                BookTitles = a.Books_Authors.Select(ba => ba.Book.Title).ToList()
            }).FirstOrDefault();
            return _author;
        }
    }
}
