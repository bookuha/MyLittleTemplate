using System.Collections.Generic;
using Template.Application.Contracts.Common;
using Template.Application.Contracts.Responses;
using MediatR;

namespace Template.Application.Books.Queries.GetAllBooks
{
    public record GetAllBooksQuery : IRequest<Result<List<BookResponse>>>;
}