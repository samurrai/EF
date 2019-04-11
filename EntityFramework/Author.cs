using System.Collections.Generic;

namespace EntityFramework
{
    public class Author : Entity
    {
        public string Name { get; set; }
        public ICollection<Book> Books { get; set; } = new List<Book>();
    }
}