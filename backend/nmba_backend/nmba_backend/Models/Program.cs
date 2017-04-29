using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace nmba_backend.Models
    { 
    public class Program {
    public Program()
    {
        Courses = new List<Course>();
    }
    public int Id { get; set; }
    public string Description { get; set; }
    public string Name { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime ActiveFrom { get; set; }
    public DateTime ActiveTo { get; set; }
    public int TeacherId { get; set; }
    public ICollection<Event> Events { get; set; }
    public ICollection<Student> Students { get; set; }
    public ICollection<Course> Courses { get; set; }
    public ICollection<Notification> Notifications { get; set; }
}
}
