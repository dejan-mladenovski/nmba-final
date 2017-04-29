using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace nmba_backend.Models
{
    public class Lesson
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public int TeacherId { get; set; }
        public int ActiveCourseId { get; set; }
        public int Status { get; set; }
        public int Position { get; set; }
        public virtual ActiveCourse ActiveCourse { get; set; }

        public virtual Teacher Teacher { get; set; }

        public virtual ICollection<Resource> Resources { get; set; }
        public virtual ICollection<Qna> Qnas { get; set; }
    }
}