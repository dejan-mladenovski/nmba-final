using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace nmba_backend.Models
{
    public class Student
    {
        public int UserId { get; set; }
        public DateTime EnrolledOn { get; set; }
        public int EnrollmentId { get; set; }
        public virtual User User { get; set; }
        public virtual Enrollment Enrollment { get; set; }
        public ICollection<Event> Events { get; set; }
        public ICollection<ActiveCourse> ActiveCourses { get; set; }
        
         
    }
}