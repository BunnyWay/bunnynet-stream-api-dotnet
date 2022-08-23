using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BunnyNet.Stream.Api
{
    public enum EncoderCallbackType
    {
        ThumbnailGenerated = 0,
        TaskFinished = 1,
        JobFinished = 2,
        TranscodingFailed = 3,
        VideoInformation = 4,
        ThumbnailInformation = 5,
        Progress = 6,
        ResolutionFinished = 7,
        KeyGenerated = 8
    }

    public class EncoderCallbackModel
    {
        public long VideoLibraryId { get; set; }
        public string VideoGuid { get; set; }
        public bool Success { get; set; }
        public EncoderCallbackType Type { get; set; }
        public string Data { get; set; }
    }
}
