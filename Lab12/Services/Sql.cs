using Microsoft.EntityFrameworkCore;
using Lab12.Models;

namespace Lab12.Services;

public class SqlAuthors : ICollection<Author>
{
    private LibraryContext _db;

    public SqlAuthors(LibraryContext db)
    {
        _db = db;
    }

    public Author? Get(int? id)
    {
        return _db.Authors.Find(id);
    }

    public IEnumerable<Author> GetAll()
    {
        return _db.Authors;
    }

    public Author Add(Author author)
    {
        _db.Authors.Add(author);
        _db.SaveChanges();
        return author;
    }

    public Author? Edit(Author newAuthor)
    {
        var author = _db.Authors.Attach(newAuthor);
        author.State = EntityState.Modified;
        _db.SaveChanges();
        return newAuthor;
    }

    public Author? Delete(int id)
    {
        var author = _db.Authors.Find(id);
        if (author != null)
        {
            _db.Authors.Remove(author);
            _db.SaveChanges();
        }

        return author;
    }
}


public class SqlPublishers : ICollection<Publisher>
{
    private LibraryContext _db;

    public SqlPublishers(LibraryContext db)
    {
        _db = db;
    }

    public Publisher? Get(int? id)
    {
        return _db.Publishers.Find(id);
    }

    public IEnumerable<Publisher> GetAll()
    {
        return _db.Publishers;
    }

    public Publisher Add(Publisher publisher)
    {
        _db.Publishers.Add(publisher);
        _db.SaveChanges();
        return publisher;
    }

    public Publisher Edit(Publisher newPublisher)
    {
        var publisher = _db.Publishers.Attach(newPublisher);
        publisher.State = EntityState.Modified;
        _db.SaveChanges();
        return newPublisher;
    }

    public Publisher? Delete(int id)
    {
        var publisher = _db.Publishers.Find(id);
        if (publisher != null)
        {
            _db.Publishers.Remove(publisher);
            _db.SaveChanges();
        }
        return publisher;
    }
}

public class SqlBooks : ICollection<Book>
{
    private LibraryContext _db;

    public SqlBooks(LibraryContext db)
    {
        _db = db;
    }

    public Book? Get(int? id)
    {
        return _db.Books.Find(id);
    }

    public IEnumerable<Book> GetAll()
    {
        return _db.Books;
    }

    public Book Add(Book book)
    {
        _db.Books.Add(book);
        _db.SaveChanges();
        return book;
    }

    public Book Edit(Book newBook)
    {
        var book = _db.Books.Attach(newBook);
        // book.State = EntityState.Modified;
        _db.SaveChanges();
        return newBook;
    }

    public Book? Delete(int id)
    {
        var book = _db.Books.Find(id);
        if (book != null)
        {
            _db.Books.Remove(book);
            _db.SaveChanges();
        }
        return book;
    }
}
