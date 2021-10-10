using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using my_books.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_books.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using(var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                if (!context.Books.Any())
                {
                    //context.Books.AddRange(    
                    //new Book() 
                    //{
                    //    Title = "Book1",
                    //    Description = "Description1",
                    //    IsRead = true,
                    //    DateRead = DateTime.Now.AddDays(-1),
                    //    Rate = 1,
                    //    Genre = "Genre1",
                    //    Author = "Author1",
                    //    CoverUrl = "CoverUrl1",
                    //    DateAdded = DateTime.Now
                    //},
                    //new Book() 
                    //{
                    //    Title = "Book2",
                    //    Description = "Description",
                    //    IsRead = true,
                    //    DateRead = DateTime.Now.AddDays(-2),
                    //    Rate = 2,
                    //    Genre = "Genre2",
                    //    Author = "Author2",
                    //    CoverUrl = "CoverUrl2",
                    //    DateAdded = DateTime.Now
                    //},
                    //new Book() 
                    //{
                    //    Title = "Book3",
                    //    Description = "Description3",
                    //    IsRead = true,
                    //    DateRead = DateTime.Now.AddDays(-3),
                    //    Rate = 3,
                    //    Genre = "Genre3",
                    //    Author = "Author3",
                    //    CoverUrl = "CoverUrl3",
                    //    DateAdded = DateTime.Now
                    //},
                    //new Book() 
                    //{
                    //    Title = "Book4",
                    //    Description = "Description4",
                    //    IsRead = false,
                    //    Genre = "Genre4",
                    //    Author = "Author4",
                    //    CoverUrl = "CoverUrl4",
                    //    DateAdded = DateTime.Now
                    //});
                    context.SaveChanges();
                }
            }
        }
    }
}
