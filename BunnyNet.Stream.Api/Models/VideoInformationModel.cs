using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BunnyNet.Stream.Api
{
    public class VideoInformationModel
    {
        public long Length { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public double Framerate { get; set; }
    }
}
