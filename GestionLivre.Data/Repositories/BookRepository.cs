using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionLivre.Data.Context;
using GestionLivre.Data.Entities;


namespace GestionLivre.Data.Repositories
{
    public class BookRepository
    {
        private readonly LibraryContext _context;

        public BookRepository(LibraryContext context)
        {
            _context = context;
        }

        public IEnumerable<Book> GetAll() => _context.Books.ToList();

        public Book GetById(int id) => _context.Books.FirstOrDefault(b => b.Id == id);

        public IEnumerable<Book> Search(string keyword)
        {
            return _context.Books
                .Where(b => b.Title.Contains(keyword) || b.Author.Contains(keyword))
                .ToList();
        }

        public void Add(Book book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();
        }

        public void Update(Book book)
        {
            _context.Books.Update(book);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var book = _context.Books.Find(id);
            if (book != null)
            {
                _context.Books.Remove(book);
                _context.SaveChanges();
            }
        }
    }
}
