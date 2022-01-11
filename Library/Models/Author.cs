using System.Collections.Generic;

namespace Library.Models
{
    public class Author
    {
        public Author()
        {
            this.JoinEntities = new HashSet<BookAuthor>();
        }

        public int AuthorId { get; set; }
        public string Name { get; set; }
        public virtual ApplicationUser User { get; set; }
        public virtual ICollection<BookAuthor> JoinEntities { get;}
    }
}