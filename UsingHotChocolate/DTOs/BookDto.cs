using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsingHotChocolate.Schema.DTOs
{
    public class BookDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public bool Published { get; set; }

        public string Genre { get; set; }

        public AuthorDto Author { get; set; }

        public double? Rating { get; set; }

        public int RatingCount { get; set; }
    }
}
