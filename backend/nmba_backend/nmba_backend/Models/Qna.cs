using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace nmba_backend.Models
{
    public class Qna
    {
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public int ResponderId { get; set; }
        public int CourseId { get; set; }
        public int LessonId { get; set; }
        public int UserId { get; set; }
        public DateTime AskedOn { get; set; }
        public DateTime AnsweredOn { get; set; }
        public string question { get; set; }
        public string answer { get; set; }
        public virtual User User { get; set; }
        public virtual Lesson Lesson { get; set; }


    }
}