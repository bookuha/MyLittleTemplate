using System.Threading;
using System.Threading.Tasks;
using Template.Application.Contracts.Common;
using Template.Application.Contracts.Responses;
using Template.Infrastructure.Maps;
using Template.Infrastructure.Persistence;
using MediatR;

namespace Template.Application.Books.Commands.DeleteBook
{
    public class
        DeleteBookHandler : IRequestHandler<DeleteBookCommand,
            Result<BookResponse>> // Make it IRequestHandler and return Either
    {
        private readonly LibraryContext _context;

        public DeleteBookHandler(LibraryContext context)
        {
            _context = context;
        }

        public async Task<Result<BookResponse>>
            Handle(DeleteBookCommand request, CancellationToken cancellationToken) // to public
        {
            var book = await _context.Books.FindAsync(request.Id);
            if (book == null) return Error.NullValue; //  TODO: Not found error

            _context.Remove(book);
            await _context.SaveChangesAsync(cancellationToken);

            return book.ToResponse();
        }
    }
}