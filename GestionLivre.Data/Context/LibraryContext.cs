using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionLivre.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace GestionLivre.Data.Context
{
    public class LibraryContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Loan> Loans { get; set; }

        public LibraryContext() { }

        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlite("Data Source=library.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                .Property(b => b.Title)
                .IsRequired()
                .HasMaxLength(100);

            modelBuilder.Entity<Member>()
                .Property(m => m.Email)
                .IsRequired();

            modelBuilder.Entity<Loan>()
                .HasOne(l => l.Book)
                .WithMany(b => b.Loans)
                .HasForeignKey(l => l.BookId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Loan>()
                .HasOne(l => l.Member)
                .WithMany(m => m.Loans)
                .HasForeignKey(l => l.MemberId)
                .OnDelete(DeleteBehavior.Cascade);
        }

        public void Seed(bool force = false)
        {
            if (force || (!Books.Any() && !Members.Any()))
            {
                // clear old data if force
                if (force)
                {
                    Loans.RemoveRange(Loans);
                    Books.RemoveRange(Books);
                    Members.RemoveRange(Members);
                    SaveChanges();

                    // Reset auto-increment IDs
                    Database.ExecuteSqlRaw("DELETE FROM sqlite_sequence WHERE name='Books';");
                    Database.ExecuteSqlRaw("DELETE FROM sqlite_sequence WHERE name='Members';");
                    Database.ExecuteSqlRaw("DELETE FROM sqlite_sequence WHERE name='Loans';");
                }

                var book1 = new Book { Title = "C# in Depth", Author = "Jon Skeet", TotalCopies = 5, AvailableCopies = 5 };
                var book2 = new Book { Title = "Clean Code", Author = "Robert C. Martin", TotalCopies = 3, AvailableCopies = 3 };

                var member1 = new Member { FullName = "Alice Dupont", Email = "alice@example.com", SubscriptionDate = DateTime.Now.AddMonths(-2) };
                var member2 = new Member { FullName = "Bob Martin", Email = "bob@example.com", SubscriptionDate = DateTime.Now.AddMonths(-1) };

                Books.AddRange(book1, book2);
                Members.AddRange(member1, member2);
                SaveChanges();

                var loan = new Loan
                {
                    BookId = book1.Id,
                    MemberId = member1.Id,
                    LoanDate = DateTime.Now.AddDays(-10)
                };

                Loans.Add(loan);
                SaveChanges();
            }
        }

    }
}