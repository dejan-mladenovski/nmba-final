﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace nmba_backend.Models
{
    public class Admin
    {
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}