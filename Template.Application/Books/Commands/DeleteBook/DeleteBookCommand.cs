using Template.Application.Contracts.Common;
using Template.Application.Contracts.Responses;
using MediatR;

namespace Template.Application.Books.Commands.DeleteBook
{
    public record DeleteBookCommand(
        long Id) : IRequest<Result<BookResponse>>;
}