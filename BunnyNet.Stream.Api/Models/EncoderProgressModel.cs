using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BunnyNet.Stream.Api
{
    public class EncoderProgressModel
    {
        public long VideoLibraryId { get; set; }
        public string VideoGuid { get; set; }
        public string AvailableResolutions { get; set; }
    }
}
