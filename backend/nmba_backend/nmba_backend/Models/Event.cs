using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace nmba_backend.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int ProgramId { get; set; }
        
        public virtual Program Program { get; set; }
        public virtual ICollection<ActiveCourse> ActiveCourses { get; set; }
        public virtual ICollection<Student> Students { get; set; }



    }
}