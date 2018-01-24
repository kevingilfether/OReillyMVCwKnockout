using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OReilleyMVCwKnockout.Models
{
    public class Author
    {
        public int ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Biography { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}