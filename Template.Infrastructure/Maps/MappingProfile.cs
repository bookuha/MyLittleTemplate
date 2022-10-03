using Template.Application.Contracts.Responses;
using Template.Domain.Entities;

namespace Template.Infrastructure.Maps
{
    public static class MappingProfile
    {
        public static BookResponse ToResponse(this Book entity)
        {
            if (entity != null)
                return new BookResponse
                {
                    Id = entity.Id,
                    Name = entity.Name,
                    Genres = entity.Genres,
                    BriefDescription = entity.BriefDescription,
                    FullDescription = entity.FullDescription,
                    OriginallyPublishedAt = entity.OriginallyPublishedAt,
                    AppPublishedAt = entity.AppPublishedAt,
                    Authors = entity.Authors,
                    Files = entity.DownloadableFiles
                };

            return null;
        }
    }
}