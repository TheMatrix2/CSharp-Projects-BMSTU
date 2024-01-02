using Lab12.Models;

namespace Lab12.Services;

public class MockAuthors : ICollection<Author>
{
    private readonly List<Author> _authors;

    public MockAuthors()
    {
        _authors = new List<Author>()
        {
            new Author()
            {
                ID = 0,
                Name = "Steven King"
            },
            new Author()
            {
                ID = 1,
                Name = "Jack London"
            },
            new Author()
            {
                ID = 2,
                Name = "George Orwell"
            }
        };
    }

    public Author? Get(int? id)
    {
        return _authors.FirstOrDefault(x => x.ID == id);
    }

    public IEnumerable<Author> GetAll()
    {
        return _authors;
    }

    public Author Add(Author author)
    {
        author.ID = _authors.Max(x => x.ID) + 1;
        _authors.Add(author);
        return author;
    }

    public Author? Delete(int id)
    {
        var author = _authors.FirstOrDefault(x => x.ID == id);
        if (author != null)
        {
            _authors.Remove(author);
        }

        return author;
    }

    public Author? Edit(Author newAuthor)
    {
        var author = _authors.FirstOrDefault(x => x.ID == newAuthor.ID);
        if (author != null)
        {
            author.ID = newAuthor.ID;
            author.Name = newAuthor.Name;
        }

        return author;
    }
}


public class MockPublishers : ICollection<Publisher>
{
    private readonly List<Publisher> _publishers;

    public MockPublishers()
    {
        _publishers = new List<Publisher>()
        {
            new Publisher()
            {
                ID = 0,
                Name = "Publisher A"
            },
            new Publisher()
            {
                ID = 1,
                Name = "Publisher B"
            },
            new Publisher()
            {
                ID = 2,
                Name = "Publisher C"
            }
        };

    }

    public Publisher? Get(int? id)
    {
        return _publishers.FirstOrDefault(x => x.ID == id);
    }

    public IEnumerable<Publisher> GetAll()
    {
        return _publishers;
    }

    public Publisher Add(Publisher publisher)
    {
        publisher.ID = _publishers.Max(x => x.ID) + 1;
        _publishers.Add(publisher);
        return publisher;
    }

    public Publisher? Delete(int id)
    {
        var publisher = _publishers.FirstOrDefault(x => x.ID == id);
        if (publisher != null)
        {
            _publishers.Remove(publisher);
        }

        return publisher;
    }

    public Publisher? Edit(Publisher newPublisher)
    {
        var publisher = _publishers.FirstOrDefault(x => x.ID == newPublisher.ID);
        if (publisher != null)
        {
            publisher.ID = newPublisher.ID;
            publisher.Name = newPublisher.Name;
        }

        return publisher;
    }
}


public class MockBooks : ICollection<Book>
{
    private readonly List<Book> _books;

    public MockBooks()
    {
        _books = new List<Book>()
        {
            new Book()
            {
                ID = 0,
                Title = "11/22/1963",
                AuthorID = 0,
                PublisherID = 0
            },
            new Book()
            {
                ID = 1,
                Title = "Martin Eden",
                AuthorID = 1,
                PublisherID = 1
            },
            new Book()
            {
                ID = 2,
                Title = "1984",
                AuthorID = 2,
                PublisherID = 2
            }
        };
    }

    public Book? Get(int? id)
    {
        return _books.FirstOrDefault(x => x.ID == id);
    }

    public IEnumerable<Book> GetAll()
    {
        return _books;
    }

    public Book Add(Book book)
    {
        book.ID = _books.Max(x => x.ID) + 1;
        _books.Add(book);
        return book;
    }

    public Book? Delete(int id)
    {
        var book = _books.FirstOrDefault(x => x.ID == id);
        if (book != null)
        {
            _books.Remove(book);
        }

        return book;
    }

    public Book? Edit(Book newBook)
    {
        var book = _books.FirstOrDefault(x => x.ID == newBook.ID);
        if (book != null)
        {
            book.ID = newBook.ID;
            book.Title = newBook.Title;
            book.AuthorID = newBook.AuthorID;
            book.PublisherID = newBook.PublisherID;
        }

        return book;
    }
}

