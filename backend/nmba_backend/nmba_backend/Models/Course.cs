using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace nmba_backend.Models
{
    public class Course
    {
        public Course()
        {
            ActiveCourses = new List<ActiveCourse>();
            Programs = new List<Program>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int TotalHours { get; set; }

        public virtual ICollection<ActiveCourse> ActiveCourses { get; set; }
        public virtual ICollection<Notification> Notifications { get; set; }
        public virtual ICollection<Program> Programs { get; set; }





    }
}