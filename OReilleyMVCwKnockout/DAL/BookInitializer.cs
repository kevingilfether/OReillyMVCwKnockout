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

            };
        }
    }
}