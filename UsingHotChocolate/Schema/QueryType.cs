using AspNetCoreGraphQL;
using AspNetCoreGraphQL.Models;
using HotChocolate;
using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsingHotChocolate.Schema
{
    public class QueryType : ObjectType<Query>
    {
        protected override void Configure(IObjectTypeDescriptor<Query> descriptor)
        {
            descriptor
                .Field(q => q.GetBooks(default))
                .Type<NonNullType<ListType<BookType>>>()
                .UseSelection();

            //descriptor
            //    .Field(q => q.GetBookById(default, default))
            //    .Name("book")
            //    .UseSingleOrDefault()
            //    .UseSelection();

            //descriptor
            //    .Field(q => q.GetAuthors(default))
            //    .UseSelection();

            //descriptor
            //    .Field(q => q.GetAuthorById(default, default))
            //    .Name("author")
            //    .UseSingleOrDefault()
            //    .UseSelection();
        }
    }
}
