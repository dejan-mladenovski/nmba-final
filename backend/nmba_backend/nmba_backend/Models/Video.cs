using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace nmba_backend.Models
{
    public class Video
    {
        public int ResourceId { get; set; }
        public string Url { get; set; }
        public virtual Resource Resource { get; set; }

    }
}