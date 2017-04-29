using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace nmba_backend.Models
{
    public class Course_Program
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public int ProgramId { get; set; }

        public DateTime ActiveFrom { get; set; }
        public DateTime ActiveTo { get; set; }
        public int Position { get; set; }
        public bool IsMandatory { get; set; }


    }
}