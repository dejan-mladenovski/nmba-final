using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace nmba_backend.Models
{
    public class Announcement
    {
        public int Id { get; set; }
        public int ActiveCourseId { get; set; }
        public int LessonId { get; set; }
        public int AuthorId { get; set; }
        public string tekst { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }


    }
}