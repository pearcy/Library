using System.Collections.Generic;

namespace Library.Models
{
  public class Book
  {
    public Book()
    {
      this.Authors = new HashSet<AuthorBook>();
      this.Patrons = new HashSet<BookPatron>(); // Patrons who have currently checked out this book, length must be less than CopyCount to checkout
    }

    public int BookId { get; set; }

    public int CopyCount { get; set; }

    public string BookTitle { get; set; }

    public string BookGenre { get; set; }

    public virtual ICollection<AuthorBook> Authors { get; set; }
    public virtual ICollection<BookPatron> Patrons { get; set; }
  }
}