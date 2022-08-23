using Cassandra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BunnyNet.Stream.Api
{
    public enum VideoModelStatus
    {
        Created = 0,
        Uploaded = 1,
        Processing = 2,
        Transcoding = 3,
        Finished = 4,
        Error = 5
    }

    public class VideoModel
    {
        public long VideoLibraryId { get; set; }
        public string Guid { get; set; }
        public string Title { get; set; }
        public DateTime DateUploaded { get; set; }
        public long Views { get; set; }
        public bool IsPublic { get; set; }
        public int Length { get; set; }
        public VideoModelStatus Status { get; set; }
        public double Framerate { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string AvailableResolutions { get; set; }
        public int ThumbnailCount { get; set; }
        public int EncodeProgress { get; set; }
        public long StorageSize { get; set; }
        public List<CaptionModel> Captions { get; set; }
        public bool HasMP4Fallback { get; set; }
        public string CollectionId { get; set; }
        public string ThumbnailFileName { get; set; }
    }
}
