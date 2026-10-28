using Library_System.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library_System.Data
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer("Server=.;Database=LibraryDb;Trusted_Connection=True;TrustServerCertificate=True");
        protected override void OnModelCreating(ModelBuilder b)
        {
            b.Entity<Loan>().HasKey(L => new { L.BookId, L.BorrowerId });

            b.Entity<Book>().HasOne(b => b.Author)
                            .WithMany(a => a.Books)
                            .HasForeignKey(b => b.AuthorId);

            b.Entity<Loan>().HasOne(l => l.Book)
                            .WithMany(b => b.Loans)
                            .HasForeignKey(l => l.BookId);

            b.Entity<Loan>().HasOne(l => l.Borrower)
                            .WithMany(b => b.Loans)
                            .HasForeignKey(l => l.BorrowerId);
        }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Borrower> Borrowers { get; set; }
        public DbSet<Loan> Loans { get; set; }

    }
}
