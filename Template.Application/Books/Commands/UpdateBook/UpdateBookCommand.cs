using System;
using System.Collections.Generic;
using Template.Application.Contracts.Common;
using Template.Application.Contracts.Responses;
using Template.Domain.Enums;
using MediatR;

namespace Template.Application.Books.Commands.UpdateBook
{
    public record UpdateBookCommand : IRequest<Result<BookResponse>>
    {
        public long Id { get; init; }

        public string Name { get; init; }
        public Genres Genres { get; init; }
        public string BriefDescription { get; init; }
        public string FullDescription { get; init; }
        public DateTime OriginallyPublishedAt { get; init; }
        public IEnumerable<long> AuthorIds { get; init; } = new HashSet<long>();
        public IEnumerable<long> FileIds { get; init; } = new HashSet<long>();
    }
}