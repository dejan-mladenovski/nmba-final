using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace nmba_backend.Models
{
    public class Event_User
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int EventId { get; set; }

    }
}