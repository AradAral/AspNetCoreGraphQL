using AspNetCoreGraphQL;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UsingHotChocolate.Mappers;
using UsingHotChocolate.Schema.DTOs;

namespace AppCore
{
    [ApiController]
    [Route("api")]
    public class MyController : ControllerBase
    {
        private readonly AppDbContext dbContext;

        public MyController(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [Route("my")]
        public ActionResult MyAction()
        {
            var queryableDto = dbContext.Books.Select(book => new BookDto
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
            return Ok(queryableDto.Select(bDto => new
            {
                Name = bDto.Name,
                Author = new
                {
                    Name = bDto.Author.Name,
                }
            }).ToList());
        }
    }
}
