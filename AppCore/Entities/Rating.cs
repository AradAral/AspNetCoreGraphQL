namespace AspNetCoreGraphQL.Models
{
    public class Rating
    {
        public int Id { get; set; }

        public int BookId { get; set; }
        public Book Book { get; set; }

        public int Rate { get; set; }
    }
}
