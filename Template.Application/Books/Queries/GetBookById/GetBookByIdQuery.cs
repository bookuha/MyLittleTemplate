using Template.Application.Contracts.Common;
using Template.Application.Contracts.Responses;
using MediatR;

namespace Template.Application.Books.Queries.GetBookById
{
    public record GetBookByIdQuery(long Id) : IRequest<Result<BookResponse>>;
}