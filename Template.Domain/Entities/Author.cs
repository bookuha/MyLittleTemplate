using System.Collections.Generic;
using Template.Domain.Common;

namespace Template.Domain.Entities
{
    public class Author : BaseEntity
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public ICollection<Book> Books { get; set; } = new HashSet<Book>();
    }
}