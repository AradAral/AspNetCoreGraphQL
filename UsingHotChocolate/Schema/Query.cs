using AspNetCoreGraphQL;
using AspNetCoreGraphQL.Models;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using HotChocolate;
using HotChocolate.Types;
using Mapster;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UsingHotChocolate.Mappers;
using UsingHotChocolate.Schema.DTOs;

namespace UsingHotChocolate.Schema
{
    public class Query
    {
        public IQueryable<BookDto> GetBooks([Service]AppDbContext dbContext)
        {
            return dbContext.Books.Select(book => new BookDto
            {
                Name = book.Name,
                Genre = book.Genre,
                Published = book.Published,
                Rating = Math.Round(book.Ratings.Average(r => r.Rate), 1),
                RatingCount = book.Ratings.Count,
                Author = new AuthorDto
                {
                    Id = book.Author.Id,
                    Name = book.Author.Name,
                    Age = book.Author.Age
                }
            });
        }
        //public IQueryable<Book> GetBooks([Service]AppDbContext dbContext)
        //{
        //    return dbContext.Books;
        //}
        //public IQueryable<Book> GetBookById([Service] AppDbContext dbContext, int bookId) => dbContext.Books.Where(b => b.Id == bookId);

        //public IQueryable<AuthorDto> GetAuthors([Service]AppDbContext dbContext) => dbContext.Authors.ProjectToAuthorDto();

        //public IQueryable<Author> GetAuthorById([Service] AppDbContext dbContext, int authorId) => dbContext.Authors.Where(a => a.Id == authorId);
    }
}
