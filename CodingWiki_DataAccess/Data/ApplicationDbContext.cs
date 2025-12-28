using CodingWiki_Model.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingWiki_DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Genre> Genres { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-8DI1SVB\\SQLEXPRESS;Database=CodingWikiDB;TrustServerCertificate=True;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>(entity =>
            {
                entity.HasKey(e => e.BookId);
                entity.Property(e => e.Title).IsRequired();
                entity.Property(e => e.Author).IsRequired();
                entity.Property(e => e.ISBN).IsRequired();
                entity.Property(e => e.Price);
            });

            modelBuilder.Entity<Book>().HasData(
                new Book { BookId = 1, Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", ISBN = "9780743273565", Price = 10.99 },
                new Book { BookId = 2, Title = "To Kill a Mockingbird", Author = "Harper Lee", ISBN = "9780061120084", Price = 7.99 }
            );


            var bookList = new Book[]
            {
                new Book { BookId = 3, Title = "1984", Author = "George Orwell", ISBN = "9780451524935", Price = 9.99 },
                new Book { BookId = 4, Title = "Pride and Prejudice", Author = "Jane Austen", ISBN = "9780141439518", Price = 6.99 },
                new Book { BookId = 5, Title = "The Catcher in the Rye", Author = "J.D. Salinger", ISBN = "9780316769488", Price = 8.99 }
            };
            modelBuilder.Entity<Book>().HasData(bookList);

            var newBook = new List<Book>
            {
                new Book { BookId = 6, Title = "Bangladesh", Author ="Naeem" , ISBN="1111", Price = 100 },

            };
            modelBuilder.Entity<Book>().HasData(newBook);

           

            }
        }


}
