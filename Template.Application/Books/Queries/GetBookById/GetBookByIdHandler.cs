using System.Threading;
using System.Threading.Tasks;
using ELibrary.Domain.Errors;
using Template.Application.Contracts.Common;
using Template.Application.Contracts.Responses;
using Template.Domain.Entities;
using Template.Infrastructure.Maps;
using Template.Infrastructure.Persistence;
using MediatR;

namespace Template.Application.Books.Queries.GetBookById
{
    public class GetBookByIdHandler : IRequestHandler<GetBookByIdQuery, Result<BookResponse>>
    {
        private readonly LibraryContext _context;

        public GetBookByIdHandler(LibraryContext context)
        {
            _context = context;
        }

        public async Task<Result<BookResponse>> Handle(GetBookByIdQuery request, CancellationToken cancellationToken)
        {
            var book = await _context.Books.FindAsync(request.Id);
            if (book == null) return DomainErrors.Book.NotFound;

            return book.ToResponse();
        }
    }
}