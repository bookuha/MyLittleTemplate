using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Template.Application.Contracts.Common;
using Template.Application.Contracts.Responses;
using Template.Infrastructure.Maps;
using Template.Infrastructure.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Template.Application.Books.Queries.GetAllBooks
{
    public class GetAllBooksHandler : IRequestHandler<GetAllBooksQuery, Result<List<BookResponse>>>

    {
        private readonly LibraryContext _context;

        public GetAllBooksHandler(LibraryContext context)
        {
            _context = context;
        }

        public async Task<Result<List<BookResponse>>> Handle(GetAllBooksQuery request,
            CancellationToken cancellationToken)
        {
            return await _context.Books.Select(b => b.ToResponse()).ToListAsync(cancellationToken);
        }
    }
}