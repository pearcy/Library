using System.Collections.Generic;

namespace Library.Models
{
  public class Book
  {
    public Book()
    {
      this.Authors = new HashSet<AuthorBook>();
      this.Patrons = new HashSet<BookPatron>();
    }

    public int BookId { get; set; }

    public int CopyCount { get; set; }
    public int OnLoanCount { get; set; }

    public string BookTitle { get; set; }

    public string BookGenre { get; set; }

    public virtual ICollection<AuthorBook> Authors { get; set; }
    public virtual ICollection<BookPatron> Patrons { get; set; }
  }
}