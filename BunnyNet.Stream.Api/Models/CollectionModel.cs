using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BunnyNet.Stream.Api
{ 
    public class CollectionModel
    {
        public long VideoLibraryId { get; set; }
        public string Guid { get; set; }
        public string Name { get; set; }
        public long VideoCount { get; set; }
        public long TotalSize { get; set; }
        public string PreviewVideoIds { get; set; }
    }
}
