using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BunnyNet.Stream.Api
{
    public class StatusModel
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public int StatusCode { get; set; }
    }
}
