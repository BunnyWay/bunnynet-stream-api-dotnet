using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BunnyNet.Stream.Api
{
    public class PaginationList<T>
    {
        public long TotalItems { get; set; }
        public long CurrentPage { get; set; }
        public int ItemsPerPage { get; set; }
        public List<T> Items { get; set; }
    }
}
