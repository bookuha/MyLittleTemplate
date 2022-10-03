using Template.Domain.Common;
using Template.Domain.Enums;

namespace Template.Domain.Entities
{
    public class DownloadableFile : BaseEntity
    {
        public FileFormat Format { get; set; }
        public string Link { get; set; }

        public Book Book { get; set; }
    }
}