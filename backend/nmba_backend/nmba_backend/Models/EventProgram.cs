using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace nmba_backend.Models
{
    public class EventProgram
    {
        public int Id { get; set; }
        public int ProgramId { get; set; }
        public int EventId { get; set; }
    }
}