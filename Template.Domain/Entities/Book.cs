using System;
using System.Collections.Generic;
using Template.Domain.Common;
using Template.Domain.Enums;

namespace Template.Domain.Entities
{
    public class Book : BaseEntity
    {
        public string Name { get; set; }

        public Genres Genres { get; set; }
        public string BriefDescription { get; set; }
        public string FullDescription { get; set; }

        public DateTime OriginallyPublishedAt { get; set; }
        public DateTime AppPublishedAt { get; set; }

        public ICollection<Author> Authors { get; set; } = new HashSet<Author>();
        public ICollection<DownloadableFile> DownloadableFiles { get; set; } = new HashSet<DownloadableFile>();
    }
}