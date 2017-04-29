using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace nmba_backend.Models
{
    public class Enrollment
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int ProgramId { get; set; }
        public DateTime EnrolledOn { get; set; }
        public DateTime FinishedOn { get; set; }
        public int status { get; set; }
        


    }
}