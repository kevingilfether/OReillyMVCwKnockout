using OReilleyMVCwKnockout.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OReilleyMVCwKnockout.DAL
{
    public class BookInitializer : DropCreateDatabaseIfModelChanges<BookContext>
    {
        protected override void Seed(BookContext context)
        {
            var author = new Author
            {
                Biography = "...",
                FirstName = "Jamie",
                LastName = "Munro"
            };

            var books = new List<Book>
            {
                new Book
                {
                    Author = author,
                    Description = "...",
                    ImageURL = "http://ecx.images-amazon.com/images/I/51T%2BWt430bl._AA160_.jpg",
                    ISBN = "1491914319",
                    Synopsis = "...",
                    Title = "Knockout.js: Building Dynamic Client-Side Web Applications"                    
                },
                new Book
                {
                    Author = author,
                    Description = "...",
                    ImageURL = "http://ecx.images-amazon.com/images/I/51AkFkNeUxl._AA160_.jpg",
                    ISBN = "1449319548",
                    Synopsis = "...",
                    Title = "20 Recipes for Programming PhoneGap: Cross-Platform Mobile Development"
                }
            };
            books.ForEach(b => context.Books.Add(b));

            context.SaveChanges();
        }
    }
}