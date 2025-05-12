using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionLivre.Data.Context;
using GestionLivre.Data.Entities;


namespace GestionLivre.Data.Repositories
{
    public class LoanRepository
    {
        private readonly LibraryContext _context;

        public LoanRepository(LibraryContext context)
        {
            _context = context;
        }

        public IEnumerable<Loan> GetAll() => _context.Loans.ToList();

        public Loan GetById(int id) => _context.Loans.FirstOrDefault(l => l.Id == id);

        public void BorrowBook(int bookId, int memberId)
        {
            var book = _context.Books.Find(bookId);
            if (book != null && book.AvailableCopies > 0)
            {
                book.AvailableCopies--;
                var loan = new Loan
                {
                    BookId = bookId,
                    MemberId = memberId,
                    LoanDate = DateTime.Now
                };
                _context.Loans.Add(loan);
                _context.SaveChanges();
            }
        }

        public void ReturnBook(int loanId)
        {
            var loan = _context.Loans.Find(loanId);
            if (loan != null && !loan.IsReturned)
            {
                loan.ReturnDate = DateTime.Now;
                var book = _context.Books.Find(loan.BookId);
                if (book != null)
                {
                    book.AvailableCopies++;
                }
                _context.SaveChanges();
            }
        }

        public IEnumerable<Loan> GetOverdueLoans(int maxDays)
        {
            var threshold = DateTime.Now.AddDays(-maxDays);
            return _context.Loans
                .Where(l => !l.IsReturned && l.LoanDate < threshold)
                .ToList();
        }
    }
}
