using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace nmba_backend.Models
{
    public class Notification
    {
        public int NotificationID { get; set; }
        public int CourseId { get; set; }
        public int ProgramId { get; set; }
        public virtual Program Program { get; set; }
        public virtual Course Course { get; set; }
    }
}