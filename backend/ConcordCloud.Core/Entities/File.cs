using System;

namespace ConcordCloud.Core.Entities
{
    public class File
    {
        public Guid Id { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public string ContentType { get; set; }
        public long FileSize { get; set; }
        public DateTime UploadDate { get; set; }
        public Guid UserId { get; set; }
        public virtual User Owner { get; set; }
    }
}
