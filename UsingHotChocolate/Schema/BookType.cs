using AspNetCoreGraphQL;
using AspNetCoreGraphQL.Models;
using HotChocolate;
using HotChocolate.Types;
using HotChocolate.Types.Descriptors;
using HotChocolate.Types.Relay;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UsingHotChocolate.Schema.DTOs;

namespace UsingHotChocolate.Schema
{
    public class BookType : ObjectType<BookDto>
    {
        protected override void Configure(IObjectTypeDescriptor<BookDto> descriptor)
        {
            descriptor.Name("Book");
        }
    }
}
