using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BunnyNet.Stream.Api
{
    public class CaptionModelAdd
    {
        public string Srclang { get; set; }
        public string Label { get; set; }
        public string CaptionsFile { get; set; }
    }
}
