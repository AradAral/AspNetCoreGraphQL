using AspNetCoreGraphQL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreGraphQL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasData(
                new Author
                {
                    Id = 1,
                    Name = "Dale Carnegie",
                    Age = 76,
                },
                new Author
                {
                    Id = 2,
                    Name = "Max Tegmark",
                    Age = 46,
                },
                new Author
                {
                    Id = 3,
                    Name = "Sam Harris",
                    Age = 53,
                },
                new Author
                {
                    Id = 4,
                    Name = "James Clear",
                    Age = 47,
                }
            );

            modelBuilder.Entity<Book>().HasData(
                    new Book
                    {
                        Id = 1,
                        Name = "How to Win Fiends and Influence People",
                        Genre = "Self-help",
                        Published = true,
                        AuthorId = 1
                    },
                    new Book
                    {
                        Id = 2,
                        Name = "Life 3.0",
                        Genre = "Science",
                        Published = true,
                        AuthorId = 2
                    },
                    new Book
                    {
                        Id = 3,
                        Name = "Free Will",
                        Genre = "Philosophy",
                        Published = true,
                        AuthorId = 3
                    },
                    new Book
                    {
                        Id = 4,
                        Name = "Atomic Habits",
                        Genre = "Self-help",
                        Published = true,
                        AuthorId = 4
                    }
                );
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Author> Authors { get; set; }
    }
}
