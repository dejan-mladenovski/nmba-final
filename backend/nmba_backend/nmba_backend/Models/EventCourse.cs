using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace nmba_backend.Models
{
    public class EventCourse
    {
        public int Id { get; set; }
        public int ActiveCourseId { get; set; }
        public int EventId { get; set; }

    }
}