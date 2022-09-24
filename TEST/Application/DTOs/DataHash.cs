using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOs
{
    class DataHash
    {
        public bool Success { get; set; }
        public string Data { get; set; }
        public string Hash { get; set; }
        public IList<String> Json { get; set; }
    }
}
