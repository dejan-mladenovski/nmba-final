using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace nmba_backend.Models
{
    public class ActiveCourse
    {
        public ActiveCourse()
        {
            this.Lessons = new List<Lesson>();
        }
        public int Id { get; set; }
        public int? CourseId { get; set; }
        public int? TeacherId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime ActiveFrom { get; set; }
        public DateTime ActiveTo { get; set; }
        public virtual Course Course { get; set; }
        public virtual Teacher Teacher { get; set; }
             

        public virtual ICollection<Lesson> Lessons { get; set; }
        public virtual ICollection<Resource> Resources { get; set; }
        public virtual ICollection<Event> Events { get; set; }
        public virtual ICollection<Student> Students { get; set; }



    }
}