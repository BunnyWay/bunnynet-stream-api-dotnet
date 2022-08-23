using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BunnyNet.Stream.Api
{
    public class FetchVideoRequest
    {
        public string Url { get; set; }

        public Dictionary<string, string> Headers { get; set; }
    }
}
