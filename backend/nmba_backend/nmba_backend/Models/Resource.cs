using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace nmba_backend.Models
{
    public class Resource
    {
        public int Id { get; set; }
        public int CreatorId { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public int LessonId { get; set; }
        public virtual Video Video { get; set; }
        public virtual Lesson Lesson { get; set; }
        public virtual ICollection<ActiveCourse> ActiveCourses { get; set; }
    }
}