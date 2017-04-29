using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace nmba_backend.Models
{
    public class Teacher
    {
        public int UserId { get; set; }
        public bool IsApproved { get; set; }
        public ICollection<Lesson> Lessons { get; set; }
        public ICollection<ActiveCourse> ActiveCourses { get; set; }
        public virtual User User { get; set; }
    }
}