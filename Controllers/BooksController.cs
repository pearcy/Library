using Microsoft.AspNetCore.Mvc;
using Library.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Library.Controllers
{
  public class BooksController : Controller
  {
    private readonly LibraryContext _db;
    
    public BooksController(LibraryContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      return View(_db.Books.ToList());
    }
    public ActionResult Create()
    {
      ViewBag.AuthorId = new SelectList(_db.Authors, "AuthorId", "AuthorName");
      return View();
    }
    [HttpPost]
    public ActionResult Create(Book book, int AuthorId, string AuthorName)
    {
      _db.Books.Add(book);
      if (AuthorName == "")
      {
        if (AuthorId != 0)
        {
          _db.AuthorBook.Add(new AuthorBook() { AuthorId = AuthorId, BookId = book.BookId });
        }
      } else
      {
        Author NewAuthor = new Author();
        NewAuthor.AuthorName = AuthorName;
        _db.Authors.Add(NewAuthor);
        _db.AuthorBook.Add( new AuthorBook() { AuthorId = NewAuthor.AuthorId, BookId = book.BookId });
      }
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}

