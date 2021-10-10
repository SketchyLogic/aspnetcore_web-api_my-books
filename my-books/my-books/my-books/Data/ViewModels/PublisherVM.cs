using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_books.Data.ViewModels
{
    public class PublisherVM
    {
        public string Name { get; set; }
    }

    public class PublisherWithBooksAndAuthorsVM
    {
        public string PublisherName { get; set; }
        public List<BookAuthorsVM> BooksAuthors { get; set; }
    }

    public class BookAuthorsVM
    {
        public string BookName { get; set; }
        public List<string> BookAuthors { get; set; }
    }
}
